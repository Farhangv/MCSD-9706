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
    }
}