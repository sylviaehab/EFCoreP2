using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreP2.Models
{
    public class OrganizerProfile
    {
        public int Id { get; set; }

        public string Bio { get; set; } 

        public string? WebsiteUrl { get; set; }

        public string? LogoUrl { get; set; }

        public int OrganizerID { get; set; }
        public Organizer? Organizer { get; set; }
    }
}
