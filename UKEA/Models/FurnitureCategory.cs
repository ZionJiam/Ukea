using System.ComponentModel.DataAnnotations;

namespace UKEA.Models
{
    public class FurnitureCategory
    {

        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
