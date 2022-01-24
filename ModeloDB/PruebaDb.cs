using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDB
{
    public class PruebaDb : DbContext
    {
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Customer> Customers { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder options)
        {
            string connSQL = "server=DESKTOP-OAT5MPN;database=Prueba;user id=Sa; password=1234";
            options.UseSqlServer(connSQL);

        }
        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Payment>()
                .HasOne<Customer>(s => s.customer)
                .WithMany(g => g.Payments)
                .HasForeignKey(s => s.paymentId);
        }
    }
}