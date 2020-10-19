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
                content.Currency.AddRange(Currencys.Select(c => c.Value));
            }

            if (!content.Rate.Any())
            {
                content.AddRange(
                    new Rate { 
                        dataRate = new DateTime(2015, 7, 20),
                        value = 56.8423M,
                        nominal = 1,
                        currency = Currencys["USD"]
                    },
                    new Rate {
                        dataRate = new DateTime(2020, 10, 19),
                        value = 79644M,
                        nominal = 1,
                        currency = Currencys["USD"]
                    },
                    new Rate {
                        dataRate = new DateTime(2015, 7, 20),
                        value = 61.9183M,
                        nominal = 1,
                        currency = Currencys["EUR"]
                    },
                    new Rate {
                        dataRate = new DateTime(2020, 10, 19),
                        value = 91.304M,
                        nominal = 1,
                        currency = Currencys["EUR"]
                    }
                );
            }
        }

        private static Dictionary<string, Currency> currency;
        public static Dictionary<string, Currency> Currencys
        {
            get
            {
                if (currency == null)
                {
                    var list = new Currency[]
                    {
                        new Currency { numCode = 840, fullName = "Доллар США", title = "USD"},
                        new Currency { numCode = 978, fullName = "Евро", title = "EUR"}
                    };

                    currency = new Dictionary<string, Currency>();
                    foreach (Currency elem in list)
                    {
                        currency.Add(elem.title, elem);
                    }
                }

                return currency;
            }
        }
    }
}
