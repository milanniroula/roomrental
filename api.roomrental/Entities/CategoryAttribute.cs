using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.roomrental.Entities
{
    public class CategoryAttribute
    {

        public int Id { get; set; }
        public int CategoryAttributeId { get; set; }
        public int CategoryId { get; set; }
        public string AttributeLabel { get; set; }
        public int AttrubuteTypeId { get; set; }
        //public int AttrubuteTypeId { get; set; }





        //public int? OptionsId { get; set; }


        public virtual AttributeType AttributeType { get; set; }
        public virtual ICollection<AttributeValueOption> Options { get; set; }
        //public virtual AdCategory Category{get; set;}
    }
}
