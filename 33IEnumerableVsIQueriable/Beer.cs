using System;
using System.Collections.Generic;

namespace _33IEnumerableVsIQueriable
{
    public partial class Beer
    {
        public short BeerId { get; set; }
        public string Names { get; set; } = null!;
        public short BrandId { get; set; }

        public virtual Brand Brand { get; set; } = null!;
    }
}
