# CityInfo.Api

Sample api written in dotnet core 2.1 based on **Kevin Dockx** pluralsight course [Building Your First API with ASP.NET](https://app.pluralsight.com/library/courses/asp-dotnet-core-api-building-first/table-of-contents)

* Written in dotnet core 2.1 with EF Core 2.1.1
* Basic CRUD on Parent/Child using GET, POST, PUT, PATCH, DELETE verbs
* Example PATCH using JSON PATCH format
* Extended with EF and repository pattern
* Basic implementation of log4net
* Uses AutoMapper for mapping dtos to entities and vice versa

Next...
* Investigate FluentValidation instead of hardcoded validations.
* UnitOfWork lib which adds repositories as well as UoW to EF: [Unit Of Work](https://github.com/Arch/UnitOfWork)
* Filter for model state validation: [Model state validation filter ASP.NET Core](https://gist.github.com/Ciantic/88a2e9bae6961c23c2f366e89526b853)
* And maybe one day... getting [nlog](http://nlog-project.org/) working
