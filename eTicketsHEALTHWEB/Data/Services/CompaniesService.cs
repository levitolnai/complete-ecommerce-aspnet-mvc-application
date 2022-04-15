using eTicketsHEALTHWEB.Data.Base;
using eTicketsHEALTHWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketsHEALTHWEB.Data.Services
{
    public class CompaniesService: EntityBaseRepository<Company>, ICompaniesService
    {
        public CompaniesService(AppDbContext context): base(context)
        {
        }
    }
}
