The project contains a collection of project template for creating .net 5 and .net 6 asp.net mvc project.  
Unable most other projecte templates, these project template is designed for easy of use while your are learning asp.net core mvc.
For example :

No need for migration, identity db is already created
You can add user with only a single character password
identity db name is always asp.net.identity.db
port is always 5000 and 44300 (ssl)
program.cs and HomeController.cs files are appended with project name so that you know which project's program.cs you are editing when you have many projects.
OpenAPISupport (Swashbuckle)
Blazor Server Side support
(.NET 6) Both w3c loging and HTTP logging middleware are included. It include a controller to view w3c log
(C# 10) Global using file GlobalUsings.cs


The main project is a visual studio 2022 vsix installation project.  If you just want to install the template, go to

PonyProjectTemplateInstaller\bin\Debug\PonyProjectTemplateInstaller.vsix

The project only tested under vs 2022.
