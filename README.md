# CustomerSubscriptionAPIClient
Class library for request to WebApi project managing Customer subscriptions. Including a package for installing from nuget manager

## Class library application
This code sample presents a class library based on Net Core 3.1 and contains as a client api for consuming data from an existing Web API application project for managin Customers and Products Master data as well as Subscriptions (Customers being register with multiples Products).

This application was packed as a nuget package that can be found on Nuget.org (https://www.nuget.org/packages/Challenge.Util.CustomerSubscriptionAPIClient).

The Web API application can be downloaded as a single container on Docker hub (https://hub.docker.com/repository/docker/dalbarracin/customersubscriptionapi) as well as Github (https://github.com/dalbarracin/CustomerSubscriptionAPI)

## Architectural constraints

Some architectural decisions were made by exposing API clients Interfaces (Customer, Products and Subscriptions) whose definitions are configured by using Dependency Injection pattern.

Created a ServiceCollectionExtensions static class in our library for adding services to the container, so exposing Interfaces with concrete class is possible.

## Using class library
Since a composition root is always decleared in each Entry point application (Such as web aplication, console application, etc) some configurations needs to be done first before using interfaces.

Configure services by calling `services.AddCustomerSubscriptionScoped()` implementation.
Use interface in a constructor of each class, so the system will resolve a dependency in runtime.

## Limitaitons

This packaged was build as an example how to consume data from a Web API application in a docker container. 
The architectural constraints decided include using a HttpClient class for sending Http Request defining a BaseURL (http://host.docker.internal) since this application is intended to be used on Docker.

## Requirements and Dependencies

- .NETCoreApp 3.1
- Microsoft.Extensions.DependencyInjection.Abstractions (>= 5.0.0)
- Newtonsoft.Json (>= 12.0.3)
