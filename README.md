# **Storeak Demo API (Web Api Project)**

In this demo, you will see a set of REST APIs capable of reading a JSON data deployed
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

# **Database & Environment Configuration:**

You need to create environment variable for making connection string. Storeak Core nuget package get these variables and make connection string for your project.

to add these varables:
* run "edit the system environment variables" from start menu

![alt text](https://www.storeakmedia.com/theme/GitStoreakDemoApi/env.png)

* Click on "Environment Variables" button

* Under System variables add the following:

> AzurePool_DataSource: Database Server Name
 
> AzurePool_UserID :  Database Server User Id
 
> AzurePool_Password:  Database Server Password
 
> Enco: set to empty

# **Project Folder Structure (Demo project):**
> 


> * **wwwroot/App_Data** have xml file that handle multilanguage messages.
> * **Application/BusinessUseCases** have (Create,Update,Delete) Operations
> * **Application/Queries** have select operations.
> * **Application/UnitOfWork** have the repositories.
> * **Controllers** have the apis crud.
> * **Infrastructure/DataModels** have database entities(DTO).
> * **Infrastructure/Mapping** have configuration of entities.
> * **Infrastructure/DemoContext** have dbset with entity configuration (mapping) also inherit with core store db context class to inherit all db methods for database interaction.
> * **Infrastructure/ResponseMessages** have messages variables that return message based on language (Multilanguage handling) that created in xml file.
> * **Models** have Api Request and Response models.
> * **MapperProfile** have the auto mapping between the entities and models.
> * **Startup** is inherit core startup class and configure your project setting(dependencies resolver,mappers,database etc)

# **Postman Collection**
 you can download a **Postman collection** that wrapp this project apis from this [link]( https://www.storeakmedia.com/theme/GitStoreakDemoApi/Storeak.Demo.Api.postman_collection.json)

