using Solution.Dapper.Domain.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.Dapper.Domain.Models
{
    public class Cliente : EntityBase
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
