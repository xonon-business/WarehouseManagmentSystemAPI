
namespace WarehouseManagmentSystemAPI.Services.ServicesImp
{
    public class BaseServicesImp<T> : IBaseServices<T>  where T:class
    {
        private IBaseRepository<T> _baseRepository;
        private IMapper _mapper;

        public BaseServicesImp(IBaseRepository<T> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper =  mapper;
        }


        public T Create(T TT)
        {
           var _mapperEntity = _mapper.Map<T>(TT); 

           return _baseRepository.Add(TT);
        }

        public async Task<T> CreateAsync(T TT)
        {
            var _mapperEntity = _mapper.Map<T>(TT); 

           return await _baseRepository.AddAsync(TT);
        }

        public void Delete(Guid id)
        {
            _baseRepository.DeleteById(id);
        }

        public T GetById(Guid id)
        {
            return _baseRepository.GetById(id);
        }

        public T GetById(Guid? id)
        {
            return _baseRepository.GetById(id);
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _baseRepository.GetByIdAsync(id);
        }

        public IEnumerable<T> Read()
        {
            return _baseRepository.GetAll();
        }
    }
    
    
}
