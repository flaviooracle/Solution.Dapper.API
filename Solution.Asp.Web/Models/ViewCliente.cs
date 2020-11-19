using Solution.Dapper.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution.Asp.Web.Models
{
    public class ViewCliente
    {
        public IEnumerable<Cliente> Clientes { get; set; }
    }
}
