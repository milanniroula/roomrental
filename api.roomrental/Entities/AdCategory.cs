using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.roomrental.Entities
{
    public class AdCategory
    {
      
        public int CategoryId { get; set; }
        public string AdCategoryName { get; set; }
        public string NormalisedAdCategoryName { get; set; }
    
        public virtual ICollection<CategoryAttribute> CategoryAttributes { get; set; }
    }
}
