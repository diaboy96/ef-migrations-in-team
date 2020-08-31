using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ef_migrations_in_team.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int Rating { get; set; }
    }
}
