using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;


namespace MaterCore.Web
{
    public class WebApiHelper
    {
        private string _apiBaseURI = "https://localhost:44333/";
        public HttpClient InitializeClient()
        {
            HttpClient httpClient;
            httpClient = new HttpClient { Timeout = new TimeSpan(0, 5, 0) };
            //Passing service base url  
            httpClient.BaseAddress = new Uri(_apiBaseURI);

            httpClient.DefaultRequestHeaders.Clear();
            //Define request data format  
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return httpClient;

        }
    }
}
