# Designing & Implementing Microservices and Event Driven Applications using Microsoft Azure

## Introduction

Why Microservices
Monolyth vs Microservices
Why Event Driven Applications
Open Api & Swagger
Creating Software Architecture Diagrams
What are Cloud Architecture Design Patterns
The sample Application

## Building Blocks and Architecture Overview

- Hosting: Containers, Kubernetes and Functions
- Storage: Azure Cosmos DB, Azure SQL, Blob Storage
- Caching: Redis and Client Side Caching
- Configuration Management: KeyVault, App Config Service
- Connecting and Events: Service Bus, Event Hub, Event Grid
- Access: Api Management & Application Gateway

## Data Storage: Azure SQL and Blob Storage

- Track and Record Data Changes using Azure SQL Change Data Capture
- Azure SQL Change Feed
- Using Blob Storage and Claim Check Pattern

## Event Driven Datastorage using Cosmos DB

- Domain-driven design (DDD) 
- Relational to Schemaless: Designig and Optimizing Schema
- Cosmos DB Indixing and Partitions
- Implementing a Product Catalog
- Persisting & Sharing Client State between Frontends

## Containers - Docker

- Container Basics (Multistage Build, Run, Debug, Publish)
- Docker Development Workflow    
- Resiliency and Healt Checks    
- Managing State in Containers    
- Configuration Management Options (Env, Config Mgmt, App Config)
- Debugging Containers

## Kubernetes

- Recap: Basic Terms (Pod, LB, ... )
- Config Map, Secrets
- Kubernetes Routing Methods
- Implementing Helm charts
- Understanding and using Sidecar Pattern
- Debugging with Bidge to Kubernetes
- Monitoring and App Insights Integration

## Azure Functions

- Implementing OData and Open Api Support
- Durable Functions and Patterns Intro
- Using Azure Durable Entites
- Long running processes and background Tasks


## Managing Asynchronous event-based communication

- Service Bus, Event Grid, Event Hub Recap
- Common Cloud Design Patterns used with Even Driven Architecture
- Deduplication and Transactions
- Event Sourcing and Integration Events
- 

## Managing Client Access and Connecting FrontEnds

- Recap API Management and Application Gateway
- Understanding Gateway Pattern and Backends for Frontends Pattern
- Overview API Management Policies (Throtteling, Authentication)
- Securing Api Access using Managed Identites
- Using Redis Cache in API Management
- Implementing API Gateways using Envoy
- Real Time Communications from Service to UI using Azure PubSub