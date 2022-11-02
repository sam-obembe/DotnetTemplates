# About
These templates were created to make it easier to create classes. It's especially usefull when working with a text editor or IDE that does not have an option to right click and create a class. In the future I might make it available as a nuget package. 

## How to use
* Navigate to a template inside `working/templates`
* From inside the template folder, run `dotnet new --install ./`. This would install that template. 
* To verify the template has been installed, run  `dotnet new --list`. Read through the output for the shortName and name for that template. 
* To generate a class in a project, run `dotnet new <templateShortname> -n <ClassName>`. 
* For example, to generate a controller, in a asp.net core api project, run `dotnet new controllerClass -n HelloController`. This would create  HelloController.cs file
* You'll need to add namespaces and package references as necessary.