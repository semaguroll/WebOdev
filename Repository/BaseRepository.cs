﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Odev.Data;

namespace Web.Odev.Repository
{
    public abstract class BaseRepository
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}

//using Supermarket.API.Persistence.Contexts;

//namespace Supermarket.API.Persistence.Repositories
//{
//    public abstract class BaseRepository
//    {
//        protected readonly AppDbContext _context;

//        public BaseRepository(AppDbContext context)
//        {
//            _context = context;
//        }
//    }
//}