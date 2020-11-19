using Solution.Dapper.Domain.Models;
using System.Collections.Generic;

namespace Solution.Dapper.Repository.Mapper
{
    public static class ClienteMapper
    {
        public static List<Cliente> MapToCoreModel(this IEnumerable<ClienteDTO> dto)
        {
            List<Cliente> LCliente = new List<Cliente>();
            
            foreach (ClienteDTO c in dto)
            {
                Cliente Cli = new Cliente();
                Cli.Id = c.Id;
                Cli.Nome = c.Nome;
                LCliente.Add(Cli);
            }

            return LCliente;
        }
    }
}
