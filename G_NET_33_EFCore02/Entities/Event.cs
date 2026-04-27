using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_33_EFCore02.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string? Title { get; set; } 
        public string ?Description { get; set; } 
        public DateTime StartDate { get; set; }

        
        public DateTime? EndDate { get; set; }
        public int MaxAttendees { get; set; }

        //Navigation prop
        public int? ParentEventId { get; set; }
        public Event? ParentEvent { get; set; }
        public ICollection<Event> Sessions { get; set; } = new List<Event>();
        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; } = null!;
        public ICollection<Registration> Registrations { get; set; } = new List<Registration>();

    }

    
}
