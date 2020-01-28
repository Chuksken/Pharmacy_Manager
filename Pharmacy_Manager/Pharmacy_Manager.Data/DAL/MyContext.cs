using Pharmacy_Manager.Data.Models;
using Pharmacy_Manager.Data.Models.InventoryModel;
using Pharmacy_Manager.Data.Models.PurchaseModel;
using Pharmacy_Manager.Data.Models.SalesModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Manager.Data.DAL
{
    public class MyContext : DbContext
    {

        public MyContext()
            : base("DefaultConnection")
        {

        }
        public DbSet<DrugGenericName> DrugGenericNames { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseItem> PurchaseItems { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<SalesReturn> SalesReturns { get; set; }
        public DbSet<SalesReturnDetail> SalesReturnDetails { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<SalesItem> SalesItems { get; set; }


        //avoids pluralizing table names in database
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Purchase>()
            //          .HasOptional(e => e.Supplier)
            //          .WithMany()

            //          .HasForeignKey(m => m.SupplierID);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //base.OnModelCreating(modelBuilder);


        }
    }
}
