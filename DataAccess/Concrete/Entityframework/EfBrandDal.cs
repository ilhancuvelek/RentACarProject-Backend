﻿using Core.DataAccess.Entityframework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.Entityframework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, RentACarContext>, IBrandDal
    {
        
    }
}
