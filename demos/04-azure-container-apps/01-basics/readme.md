# Deploying a muliti-container App (Ingress, Exgress)

[Azure Container Apps documentation](https://learn.microsoft.com/en-us/azure/container-apps/)

## Demo

Task 1: Create a container app environment and deploy two apps

[food-catalog-api](/app/food-catalog-api/) provides a REST API to manage a food catalog.

[food-shopp-ui](/app/food-shop-ui//) consumes it and provides an Online Food Shop implemented in Angular.

- Execute [create-container-base.azcli](create-container-base.azcli) to create the base ressources of the app. It creates the following resources:

    - resource group
    - container registry
    - log analytics workspace
    - container app environment
