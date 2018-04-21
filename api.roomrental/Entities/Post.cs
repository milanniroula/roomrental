using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.roomrental.Entities
{
    public class Post
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public int AdTypeId { get; set; }
        public int CategoryId { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime ExpireAt { get; set; }
        public DateTime ModifiedAt { get; set; }

        public bool Flag { get; set; }
        public bool FlagA { get; set; }

        public virtual AdCategory Category { get; set; }
        public virtual AppUser Owner { get; set; }
        public virtual AdType AdType { get; set; }
    }
}
