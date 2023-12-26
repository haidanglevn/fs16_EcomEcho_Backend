using System.Text;
using EcommerceAPI.Business.src.Abstraction;
using EcommerceAPI.Business.src.Service;
using EcommerceAPI.Core.src.Abstraction;
using EcommerceAPI.Core.src.Entity;
using EcommerceAPI.WebAPI.src.Database;
using EcommerceAPI.WebAPI.src.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder =>
    {
        builder.WithOrigins("http://localhost:3000")
               .AllowAnyHeader()
               .AllowAnyMethod();
        builder.WithOrigins("http://ecomecho.netlify.app/")
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

// Continue with the rest of your service configurations...

builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// declare services
builder.Services.AddScoped<IUserService, UserService>(); // create an instance of UserService
builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddScoped<ICategoryRepo, CategoryRepo>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductRepo, ProductRepo>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IReviewRepo, ReviewRepo>();
builder.Services.AddScoped<IReviewService, ReviewService>();
builder.Services.AddScoped<IImageRepo, ImageRepo>();
builder.Services.AddScoped<IImageService, ImageService>();

builder.Services.AddScoped<ITokenService, TokenService>();

builder.Services.AddScoped<IPasswordHasher, PasswordHasher>();

// add automapper dependency injections
builder.Services.AddAutoMapper(typeof(UserService).Assembly);
var connectionString = builder.Configuration.GetConnectionString("LocalDb");
var dataSourceBuilder = new NpgsqlDataSourceBuilder(connectionString);
dataSourceBuilder.MapEnum<Role>();
dataSourceBuilder.MapEnum<Status>();
dataSourceBuilder.MapEnum<Color>();
dataSourceBuilder.MapEnum<Size>();
var dataSource = dataSourceBuilder.Build();

// add database context service
builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseNpgsql(dataSource)
           .UseSnakeCaseNamingConvention()
           .AddInterceptors(new TimeStampInterceptor());
});

// config for authentication
var jwtTokenKey = builder.Configuration.GetValue<string>("Jwt:Token");
if (string.IsNullOrEmpty(jwtTokenKey) || jwtTokenKey.Length < 16) // Example length check
{
    throw new InvalidOperationException("JWT Token key is not set or too short in configuration.");
}
builder.Services.AddAuthentication().AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtTokenKey)),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Use CORS with the defined policy
app.UseCors("CorsPolicy");

// Authen first -> then Authorize
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
