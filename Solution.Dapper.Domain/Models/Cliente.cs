﻿using Solution.Dapper.Domain.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.Dapper.Repository.Models
{
    public class Cliente : EntityBase
    {
        public string Nome { get; set; }
    }
}
