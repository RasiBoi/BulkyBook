using System.ComponentModel.DataAnnotations;

namespace Bulkybook.Models
{
    public class Category
    {
        [Key] // This attribute indicates that this property is the primary key for the Category entity.
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;


    }
}
