using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RasaChatWin.DataHandler
{
    public static class response
    {
        public static List<keystrings> ResponseProcessor(string responses)
        {
            // List<> listRange = new List<> 
            Console.WriteLine(responses);
            List<keystrings> objList = JsonConvert.DeserializeObject<List<keystrings>>(responses);

            /* foreach (keystrings obj in objList)
            {
                string text = obj.text;
                string image = obj.image;
                Console.WriteLine("text:  {0}", text);
                Console.WriteLine("imt:  {0}", image);
            }
                string temps = "Label controls"; */
            return objList;
        }
    }
}
