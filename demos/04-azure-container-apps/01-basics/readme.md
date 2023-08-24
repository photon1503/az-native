# Deploying a muliti-container App (Ingress, Exgress)

[Azure Container Apps documentation](https://learn.microsoft.com/en-us/azure/container-apps/)

## Demo

[food-catalog-api](/app/food-catalog-api/) provides a REST API to manage a food catalog.

[food-shopp-ui](/app/food-shop-ui//) consumes it and provides an Online Food Shop implemented in Angular.

Task 1: Create a container app environment and deploy two apps

- Execute [create-container-base.azcli](create-container-base.azcli) to create the base ressources of the app. It creates the following resources:

    - resource group
    - container registry
    - log analytics workspace
    - container app environment

- Navigate to the [app](/app/) folder and execute [create-images.azcli](/app/create-images.azcli) to create the container images.

    >Note: To save time you might just initialize all variables and build only the images you need.

- Excute [deploy-apps.azcli](deploy-apps.azcli) to deploy the apps to the container app environment.