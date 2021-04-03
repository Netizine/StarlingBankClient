# Getting started

This is an unofficial C# .NET Standard SDK for Starling Bank's API. 
Starling's API enables seamless integration of Starling account and transactional data into your application.
You can, subject to permission, use it to view account holder data and to automate actions on their accounts.
Before using the SDK, please follow the steps for getting started defined at (https://developer.starlingbank.com/get-started)

All the test have not be implemented as i cant get the AvailablePeriodsAsync to work (Even by using the starling site) so implement tests yourself. 

## Nuget

[![NuGet version (StarlingBank)](https://img.shields.io/nuget/v/StarlingBank.svg?style=flat-square)](https://www.nuget.org/packages/StarlingBank/)

## How to Build
The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2019 for compilation."
1. Open the solution (StarlingBankClient.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the StarlingBank Client library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.
Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

### 3. Add reference of the library project

In order to use the StarlingBank library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.
Next, a window will be displayed where we must set the ``` checkbox ``` on ``` StarlingBank.Tests ``` and click ``` OK ```. By doing this, we have added a reference of the ```StarlingBank.Tests``` project into the new ``` TestConsoleProject ```.

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need XUnit.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Example
Add you service in your startup.
```csharp
service.AddStarlingBank();
```
If you dont need all the services, you can add individual service ass follows
```csharp
services.AddSingleton<IAccountHoldersService, AccountHoldersService>();
```
All the methods need you to pass the client so build a intance of the client following the builder pattern.
```csharp
var starlingClient = StarlingClient.Builder
                .Environment(ServerEnvironment.SANDBOX)
                .OAuthAccessToken("YOUR_OAUTH_TOKEN")
                .Build();
```               
In your constructor, get the service you need. For a list of services, see AddStarlingBank
```csharp
private IAccountHoldersService _accountHolderSerice;
public YourService(AccountHoldersService accountHoldersService)
{
        _accountHolderSerice = accountHoldersService;
}
```
Then simply call your method, eg
```csharp
var accountHolder = await _accountHolderSerice.GetAccountHolderAsync(starlingClient);
```
                
