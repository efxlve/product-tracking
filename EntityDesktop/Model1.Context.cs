//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityDesktop
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DbProductEntities1 : DbContext
    {
        public DbProductEntities1()
            : base("name=DbProductEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblCategory> TblCategories { get; set; }
        public virtual DbSet<TblCustomer> TblCustomers { get; set; }
        public virtual DbSet<TblProduct> TblProducts { get; set; }
        public virtual DbSet<TblSale> TblSales { get; set; }
        public virtual DbSet<TblAdmin> TblAdmins { get; set; }
    
        public virtual ObjectResult<string> BringBrand()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("BringBrand");
        }
    }
}
