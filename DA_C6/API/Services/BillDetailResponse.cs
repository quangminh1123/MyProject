﻿using Microsoft.AspNetCore.Mvc;
using API.Data;
using API.Model;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class BillDetailResponse : IBillDetail
    {
        private readonly ApplicationDbContext _context;
        public BillDetailResponse(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public List<BillDetails> GetBillDetails(int id)
        {
            return _context.BillDetails
                           .Include(bd => bd.ProductDetails)
                               .ThenInclude(pd => pd.Product)
                           .Include(bd => bd.ProductDetails)
                               .ThenInclude(pd => pd.Colors)
                           .Include(bd => bd.ProductDetails)
                               .ThenInclude(pd => pd.Sizes)
                           .Where(x => x.IDBill == id)
                           .ToList();
        }

        public IEnumerable<BillDetails> GetBillDetailsForAdmin(int id)
        {
            return _context.BillDetails.Where(x => x.IDBill == id);
        }
    }
}
