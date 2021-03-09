using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectasp.Models
{
    public class EventDetail
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int EventId { get; set; }

        public Event Event { get; set; }


        public virtual Speaker Speaker { get; set; }

        

    }
}
