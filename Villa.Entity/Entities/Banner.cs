using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Entity.Entities
{
    public class Banner : BaseEntity // Child of 'Base Entity'
    {
        public string City { get; set; }

        public string Title { get; set; }

        public string ImageUrl { get; set; }
    }
}
