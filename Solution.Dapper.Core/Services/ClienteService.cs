using Solution.Dapper.Core.Services.interfaces;
using Solution.Dapper.Domain.Contract;
using Solution.Dapper.Repository.Models;
using Solution.Dapper.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Dapper.Core.Services
{
    public class ClienteService : IClienteService
    { 

    private readonly IClienteContract _clienteContract;
    public ClienteService(IClienteContract clienteContract)
    {
        _clienteContract = clienteContract;
            
        }

    public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Cliente>> GetAll()
        {
            return await _clienteContract.GetAll();
        }

        public Cliente GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> GetList(Expression<Func<Cliente, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Insert(ref Cliente entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Cliente entity)
        {
            throw new NotImplementedException();
        }
    }
}


//using Solution.Dapper.Core.Services.interfaces;
//using System.Collections.Generic;

//namespace Solution.Dapper.Core.Services
//{
//    public class ClienteService 
//    {
//        private readonly IClienteRepository _clienteRepository;
//        public ClienteService(IRepositoryBase<Cliente> clienteRepository)
//        {
//            _clienteRepository = clienteRepository;
//        }

//        public IEnumerable<Cliente> GetAll()
//        {
//            return _clienteRepository.GetAll();
//        }


//    }
//}