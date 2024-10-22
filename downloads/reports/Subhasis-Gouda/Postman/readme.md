## POSTMAN API

An API allows code to talk to other code, basically the building block of modern software.
They allow for sharing of resources and services across applications, organizations and devices.
Use: Payments, checking weather, Getting G-maps on other apps, on other apps.
1. Build automation.
2. Open products for faster innovation.
3. API can be product themselves.

### Analogy:

Api is like a waiter in a restaurant. Serving as a go.	
Client ->   (request  →)/(response <-)  API  (<-)/→  API Server
Client is the requester like browser, mobile app - Customer.
API is a simplified interface to interact with backend - Waiter.
Server is the backend where the process happens - Kitchen.
Types of API:
Hardware API: Interface for software to talk to hardware.
Software API: Interface for directly consuming code from another codebase.
Web API: Interface for communicating across code base over a network.
    eg. fetching current stock prices from a finance API.

### Architecture:

#### REST (API)
The rest of the API has the ability to cache, send and receive various datatypes.
Access Scope: 
1. Public API - by anyone who discovers it.
2. Private API – by an organization.
3. Partner API – between one or more organizations.


### Public REST Web API

Postman is an API platform for building and using APIs.
1. Basics Creating Workshop:
	- Create workshop.
	- Select a blank workspace.
	- Name ur workshop as Postman Api Fundamentals Student Expert.
	- Set the visibility to Public.
2. Creating a collection:	
    - Now create a collection. 
	- Name the collection Postman Library API v2.
3. Creating a request:
	- Add a request inside the collection 
	- Name it as get books.
	- Then we select GET and request the url:  https://library-api.postmanlabs.com/books
	- Now sending the request and viewing the response.
4. Response:
    - The JSON response body with an array of object (books).


Request Methods:

| Method | name | Operation |
|--------|------|-----------|
| GET | Retrieve data | (Read) |
| POST | Send data | (Create) |
| PUT/PATCH | Update data | (Update)  PUT usually replaces an entire resource, whereas PATCH usually is for partial updates |
| DELETE | Delete | data (Delete) |
 

