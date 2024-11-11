
API DOCUMENTATION



Addresses

HTTP-POST: /api/Address/Add

Description

End-Point adds new data to database, by accepting Address Object as parameter. In short, It creates a new Address record inside the database.

Request Body (JSON).

{
    "HouseNumber" : 123,
    "StreetName": "Loot",
    "SurburbName":"Blair",
    "CityName":"Randburg",
    "ProvinceID":1,
    "PostalCode":2194
}

Request Parameters 

Parameters	Type	Description	Required
House Number	Long	House number of user, should be less than 7 digits.	Yes
Street Name	String	Street name of user, Should be less than 50 characters.	Yes
Surburb Name	String 	Suburb name of user, should be less than 30 characters.	Yes
City Name	String 	City name of user, should be less than 30 characters.	Yes
ProvinceID	Int	Province user reside in, system will automatically provide ProvinceID after user selects their Province from drop down box. 	Yes
Postal Code	Int	Postal code of user, should be less than 6 digits.	Yes


Responses

200 Ok: Added Successfully.
400 Bad Request: Invalid Data Input.
Internal Server Error.


Error Handling
400 Bad Request: Returned when clients sends invalid Data.
404 Not Found: Returned when requested resource is not found.
500 Internal Server Error: Returned when error occurs.



 
HTTP-PUT: /api/Address/Update

Description

End-Point update existing data in the database, by accepting Address Object as parameter. 

Request Body (JSON).

{
    “AddressID” : 1,
    "HouseNumber" : 123,
    "StreetName": "Loot",
    "SurburbName":"Blair",
    "CityName":"Randburg",
    "ProvinceID":1,
    "PostalCode":2194
}

Request Parameters 

Parameters	Type	Description	Required
AddressID	Int	Primary Key.	Yes
House Number	Long	House number of user, should be less than 7 digits.	Yes
Street Name	String	Street name of user, Should be less than 50 characters.	Yes
Surburb Name	String 	Suburb name of user, should be less than 30 characters.	Yes
City Name	String 	City name of user, should be less than 30 characters.	Yes
ProvinceID	Int	Province user reside in, system will automatically provide ProvinceID after user selects their Province from drop down box. 	Yes
Postal Code	Int	Postal code of user, should be less than 6 digits.	Yes


Responses

200 Ok: Updated Successfully.
400 Bad Request: Invalid Data Input.
404 Not Found.
Internal Server Error: Something went wrong.


Error Handling
400 Bad Request: Returned when clients sends invalid Data.
404 Not Found: Returned when requested resource is not found.
500 Internal Server Error: Returned when error occurs.





HTTP-DELETE: /api/Address/Delete

Description

End-Point Delete existing data in the database, by accepting record Primary Key as parameter. 

Request Body (JSON).

{
    “AddressID” : 1
}

Request Parameters 

Parameters	Type	Description	Required
AddressID	Int	Primary Key.	Yes


Responses

200 Ok: Deleted Successfully.
404 Not Found
Internal Server Error.


Error Handling
400 Bad Request: Returned when clients sends invalid Data.
404 Not Found: Returned when requested resource is not found.
500 Internal Server Error: Returned when error occurs.



HTTP-GET: /api/Address/GetAll

Description

End-Point retrieves all existing Address data in the database. 

Request Body (JSON).

{
}

Request Parameters 

Parameters	Type	Description	Required
			


Responses

200 Ok: List of Address.
Internal Server Error: Something went wrong.


Error Handling
400 Bad Request: Returned when clients sends invalid Data.
500 Internal Server Error: Returned when error occurs.









HTTP-GET: /api/Address/GetBy

Description

End-Point retrieves existing Address record in the database, by accepting a Primary Key as parameter. 

Request Body (JSON).

{
    “AddressID” : 1
}

Request Parameters 

Parameters	Type	Description	Required
AddressID	Int	Primary Key.	Yes


Responses

200 Ok: Address Object.
404 Not Found.
Internal Server Error: Something went wrong.


Error Handling
400 Bad Request: Returned when clients sends invalid Data.
404 Not Found: Returned when requested resource is not found.
500 Internal Server Error: Returned when error occurs.








Person	

HTTP-POST: /api/Person/AddPerson

Description

End-Point adds new data to database, by accepting PersonViewModel Object as parameter. It creates a new record in the database.

Request Body (JSON).

{
"FirstName" : "Gert",
"MiddleName" : "Lesibana George",
"Surname" : "Molala",
"Age" : 27,
"Email" : "GeorgeMolala@outlook.com",
"HouseNumber" : 2345,
"StreetName" : "Loot",
"SuburbName" : "Blairgowrie",
"CityName" : "Randburg",
"ProvinceID" : 1,
"PostalCode" : 2194,
}

Request Parameters 

Parameters	Type	Description	Required
FirstName	String	First name of user, should be less than 20 Characters	Yes
MiddleName	String	Middle of user, Should be less than 40 Characters.	No
Surname	String	Surname of user, should be less than 20 characters.	Yes
Age	Int	Age of user, should be less than 120 and start from 16. 	Yes
Email	String	User email.	Yes
House Number	Long	House number of user, should be less than 7 digits.	Yes
Street Name	String	Street name of user, Should be less than 50 characters.	Yes
Surburb Name	String 	Suburb name of user, should be less than 30 characters.	Yes
City Name	String 	City name of user, should be less than 30 characters.	Yes
ProvinceID	Int	Province user reside in, system will automatically provide ProvinceID after user selects their Province from drop down box. 	Yes
Postal Code	Int	Postal code of user, should be less than 6 digits.	Yes


Responses

200 Ok: Added Successfully.
400 Bad Request: Invalid Data Input.
Internal Server Error.


Error Handling
400 Bad Request: Returned when clients sends invalid Data.
500 Internal Server Error: Returned when error occurs.






HTTP-POST: /api/Person/AddPersonAddress

Description

End-Point adds new data to AddressLink Table, by assigning existing Address record from Address Table and existing Person record from Person Table to AddressLink Table. This Endpoint accepts AddressLink object as parameter. 

Request Body (JSON).

{
"AddressID" : 1,
"PersonID" : 1
}

Request Parameters 

Parameters	Type	Description	Required
AddressID	Int	Foreign Key, Pointing to specific record in Address Table.	Yes
PersonID	Int	Foreign Key, Pointing to specific record in Person Table.	Yes


Responses

200 Ok: Added Successfully.
400 Bad Request: Invalid Data Input.
Internal Server Error.



Error Handling
400 Bad Request: Returned when clients sends invalid Data.
500 Internal Server Error: Returned when error occurs.





HTTP-DELETE: /api/Person/Delete

Description

End-Point Delete existing data in the database, by accepting Address Object as parameter. 

Request Body (JSON).

{
    “PersonID” : 1
}

Request Parameters 

Parameters	Type	Description	Required
PersonID	Int	Primary Key.	Yes


Responses

200 Ok: Deleted Successfully.
404 Bad Request.
Internal Server Error.


Error Handling
400 Bad Request: Returned when clients sends invalid Data.
404 Not Found: Returned when requested resource is not found.
500 Internal Server Error: Returned when error occurs.





HTTP-PUT: /api/Person/UpdatePerson

Description

End-Point update existing data in the database, by accepting Person Object as parameter. 

Request Body (JSON).

{
"PersonID" : 1,
"FirstName" : "Mosco",
"MiddleName" : "Molalas",
"Surname" : "Molalakgori",
"Age" : 28,
"Email" : "Gman@outlook.com",
}


Request Parameters 

Parameters	Type	Description	Required
PersonID	Int	Primary Key of existing record.	Yes
FirstName	String	First name of user, should be less than 20 Characters	Yes
MiddleName	String	Middle of user, Should be less than 40 Characters.	No
Surname	String	Surname of user, should be less than 20 characters.	Yes
Age	Int	Age of user, should be less than 120 and start from 16. 	Yes
Email	String	User email.	Yes


Responses

200 Ok: Added Successfully.
400 Bad Request: Invalid Data Input.
404 Not Found.
Internal Server Error: Something went wrong.


Error Handling
400 Bad Request: Returned when clients sends invalid Data.
404 Not Found: Returned when requested resource is not found.
500 Internal Server Error: Returned when error occurs.













Qualifications

HTTP-GET: /api/Qualifications/GetBy

Description

End-Point retrieves existing Qualification record in the database, by accepting a Primary Key as parameter. 

Request Body (JSON).

{
    “QualificationID” : 1
}

Request Parameters 

Parameters	Type	Description	Required
QualificationID	Int	Primary Key.	Yes


Responses

200 Ok: Qualification Object.
404 Not Found.
Internal Server Error: Something went wrong.


Error Handling
400 Bad Request: Returned when clients sends invalid Data.
404 Not Found: Returned when requested resource is not found.
500 Internal Server Error: Returned when error occurs.
HTTP-GET: /api/Qualifications/GetAll

Description

End-Point retrieves all existing Qualifications records in the database. 

Request Body (JSON).

{
}

Request Parameters 

Parameters	Type	Description	Required
			


Responses

200 Ok: List of Qualifications.
Internal Server Error: Something went wrong.


Error Handling
400 Bad Request: Returned when clients sends invalid Data.
500 Internal Server Error: Returned when error occurs.






HTTP-POST: /api/Qualifications/Add

Description

End-Point adds new record to Qualification table, by accepting Qualification Object as parameter. 

Request Body (JSON).

{
"QualififcationName" : "IT",
"QualificationLevel" : "Diploma"
}

Request Parameters 

Parameters	Type	Description	Required
QualificationName	String	Name of Qualification, Should be less than 25 characters. 	Yes
QualificationLevel	String	Qualification NQL level or name, Should be less than 15 characters	Yes


Responses

200 Ok: Added Successfully.
400 Bad Request: Invalid Data Input.
Internal Server Error: Something went wrong.


Error Handling
400 Bad Request: Returned when clients sends invalid Data.
500 Internal Server Error: Returned when error occurs.

HTTP-PUT: /api/Qualifications/Update

Description

End-Point update existing record in Qualifications Table, by accepting Qualifications Object as parameter. 

Request Body (JSON).

{
“QualificationID” : 1,
"QualififcationName" : "IT Software",
"QualificationLevel" : "Degree"
}

Request Parameters 

Parameters	Type	Description	Required
QualificationsID	Int	Primary Key.	Yes
QualificationName	String	Name of qualification, Should be less than 15 characters	Yes
QualificationLevel	String	Qualification NQL level or name, Should be less than 15 characters	Yes


Responses

200 Ok: Updated Successfully.
400 Bad Request: Invalid Data Input.
404 Not Found.
Internal Server Error: Something went wrong.


Error Handling
400 Bad Request: Returned when clients sends invalid Data.
404 Not Found: Returned when requested resource is not found.
500 Internal Server Error: Returned when error occurs.


























HTTP-DELETE: /api/Qualifications/Delete

Description

End-Point Delete existing record in Qualifications Table, by accepting record Primary Key as parameter. 

Request Body (JSON).

{
    “QualificationID” : 1
}

Request Parameters 

Parameters	Type	Description	Required
QualificationID	Int	Primary Key.	Yes


Responses

200 Ok: Deleted Successfully.
404 Not Found
Internal Server Error: Something went wrong.

Error Handling
400 Bad Request: Returned when clients sends invalid Data.
404 Not Found: Returned when requested resource is not found.
500 Internal Server Error: Returned when error occurs.



HTTP-POST: /api/Qualifications/AddPersonQualification

Description

End-Point adds new record to QualificationLink Table, by assigning existing Qualification record from Qualification Table and existing Person record from Person Table to QualificationLink Table. This Endpoint accepts QualificationLink object as parameter. 

Request Body (JSON).

{
"QualificationDescription" : "Diploma Majoring in Software Development",
 "PersonID" : 1,
 "QualificationID" : 1
}

Request Parameters 

Parameters	Type	Description	Required
QualificationDescription	String	Description of the qualification.	No
QualificationID	Int	Foreign Key, Pointing to specific record in Qualification Table.	Yes
PersonID	Int	Foreign Key, Pointing to specific record in Person Table.	Yes


Responses

200 Ok: Added Successfully.
400 Bad Request: Invalid Data Input.
Internal Server Error: Something went wrong.

Error Handling
400 Bad Request: Returned when clients sends invalid Data.
500 Internal Server Error: Returned when error occurs.

HTTP-PUT: /api/Qualifications/UpdatePersonQualification

Description

End-Point update existing record in QualificationLink Table, by accepting QualificationLink Object as parameter. 

Request Body (JSON).

{
“QualificationLinkID” : 1, 
"QualificationDescription" : "Majoring in Software Development",
 "PersonID" : 1,
 "QualificationID" : 1
}

Request Parameters 

Parameters	Type	Description	Required
QualificationLinkID 	Int	Primary Key.	Yes
QualificationDescription	String	Description of the qualification.	No
PersonID	Int	Foreign Key, Pointing to specific record in Person Table.	Yes
QualificationID	Int	Foreign Key, Pointing to specific record in Qualification Table.	Yes


Responses

200 Ok: Updated Successfully.
400 Bad Request: Invalid Data Input.
404 Not Found.
Internal Server Error: Something went wrong.


Error Handling
400 Bad Request: Returned when clients sends invalid Data.
404 Not Found: Returned when requested resource is not found.
500 Internal Server Error: Returned when error occurs.






HTTP-DELETE: /api/Qualifications/DeletePersonQualification

Description

End-Point Delete existing record in QualificationLink Table, by accepting record Primary Key as parameter. 

Request Body (JSON).

{
    “QualificationLinkID” : 1
}

Request Parameters 

Parameters	Type	Description	Required
QualificationLinkID	Int	Primary Key.	Yes


Responses

200 Ok: Deleted Successfully.
404 Not Found
Internal Server Error: Something went wrong.

Error Handling
400 Bad Request: Returned when clients sends invalid Data.
404 Not Found: Returned when requested resource is not found.
500 Internal Server Error: Returned when error occurs.




HTTP-GET: /api/Qualifications/GetByPersonQualification

Description

End-Point retrieves existing QualificationLink record in the database, by accepting a Primary Key as parameter. 

Request Body (JSON).

{
    “QualificationLinkID” : 1
}

Request Parameters 

Parameters	Type	Description	Required
QualificationLinkID	Int	Primary Key.	Yes


Responses

200 Ok: QualificationLink Object.
404 Not Found.
Internal Server Error: Something went wrong.


Error Handling
400 Bad Request: Returned when clients sends invalid Data.
404 Not Found: Returned when requested resource is not found.
500 Internal Server Error: Returned when error occurs.




HTTP-GET: /api/Qualifications/GetAllPersonQualification

Description

End-Point retrieves all existing Qualifications records in the database associated with a specific user. Accepts PersonID as parameter.

Request Body (JSON).

{
“PersonID” : 1
}


Request Parameters 

Parameters	Type	Description	Required
PersonID	Int	Foreign Key, Used to Identity specific user for purpose of retrieving user qualifications.	Yes


Responses

200 Ok: List of User Qualifications.
Internal Server Error: Something went wrong.


Error Handling
400 Bad Request: Returned when clients sends invalid Data.
500 Internal Server Error: Returned when error occurs.










Note: These documentation is not complete, the web API is still missing some end points. Surely before the end of today I’ll update web api including api documentation. The final product will be pushed on GitHub.

There are also couple of flaws I noticed, but I decided to let them slide since you advised on them last week. 
