using Microsoft.EntityFrameworkCore;
using MyCurrencyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCurrencyApp.Data
{
    public class AppDBContent : DbContext
    {
        //создадим конструктор класса с парамертами options
        //и передаём параметры options в базлвый конструктор
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
        }

        public DbSet<Currency> Currency { get; set; }
    }
}
