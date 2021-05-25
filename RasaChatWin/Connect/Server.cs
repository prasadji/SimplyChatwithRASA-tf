using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RasaChatWin.DataHandler
{
    public static class server
    {
        private static readonly string baseurl = "http://127.0.0.1:5005/webhooks/rest/webhook";
        private static HttpClient client = new HttpClient();
        public static async Task<string> GetAll(string user_input)
        {
            var values = new Dictionary<string, string>
                {
                    { "sender","test_user" },
                    { "message", user_input  }
                };

            // values.Add("message", user_input);

            //var data = new FormUrlEncodedContent(values);
            var data = new StringContent(JsonConvert.SerializeObject(values), Encoding.UTF8, "application/json");

            //   using (HttpClient client = new HttpClient())
            //   {
            using (HttpResponseMessage res = await client.PostAsync(baseurl, data))
            {
                using (HttpContent content = res.Content)
                {

                    //string datas = await content.ReadAsStringAsync();
                    var datas = await content.ReadAsStringAsync();
                    if (datas != null)
                    {
                        return datas;
                    }
                }
            }
            //  }
            return string.Empty;
        }
    }
}
