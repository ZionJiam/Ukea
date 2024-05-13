using System.ComponentModel.DataAnnotations;

namespace UKEA.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string password { get; set; }
    }
}
