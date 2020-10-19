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
                        numCode = 840,
                        fullName = "Доллар США",
                        title = "USD",
                        value = 77.9644M,
                        nominal = 1
                    },
                    new Currency
                    {
                        numCode = 978,
                        fullName = "Евро",
                        title = "EUR",
                        value = 91.3041M,
                        nominal = 1
                    }
                );
            }

            //сохранить все изменения в БД
            content.SaveChanges();
        }
    }
}
