# project 2
July 2021 Arlington .NET / Nick Escalona

- Angular single-page application
    - proper use of Angular abstractions (component, service injection, data binding, & HttpClient)
    - client-side validation
    - error handling on requests to APIs
    - deployed to Azure App Service
    - supports deep links
- ASP.NET Core REST service
    - follow standard HTTP uniform interface, except hypermedia
    - good architecture
    - deployed to Azure App Service
    - Entity Framework Core
        - DB should be on the cloud
        - all DB/network access should be async
    - server-side validation
    - support filtering or pagination on at least one resource
    - logging
    - implement hypermedia, or, implement an API Description Language, e.g. using Swashbuckle / Swagger
    - (optional: implement a custom filter, health check, or middleware, e.g. exception-handling middleware)
- Azure Pipelines
    - CI pipelines
        - Unit tests
        - SonarCloud
            - Code coverage at least 50% for API, at least 30% for Angular app
            - Reliability/Security/Maintainability at A
    - (optional: deploy in release definition or separate job instead of in build job, and use health checks)
- authentication and authorization with e.g. Auth0 or Okta
- (optional: calls an external API, or integrates with some other service)
- Scrum processes
    - Project board to track user stories across team. (no requirements on how detailed)
    - Standup at least two or three times a week
- any other tech you want within reason
- the data model (how many tables, what kind of complex relationship like N to N) must be at least as complicated as project 1.
- the user interaction model (what are the user stories, what inputs/interactions can the user make) must be at least as complicated as project 1.
- a project proposal
    - MVP minimum viable product
    - potentially stretch goals, extra features
