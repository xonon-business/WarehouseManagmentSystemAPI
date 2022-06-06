
namespace WarehouseManagmentSystemAPI.Services.ServicesImp
{
    public class CustomerServicesImp : BaseServicesImp<CustomerDto>, ICustomersServices
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        public CustomerServicesImp(IBaseRepository<CustomerDto> baseRepository, IMapper mapper, IUnitOfWork unitOfWork) : base(baseRepository, mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<CustomerEntity> UpdateCustomerByIdAsync(CustomerDto obj, Guid id)
        {
            var customer = await _unitOfWork.Customers.GetByIdAsync(id);

            var _mapperCustomer = _mapper.Map<CustomerEntity>(obj);

            return await _unitOfWork.Customers.UpdateAsync(_mapperCustomer);

        }
    }
}
