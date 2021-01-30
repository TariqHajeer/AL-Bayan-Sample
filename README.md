# **Tatweerak Guide Task (Web Api Project)**

In this task, you will develop a set of REST APIs capable of reading a JSON data deployed
on a server and returning information by using a collection of simple HTTP requests using postman.

# **Nuget Package Requirement:**

You need to install a storeak nuget package (Storeak.Api.Core) using link https://storeak-nuget-service.azurewebsites.net/nuget on your web api project where you can access important libraries thats need for project like 
* Generic repository pattern,
* Custom required attributes,
* Trackable dto,
* Paging methods,
* Filters,
* Logging methods
* Api Custom response methods.

This package will help us to avoid repeated code thats need in every api project and make projects fast development.

# **Database Configuration:**

You need to create environment variable for making connection string. Storeak Core nuget package get these variables and make connection string for your project.

* AzurePool_DataSource: Database Server Name
 
* AzurePool_UserID :  Database Server User Id
 
* AzurePool_Password:  Database Server Password
 
* ENVIRONMENT : LocalHost
 
* Enco: set to empty

# **Project Folder Structure (Demo project):**
> 


***In wwwroot folder you need to create xml file in App_Data folder that handle multilanguage messages.***

> 

***In Business Use Cases you need to create (Create,Update,Delete) Operations***

> 

***In Queries you need to create select operations.***


> 

***In Unit of work you need to create repositories.***
> 
> 
***In Controller you need to create all apis crud.***



***In DataModel you need to create database entities(DTO).***
> 

***In Mapping you need to create configuration of entities.***


***In News context you need to create project db context and inherit with core store db context class to inherit all db methods for database interaction.***


***In ResponseMessage you need to add messages variables that return message based on language (Multilanguage handling).***


***In Models you need to create Api Response models.***

***In MapperProfile you need to add mapping of entities using automapper.***


***In Startup you need to inherit core startup class and configure your project setting(dependencies resolver,mappers,database etc)***


