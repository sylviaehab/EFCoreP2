using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreP2.Models
{
    public enum BadgeTier {
        Standard,  VIP

    }
    public class Badge
    {
        public int Id { get; set; }
        public string BadgeNumber { get; set; }
        public DateTime Date { get; set; }
        public BadgeTier Tier { get; set; }
        public int AttendeeId { get; set; }

        public Attendee Attendee { get; set; }
    }
}
