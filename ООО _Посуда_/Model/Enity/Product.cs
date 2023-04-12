using System;
using System.Collections.Generic;

namespace ООО__Посуда_.Model.Enity
{
    public partial class Product
    {
        public Product()
        {
            Orderproducts = new HashSet<Orderproduct>();
        }

        public string ProductArticleNumber { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public int ProductUnitId { get; set; }
        public string ProductDescription { get; set; } = null!;
        public int ProductCategoryId { get; set; }
        public string ProductPhoto { get; set; } = null!;
        public int ProductManufacturerId { get; set; }
        public int ProductSupplierId { get; set; }
        public decimal ProductCost { get; set; }
        public sbyte? ProductDiscountAmount { get; set; }
        public sbyte? ProductDiscountMax { get; set; }
        public int ProductQuantityInStock { get; set; }

        public virtual Category ProductCategory { get; set; } = null!;
        public virtual Manafacturer ProductManufacturer { get; set; } = null!;
        public virtual Supplier ProductSupplier { get; set; } = null!;
        public virtual Unit ProductUnit { get; set; } = null!;
        public virtual ICollection<Orderproduct> Orderproducts { get; set; }
    }
}
