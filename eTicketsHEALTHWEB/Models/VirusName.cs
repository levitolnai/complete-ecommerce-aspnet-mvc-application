using eTicketsHEALTHWEB.Data;
using eTicketsHEALTHWEB.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTicketsHEALTHWEB.Models
{
    public class VirusName: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public VirusNameCategory VirusNameCategory { get; set; }

        //Relationships

        public List<Doctor_VirusName> Doctors_VirusNames { get; set; }

        //Hospital

        public int HospitalId { get; set; }
        [ForeignKey("HospitalId")]

        public Hospital Hospital { get; set; }
        
        //Company

        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]

        public Company Company { get; set; }
    }
}
