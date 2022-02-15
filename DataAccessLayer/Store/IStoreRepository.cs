namespace DataAccessLayer.Store;

using Data.Entities;

public interface IStoreRepository
{
    List<Store> ReadAll();
    int Create(Store store);
    void Modify(Store store);
    int Remove(int id);
}