namespace G_NET_33_EFCore02.Entities
{
    public enum BadgeTier
    {
        Standard = 0,
        VIP = 1
    }


    public class Badge
        {
            public int Id { get; set; }

            public string? BadgeNumber { get; set; }
            public DateTime IssuedOn { get; set; }
            public BadgeTier Tier { get; set; } = BadgeTier.Standard;
            public int AttendeeId { get; set; }
            public Attendee Attendee { get; set; } = null!;
        }

    }
