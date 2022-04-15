using eTicketsHEALTHWEB.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTicketsHEALTHWEB.Models
{
    public class Doctor: IEntityBase
    {
        [Key] //I could remove cos of IEntityBase- simply ovveride
        public int Id { get; set; } //I could remove cos of IEntityBase- simply ovveride

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage ="Profile Picture is required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength =3,ErrorMessage ="Full Name must be between 3 and 50 chars")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }
        //Relationships
        public List<Doctor_VirusName> Doctors_VirusNames { get; set; }
    }
}
