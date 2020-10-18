using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCurrencyApp.Models
{
    public class CurrencysContext : DbContext
    {
        public DbSet<Currency> Currencys { get; set; }
        public CurrencysContext(DbContextOptions<CurrencysContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}