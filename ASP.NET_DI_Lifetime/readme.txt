See the difference between Dependency injection call lifetime through an application run.

There are 3 DI types in ASP.net 
* Singleton - creates 1 instance of an object through whole application lifetime 
* Scoped - creates 1 instance for http call 
* Transiant - creates new instance everypossible time.

in the output you can see UID ( UID imposible to get collisions ) for every DI class intance. 

Singleton -  every call shows the same UID
Scoped - 1 UID for 1 call
Transiant - each time new UID


-----------------------CALL_1-----------------------

||||||| Test Controller |||||||
Singleton UID:          49563c8b-7e4b-45d6-b0ee-df676512480b
Scoped UID:             672b30db-a82e-44b7-9c75-5a738b5bfda5
Transient UID:          17922d3f-0a63-4edc-8065-a76dcdaeacd9

||||||| Database Service |||||||
Singleton UID:          49563c8b-7e4b-45d6-b0ee-df676512480b
Scoped UID:             672b30db-a82e-44b7-9c75-5a738b5bfda5
Transient UID:          3c8ad5a6-eb9d-40d9-ba1b-58bb42d4363f

-----------------------CALL_2-----------------------

||||||| Test Controller |||||||
Singleton UID:          49563c8b-7e4b-45d6-b0ee-df676512480b
Scoped UID:             fd04c22a-4a66-4207-b64c-c99640b5ddac
Transient UID:          bb3459ab-79b3-4cbe-bc11-05292ba61363

||||||| Database Service |||||||
Singleton UID:          49563c8b-7e4b-45d6-b0ee-df676512480b
Scoped UID:             fd04c22a-4a66-4207-b64c-c99640b5ddac
Transient UID:          4e5e1fad-1b71-4f66-b21c-04eb9f6e4dd9
