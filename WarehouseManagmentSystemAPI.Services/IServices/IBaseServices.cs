
namespace WarehouseManagmentSystemAPI.Services.IServices
{
    public interface IBaseServices<T> where T: class
    {
        public T Create(T TT);
        public Task<T> CreateAsync(T TT);
        public void Delete(Guid id);
        public void DeleteAsync(Guid id);
        public IEnumerable<T> GetAll();
        public T GetById(Guid id);
        public T GetById(Guid? id);
        public Task<IEnumerable<T>> GetAllASync();
        public Task<T> GetByIdAsync(Guid id);
        public Task<T> UpdateByIdAsync(T obj, Guid id);
    }
}
