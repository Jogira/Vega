using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;


namespace Vega.Models
{
    public class Make
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public String? Name { get; set; }
        public ICollection<Model>? Models { get; set; }


        public Make()
        {
            Models = new Collection<Model>();
        }
    }
}