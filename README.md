![Build and Test](https://github.com/anaghesh-muruli/Commander-API/workflows/Build/badge.svg)
![Limit complexity](https://github.com/anaghesh-muruli/Commander-API/workflows/Limit%20complexity/badge.svg)
![GitHub last commit](https://img.shields.io/github/last-commit/anaghesh-muruli/Commander-API)
![GitHub top language](https://img.shields.io/github/languages/top/anaghesh-muruli/Commander-API)
# Commander-API
API to manage platform commands

## Index
1. [Tech stack](#Techstack)
2. [APIs](#APIs)
3. [Topics covered](#Topicscovered)

## Tech stack
a. ASP .NET Core 3.1

b. MS SQL Server 10.0

## APIs 

| **SL. No** | **HTTP Method** | **API URL**         | **Description**          | **Success Response**           | **Failure Response**         |
|------------|-----------------|---------------------|--------------------------|--------------------------------|-------------------------------|
| 1          | GET             | api/commands        | Get all Commands         | 200 status code with "OK"      | 400 status code 'BAD REQUEST' |
| 2          | GET             | api/commands/\{id\} | Get Command by id        | 200 status code with "OK"      | 400 status code 'BAD REQUEST' |
| 3          | POST            | api/commands        | Add a Command            | 201 status code with "CREATED" | 400 status code 'BAD REQUEST' |
| 4          | PUT             | api/commands/\{id\} | Update a Command         | 204 status code 'NO CONTENT'   | 400 status code 'BAD REQUEST' |
| 5          | PATCH           | api/commands/\{id\} | Partial Update a Command | 204 status code 'NO CONTENT'   | 400 status code 'BAD REQUEST' |
| 6          | DELETE          | api/commands/\{id\} | Delete a Command         | 204 status code 'NO CONTENT'   | 400 status code 'BAD REQUEST' |

## Topics covered
a.	Fundamentals of C#

b.	Introduction to .NET

c.	Application architecture

d.	CLR and class Library

e.	Dependency Injection 

f.	Service lifetimes

g.	Creating Domain models 

h.	Migrations, DBContext

i.	Understanding RabbitMQ Service Bus

j.	Creating microservice using MongoDB (Theory)
