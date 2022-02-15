namespace DataAccessLayer.Store;
using Data.Entities;
public class StoreRepository : IStoreRepository
{
    public List<Store> ReadAll()
    {
        var list = new List<Store>();
        list.Add(new Store() { Id = 1, Name = "스타벅스 우이점", ContactNumber = "010-8546-7027" });
        list.Add(new Store() { Id = 2, Name = "스타벅스 논현점", ContactNumber = "010-8546-7027" });
        list.Add(new Store() { Id = 3, Name = "스타벅스 신사점", ContactNumber = "010-8546-7027" });
        return list;
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