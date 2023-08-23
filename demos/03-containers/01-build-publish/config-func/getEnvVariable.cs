using System.Net;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace Integrations
{
    public class getEnvVariable
    {
        private readonly ILogger _logger;

        public getEnvVariable(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<getEnvVariable>();
        }

        [Function("getEnvVariable")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            var queryDictionary = QueryHelpers.ParseQuery(req.Url.Query);
            if(queryDictionary["paramName"].Count > 0){
                var param = queryDictionary["paramName"][0];
                var value = Environment.GetEnvironmentVariable(param);
                response.WriteString($"{param} has the following Value: {value}");
            }            
            
            return response;
        }
    }
}
