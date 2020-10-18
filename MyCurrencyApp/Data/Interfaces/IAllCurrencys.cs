using MyCurrencyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCurrencyApp.Data.Interfaces
{
    interface IAllCurrencys
    {
        IEnumerable<Currency> Currencys { get; }

        Currency getObjectCar(string title);
    }
}
