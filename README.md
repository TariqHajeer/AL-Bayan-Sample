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


# **Ecommerce Project requirement**:

You need to create a Ecommerce Web Api project in .Net Core 2.2 using The Repository and Unit of Work Patterns

**Database Entities(DTO):**

* Item Category 
* Item (should inherit with basic trackable dto)
* Order(should inherit with basic trackable dto)
* Order Item(should inherit with basic trackable dto)
* Advertisement(should inherit with basic trackable dto)

**Project Apis:**

*Item Category:*

> * GetAll [HttpGet]
> Need to return list of category.
> 
> * Get [HttpGet]
> Need to return category detail.
> 
> * GetDropDown [HttpGet]
> Need to return category dropdown.
> 
> * Create [HttpPost]
> Need to create category by passing data in request body. 
> 
> * Update [HttpPut]
> Need to update category by passing data in request body and id in route url. 
> 
> * DELETE [HttpDelete]
> Need to delete category by passing id in route url. 

*Item:*

> * Search [HttpGet]
> Need to search items by name.
> 
> * GetAll [HttpGet]
> Need to return list of items.
> 
> * GetDropDown [HttpGet]
> Need to return item dropdown.
> 
> * Get [HttpGet]
> Need to return item detail.
> 
> * Create [HttpPost]
> Need to create item by passing data in request body. 
> 
> * Update [HttpPut]
> Need to update update by passing data in request body and id in route url. 
> 
> * DELETE [HttpDelete]
> Need to delete item by passing id in route url. 

*Order:*

> * Search [HttpGet]
> Need to search orders by order no or created date.
> 
> * GetAll [HttpGet]
> Need to return list of orders.
> 
> * Get [HttpGet]
> Need to return order detail.
> 
> * Create [HttpPost]
> Need to create order by passing order data with multiple order items in request body. 
> 
> * Update [HttpPut]
> Need to update order data only in request body and id in route url. 
> 
> * DELETE [HttpDelete]
> Need to delete order by passing id in route url. 

Order Items:

> * Get [HttpGet]
> Need to return order item detail.
> 
> * Create [HttpPost]
> Need to add order item by passing order item data in request body for existing orders.
> 
> * Update [HttpPut]
> Need to update order item by passing order item data in request body and id in route url for existing orders.
> 
> * Delete [HttpDelete]
> Need to delete order item by passing id in route url for existing orders.

*Advertisement:*

> * GetAll [HttpGet]
> Need to return list of adverstisement.
> 
> * Get [HttpGet]
> Need to return adverstisement detail.
> 
> * Create [HttpPost]
> Need to create adverstisement by passing data in request body. 
> 
> * Update [HttpPut]
> Need to update adverstisement by passing data in request body and id in route url. 
> 
> * Publish [HttpPut]
> Need to publish adverstisement by passing data in request body and id in route url.
> 
> * UnPublish [HttpPut]
> Need to unpublish adverstisement by passing data in request body and id in route url.
> 
> * DELETE [HttpDelete]
> Need to delete adverstisement by passing id in route url. 

## **Note:** :For delete apis , you need to add check if child record exist against parent record then user cannot delete parent record and you need to return bad request custom response.
