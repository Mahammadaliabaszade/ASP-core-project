using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectasp.Models
{
    public class Event
    {

        public int Id { get; set; }

        public string Image { get; set; }

        public DateTime Day { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime Endtime { get; set; }

        public string Location { get; set; }

        public string EventName { get; set; }

       

        public int CategoryId { get; set; }

        public bool IsDeleted { get; set; }

        public virtual Category Category { get; set; }

        public EventDetail EventDetail { get; set; }

       




    }
}
