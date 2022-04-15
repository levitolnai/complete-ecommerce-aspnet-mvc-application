using eTicketsHEALTHWEB.Data;
using eTicketsHEALTHWEB.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTicketsHEALTHWEB.Models
{
    public class VirusNameVM
    {
        public int Id { get; set; }

        [Display(Name = "Virus name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Virus description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Virus poster URL")]
        [Required(ErrorMessage = "Movie poster URL is required")]
        public string ImageURL { get; set; }

        [Display(Name = "Vaccination start date")]
        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Vaccination end date")]
        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Virus category is required")]
        public VirusNameCategory VirusNameCategory { get; set; }

        //Relationships
        [Display(Name = "Select doctor(s)")]
        [Required(ErrorMessage = "Doctor(s) is required")]
        public List<int> DoctorIds { get; set; }

        [Display(Name = "Select a hospital")]
        [Required(ErrorMessage = "Hospital is required")]
        public int HospitalId { get; set; }

        [Display(Name = "Select a company")]
        [Required(ErrorMessage = "Company is required")]
        public int CompanyId { get; set; }
    }
}
