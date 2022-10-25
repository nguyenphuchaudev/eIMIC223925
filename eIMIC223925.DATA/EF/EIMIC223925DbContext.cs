using eIMIC223925.DATA.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eIMIC223925.DATA.EF
{
    public class EIMIC223925DbContext : DbContext
    {
        public EIMIC223925DbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        } 

    }
}
