using MyCurrencyApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCurrencyApp.Data.Interfaces
{
    interface IAllRates
    {

        Rate getObjectrat(DateTime dataRate);
    }
}
