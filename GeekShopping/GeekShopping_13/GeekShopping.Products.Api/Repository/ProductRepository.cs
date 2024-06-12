using AutoMapper;
using GeekShopping.Products.Api.Data.ValueObjects;
using GeekShopping.Products.Api.Model;
using GeekShopping.Products.Api.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.Products.Api.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MySqlContext _context;
        private IMapper _mapper;

        public ProductRepository(MySqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ProductVo> Create(ProductVo vo)
        {
            Product product = _mapper.Map<Product>(vo);
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductVo>(product);
        }

        public async Task<bool> DeleteById(long id)
        {
            try
            {
                var products = await _context.Products.FirstOrDefaultAsync(product => product.Id == id);
                if (products == null) return false;
                _context.Products.Remove(products);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<IEnumerable<ProductVo>> FindAll()
        {
            var products = await _context.Products.ToListAsync();
            return _mapper.Map<List<ProductVo>>(products);
        }

        public async Task<ProductVo> FindById(long id)
        {
            var products = await _context.Products.FirstOrDefaultAsync(product => product.Id == id);
            return _mapper.Map<ProductVo>(products);
        }

        public async Task<ProductVo> Update(ProductVo vo)
        {
            Product product = _mapper.Map<Product>(vo);
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductVo>(product);
        }
    }
}
