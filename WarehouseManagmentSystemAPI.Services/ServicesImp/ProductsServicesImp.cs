



namespace WarehouseManagmentSystemAPI.Services.ServicesImp
{
    public class ProductsServicesImp : BaseServicesImp<ProductDto>,IProductsServices
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        public ProductsServicesImp(IBaseRepository<ProductDto> baseRepository, IMapper mapper, IUnitOfWork unitOfWork) : base(baseRepository,mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
 
        public async Task<ProductDto> GetProductByNameAsync(string productName)
        {
            var product = await _unitOfWork.Products.GetProductByNameAsync(productName);

            if (product == null)
            {
                return new ProductDto { Message = "Product Not Found" };
            }

            var result  =  _mapper.Map<ProductDto>(product);

            return result;

        }

        public async Task<IEnumerable<ProductEntity>> GetAllProductsAsync()
        {
            return await _unitOfWork.Products.GetAllAsync();
        }

        public async Task<ProductEntity> UpdateProductById(ProductDto obj, Guid id)
        {

            var product = await _unitOfWork.Products.GetByIdAsync(id);

            // ? validation

            var mappedProduct = _mapper.Map<ProductEntity>(obj);

            return await _unitOfWork.Products.UpdateAsync(mappedProduct);



        }
    }
}
