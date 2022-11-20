using easy_groceries_backend.Data.Entities;

namespace easy_groceries_backend.Repository
{
    public interface IStoreItemRepository
    {
        IEnumerable<StoreItem> GetStoreItem();
    }
}
