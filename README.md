# ReCapProjectBackend
ReCapProject
## Built With
* C# -- ASP.NET -- MSSQL -- ENTITY FRAMEWORK -- AUTOFAC -- FLUENT VALIDATION
## Project purpose
*A car rental site design in accordance with the SOLID software development principle.*

## Specifications
* __CARS__
* *Public Operations*
  * Searching Cars by Brands
  * Searching Cars by Colors
  * Searching Cars by Brands
  
* *Private Operations*
  * Authorized Operations
    * Add a new car
    * Update a car
    * Delete a car
   
* __BRANDS__
* *Public Operations*
  * Add a new Brands
  * Update a Brands
  * Delete a Brands
  * Searching Brands 
  * List Brands
 
  
* *Private Operations*
  * Authorized Operations
    * Not added yet
    
  
* __COLORS__
* *Public Operations*
  * Searching Colors 
  * List Colors
 
* *Private Operations*
  * Authorized Operations
    * Add a new color
    * Update a color
    * Delete a color
    
* __CUSTOMER__
* *Public Operations*
  * Add a new customer
  * Delete a customer
  * Update a customer
 
* *Private Operations*
  * Authorized Operations
    * Not added yet
    
* __RENTALS__
* *Public Operations*
  * Delete a rental
  * Get Single Rental 
  * Update a rental
  
 
* *Private Operations*
  * Authorized Operations
    * Add rentals (Logged users only)
    * Not added yet


* __USERS__
* *Public Operations*
  * Get UserDeail by Mail
  * Add a user
  * Update a user ( Logged users only)
  * Get a User
  * Get all Users
  * Edit a User
  * Delete a User
  
* *Private Operations*
  * Authorized Operations
  * Not added yet
  
* __PAYMENT__
* Test(FAKE)

* __CARIMAGE__
* *Public Operations*
  * Add a image
  * Delete a image
  * Update a image 
  * Get a image
* *Private Operations*
  * Authorized Operations
  * Not added yet

* __Authentication__
* Requests are authenticated using the  `Authorization` header and value `Bearer {{token}}.`  with a valid JWT.
* Authentication Strategy : JWT
* __Registration__
  * Create Access Token
  * User can register as a "Admin" or simply "User"
  * Password Salt
  * Password Hash
  * Token includes : "id", "email", "name" and "roles"
* __Login__
  * Logged users only
  * Create Access Token
  * User can login with "email" and "password"
  * Everytime a user login, new Token are sent to to client

* Private Operations Login and Registration
  * Encryption
  * Hashing
  * JWT
  

## LAYERS 

* __BUSINNES__
  * Business Layer created to process or control the incoming information according to the required conditions.
* __CORE__
  * Core layer containing various particles independent of the project.
* __DataAccess__
  * Data Access Layer created to perform database CRUD operations.
* __Entities__
  * Entities Layer created for database tables.
*__WEPAPI__
  * Web API Layer that opens the business layer to the internet. 
* __ConsoleUI__
  * Temporary test layer at project start

## CONTACT
MAİL : metehanyetkin12@gmail.com
 Linkedin : [Metehan Yetkin](https://www.linkedin.com/in/metehan-yetkin-5951b2164)

## Acknowledgements
 [ENGİN DEMİROG](https://www.linkedin.com/in/engindemirog/?originalSubdomain=tr)












