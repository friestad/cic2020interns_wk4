using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Ibm.Br.Cic.Internship.Covid.Be.Configuration;
using Ibm.Br.Cic.Internship.Covid.Be.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Ibm.Br.Cic.Internship.Covid.Be.Services
{
    public class Covid19ApiService : ICovid19Api
    {
        private readonly IConfiguration _configuration;
        private readonly ILocator _locator;
        public Covid19ApiService(IConfiguration configuration, ILocator locator)
        {
            _configuration = configuration;
            _locator = locator;
        }

        //Task: Implement Service
        //Add method (Task<IEnumerable<Covid19ApiDataModel>> GetData()) to ICovid19ApiService
        public async Task<IEnumerable<Covid19ApiDataModel>> GetData()
        {
            var covid19ApiConfig = new Covid19ApiConfig();
            _configuration.GetSection("Covid19ApiConfig").Bind(covid19ApiConfig);

            List<Covid19ApiDataModel> covid19ApiDataModels = new List<Covid19ApiDataModel>();

            using (HttpClient httpClient = new HttpClient())
            {
                var responseString = await httpClient.GetStringAsync($"{covid19ApiConfig.BaseUrl}{covid19ApiConfig.RequestUrl}");
                Console.WriteLine(responseString);

                Covid19ApiDataModel temp = JsonConvert.DeserializeObject<Covid19ApiDataModel>(responseString);
                covid19ApiDataModels.Add(temp);
            }

            covid19ApiDataModels[0].Countries.ForEach(async (Country) =>
            {
                var location = _locator.GetLocation(Country.CountryName);
                Country.Location = location == null ? new LocationDataModel() { Latitude = 0, Longitude = 0 } : location;
            });

            return covid19ApiDataModels;

        }

    }
}
