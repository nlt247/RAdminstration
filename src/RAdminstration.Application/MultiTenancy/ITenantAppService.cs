﻿using Abp.Application.Services;
using RAdminstration.MultiTenancy.Dto;

namespace RAdminstration.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

