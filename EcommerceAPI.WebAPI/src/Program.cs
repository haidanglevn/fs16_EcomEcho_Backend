using EcommerceAPI.Business.src.Abstraction;
using EcommerceAPI.Business.src.Service;
using EcommerceAPI.Core.src.Abstraction;
using EcommerceAPI.WebAPI.src.Database;
using EcommerceAPI.WebAPI.src.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// declare services
builder.Services.AddScoped<IUserService, UserService>(); // create an instance of UserService
builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddScoped<ITokenService, TokenService>();

builder.Services.AddScoped<IPasswordHasher, PasswordHasher>();

// add automapper dependency injections
builder.Services.AddAutoMapper(typeof(UserService).Assembly);

// add database context service
builder.Services.AddDbContext<DatabaseContext>();

// config for authentication
builder.Services.AddAuthentication();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Authen first -> then Authorize
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
