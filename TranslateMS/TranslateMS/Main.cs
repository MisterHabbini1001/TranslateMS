using System;
using System.Net.Http;

namespace TranslateMS
{
    public static class Main
    {
        private const string ApiKeyHeader = "Ocp-Apim-Subscription-Key";

        private const string ApiUrl = "http://api.microsofttranslator.com/v2/http.svc/translate?text={0}&to={1}&from=en&category=general";

        private const string ApiKey = "7051e354d610423b93cb98b7dd77db43";

        public static string fetch(string text, string to)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add(ApiKeyHeader, ApiKey);
            string connection_url = String.Format(ApiUrl, text, to);

            var response = client.GetAsync(connection_url).Result;

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                return "there was an error";
            }
        }       
    }
}

/*
public static string fetch(string text, string to)
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Put, ApiUrl);
            requestMessage.Headers.Add(ApiKeyHeader, ApiKey);  
            client.DefaultRequestHeaders.Add(ApiKeyHeader, ApiKey);
            string connection_url = String.Format(ApiUrl, text, to);

            HttpResponseMessage response = client.GetAsync(connection_url).Result;
            //string response = client.GetAsync(connection_url).Result;

            return response.ToString();
            //return "";

        }
*/


