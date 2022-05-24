


namespace WarehouseManagmentSystemAPI.Infrastructure.IRepositories
{
    public interface IBaseRepository<T> where T:class
    {
        public Task<T> GetByIdAsync(Guid id);
        public T GetById(Guid id);
        public Task<T> GetByIdAsync(Guid? id);
        public T GetById(Guid? id);
        public Task<IEnumerable<T>> GetAllAsync();
        public IEnumerable<T> GetAll();
        //public T GetByName(string name);
        //public T GetByNameAsync(string name);
        public T UpdateById(Guid id);
        public Task<T> DeleteByIdAsync(Guid id);
        public T DeleteById(Guid id);
        public T Add(T entity);
        public Task<T> UpdateByIdAsync(Guid id);
        public Task<T> FindAnyAsync(Expression<Func<T, bool>> match, string[] includesFKdata = null);
        public Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> match, string[] includesFKdata = null);
        public Task<T> AddAsync(T entity);



    }
}
