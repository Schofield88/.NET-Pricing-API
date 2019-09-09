using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PricingApi.Models;

namespace PricingApi.Controllers {
    [Route ("api/[controller]")]
    [ApiController]

    public class OrderController : ControllerBase {
        [HttpPost]
        public ActionResult<CustomerOrder> Invoice (CustomerOrder invoice) {
            return invoice;
        }
    }

}