﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkDemo
{
    public class ETradeContext : DbContext
    {
        public ETradeContext(DbContextOptions<ETradeContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }

}
