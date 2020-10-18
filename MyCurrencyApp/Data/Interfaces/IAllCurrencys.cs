using MyCurrencyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCurrencyApp.Data.Interfaces
{
    public interface IAllCurrencys
    {
        Task<IEnumerable<Currency>> Currencys();

        Task<Currency> getObjectCurrency(string title);
    }
}
