namespace CodeFirstDemo
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext()
            :base("LibraryDbContext")
        {

        }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Book>()
            //    .HasKey(b => b.ISBN);

        }
    }
}