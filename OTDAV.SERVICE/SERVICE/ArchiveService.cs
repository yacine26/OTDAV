using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient.Memcached;
using OTDAV.DOMAIN.Entities;

namespace OTDAV.SERVICE.SERVICE
{
    public class ArchiveService
    {

        public IEnumerable<archive> getAllArchives()
        {

            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:8080");
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = Client.GetAsync("/otdav-4GLA-web/api/archive").Result;
            if (response.IsSuccessStatusCode)
            {
                return  response.Content.ReadAsAsync<IEnumerable<archive>>().Result;
            }
            else
            {
                return response.Content.ReadAsAsync<IEnumerable<archive>>().Result;
            }

        }

    }
}
