using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ООО__Посуда_.Model.Enity
{
    public partial class tradeContext : DbContext
    {
        public tradeContext()
        {
        }

        public static tradeContext DbContext { get; private set; } = new tradeContext();

        public  tradeContext(DbContextOptions<tradeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Manafacturer> Manafacturers { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Orderproduct> Orderproducts { get; set; } = null!;
        public virtual DbSet<Pickpoint> Pickpoints { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Statusorder> Statusorders { get; set; } = null!;
        public virtual DbSet<Street> Streets { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<Unit> Units { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("user=root;password=12345;database=trade;server=localhost", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.30-mysql")).UseLazyLoadingProxies();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.CategoryName).HasMaxLength(150);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("city");

                entity.Property(e => e.CityName).HasMaxLength(150);
            });

            modelBuilder.Entity<Manafacturer>(entity =>
            {
                entity.ToTable("manafacturer");

                entity.Property(e => e.ManafacturerName).HasMaxLength(150);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("order");

                entity.HasIndex(e => e.OrderStatusId, "OrderStatusId");

                entity.HasIndex(e => e.OrderUserId, "order_ibfk_2");

                entity.HasIndex(e => e.OrderPickupPointId, "ordres_dsf_idx");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDeliveryDate).HasColumnType("datetime");

                entity.HasOne(d => d.OrderPickupPoint)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderPickupPointId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ordres_dsf");

                entity.HasOne(d => d.OrderStatus)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("order_ibfk_1");

                entity.HasOne(d => d.OrderUser)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderUserId)
                    .HasConstraintName("order_ibfk_2");
            });

            modelBuilder.Entity<Orderproduct>(entity =>
            {
                entity.ToTable("orderproduct");

                entity.HasIndex(e => e.OrderId, "OrderID");

                entity.HasIndex(e => e.ProductArticleNumber, "ProductArticleNumber");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductArticleNumber)
                    .HasMaxLength(100)
                    .UseCollation("utf8mb3_general_ci")
                    .HasCharSet("utf8mb3");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Orderproducts)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orderproduct_ibfk_1");

                entity.HasOne(d => d.ProductArticleNumberNavigation)
                    .WithMany(p => p.Orderproducts)
                    .HasForeignKey(d => d.ProductArticleNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orderproduct_ibfk_2");
            });

            modelBuilder.Entity<Pickpoint>(entity =>
            {
                entity.ToTable("pickpoint");

                entity.HasIndex(e => e.PickPointCityId, "PickPointCityId");

                entity.HasIndex(e => e.PickPointStreetId, "PickPointStreetId");

                entity.HasOne(d => d.PickPointCity)
                    .WithMany(p => p.Pickpoints)
                    .HasForeignKey(d => d.PickPointCityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pickpoint_ibfk_1");

                entity.HasOne(d => d.PickPointStreet)
                    .WithMany(p => p.Pickpoints)
                    .HasForeignKey(d => d.PickPointStreetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pickpoint_ibfk_2");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductArticleNumber)
                    .HasName("PRIMARY");

                entity.ToTable("product");

                entity.HasIndex(e => e.ProductCategoryId, "ProductCategoryId");

                entity.HasIndex(e => e.ProductManufacturerId, "ProductManufacturerId");

                entity.HasIndex(e => e.ProductSupplierId, "ProductSupplierId");

                entity.HasIndex(e => e.ProductUnitId, "ProductUnitId");

                entity.Property(e => e.ProductArticleNumber)
                    .HasMaxLength(100)
                    .UseCollation("utf8mb3_general_ci")
                    .HasCharSet("utf8mb3");

                entity.Property(e => e.ProductCost).HasPrecision(19, 4);

                entity.Property(e => e.ProductDescription).HasColumnType("text");

                entity.Property(e => e.ProductName).HasColumnType("text");

                entity.Property(e => e.ProductPhoto).HasMaxLength(250);

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("product_ibfk_2");

                entity.HasOne(d => d.ProductManufacturer)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductManufacturerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("product_ibfk_3");

                entity.HasOne(d => d.ProductSupplier)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductSupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("product_ibfk_4");

                entity.HasOne(d => d.ProductUnit)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("product_ibfk_1");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(100);
            });

            modelBuilder.Entity<Statusorder>(entity =>
            {
                entity.ToTable("statusorder");

                entity.Property(e => e.StatusOrderName).HasMaxLength(150);
            });

            modelBuilder.Entity<Street>(entity =>
            {
                entity.ToTable("street");

                entity.Property(e => e.StreetName).HasMaxLength(150);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("supplier");

                entity.Property(e => e.SupplierName).HasMaxLength(150);
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.ToTable("unit");

                entity.Property(e => e.UnitName).HasMaxLength(150);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.HasIndex(e => e.UserRoleId, "UserRoleId");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserLogin).HasColumnType("text");

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.Property(e => e.UserPassword).HasColumnType("text");

                entity.Property(e => e.UserPatronymic).HasMaxLength(100);

                entity.Property(e => e.UserSurname).HasMaxLength(100);

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
