﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WinterApp.DATA
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions option) : base(option)
        {

        }



    }
}
