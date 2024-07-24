using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Hotels
    {

        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string? Name { get; set; }

        [StringLength(50)]
        [Required]
        public string City { get; set; }

    }
}
