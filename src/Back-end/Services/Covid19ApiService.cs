﻿using System;
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
        public async Task<IEnumerable<Covid19ApiDataModel>> GetDataAsync()
        {
            var covid19ApiConfig = new Covid19ApiConfig();
            _configuration.GetSection("Covid19ApiConfig").Bind(covid19ApiConfig);

            List<Covid19ApiDataModel> covid19ApiDataModels = new List<Covid19ApiDataModel>();

            using (HttpClient httpClient = new HttpClient())
            {
                var responseString = await httpClient.GetStringAsync($"{covid19ApiConfig.BaseUrl}{covid19ApiConfig.RequestUrl}");
                Console.WriteLine(responseString);

                Console.WriteLine(covid19ApiDataModels);
                covid19ApiDataModels = JsonConvert.DeserializeObject<List<Covid19ApiDataModel>>(responseString);

            }

            covid19ApiDataModels.ForEach(async (covid19ApiDataModel) =>
            {
                var iter = 0;
                var location = _locator.GetLocation(covid19ApiDataModel.Countries[iter].CountryName);
                covid19ApiDataModel.Countries[iter].Location = location == null ? new LocationDataModel() { Latitude = 0, Longitude = 0 } : location;
                iter++;
            });

            return covid19ApiDataModels;

        }

    }
}
