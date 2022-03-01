using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PrimeHrmsApi.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeHrmsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public IConfiguration Configuration { get; }

        private readonly HRMS_ONLINEContext _context;
        public ValuesController(HRMS_ONLINEContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IEnumerable<tblAddress>> Get()
        {
            var customerList = await _context.tblAddress.AsNoTracking().ToListAsync();
            if (customerList == null)
            {
                return null;
            }
            return customerList.AsReadOnly();
        }
        [HttpPost]
        public async Task<int> Save(int id1)
        {
            var customer = new tblAddress();
            //int id= await _context.tblAddress.Where(x=>x.intMasterId==1).AsNoTracking().MaxAsync(x => x==null ? 0:x.intSeqId);
            int id = await _context.tblAddress.AsNoTracking().MaxAsync(x => x == null ? 0 : x.intSeqId) + 1;
            customer.varAddress = "Test Address from api";
            customer.varEmail = "Tayyab@h3solution.net";
            customer.intSeqId = id;
            _context.tblAddress.Add(customer);
            await _context.SaveChangesAsync();
            return id1;
        }

    }
}
