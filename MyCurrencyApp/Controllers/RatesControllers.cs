using Microsoft.AspNetCore.Mvc;
using MyCurrencyApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCurrencyApp.Controllers
{
    [ApiController]
    [Route("api/Rate")]
    public class RatesControllers : Controller
    {
        private IAllRates _allRates;

        public RatesControllers(IAllRates iAllRates)
        {
            _allRates = iAllRates;
        }
    }
}
