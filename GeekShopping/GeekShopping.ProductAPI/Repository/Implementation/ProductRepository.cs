using AutoMapper;
using GeekShopping.ProductAPI.Data.Context;
using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Models;
using GeekShopping.ProductAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Repository.Implementation
{
    public class ProductRepository : IProductRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public ProductRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductVO>> FindAll()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return _mapper.Map<List<ProductVO>>(products);
        }

        public async Task<ProductVO> FindById(long id)
        {
            Product product = await _context.Products.Where(x => x.Id == id).FirstAsync();
            return _mapper.Map<ProductVO>(product);
        }

        public async Task<ProductVO> Create(ProductVO productVO)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductVO> Update(ProductVO productVO)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(long id)
        {
            throw new NotImplementedException();
        }
    }
}
