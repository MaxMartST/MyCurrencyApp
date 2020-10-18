using MyCurrencyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCurrencyApp.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Currency.Any())
            {
                content.AddRange(
                    new Currency
                    {
                        fullName = "ДОЛЛАР США",
                        title = "USD",
                        description = 376.4M,
                        quant = 1
                    },
                    new Currency
                    {
                        fullName = "ЕВРО",
                        title = "EUR",
                        description = 427.36M,
                        quant = 1
                    }
                );
            }

            //сохранить все изменения в БД
            content.SaveChanges();
        }
    }
}
