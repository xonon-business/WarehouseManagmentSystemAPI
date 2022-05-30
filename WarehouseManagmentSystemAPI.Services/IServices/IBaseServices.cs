
namespace WarehouseManagmentSystemAPI.Services.IServices
{
    public interface IBaseServices<T> where T: class
    {
        public T Create(T TT);
        public void Delete(Guid id);
        public IEnumerable<T> Read();
        public T GetById(Guid id);
        public T GetById(Guid? id);
        public Task<T> GetByIdAsync(Guid id);
    }
}
