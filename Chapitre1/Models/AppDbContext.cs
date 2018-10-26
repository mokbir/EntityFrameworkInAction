using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapitre1.Models
{
    public class AppDbContext: DbContext
    {
        
        public DbSet<Book> Books { get; set; }

    }
}
