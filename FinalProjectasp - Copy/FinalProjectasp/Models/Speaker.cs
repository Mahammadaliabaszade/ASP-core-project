using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectasp.Models
{
    public class Speaker
    {

        public int Id { get; set; }

        public string Name { get; set; }
        public string Image { get; set; }

        public string Occupation { get; set; }

        public int EventDetailId { get; set; }

        public  virtual EventDetail EventDetail { get; set; }
    }
}
