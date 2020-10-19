using MyCurrencyApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCurrencyApp.Data.Interfaces
{
    public interface IAllRates
    {
        Task<IEnumerable<Rate>> Rates();
        Task<Rate> getObjectRate(DateTime dataRate);
    }
}
