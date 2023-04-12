using System;
using System.Collections.Generic;

namespace ООО__Посуда_.Model.Enity
{
    public partial class Supplier
    {
        public Supplier()
        {
            Products = new HashSet<Product>();
        }

        public int SupplierId { get; set; }
        public string SupplierName { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
