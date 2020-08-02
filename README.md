# AspnetCoreTestApp
sample aspnet core app exposed as web api

#Introduction

This is a very basic example with asp.net 3+ with API exposing application. it uses the Entity Framework Core code first migration concepts for sql server interation.
This is mostly for developers. in order to make production grade app, we need to improve the code and configuration little further. (I will do it in near future)

# Prerequisites
1) Basic understanding of asp.net core
2) Basic understanding of Entity framework core

# Setup - How to Run
1) Download the code
2) restore the packages (CLI / restore packages in VS. eg CLIcommand project folder > dotnet restore)
3) Modify the sql server connection string according to your system/remote installation. I just used sqlserver dev edition with basic feature. connected as windows integrated authentication
4) Modify the connection string in 2 places. one with asp.net core appsettings.json (this will be registered in start up with Dependency Injection feature)
5) Modify the second connection string in Test-DataAccessRepository project inside DesignTimeDbContextFactory class. here the connection string is used for Entity framework core code first migration execution
6) if you want do not wish to do migration commands in packagemanager console then
  6.a) Create the new database in your sql server
  6.b) There is already a generated scripts in the Migrations folders that you could take and execute in your DB. This will create the relavant tables.
7) If you are fine to execute code first migrations from scratch then,
  7.a) Delete the Migrations folder from Test-AccessReposority project.
  7.b) Select the Test-AccessRepositoy project as default project and open the Package manager console.
  7.c) In Package manager console execute the below commands (PMconsole > Add-Migration MyInitialMigration, PMconsole > Update-Database )
  7.d) Now, you can verify the migrations folders with UP and Down migration files
  7.e) Also, you can verify in your Sql server the DB is created with relevant tables.
8) Now, you are ready to run the app in one of the below 2 ways at least
  8.a) Select Aspnetcore-Test project as startup project and run in IIS Express or
  8.b) Using CLI command prompt, navigate to the project folder with CD <.. Your actualProject Path..> and execute dotnet run.
9) That is it !! This application is up and running !! :) :)

# Do you want fiddle it ?
1) you could fiddle with this api using fiddler or postman.
2) Example with Postman:

URL: https://localhost:5001/api/property/
Method: POST
Request Header: Content-Type: application/json and Accept: application/json
Request Body: 
{    
    "Address":"test address updated",
    "YearBuild":2020,
    "ListPrice":2000.00,
    "MonthlyRent":1500,
    "GrossYield":12
}

3) Great ! It works !!.
