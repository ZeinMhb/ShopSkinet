using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.DbContext

namespace api.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext (DbContextOptions options) :base(options){

        }
        
        public DbSet<Product> Products{ get; set;}
    }
}