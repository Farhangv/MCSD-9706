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
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)//FluentAPI
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Book>()
            //    .HasKey(b => b.ISBN);
            
            modelBuilder.Entity<Contact>()
                .HasRequired(c => c.Publisher)
                .WithOptional(p => p.Contact);

            modelBuilder.Entity<Book>()
                .HasMany(b => b.Authors)
                .WithMany(a => a.Books)
                .Map(m => m.ToTable("Author_Book", "Books"));
        }
    }
}