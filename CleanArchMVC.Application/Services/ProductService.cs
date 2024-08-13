using AutoMapper;
using CleanArchMVC.Application.DTOs;
using CleanArchMVC.Application.Interfaces;
using CleanArchMVC.Domain.Interfaces;

namespace CleanArchMVC.Application.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IMapper mapper, IProductRepository productRepository)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));

            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            var productsEntity = await _productRepository.GetByIdAsync(id);
            throw new NotImplementedException();
        }

        public Task<ProductDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDTO> GetProductCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task Add(ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }

        public Task Update(ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }

        public Task Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
