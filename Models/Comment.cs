using System;

namespace meetup_1_asp_net_core.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public DateTime AddedAt { get; set; }
    }
}
