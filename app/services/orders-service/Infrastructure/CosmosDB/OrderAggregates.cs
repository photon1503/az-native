﻿using Microsoft.Azure.Cosmos;

namespace FoodApp
{
    public class OrderAggregates : IOrderAggregates
    {
        private Container container;
        public OrderAggregates(
                string connectionString,
                string databaseName,
                string containerName)
        {
            CosmosClient client = new CosmosClient(connectionString);
            container = client.GetContainer(databaseName, containerName);
        }
    
        public async Task<Order> GetOrderByIdAsync(string id, string customerId)
        {
            try
            {
                ItemResponse<Order> response = await container.ReadItemAsync<Order>(id, new PartitionKey(customerId));
                return response.Resource;
            }
            catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
        }        
        public Task<IEnumerable<Order>> GetAllOrdersForCustomer(string customerId)
        {
            var sql = "SELECT * FROM orders o where o.type='order' and o.customer.Id='" + customerId + "'";
            return GetOrdersByQueryAsync(sql);
        }

        public async Task<IEnumerable<Order>> GetAllOfTypeOrderAsync()
        {
            var sql = "SELECT * FROM orders o where o.type='order'";
            QueryDefinition qry = new QueryDefinition(sql);
            FeedIterator<Order> feed = container.GetItemQueryIterator<Order>(qry);

            List<Order> orders = new List<Order>();
            while (feed.HasMoreResults)
            {
                FeedResponse<Order> response = await feed.ReadNextAsync();
                foreach (Order od in response)
                {
                    orders.Add(od);
                    Console.WriteLine("\tRead {0}\n", od.Customer.Id);
                }
            }
            return orders;
        }

        public async Task<IEnumerable<Order>> GetOrdersByQueryAsync(string queryString)
        {
            var query = container.GetItemQueryIterator<Order>(new QueryDefinition(queryString));
            List<Order> results = new List<Order>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();

                results.AddRange(response.ToList());
            }
            return results;
        }
    }
}