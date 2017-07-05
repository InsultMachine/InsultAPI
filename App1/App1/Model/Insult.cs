using System.Collections.Generic;
using Mobile.Model;

namespace Mobile.Models
{
    public class Insult
    {
        public int InsultId { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public List<InsultVote> Votes { get; set; }
    }
}
