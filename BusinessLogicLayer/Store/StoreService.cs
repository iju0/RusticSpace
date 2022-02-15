using DataAccessLayer.Store;

namespace BusinessLogicLayer.Store;
using Data.Entities;

public class StoreService : IStoreService
{
    private readonly IStoreRepository _storeRepository;
    
    public StoreService(IStoreRepository storeRepository)
    {
        _storeRepository = storeRepository;
    }

    public List<Store> ReadAll()
    {
        return _storeRepository.ReadAll();
    }

    public int Create(Store store)
    {
        throw new NotImplementedException();
    }

    public void Modify(Store store)
    {
        throw new NotImplementedException();
    }

    public int Remove(int id)
    {
        throw new NotImplementedException();
    }
}