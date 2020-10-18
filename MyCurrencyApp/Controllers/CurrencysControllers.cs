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
        public async Task<ActionResult<Currency>> Convector(string title)
        {
            string _title = title;
            Currency currency = await _allCurrencys.getObjectCurrency(_title);
            
            if (currency == null)
            {
                return NotFound();
            }
                
            return new ObjectResult(currency);
        }

        // CurrencysContext db;
        // public CurrencysControllers(CurrencysContext context)
        // {
        //     db = context;
        //     if (!db.Currencys.Any())
        //     {
        //         db.Currencys.Add(new Currency { fullName = "ДОЛЛАР США", title = "USD", description = 376.4M, quant = 1 });
        //         db.Currencys.Add(new Currency { fullName = "ЕВРО", title = "EUR", description = 427.36M, quant = 1 });
        //         db.SaveChanges();
        //     }
        // }

        // [HttpGet]
        // public async Task<ActionResult<IEnumerable<Currency>>> Get()
        // {
        //     return await db.Currencys.ToListAsync();
        // }

        // // GET api/currencys/5
        // [HttpGet("{id}")]
        // public async Task<ActionResult<Currency>> Get(int id)
        // {
        //     Currency currency = await db.Currencys.FirstOrDefaultAsync(x => x.id == id);
        //     if (currency == null)
        //         return NotFound();
        //     return new ObjectResult(currency);
        // }

        // POST api/currencys
        //[HttpPost]
        // public async Task<ActionResult<Currency>> Post(Currency currency)
        // {
        //     if (currency == null)
        //     {
        //         return BadRequest();
        //     }

        //     db.Currencys.Add(currency);
        //     await db.SaveChangesAsync();
        //     return Ok(currency);
        // }

        // PUT api/currencys/
        // [HttpPut]
        // public async Task<ActionResult<Currency>> Put(Currency currency)
        // {
        //     if (currency == null)
        //     {
        //         return BadRequest();
        //     }
        //     if (!db.Currencys.Any(x => x.id == currency.id))
        //     {
        //         return NotFound();
        //     }

        //     db.Update(currency);
        //     await db.SaveChangesAsync();
        //     return Ok(currency);
        // }

        // DELETE api/currencys/5
        // [HttpDelete("{id}")]
        // public async Task<ActionResult<Currency>> Delete(int id)
        // {
        //     Currency currency = db.Currencys.FirstOrDefault(x => x.id == id);
        //     if (currency == null)
        //     {
        //         return NotFound();
        //     }
        //     db.Currencys.Remove(currency);
        //     await db.SaveChangesAsync();
        //     return Ok(currency);
        // }
    }
}