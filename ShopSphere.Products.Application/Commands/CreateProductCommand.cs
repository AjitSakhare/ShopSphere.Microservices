using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSphere.Products.Application.Commands
{
    public record CreateProductsCommand
 (
     string Name,
     decimal Price
 ) : IRequest<string>;
}
