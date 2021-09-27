using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using TTS.DAL.Entities;
using TTS.Shared.Infrastructure;

namespace TTS.BLL.Services.Abstract
{
    public interface IUserService : IService
    {
        Task<OperationStatus<List<T>>> GetByJobAsync<T>(Guid id);
        Task<OperationStatus<T>> GetAsync<T>(ClaimsPrincipal principal);
    }
}