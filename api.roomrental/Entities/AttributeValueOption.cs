using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.roomrental.Entities
{
    public class AttributeValueOption
    {
        public int Id { get; set; }
        public int AttributeValueOptionId { get; set; }
        public int CategoryAttributeId { get; set; }
        public int Value { get; set; }
        public string Label { get; set; }
    }
}
