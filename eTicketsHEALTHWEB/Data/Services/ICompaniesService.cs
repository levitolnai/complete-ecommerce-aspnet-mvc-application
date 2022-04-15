using eTicketsHEALTHWEB.Data.Base;
using eTicketsHEALTHWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketsHEALTHWEB.Data.Services
{//important to be public don't miss
    public interface ICompaniesService: IEntityBaseRepository<Company>
    {
    }
}
