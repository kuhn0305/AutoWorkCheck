using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AutoWorkCheck
{
    public class Account
    {
        public string id;
        public string password;

        public Account(string fileName)
        {
            string path = Path.Combine("Resource", fileName);
            if(File.Exists(path))
            {
                string text = File.ReadAllText(path);
                JObject jObject = JObject.Parse(text);

                id = jObject["Id"].ToString();
                password = jObject["Password"].ToString();
            }
        }
    }
}
