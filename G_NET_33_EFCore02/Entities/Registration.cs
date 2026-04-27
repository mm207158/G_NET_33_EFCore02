using System.ComponentModel.DataAnnotations.Schema;

namespace G_NET_33_EFCore02.Entities
{
    public class Registration
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       
        public int AttendeeId { get; set; }
        public int EventId { get; set; }

       
        public string? NoteToOrganizer { get; set; }

        
        public DateTime RegisteredAt { get; set; }

        //  Navigation 
        public Attendee Attendee { get; set; } = null!;
        public Event Event { get; set; } = null!;
    }
}