using System;
using System.Collections.Generic;

namespace ООО__Посуда_.Model.Enity
{
    public partial class Unit
    {
        public Unit()
        {
            Products = new HashSet<Product>();
        }

        public int UnitId { get; set; }
        public string UnitName { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
