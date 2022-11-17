using easy_groceries_backend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace easy_groceries_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreItemController : ControllerBase
    {
        private readonly EasyGroceryContext _dbContext;
        public StoreItemController(EasyGroceryContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var storeItems = await _dbContext.StoreItem.ToListAsync();
            return Ok(storeItems);
        }
    }
}
