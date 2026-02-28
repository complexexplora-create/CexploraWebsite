// Program.cs - Minimal ASP.NET Core empty project setup for hosting on Azure App Service.
// This sets up a simple web app serving static files from wwwroot.
// Ensure the project targets .NET 9.0 in the .csproj file: <TargetFramework>net9.0</TargetFramework>
// The project structure: Program.cs and wwwroot/index.html
// To host on Azure: Create an Azure App Service, publish via Visual Studio or Azure CLI.

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Configure default files (serves index.html by default)
app.UseDefaultFiles();

// Serve static files from wwwroot
app.UseStaticFiles();

app.Run();
