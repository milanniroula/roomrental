using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.roomrental.Entities
{
    public class AdCategory
    {
      
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string NormalisedCategoryName { get; set; }

    
        public virtual ICollection<CategoryAttribute> CategoryAttributes { get; set; }
    }
}
