using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CRUDBasicsAPI.Model
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required int ID { get; set; }
        public required string Name { get; set; }
        public string? Address { get; set; }

    }
}
