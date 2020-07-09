using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ibm.Br.Cic.Internship.Covid.Be.Models;

namespace Ibm.Br.Cic.Internship.Covid.Be.Services
{
    public interface ICovid19Api
    {
        Task<IEnumerable<Covid19ApiDataModel>> GetData();
    }
}
