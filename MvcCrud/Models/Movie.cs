using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCrud.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Title can't exceed {1} characters")]
        public string Title { get; set; }
    }
}
