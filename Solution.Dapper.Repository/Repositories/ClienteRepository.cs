using Dapper;
using Solution.Dapper.Domain.Contract;
using Solution.Dapper.Domain.Contract.Interface;
using Solution.Dapper.Domain.Models;
using Solution.Dapper.Repository.Mapper;
using Solution.Dapper.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Solution.Dapper.Repository.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository  //
    {
        //protected readonly string ConnectionString;
        //protected readonly int CommandTimeout;

        //protected ClienteRepository()
        //{
        //    CommandTimeout = 0;
        //    ConnectionString = "Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=ConspiracaoDB;Data Source=DESKTOP-EUD6FT9\\SQLEXPRESS";
        //}
      

        public override async Task<IEnumerable<Cliente>> GetAll()
        {
            try
            {
                string GetSuggestions = "select * from cliente";
                IEnumerable<ClienteDTO> result;
                DynamicParameters parameters = new DynamicParameters();
                //parameters.Add(":sitReq", request.RequestSituation);
                //parameters.Add(":taxId", request.TaxId);
                //parameters.Add(":offset", request.Offset);
                //parameters.Add(":max", request.Offset + request.Limit);

                var connection = new SqlConnection(ConnectionString);

                result = await connection
                               .QueryAsync<ClienteDTO>(GetSuggestions, 
                                                    param: parameters,
                                                    commandTimeout: CommandTimeout)
                               .ConfigureAwait(false);
                return result.MapToCoreModel();
            }
            catch (Exception ex)
            {
               // this.Logger?.DatabaseError(ex);
                throw;
            }
        }

    }
}
