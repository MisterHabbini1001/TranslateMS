using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Web;
using System.Media;

namespace TranslateMS
{
    class Main
    {
        private const string ApiKeyHeader = "Ocp-Apim-Subscription-Key";

        private const string ApiUrl = "http://api.microsofttranslator.com/v2/http.svc/translate?text={0}&to={1}&from=en&category=general";

        private const string ApiKey = "7051e354d610423b93cb98b7dd77db43";


        // TranslateMS.Main.fetch("hello world", "fr");

        public static string fetch(string text, string to)
        {
            /**
             * Use Dot net HttpClient library to connect to ApiUrl, with a custom http header as :
             * 
             * {ApiKeyHeader} : {ApiKey}
             * 
             * format the ApiUrl and add {text} and {to} to the url
             * 
             * Return results as text.
             * 
             * lang code:
             * en
             * fr
             * de
             * 
             * 
             * 
             * */
            HttpClient client = new HttpClient();
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Put, ApiUrl);
            requestMessage.Headers.Add(ApiKeyHeader, ApiKey);  
            client.DefaultRequestHeaders.Add(ApiKeyHeader, ApiKey);
            string connection_url = String.Format(ApiUrl, text, to);

            HttpResponseMessage response = client.GetAsync(connection_url).Result;
            Console.WriteLine(response.ToString());

            return response.ToString();
            //return "";

        }

        public static void Main(string[] args)
        {
           fetch("hello world", "fr");
        }

        private static string _request()
        {
            return "";
        }
       
    }
}


