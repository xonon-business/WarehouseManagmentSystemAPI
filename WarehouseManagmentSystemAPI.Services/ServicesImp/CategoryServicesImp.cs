

namespace WarehouseManagmentSystemAPI.Services.ServicesImp
{
    public class CategoryServicesImp : ICategoriesServices
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryServicesImp(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public CategoryDto GetCategoryByName(string CategoryName)
        {
            var category = _unitOfWork.Categories.GetCategoryByName(CategoryName);

            if (category == null)
            {

                return new CategoryDto { Message = "Product Not Found" };

            }
                var result = _mapper.Map<CategoryDto>(category);

                return result;
            }

        }


    
}
