# Vehicle Sales

This Application Demonstrates upload of Vehicle Sales data in CSV Format, display UI showing all aspects of data and displays the most sold vehicle

# Technology Stack

Asp.Net Core 3.1
Angular
bootstrap

# Installation Instruction

--Please install .net core 3.1 sdk and nodejs

1. Clone Repository or download VehicleSales-main.zip and extract contents to C:

2. Open Command Promp

3. Run Below Command and change directory to ClientApp Folder

cd C:\VehicleSales-main\VehicleSales\ClientApp

4. Run below command to install npm packages

npm install

5. Run below command and change directory to VehicleSales Project

cd C:\VehicleSales-main\VehicleSales\

6. Run below command to run dotnet core project VehicleSales.csproj

dotnet run

It will show the url where Vehicle Sales is running

7. Open below url in browser

https://localhost:5001

--URL can also be located in previous command result

--since URL is https browser might show message you will need to continue to view the application

8. To Run Unit Test, Change directory to below

cd C:\VehicleSales-main\VehicleSales.Tests\

and run below command to run test in VehicleSales.Tests.csproj

dotnet test 

--it will run the unit test and show the result

Here is a screenshot of running application
![VehicleSales](https://github.com/maysh15/VehicleSales/blob/main/Demo/VehicleSales.JPG)

you can play a demo buy opening below file

C:\VehicleSales-main\VehicleSales\VehicleSalesDemo.webm

Solution Structure

![VehicleSales](https://github.com/maysh15/VehicleSales/blob/main/Demo/SolutionStructure.JPG)

Angular Components

![angularcomponents](https://github.com/maysh15/VehicleSales/blob/main/Demo/angularcomponents.JPG)

LoadingCSVFileData - Code reads CSV File Data and loads to List of Vehicle Deals
![LoadingCSVFileData](https://github.com/maysh15/VehicleSales/blob/main/Demo/LoadingCSVFileData.JPG)

Dependency Injection
![Dependency_Injection](https://github.com/maysh15/VehicleSales/blob/main/Demo/Dependency_Injection.JPG)

Interface Segregation
![Interface_Segregation](https://github.com/maysh15/VehicleSales/blob/main/Demo/Interface_Segregation.JPG)

Single Responsibility
![Single_Reponsibility](https://github.com/maysh15/VehicleSales/blob/main/Demo/Single_Reponsibility.JPG)

Unit Testing
![UnitTesting](https://github.com/maysh15/VehicleSales/blob/main/Demo/UnitTesting.JPG)

