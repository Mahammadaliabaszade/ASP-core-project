using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectasp.Models
{
    public class NoticeBoard
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public string Title { get; set; }
        public string Descript { get; set; }

        public string Link { get; set; }

      
    }
}
