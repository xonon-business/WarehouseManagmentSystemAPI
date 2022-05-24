


namespace WarehouseManagmentSystemAPI.Services.ServicesImp
{
    public class BaseServicesImp<T> : IBaseServices<T>  where T:class
    {
        private IBaseRepository<T> _baseRepository;

        public BaseServicesImp(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }


        public T Create(T TT)
        {
           return _baseRepository.Add(TT);
        }

        public void Delete(Guid id)
        {
            _baseRepository.DeleteById(id);
        }

        public IEnumerable<T> Read()
        {
            return _baseRepository.GetAll();
        }

        public T Update(Guid id)
        {
            return _baseRepository.UpdateById(id);
        }
    }
    
    
}
