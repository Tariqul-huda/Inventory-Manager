using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inventory_Manger
{
    internal static class FireBaseConfig
    {

            static IFirebaseConfig config = new FirebaseConfig()
            {
                AuthSecret = "h21orDLjTx6bvSpWJMLReuWdQ0p8jpYqyRMU0gw0",
                BasePath = "https://inventeger-data-default-rtdb.firebaseio.com/"
            };
        
        static IFirebaseClient client = new FirebaseClient(config);
        public static IFirebaseClient Client { get { return client; } }
        public static async void Post(string email,User u)
        {
            email = email.Substring(0,email.Length-4);
            SetResponse response = await client.SetAsync($"userList/{email}",u);
        }
        public static async Task<Dictionary<string,User>> Get()
        {
            var data = await client.GetAsync("userList"); ;
            if(data.ToString() != "null")
            {
            Dictionary<string, User> result = data.ResultAs<Dictionary<string, User>>();
            return result;
            }
            return null;
        }
       // public static 
    }
}
