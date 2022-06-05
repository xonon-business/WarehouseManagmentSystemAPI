


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



    }
}
