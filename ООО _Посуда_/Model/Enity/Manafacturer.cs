using System;
using System.Collections.Generic;

namespace ООО__Посуда_.Model.Enity
{
    public partial class Manafacturer
    {
        public Manafacturer()
        {
            Products = new HashSet<Product>();
        }

        public int ManafacturerId { get; set; }
        public string ManafacturerName { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
