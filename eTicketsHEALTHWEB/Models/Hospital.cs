using eTicketsHEALTHWEB.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTicketsHEALTHWEB.Models
{
    public class Hospital: IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name= "Hospital Logo")]
        [Required(ErrorMessage = "Hospital logo is required" )]
        public string Logo { get; set; }
        [Display(Name = "Hospital Name")]
        [Required(ErrorMessage = "Hospital name is required")]
        public string Name { get; set; }
        [Display(Name = "Hospital Description")]
        [Required(ErrorMessage = "Hospital description is required")]
        public string Description { get; set; }

        //Relationships
        public List<VirusName> VirusNames { get; set;}
    }
}
