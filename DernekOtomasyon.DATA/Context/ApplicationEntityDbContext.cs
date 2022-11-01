using DernekOtomasyon.DATA.Entity;
using DernekOtomasyon.DATA.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekOtomasyon.DATA.Context
{
    public class ApplicationEntityDbContext : DbContext
    {
        public ApplicationEntityDbContext()
            : base("DbConnection")
        {

            //Database.SetInitializer<ApplicationEntityDbContext>(new DropCreateDatabaseIfModelChanges<ApplicationEntityDbContext>());

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationEntityDbContext, Configuration>("DbConnection"));

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
            // or whatever your schema specifies

            //    modelBuilder.Entity<Member>()
            //.HasRequired<Member>(x => x.)
            //.WithMany(x => x.HobyID)
            //.HasForeignKey(x => x.CategoryId);

            //  modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //   modelBuilder.Entity<MemberFavoriteAdvert>().HasMany(i => i.AdvertID && i.MemberID).WithRequired().WillCascadeOnDelete(false);
            
        }
        public DbSet<Member> Member { get; set; }
    }
}

