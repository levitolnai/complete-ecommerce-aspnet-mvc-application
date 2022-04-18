using System.ComponentModel.DataAnnotations;

namespace eTicketsHEALTHWEB.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }

        public VirusName VirusName { get; set; }
        public int Amount { get; set; }


        public string ShoppingCartId { get; set; }

    }
}
