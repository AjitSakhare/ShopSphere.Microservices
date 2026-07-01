using MediatR;
using ShopSphere.Products.Application.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSphere.Products.Application.Handlers
{
    public class CreateProductsHandler
 : IRequestHandler<CreateProductsCommand, string>
    {
        public Task<string> Handle(CreateProductsCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
