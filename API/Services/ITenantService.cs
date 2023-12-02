using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Settings;

namespace API.Services
{
    public interface ITenantService
    {
        string? GetDatabaseProvider();
        string? GetConnectionString();
        Tenant? GetCurrentTenant();
    }
}