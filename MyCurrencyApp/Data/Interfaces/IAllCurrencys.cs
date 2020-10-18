using MyCurrencyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCurrencyApp.Data.Interfaces
{
    public interface IAllCurrencys
    {
        IEnumerable<Currency> Currencys { get; }

        Currency getObjectCurrency(string title);
    }
}
