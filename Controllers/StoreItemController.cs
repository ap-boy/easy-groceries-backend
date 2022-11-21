using easy_groceries_backend.Data;
using easy_groceries_backend.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace easy_groceries_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreItemController : ControllerBase
    {
        private readonly EasyGroceryContext _dbContext;
        private readonly IStoreItemRepository _storeItemRepository;
        public StoreItemController(EasyGroceryContext dbContext, IStoreItemRepository storeItemRepository)
        {
            _dbContext = dbContext;
            _storeItemRepository = storeItemRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var storeItems = _storeItemRepository.GetStoreItem();

            if (storeItems != null)
            {
                return Ok(storeItems);
            }

            return NotFound();
        }
    }
}
