using System;
using System.Collections.Generic;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Configuration;

namespace GitHub.FavLanguages
{
    public  class ServiceClient
    {
        /// <summary>
        /// Method to get favourite language for given github user 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public string GetUserFavoriteLanguage(string userName)
        {
            HttpClient client = new HttpClient();
            var token = "<token>";
            client.DefaultRequestHeaders.UserAgent.Add(new System.Net.Http.Headers.ProductInfoHeaderValue("AppName", "1.0"));
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue
                ("Token", ConfigurationManager.AppSettings["AuthenticationToken"]);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string ulr = String.Format(ConfigurationManager.AppSettings["GitHubServiceUrl"], userName);
            using (HttpResponseMessage response = client.GetAsync(ulr).Result)
            {
                if (response.StatusCode == HttpStatusCode.NotFound)
                    return "No user found";
                else
                    using (HttpContent content = response.Content)
                    {
                        string result = content.ReadAsStringAsync().Result;
                        List<Languages> languages = JsonConvert.DeserializeObject<List<Languages>>(result);
                        if (languages != null & languages.Count > 0)
                            if (languages[0].language == null)
                                return userName + " has no favourite programming language ";
                            else
                                return userName + "'s" + " favourite programming language is  " + languages[0].language;
                        else
                            return userName + " has no repository";

                    }
            };

        }
    }
}