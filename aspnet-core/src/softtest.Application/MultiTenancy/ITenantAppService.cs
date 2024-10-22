using Abp.Application.Services;
using softtest.MultiTenancy.Dto;

namespace softtest.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

