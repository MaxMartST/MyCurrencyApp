using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCurrencyApp.Data.Interfaces;
using MyCurrencyApp.Models;

namespace MyCurrencyApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CurrencysControllers : Controller
    {
        private IAllCurrencys _allCurrencys;

        public CurrencysControllers(IAllCurrencys iAllCurrencys)
        {
            _allCurrencys = iAllCurrencys;
        }

        [HttpGet]
        [Route("Currency/{title}")]
        public async Task<ActionResult<Currency>> Convector(string title)
        {
            string _title = title;

            Currency currency = _allCurrencys.getObjectCurrency(_title);
            
            if (currency == null)
            {
                return NotFound();
            }
                
            return currency;
        }

        [HttpGet]
        [Route("Currency/List")]
        public async Task<ActionResult<IEnumerable<Currency>>> List()
        {
            return await _allCurrencys.Currencys.ToListAsync();
        }
    }
}