# Designing & Implementing Microservices and Event Driven Applications using Microsoft Azure

Das Seminar richtet sich an Azure Entwickler und Software Architects welche einen Überblick über die Kernelemente der Entwicklung und Bereitstelle einer Event Driven Appication in Microsoft Azure lernen wollen. 

Neben den Theorieteilen der Modules, gestalten wir eine App bestehend aus klassischem Api-Monolythen mit UI in Microservices (Catalog, State, Payment, Delivery) um, und optimieren das Konfiguration Management für Container. Dabei besprechen wir im Detail mögliche Refactorings bezüglich Bereitstellung in Kubernets (Health Probes), sowie Datenspeicherung und effizientes Schemadesign für Azure Cosmos DB aber auch Azure SQL Server Features wie SQL Change Data Capture. 

Cosmos DB, sein Change Feed wird dann den Übergang in die Welt der Event Driven Applications darstellen. Teile der Microservices implementieren wir Serverless mit Hilfe von Azure Functions und Nutzen dabei auch Azure Event Hub und Azure Service Bus. In diesem Abschnitt werden sowohl einige Cloud Design Patterns an teilen der App vermittelt. 

Last but not least publizieren und sichern wir die App, und deren Mikroservices mit Api Management und Application Gateway, um dann noch unser Reactive Angular UI mit Client Side (NgRx) State in echtzeit mittels Azure PubSub aktuell zu halten.

In allen Phasen wird Authentication und Authorization mittels Microsoft Identity sichergestellt und ein Automatisiertes Deployment der App ist mittels Azure CLI und / oder BICEP gewährleistet.

## Voraussetzungen

Kursteilnehmer welche die Labs erfolgreich durchführen wollen sollten Kenntnisse der in AZ-204 vermittelten Programmierkenntnisse 

## Themen

- Introduction to Microservices and Event Driven Applications
- Building Blocks and Architecture Overview
- Data Storage: Azure SQL and Blob Storage
- Containers - Docker
- Hosting Microservices on Azure Kubernetes Services
- Schemaless and Event Optimized Datastorage using Cosmos DB
- Implementing Microservices using Durable Azure Functions
- Designing Asynchronous Event-based Communication using Service Bus and Event Hub
- Managing and Securing Api Access
- Managing Traffic using Azure Application Gateway
- Connecting Reactive Frontends using Azure PubSub

### Introduction to Microservices and Event Driven Applications

- Why Microservices
- Monolyth vs Microservices
- Why Event Driven Applications
- Open Api & Swagger
- Creating Software Architecture Diagrams
- What are Cloud Architecture Design Patterns
- The sample Application

### Building Blocks and Architecture Overview

- Hosting: Containers, Kubernetes and Functions
- Storage: Azure Cosmos DB, Azure SQL, Blob Storage
- Caching: Redis and Client Side Caching
- Configuration Management: KeyVault, App Config Service
- Connecting and Events: Service Bus, Event Hub, Event Grid
- Access: Api Management & Application Gateway
- Security: Microsoft Identity & Managed Identites

## Data Storage: Azure SQL and Blob Storage

- Track and Record Data Changes using Azure SQL Change Data Capture
- Materialized View Pattern
- Azure SQL Change Feed
- Blob Storage and Claim Check Pattern

## Containers - Docker

- Container Recap (Multistage Build, Run, Debug, Publish to ACR)
- Docker Development Workflow and Debugging
- Resiliency and Healt Checks    
- Managing State in Containers    
- Configuration Management Options (Env Variables, ConfigMap, Azure App Config Service)

## Hosting Microservices on Azure Kubernetes Services

- Recap: Basic Terms (Pod, LB, ... )
- Using Config Map & Secrets to configure Microservices
- Implementing Helm charts
- Supporting Resilience and Health Probes in Microservices
- Kubernetes Routing Methods
- Understanding and using Sidecar Pattern
- Debugging with Bidge to Kubernetes
- Monitoring and App Insights Integration

## Schemaless and Event Optimized Datastorage using Cosmos DB

- Relational to Schemaless: Designig and Optimizing Schema 
- Domain-driven design (DDD) 
- Cosmos DB Partitioning Strategies
- Understanding the CQRS Pattern
- Cosmos DB Change Feed and Event Sourcing
- Implementing a Product Catalog 
- Persisting & Sharing Client State between Frontend Devices

## Implementing Microservices using Durable Azure Functions

- Benefits of Serverless
- Implementing OData and Open Api Support
- Durable Functions and Patterns Intro
- Using Azure Durable Entites for Long running processes and background Tasks
- Implementing a Microservice using Azure Durable Functions

## Designing Asynchronous Event-based Communication using Service Bus and Event Hub

- Service Bus & Event Hub Recap
- Common Cloud Design Patterns used with Even Driven Architecture
- Deduplication and Transactions
- Event Sourcing and Integration Events
- Analysing and Responding To Events unsing Azure Stream Analytics

## Managing and Securing Api Access

- API Management Recap
- Understanding Gateway Pattern and Backends for Frontends Pattern
- Api Versions and Revisions
- Overview API Management Policies (Throtteling, Authentication)
- Securing Api Access using Managed Identites
- Using Redis Cache in API Management

## Managing Traffic using Azure Application Gateway

- Application Gateway Recap
- Automated Deployment of the Sample Application using Azure CLI and BICEP
- Securing and Publishing the Sample Application using Azure Application Gateway

## Connecting Reactive Frontends using Azure PubSub

- Event Grid Recap
- Publishing Frondend related Events to Azure Event Grid
- Real Time Options: SignalR vs Azure PubSub
- Consuming Event Grid to implement a Real Time connected UI
