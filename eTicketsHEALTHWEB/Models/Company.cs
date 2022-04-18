﻿using eTicketsHEALTHWEB.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTicketsHEALTHWEB.Models
{
    public class Company: IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display (Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string FullName { get; set; }

        [Display(Name = "Profile")]
        [Required(ErrorMessage = "Profile is required")]
        [StringLength(500, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string Bio { get; set; }

        //RelationShips
        public List<VirusName>VirusNames { get; set; }
    }
}
