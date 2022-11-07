# Designing & Implementing Microservices and Event Driven Applications using Microsoft Azure

Das Seminar richtet sich an Azure Entwickler und Software Architects welche einen Überblick über die Kernelemente der Entwicklung und Bereitstelle von Event Driven Applications in Microsoft Azure bekommen wollen. 

Begleitend zu den Theorieteilen der einzelnen Module, gestalten wir eine App bestehend aus klassischem Monolithen mit UI in Microservices (Catalog, State, Payment, Delivery, Purchasing) und Micro Frontends um. Dabei besprechen wir im Detail mögliche Refactorings bezüglich Bereitstellung in Kubernetes (Config Injection, Health Checks, …), sowie effizientes denormalisiertes Schemadesign für Azure Cosmos DB aber auch Azure SQL Server Features wie SQL Change Data Capture. 

Cosmos DB, sein Change Feed wird dann den Übergang in die Welt der Event Driven Applications darstellen. Teile der Microservices implementieren wir Serverless mit Hilfe von Azure Durable Functions und Nutzen dabei auch Azure Event Hub und Azure Service Bus. In diesem Abschnitt werden sowohl einige Cloud Design Patterns an Teilen der App implementiert. 

Last but not least publizieren und sichern wir die App, und deren Microservices mit API Management und Application Gateway, um dann noch unser Reactive Angular UI mit Client Side (NgRx) State in Echtzeit mittels Azure Web PubSub aktuell zu halten.

In allen Phasen wird Authentication und Authorization mittels Microsoft Identity sichergestellt und ein Automatisiertes Deployment der App ist mittels Azure CLI und / oder BICEP gewährleistet.

Beispiele werden größtenteils in .NET, Node.js und TypeScript gezeigt. Fallweise können aber auch alternative Technologie Stacks verwendet werden, bzw. wird auf deren Docs verwiesen.

## Voraussetzungen und Zielgruppe

Kursteilnehmer welche die Labs erfolgreich durchführen wollen sollten Kenntnisse und Erfahrung der in AZ-204 vermittelten Kenntnisse erworben haben. Mit RECAP gekennzeichnete Themen sind Kurzzusammenfassungen von AZ-204 Inhalten.

Audience: Azure Developers & Software Architects

## Themen

- Introduction to Microservices and Event Driven Applications
- Building Blocks and Architecture Overview
- Optimizing Services and Front Ends for Containers
- Hosting Microservices on Azure Kubernetes Services
- Schemaless and Event Optimized Datastorage using Cosmos DB
- Implementing Microservices using Durable Azure Functions
- Designing Event Driven Apps using Service Bus, Event Hub & Event Grid
- Integrating Azure SQL and Blob Storage with Events
- Managing and Securing API Access using Api Management
- Managing Traffic using Azure Application Gateway
- Implementing Reactive Frontends using Azure Web PubSub

### Introduction to Microservices and Event Driven Applications

- Why Microservices
- OpenAPI Specification(OAS) & Swagger
- Monolith vs Microservices
- What are Cloud Architecture Design Patterns
- Api Gateway Pattern
- Why Event Driven Applications
- Creating Software Architecture Diagrams
- Domain Driven Design and Bounded Context Pattern
- The workshop Application: Current vs Goal

### Building Blocks and Architecture Overview

- Hosting: Containers, Kubernetes and Functions
- Storage: Azure Cosmos DB, Azure SQL, Blob Storage
- Caching: Redis and Client Side State using NgRx
- Configuration Management, Secrets: Key Vault, App Config Service
- Messaging Brokers: Service Bus, Event Hub, Event Grid
- Real Time: Azure SignalR Service, Azure Web PubSub
- Access & Management: API Management & Application Gateway
- Authentication & Authorization: Microsoft Identity, Azure AD B2C & Managed Identities

## Optimizing Services and Front Ends for Containers

- Container Recap (Multistage Build, Run, Debug, Publish to ACR)
- Configuration Management Options (Env Variables, ConfigMaps, Azure App Config Service)
- Docker Development Workflow and Debugging
- Using docker-compose.yaml to locally test multiple containers
- Docker Networking & Volumes
- Stateful Containers using Azure Blob Storage
- Using SQL-Linux in Containers

## Hosting Microservices on Azure Kubernetes Services

- Recap: Basic Terms (Pod, LB, ... )
- Using Config Map & Secrets
- Implementing Helm charts
- Supporting Resilience and Health Checks
- Kubernetes Routing Methods
- Understanding and using Sidecar Pattern
- Debugging with Bridge to Kubernetes
- Monitoring and App Insights Integration

## Designing Event Driven Apps using Service Bus, Event Hub & Event Grid

- Introduction to Event Driven Architecture
- Common Message Broker Types in Azure
- Messages vs Events
- Pub / Sub vs Event Streaming
- What to choose when: Service Bus vs Event Hub vs Event Grid
- Choosing the Messaging Broker: Features and Use-Cases
- Common Cloud Design Patterns used with Even Driven Architecture
- Event Sourcing and Integration Events
- Publishing & Subcribing Event in Microservices
- Deduplication and Transactions
- Refactor Microservices to support Event Based Communication
- Analysing and Responding to Events using Azure Stream Analytics (optional)

## Schemaless and Event Optimized Datastorage using Cosmos DB

- Relational to Schemaless: Designing and Optimizing Schema 
- Domain-driven design (DDD) 
- Cosmos DB Partitioning Strategies
- Understanding the CQRS Pattern
- Cosmos DB Change Feed and Event Sourcing
- Implementing a Product Catalogue 
- Persisting & Sharing Client State between Frontend Devices

## Implementing Microservices using Durable Azure Functions

- Serverless and Azure Functions Recap
- Implementing OData and Open API Support
- Running Function Apps Containers
- Durable Functions and Patterns
- Changing Storage Providers in Azure Durable Functions
- Using Azure Durable Entities for Long running processes and background Tasks
- Implementing a Microservice using Azure Durable Functions
- Montoring Durable Functions

## Integrating Azure SQL and Blob Storage with Events

- Provisioning Consumption based Databases for Development
- Track and Record Data Changes using Azure SQL Change Data Capture
- Materialized View Pattern
- Azure SQL bindings for Azure Functions
- Blob Storage and Claim Check Pattern

## Managing and Securing API Access using Api Management

- API Management Recap
- API Management Policies Recap (Quotas, Throttling, Mock Response, Retry, ...)
- Understanding Gateway Pattern and Backends for Frontends Pattern
- API Versions and Revisions
- Securing API Access using Authentication & Managed Identities
- Using Redis Cache in API Management

## Front End Integration

- Event Grid Recap
- Gateway Aggregation / Gateway Routing Pattern
- Real Time Options: SignalR vs Azure Web PubSub
- Implementing Reactive Real Time Frontends using Event Grid & Azure Web PubSub
