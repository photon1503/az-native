# Designing & Implementing Microservices and Event Driven Applications using Microsoft Azure

Das Seminar richtet sich an Azure Entwickler und Software Architects welche einen Überblick über die Kernelemente der Entwicklung und Bereitstelle von Event Driven Applications in Microsoft Azure bekommen wollen. 

Begleitend zu den Theorieteilen der einzelnen Module, modernisieren wir eine App bestehend aus klassischem Monolithen mit UI in eine Cloud Native App mit Microservices (Catalog, State, Payment, Delivery, Purchasing) und Micro Frontends um. Dabei besprechen wir im Detail mögliche Refactorings bezüglich Bereitstellung in Kubernetes bzw Azure Container Apps (Secrets, Revisions, Config Injection, Health Checks, Kubernetes Event Driven Auto-Scaling - KEDA), sowie effizientes denormalisiertes Schemadesign für Azure Cosmos DB aber auch Azure SQL Server Features wie SQL Change Data Capture. 

Cosmos DB, sein Change Feed wird dann den Übergang in die Welt der Event Driven Applications darstellen. Teile der Microservices implementieren wir mit Azure Durable Functions und Nutzen dabei Azure Service Bus aber auch Event Hub & Event Grid. Wir diskutieren anhand der Lösung die unterschiedlichen Hostingansätze (Serverless vs Container) und implementieren die Service to Service Kommunikation sowohl traditionell als auch mit Hilfe von Distributed Application Runtime (Dapr). In diesem Abschnitt werden auch einige Cloud Design Patterns vermittelt und an Teilen der App implementiert. 

Last but not least publizieren und sichern wir die App, und deren Microservices mit API Management und Application Gateway, um dann noch unser Reactive Angular UI mit Client Side (NgRx) State in Echtzeit mittels Azure Web PubSub aktuell zu halten.

In allen Phasen wird Authentication und Authorization mittels Microsoft Identity sichergestellt und ein Automatisiertes Deployment der App ist mittels Azure CLI und / oder BICEP gewährleistet.

Beispiele werden größtenteils in .NET, Node.js und TypeScript gezeigt. Fallweise können aber auch alternative Technologie Stacks verwendet werden, bzw. wird auf deren Docs verwiesen.

## Voraussetzungen und Zielgruppe

Kursteilnehmer welche die Labs erfolgreich durchführen wollen sollten Kenntnisse und Erfahrung der in AZ-204 vermittelten Kenntnisse erworben haben. Mit RECAP gekennzeichnete Themen sind Kurzzusammenfassungen von AZ-204 Inhalten.

Audience: Azure Developers & Software Architects

## Themen

- Introduction to Microservices and Event Driven Applications
- Building Blocks & Architecture Overview
- Optimizing Services & Front Ends for Containers
- Hosting Microservices on Azure Kubernetes Services
- Introduction to Azure Container Apps (ACA) and Kubernetes Event-Driven Autoscaling (KEDA)
- Distributed Application Runtime - Dapr
- Schemaless and Event Optimized Datastorage using Cosmos DB
- Implementing Microservices using Durable Azure Functions
- Designing Event Driven Apps using Service Bus, Event Hub & Event Grid
- Managing and Securing API Access using Api Management
- Implementing Reactive Micro Frontends using Azure Web PubSub

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

### Building Blocks & Architecture Overview

- Hosting: Containers, Kubernetes and Functions
- Storage: Azure Cosmos DB, Azure SQL, Blob Storage
- Caching: Redis and Client Side State using NgRx
- Configuration Management, Secrets: Key Vault, App Config Service
- Messaging Brokers: Service Bus, Event Hub, Event Grid
- Real Time: Azure SignalR Service, Azure Web PubSub
- Access & Management: API Management & Application Gateway
- Authentication & Authorization: Microsoft Identity, Azure AD B2C & Managed Identities

## Optimizing Services & Front Ends for Containers

- Container Recap (Multistage Build, Run, Debug, Publish to ACR)
- Configuration Management Options (Env Variables, ConfigMaps, Azure App Config Service)
- Docker Development Workflow and Debugging
- Using docker-compose.yaml to locally test multiple containers
- Docker Networking & Volumes
- Stateful Containers using Azure Blob Storage

## Hosting Microservices on Azure Kubernetes Services

- Recap: Basic Terms (Pod, LB, ... )
- Using Config Map & Secrets
- Implementing Helm charts
- Supporting Resilience and Health Checks
- Kubernetes Routing Methods
- Understanding and using Sidecar Pattern
- Debugging with Bridge to Kubernetes
- Monitoring and App Insights Integration

# Introduction to Azure Container Apps (ACA)

- Azure Container Apps vs Kubernetes
- Deploying a muliti Container App (Ingress, Exgress)
- Working with Secrets
- Introduction to KEDA (Kubernetes Event Driven Auto-Scaling) 
- Working with Revisions
- Container Apps Autehntication and Authorization using Managed Identities
- Container Apps Monitoring and Logging (Observability)

## Distributed Application Runtime - Dapr

- Introduction to Dapr
- Dapr Architecture
- Dapr Components
- Dapr State Management
- Dapr Pub/Sub

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
- Debugging Event Driven Applications

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
- Hosting and Scaling Function Apps in Containers
- Durable Functions and Patterns
- Changing Storage Providers in Azure Durable Functions
- Using Azure Durable Entities for Long running processes and background Tasks
- Implementing a Microservice using Azure Durable Functions
- Montoring Durable Functions

## Managing and Securing API Access using Api Management

- API Management Recap
- API Management Policies Recap (Quotas, Throttling, Mock Response, Retry, ...)
- Understanding Gateway Pattern and Backends for Frontends Pattern
- API Versions and Revisions
- Securing API Access using Authentication & Managed Identities
- Using Redis Cache in API Management

## Implementing Real Time Micro-Frontends & User Interfaces

- Gateway Aggregation / API Gateway Pattern
- Event Grid Recap
- Real Time Options: SignalR vs Azure Web PubSub
- Implementing Reactive Real Time Frontends using Event Grid & Azure Web PubSub