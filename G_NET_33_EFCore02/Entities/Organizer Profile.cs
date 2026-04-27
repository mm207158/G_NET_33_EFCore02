using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_33_EFCore02.Entities
{
    public class OrganizerProfile
    {
        public int Id { get; set; }
        public int OrganizerId { get; set; }
        public string?  Bio { get; set; }
        public string?  WebsiteUrl { get; set; }
        public byte? Logo { get; set; }
        public Organizer Organizer { get; set; } = null!;


    }
}
