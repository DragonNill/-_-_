using System;
using System.Collections.Generic;

namespace ООО__Посуда_.Model.Enity
{
    public partial class Statusorder
    {
        public Statusorder()
        {
            Orders = new HashSet<Order>();
        }

        public int StatusOrderId { get; set; }
        public string StatusOrderName { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
    }
}
