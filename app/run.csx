#r "Newtonsoft.Json"

using System.Net;
using Newtonsoft.Json;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info("C# HTTP trigger function processed a request.");

    string responseMessage = "Hello, World!";

    return req.CreateResponse(HttpStatusCode.OK, responseMessage);
}
