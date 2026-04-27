using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace G_NET_33_EFCore02.Entities
{
    [Table("Attendees")]
    public class Attendee
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(200)]
        public string Email { get; set; }
        [Required]
        public Address HomeAddress { get; set; } 

        //Navigation 
        
        public Badge? Badge { get; set; }

        public ICollection<Registration> Registrations { get; set; } = new List<Registration>();
    }
}