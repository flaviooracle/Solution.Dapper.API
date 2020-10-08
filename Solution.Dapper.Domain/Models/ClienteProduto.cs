using Solution.Dapper.Domain.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.Dapper.Repository.Models
{
    public class ClienteProduto
    {
        public int IdCliente { get; set; }
        public int IdProduto { get; set; }

        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
    }
}
