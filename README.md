# EcomEcho Fullstack Project

![TypeScript](https://img.shields.io/badge/TypeScript-v.4-green)
![SASS](https://img.shields.io/badge/SASS-v.4-hotpink)
![React](https://img.shields.io/badge/React-v.18-blue)
![Redux toolkit](https://img.shields.io/badge/Redux-v.1.9-brown)
![.NET Core](https://img.shields.io/badge/.NET%20Core-v.7-purple)
![EF Core](https://img.shields.io/badge/EF%20Core-v.7-cyan)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-v.14-drakblue)

## Table of Contents

1. [Introduction](#introduction)
   - [Frontend](#frontend)
   - [Backend](#backend)
   - [Installation and Usage](#installation-and-usage)
2. [Features](#features)
3. [Architecture and Design](#architecture--design)
   - [CLEAN Architecture](#clean-architecture)
   - [Folder Structure](#folder-structure)
4. [Testing](#testing)

## Introduction

This project involves creating a Fullstack project with React and Redux in the frontend and ASP.NET Core 7 in the backend. The goal is to provide a seamless experience for users, along with robust management system for administrators as an Ecommerce website.

- Frontend: MaterialUI, TypeScript, React, Redux Toolkit
- Backend: ASP.NET Core, Entity Framework Core, PostgreSQL
- Hosting: Netlify, Azure, ElephantSQL

View documentation of the backend with [SwaggerUI](https://ecomecho.azurewebsites.net/swagger/index.html)

### Frontend

FrontEnd Repo and instruction on installing can be found here [https://github.com/haidanglevn/fs16_Frontend-project](https://github.com/haidanglevn/fs16_Frontend-project)

Live website [https://ecomecho.netlify.app/](https://ecomecho.netlify.app/)

Register and login to explore the users features. Contact owner for Admin account.

### Backend

The ERD diagrams show all the entities and their relations:![entities](https://github.com/haidanglevn/fs16_CSharp-FullStack/assets/24937536/19bfb32b-b0e6-4532-9edc-2a79e4718a2a)


### Installation and usage

You can visit the [deployed SwaggerUI](https://ecomecho.azurewebsites.net/swagger/index.html), or follow these steps to set it up as local repository.

1. Clone the repository:
   ```bash
   git clone https://github.com/haidanglevn/fs16_EcomEcho_Backend.git
   ```
2. Navigate to WebAPI layer:
   ```bash
   cd EcommerceAPI.WebAPI
   ```
3. Create a new file "appsetting.json", add the content as follow, mainly focus on setting up the right connection string to your local PostgreSQL.

```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "LocalDb": "Host=localhost;Database=YourDatabase;Username=username;Password=password",
  },
  "Jwt": {
    "Token": "Your secret key for generate token"
  }
}
```

4. Create a migration and update the database with seed data:

```
dotnet ef migrations add NewDatabase
dotnet ef database update
```

4. Run the app:
   ```bash
   dotnet watch
   ```
5. (Optional) Run all the tests:
   ```bash
   dotnet test
   ```

## Features

| Entity   | User Features                                                                        | Admin Features (Include User Features)           |
| -------- | ------------------------------------------------------------------------------------ | ------------------------------------------------ |
| User     | Create "Customer" user, Edit selfInfo (firstName, lastName, email, password, avatar) | Create "Admin" user, Update & Delete any users   |
| Category | View all categories                                                                  | Create, Update, Delete any categories            |
| Product  | View all products                                                                    | Create, Update, Delete any products              |
| Image    | View all images of one products                                                      | Update images to products                        |
| Review   | Write review to a product (not ready), view a product's reviews from other           | View & Delete reviews (not ready)                |
| Order    | Add variant of product to cart, create an order                                      | View all orders, Edit status of order(not ready) |

## Architecture & Design

### CLEAN Architecture

CLEAN architecture is applied to this app. The app is seperated into 4 layers (from inside out): Core, Business, Controller, WebAPI.

- **Core layer** holds the most basic shape of all the entities and the interfaces for all the repos in Abstraction folder.
- **Business layer** holds the business logic of the app in the form of Services for each entities. Here is also where all the Data Transfer Object (DTO) locate, together with the interfaces for the services and a MapperProfile for AutoMapper functionalities.
- **Controller layer** define the endpoints that the backend will be available to user, with authorization for any that needed.
- **WebAPI layer** is the outer most layer to build and the file Program.cs to execute the app is here. This layer also has the repository, the databaseContext to connect to external DB, and the seed data.

### Folder Structure

- 📂 `EcommerceAPI.Core/`
  - 📂 `src/`
    - 📂 `Abstraction/`
    - 📂 `Entity/`
    - 📂 `Parameter/`
- 📂 `EcommerceAPI.Business/`

  - 📂 `src/`

    - 📂 `Abstraction/`
    - 📂 `DTO/`

      - 📄 `AddressDTO.cs`
      - 📄 `ProductDTO.cs`
      - 📄 `OrderDTO.cs`
      - ... and other DTOs

    - 📂 `Service/`
      - 📄 `AddressService.cs`
      - 📄 `ProductService.cs`
      - 📄 `OrderService.cs`
      - ... and other services
    - 📂 `Shared/`
      - 📄 `MapperProfile.cs`

- 📂 `EcommerceAPI.Controller/`

  - 📂 `src/Controller`
    - 📄 `AddressController.cs`
    - 📄 `ProductController.cs`
    - 📄 `OrderController.cs`
    - ... and other Controllers

- 📂 `EcommerceAPI.WebAPI/`

  - 📂 `src/`
    - 📂 `Database/`
    - 📂 `Repository/`
    - 📂 `Middleware/`
    - 📄 `Program.cs`

- 📂 `EcommerceAPI.Test/`
- 📄 `README.md`
- 📄 `.gitignore`

## Testing

**WebAPI layer** is a seperate layer just for testing. Main packages here are Moq and xUnits. There are tests for some of the services in Business layer, but more tests are being added.
