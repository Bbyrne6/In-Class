using eRestaurant.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity; //Needed for Dbcontext
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.DAL
{
    public class RestaurantContext : DbContext
    {
        #region Properties for table-to-entitty mappings
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<SpecialEvent> SpecialEvents { get; set;}
        #endregion
        #region Over-ride Onmodelcreating
        //
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Reservation>().HasMany(r => r.Tables)
                .WithMany(t => t.Reservations)
                .Map(mapping =>
                {
                    mapping.ToTable("ReservationTables");
                    mapping.MapLeftKey("ReservationID");
                    mapping.MapRightKey("TableID");
                });

            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
