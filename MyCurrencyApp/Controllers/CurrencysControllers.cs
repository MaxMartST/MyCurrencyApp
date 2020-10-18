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

        [HttpGet("{title}")]
        public ActionResult<Currency> convector(string title)
        {
            string _title = title;

            Currency currency = _allCurrencys.getObjectCurrency(_title);
            
            if (currency == null)
            {
                return Ok(NotFound());
            }
                
            return Ok(currency);
        }

        //[HttpGet]
        //[Route("Currency/List")]
        //public ActionResult<IEnumerable<Currency>> list()
        //{
        //    return Ok(_allCurrencys.Currencys);
        //}
    }
}