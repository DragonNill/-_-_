using System;
using System.Collections.Generic;

namespace ООО__Посуда_.Model.Enity
{
    public partial class Pickpoint
    {
        public Pickpoint()
        {
            Orders = new HashSet<Order>();
        }

        public int PickPointId { get; set; }
        public int PickPointIndex { get; set; }
        public int PickPointCityId { get; set; }
        public int PickPointStreetId { get; set; }
        public int PickPointHome { get; set; }

        public virtual City PickPointCity { get; set; } = null!;
        public virtual Street PickPointStreet { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
    }
}
