﻿using System;
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
    [Route("api/Currency")]
    public class CurrencysControllers : Controller
    {
        private IRatesCurrency _allCurrencys;

        public CurrencysControllers(IRatesCurrency iAllCurrencys)
        {
            _allCurrencys = iAllCurrencys;
        }

        [HttpGet("{title}")]
        public async Task<ActionResult<Currency>> convector(string title)
        {

            Currency currency = await _allCurrencys.getCurrency(title);

            if (currency == null)
            {
                return Ok(NotFound());
            }

            return Ok(currency);
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Currency>>> list()
        {
            var a = await _allCurrencys.AllCurrencys();
            return Ok(a);
        }
    }
}