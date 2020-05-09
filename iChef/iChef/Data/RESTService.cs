using iChef.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace iChef.Data
{
    public class RestService
    {
        HttpClient client;
        string grant_type = "password";

        public RestService()
        {
            //this.client = new HttpClient();
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            this.client = new HttpClient(clientHandler);
            client.MaxResponseContentBufferSize = 256000;
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
        }

        public async Task<User> Login(User user)
        {
            var postData = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("grant_type", grant_type),
                new KeyValuePair<string, string>("username", user.Username),
                new KeyValuePair<string, string>("password", user.Password)
            };
            var content = new FormUrlEncodedContent(postData);

            var response = await PostResponseLogin<User>(Constants.LoginUrl, content);

            return response;
        }

        public async Task<T> PostResponse<T>(string weburl, string jsonstring) where T : class
        {
            string contentType = "application/json";
            try
            {
                var response = await client.PostAsync(weburl, new StringContent(jsonstring, Encoding.UTF8, contentType));
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonResult = response.Content.ReadAsStringAsync().Result;
                    try
                    {
                        var contentResponse = JsonConvert.DeserializeObject<T>(jsonResult);
                        return contentResponse;
                    }
                    catch
                    {
                        return null;
                    }
                }
            }
            catch
            {
                return null;
            }
            return null;
        }

        public async Task<T> PostResponseLogin<T>(string weburl, FormUrlEncodedContent content)
        {
            var response = await client.PostAsync(weburl, content);
            var jsonResponse = response.Content.ReadAsStringAsync().Result;
            var responseObject = JsonConvert.DeserializeObject<T>(jsonResponse);
            return responseObject;
        }

        public async Task<T> GetResponse<T>(string weburl) where T : class
        {
            try
            {
                var response = await client.GetAsync(weburl);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonResult = response.Content.ReadAsStringAsync().Result;
                    Debug.WriteLine("JsonResult:" + jsonResult);
                    try
                    {
                        var contentResponse = JsonConvert.DeserializeObject<T>(jsonResult);
                        return contentResponse;
                    }
                    catch
                    {
                        return null;
                    }
                }
            }
            catch
            {
                return null;
            }
            return null;
        }
    }
}
