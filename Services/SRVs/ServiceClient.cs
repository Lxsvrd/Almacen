using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Services.DTOs.Client;
using Services.REPs;

namespace Services.SRVs
{
    public class ServiceClient : RepositoryService<Client, ClientDto, CreateUpdateClientDto>
    {
    }
}
