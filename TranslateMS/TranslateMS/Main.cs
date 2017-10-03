/*

using System;
using System.Net.Http;
using System.Threading.Tasks;
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

        private static readonly HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            //do nothing
        }
        // TranslateMS.Main.fetch("hello world", "fr");
        
        public static string fetch(string text, string to) {
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

            /*
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(ApiUrl);
            httpWebRequest.Headers.Add(ApiKeyHeader, ApiKey);

            WebResponse response = null;
            try
            {
                response = httpWebRequest.GetResponse();
                using (Stream stream = response.GetResponseStream())
                {
                    System.Runtime.Serialization.DataContractSerializer dcs = new System.Runtime.Serialization.DataContractSerializer(Type.GetType("System.String"));
                    string translation = (string)dcs.ReadObject(stream);
                    Console.WriteLine("Translation for source text '{0}' from {1} to {2} is", text, "en", to);
                    Console.WriteLine(translation);
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
            }
            catch
            {
                throw;
            }
            finally
            {
                if (response != null)
                {
                    response.Close();
                    response = null;
                }
            }

            return "";
        
        }

        private static string _request() {

            return "";
        }

    }
}

*/







