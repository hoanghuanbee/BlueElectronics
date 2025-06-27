using System.ComponentModel.DataAnnotations;

namespace BlueElectronic.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

        [Range(0, int.MaxValue)]
        public int ProductPrice { get; set; }
        public string Img1 { get; set; }
    }
}
