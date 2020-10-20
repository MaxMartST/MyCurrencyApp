using Microsoft.AspNetCore.Builder;
using MyCurrencyApp.Data.Models;
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
                content.Currency.AddRange(Currencys);
            }

            content.SaveChanges();
        }

        private static ICollection<Currency> Currencys
        {
            get
            {
                return new List<Currency>
                {
                    new Currency { numCode = 840, fullName = "Доллар США", title = "USD", rates = new List<Rate>()
                    {
                        new Rate {
                            dataRate = new DateTime(2015, 7, 20),
                            value = 56.8423M,
                            nominal = 1
                        },
                        new Rate {
                            dataRate = new DateTime(2020, 10, 19),
                            value = 79.644M,
                            nominal = 1
                        }
                    }},
                    new Currency { numCode = 978, fullName = "Евро", title = "EUR", rates = new List<Rate>()
                    {
                        new Rate {
                            dataRate = new DateTime(2015, 7, 20),
                            value = 61.9183M,
                            nominal = 1
                        },
                        new Rate {
                            dataRate = new DateTime(2020, 10, 19),
                            value = 91.304M,
                            nominal = 1
                        }
                    }}
                };
            }
        }
    }
}
