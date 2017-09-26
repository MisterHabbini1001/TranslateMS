using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace TranslateMS
{
    class Main
    {

        
        private const string ApiKeyHeader = "Ocp-Apim-Subscription-Key";

        private const string ApiUrl = "http://api.microsofttranslator.com/v2/http.svc/translate?text={0}&to={1}&from=en&category=general";

        private const string ApiKey = "7051e354d610423b93cb98b7dd77db43";

        
        public static string fetch(string text, string to) {
            /**
             * Use Dot net HttpClient library to connect to ApiUrl, with a custome http header as :
             * 
             * {ApiKeyHeader} : {ApiKey}
             * 
             * format the ApiUrl and add {text} and {to} to the url
             * 
             * Return results as text.
             * 
             * 
             * */


            return "";
        
        }

        private static string _request() {


            return "";
        }



    }
}
