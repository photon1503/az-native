# Designing & Implementing Microservices and Event Driven Applications using Microsoft Azure

Das Seminar richtet sich an Azure Entwickler und Software Architects welche einen Überblick über die Kernelemente der Entwicklung und Bereitstelle von Event Driven Applications in Microsoft Azure bekommen wollen. 

Begleitend zu den Theorieteilen der einzelnen Module, gestalten wir eine App bestehend aus klassischem Monolithen mit UI in Microservices (Catalog, State, Payment, Delivery, Purchasing) und Micro Frontends um. Dabei besprechen wir im Detail mögliche Refactorings bezüglich Bereitstellung in Kubernetes (Config Injection, Health Checks, …), sowie effizientes denormalisiertes Schemadesign für Azure Cosmos DB aber auch Azure SQL Server Features wie SQL Change Data Capture. 

Cosmos DB, sein Change Feed wird dann den Übergang in die Welt der Event Driven Applications darstellen. Teile der Microservices implementieren wir Serverless mit Hilfe von Azure Functions und Nutzen dabei auch Azure Event Hub und Azure Service Bus. In diesem Abschnitt werden sowohl einige Cloud Design Patterns an Teilen der App implementiert. 

Last but not least publizieren und sichern wir die App, und deren Mikroservices mit API Management und Application Gateway, um dann noch unser Reactive Angular UI mit Client Side (NgRx) State in Echtzeit mittels Azure Web PubSub aktuell zu halten.

In allen Phasen wird Authentication und Authorization mittels Microsoft Identity sichergestellt und ein Automatisiertes Deployment der App ist mittels Azure CLI und / oder BICEP gewährleistet.

## Voraussetzungen

Kursteilnehmer welche die Labs erfolgreich durchführen wollen sollten Kenntnisse der in AZ-204 vermittelten Programmierkenntnisse 

## Themen

- Introduction to Microservices and Event Driven Applications
- Building Blocks and Architecture Overview
- Optimizing for Containers
- Hosting Microservices on Azure Kubernetes Services
- Schemaless and Event Optimized Datastorage using Cosmos DB
- Implementing Microservices using Durable Azure Functions
- Designing Asynchronous Event-based Communication using Service Bus and Event Hub
- Integrating Azure SQL and Blob Storage with Events
- Managing and Securing API Access using Api Management
- Managing Traffic using Azure Application Gateway
- Connecting Reactive Frontends using Azure Web PubSub

### Introduction to Microservices and Event Driven Applications

- Why Microservices
- Monolith vs Microservices
- Why Event Driven Applications
- Open API & Swagger
- Creating Software Architecture Diagrams
- What are Cloud Architecture Design Patterns
- The sample Application

### Building Blocks and Architecture Overview

- Hosting: Containers, Kubernetes and Functions
- Storage: Azure Cosmos DB, Azure SQL, Blob Storage
- Caching: Redis and Client Side Caching
- Configuration Management: Key Vault, App Config Service
- Connecting and Events: Service Bus, Event Hub, Event Grid
- Access: API Management & Application Gateway
- Security: Microsoft Identity & Managed Identities

## Optimizing for Containers

- Container Recap (Multistage Build, Run, Debug, Publish to ACR)
- Docker Development Workflow and Debugging
- Stateful Containers using Azure Blob Storage
- Configuration Management Options (Env Variables, ConfigMaps, Azure App Config Service)

## Hosting Microservices on Azure Kubernetes Services

- Recap: Basic Terms (Pod, LB, ... )
- Using Config Map & Secrets
- Implementing Helm charts
- Supporting Resilience and Health Checks
- Kubernetes Routing Methods
- Understanding and using Sidecar Pattern
- Debugging with Bridge to Kubernetes
- Monitoring and App Insights Integration

## Schemaless and Event Optimized Datastorage using Cosmos DB

- Relational to Schemaless: Designing and Optimizing Schema 
- Domain-driven design (DDD) 
- Cosmos DB Partitioning Strategies
- Understanding the CQRS Pattern
- Cosmos DB Change Feed and Event Sourcing
- Implementing a Product Catalogue 
- Persisting & Sharing Client State between Frontend Devices

## Implementing Microservices using Durable Azure Functions

- Benefits of Serverless
- Implementing OData and Open API Support
- Durable Functions and Patterns Intro
- Using Azure Durable Entities for Long running processes and background Tasks
- Implementing a Microservice using Azure Durable Functions

## Designing Asynchronous Event-based Communication using Service Bus and Event Hub

- Service Bus & Event Hub Recap
- Common Cloud Design Patterns used with Even Driven Architecture
- Deduplication and Transactions
- Event Sourcing and Integration Events
- Analysing and Responding to Events using Azure Stream Analytics

## Integrating Azure SQL and Blob Storage with Events

- Provisioning Consumption based Databases for Development
- Track and Record Data Changes using Azure SQL Change Data Capture
- Materialized View Pattern
- Azure SQL bindings for Azure Functions
- Blob Storage and Claim Check Pattern

## Managing and Securing API Access using Api Management

- API Management Recap
- Understanding Gateway Pattern and Backends for Frontends Pattern
- API Versions and Revisions
- Overview API Management Policies (Throttling, Authentication)
- Securing API Access using Managed Identities
- Using Redis Cache in API Management

## Managing Traffic using Azure Application Gateway

- Application Gateway Recap
- Automated Deployment of the Sample Application using Azure CLI and BICEP
- Securing and Publishing the Sample Application using Azure Application Gateway

## Connecting Reactive Frontends using Azure Web PubSub

- Event Grid Recap
- Real Time Options: SignalR vs Azure Web PubSub
- Real Time connected UI’s using Azure Functions, Event Grid and Azure Web PubSub