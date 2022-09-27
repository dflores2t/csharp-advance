using System;
using System.Collections.Generic;

namespace _33IEnumerableVsIQueriable
{
    public partial class Brand
    {
        public Brand()
        {
            Beers = new HashSet<Beer>();
        }

        public short BrandId { get; set; }
        public string? Name { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual ICollection<Beer> Beers { get; set; }
    }
}
