using System.ComponentModel.DataAnnotations;

namespace tshirt_factory.src.Models
{
    public class CustomTShirt
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string VariationType { get; set; }

        [Required]
        public string CustomData { get; set; }
    }
}
