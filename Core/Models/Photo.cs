using System.ComponentModel.DataAnnotations;

namespace SaleIt.Core.Models
{
    public class Photo
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string FileName { get; set; }

    }
}