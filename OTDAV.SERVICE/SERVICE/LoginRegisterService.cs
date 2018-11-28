using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using OTDAV.DOMAIN.Entities;

namespace OTDAV.SERVICE.SERVICE
{
    public class LoginRegisterService
    {
        public adherent AdherentLoggedin;

        public adherent doLogin(adherent adherent)
        {

            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:8080");
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = Client.PostAsJsonAsync<adherent>("/otdav-4GLA-web/api/adherent",adherent).Result;
            if (response.IsSuccessStatusCode)
            {
              //  AdherentLoggedin = response.Content.ReadAsAsync<adherent>().Result;
                return response.Content.ReadAsAsync<adherent>().Result;
            }
            else
            {
                return response.Content.ReadAsAsync<adherent>().Result;
            }

        }
    }
}
