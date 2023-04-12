using System;
using System.Collections.Generic;

namespace ООО__Посуда_.Model.Enity
{
    public partial class Orderproduct
    {
        public int OrderProductId { get; set; }
        public int OrderId { get; set; }
        public string ProductArticleNumber { get; set; } = null!;
        public int ProductsCount { get; set; }

        public virtual Order Order { get; set; } = null!;
        public virtual Product ProductArticleNumberNavigation { get; set; } = null!;
    }
}
