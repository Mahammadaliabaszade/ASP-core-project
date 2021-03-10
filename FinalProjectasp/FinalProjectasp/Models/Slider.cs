using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectasp.Models
{
    public class Slider
    {

        public int Id { get; set; }
        [Required]
        public string Image { get; set; }

        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }

        [NotMapped]
        [Required]
        public IFormFile[] Photos { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }


    }
}
