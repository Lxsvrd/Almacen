using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Services.DTOs.Product;
using Services.REPs;

namespace Services.SRVs
{
    public class ServiceProduct : RepositoryService<Product, ProductDto, CreateUpdateProductDto>
    {
    }
}
