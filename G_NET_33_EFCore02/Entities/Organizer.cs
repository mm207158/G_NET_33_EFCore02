using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_33_EFCore02.Entities
{
    [Table("Organizers")]
    public class Organizer
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string OrganizerName{ get; set; }

        [MaxLength(100)]
        [Required]
        public string CompanyName{ get; set; }

        [Required]
        public bool IsVerified { get; set; } = false;
        public OrganizerProfile? Profile { get; set; }

        public ICollection<Event> Events { get; set; } = new List<Event>();
    }
}
