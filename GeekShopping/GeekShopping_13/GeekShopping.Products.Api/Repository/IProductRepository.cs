using GeekShopping.Products.Api.Data.ValueObjects;

namespace GeekShopping.Products.Api.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductVo>> FindAll();
        Task<ProductVo> FindById(long id);
        Task<ProductVo> Create(ProductVo vo);
        Task<ProductVo> Update(ProductVo vo);
        Task<bool> DeleteById(long id);
    }
}
