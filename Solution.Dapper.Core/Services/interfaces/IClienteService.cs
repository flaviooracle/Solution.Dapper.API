using Solution.Dapper.Domain.Contract.Interface;
using Solution.Dapper.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Solution.Dapper.Core.Services.interfaces
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> GetAll();
    }
}
