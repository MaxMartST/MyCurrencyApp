using MyCurrencyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCurrencyApp.Data.Interfaces
{
    public interface IRatesCurrency
    {
        Task<IEnumerable<Currency>> AllCurrencys();

        Task<Currency> getCurrency(string title);
        //IEnumerable<Currency> AllCurrencys { get; }
    }
}