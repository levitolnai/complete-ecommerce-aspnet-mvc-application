using eTicketsHEALTHWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketsHEALTHWEB.Data.ViewModels
{
    public class NewVirusDropVM
    {

        public NewVirusDropVM()
        {
            Companies = new List<Company>();
            Hospitals = new List<Hospital>();
            Doctors = new List<Doctor>();
        }

        public List<Company> Companies { get; set; }

        public List<Hospital> Hospitals { get; set; }
        public List<Doctor> Doctors { get; set; }

    }
}
