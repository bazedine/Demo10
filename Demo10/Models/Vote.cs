using System;
using System.Collections.Generic;

namespace Demo10.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public virtual List<Vote> Votes { get; set; }

    }
}