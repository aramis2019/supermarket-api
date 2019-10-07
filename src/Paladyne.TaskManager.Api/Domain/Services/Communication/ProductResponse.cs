using Paladyne.TaskManager.Api.Domain.Models;

namespace Paladyne.TaskManager.Api.Domain.Services.Communication
{
    public class ProductResponse : BaseResponse<Product>
    {
        public ProductResponse(Product product) : base(product) { }

        public ProductResponse(string message) : base(message) { }
    }
}