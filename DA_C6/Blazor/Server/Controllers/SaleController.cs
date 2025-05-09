﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Blazor.Shared.Model;
using Blazor.Server.Services;
using Blazor.Server.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly ISale _saleService;
        private readonly ApplicationDbContext _context;

        public SaleController(ISale saleService, ApplicationDbContext context)
        {
            _saleService = saleService;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Sale> GetSales()
        {
            return _saleService.GetSale();
        }

        [HttpPost]
        public ActionResult<Sale> AddSale(Sale sale)
        {
            var addedSale = _saleService.AddSale(sale);
            return CreatedAtAction(nameof(GetSaleName), new { name = addedSale.Name }, addedSale);
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<Sale>> GetSaleName(string name)
        {
            var sale1 = await _context.Sales.FirstOrDefaultAsync(x => x.Name == name);

            if (sale1 == null)
            {
                return NotFound();
            }

            return sale1;
        }
    }
}
