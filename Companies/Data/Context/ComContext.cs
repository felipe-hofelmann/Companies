﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context  
{
    class ComContext : DbContext
    {
        public ComContext(): base ("Data Source=192.168.0.184;Initial Catalog=Companies;Persist Security Info=True;User ID=Companies;Password=@devlabs1")
        {

        }
    }
}