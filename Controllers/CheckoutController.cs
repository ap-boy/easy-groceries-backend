using Microsoft.AspNetCore.Mvc;
using easy_groceries_backend.Data;
using easy_groceries_backend.Data.Entities;
using easy_groceries_backend.Data.Dtos;

namespace easy_groceries_backend.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CheckoutController : ControllerBase
    {
        private readonly EasyGroceryContext _dbContext;
        public CheckoutController(EasyGroceryContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<ActionResult<CheckoutOrderDto[]>> ProcessCheckout(CheckoutOrderDto[] order)
        {
 
            // extract data from items and update db quanitites

            return order;
        }
    }
}
