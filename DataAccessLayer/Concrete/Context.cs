using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-KU766VT\SQLEXPRESS;Initial Catalog=DbEnstrumanDunyam;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Blog> Blogs { get; set; }                                             
        public DbSet<Enstruman> Enstrumans { get; set; }
        public DbSet<EnstrumanCesit> EnstrumanCesits { get; set; }
        public DbSet<Marka> Markas { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Slider> Sliders { get; set; }

    }
}
