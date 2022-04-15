using eTicketsHEALTHWEB.Data.Base;
using eTicketsHEALTHWEB.Data.ViewModels;
using eTicketsHEALTHWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketsHEALTHWEB.Data.Services
{
    public interface IVirusNamesService: IEntityBaseRepository<VirusName>
    {
        Task<VirusName> GetVirusNameByIdAsync(int id);
        Task<NewVirusDropVM> GetNewVirusDropValues();
        Task AddNewVaccinationAsync (VirusNameVM data);

        Task UpdateVirusNameAsync(VirusNameVM data);

    }
}
