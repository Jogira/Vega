using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace Vega.Models
{
    public class Make
    {
        public int Id { get; set; }
        public String? Name { get; set; }
        public ICollection<Model>? Models { get; set; }


        public Make()
        {
            Models = new Collection<Model>();
        }
    }
}