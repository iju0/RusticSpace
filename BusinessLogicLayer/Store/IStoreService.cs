namespace BusinessLogicLayer;

using Data.Entities;

public interface IStoreService
{
    List<Store> ReadAll();
    int Create(Store store);
    void Modify(Store store);
    int Remove(int id);
}