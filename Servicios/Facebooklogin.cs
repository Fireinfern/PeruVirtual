using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace Servicios
{
    public class Facebooklogin
    {
        private static readonly HttpClient client = new HttpClient();
        public async Task getCode()
        {
            var values = new Dictionary<string, string>
            {
                { "code", "92a2b2e351f2b0b3503b2de251132f47"},
                {"user_code", "A1NWZ9"},
                { "verification_uri", "https://www.facebook.com/device"},
                {"expires_in", "420"},
                {"interval", ""}
            };

            var content = new FormUrlEncodedContent(values);

            var response =await client.PostAsync("https://graph.facebook.com/v2.6/device/login?access_token=326527821977671|2b594617951c9b59727c2bd57735280c&scope=public_profile", content);

            var responseString =await response.Content.ReadAsStringAsync();

            Console.WriteLine(responseString);

            
        }

    }
}
