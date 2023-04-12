using System;
using System.Collections.Generic;

namespace ООО__Посуда_.Model.Enity
{
    public partial class Order
    {
        public Order()
        {
            Orderproducts = new HashSet<Orderproduct>();
        }

        public int OrderId { get; set; }
        public int OrderStatusId { get; set; }
        public DateTime OrderDeliveryDate { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderPickupPointId { get; set; }
        public int? OrderUserId { get; set; }
        public int OrderPickPointCode { get; set; }

        public virtual Pickpoint OrderPickupPoint { get; set; } = null!;
        public virtual Statusorder OrderStatus { get; set; } = null!;
        public virtual User? OrderUser { get; set; }
        public virtual ICollection<Orderproduct> Orderproducts { get; set; }
    }
}
