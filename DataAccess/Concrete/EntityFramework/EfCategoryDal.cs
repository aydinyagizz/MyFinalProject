using Core.DataAccess.EntityFramework;
using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //ICategoryDal'daki operasyonlar EfEntityRepositoryBase'da. EfEntityRepositoryBase içinde ICategoryDal'ın istediği imzalar olduğu için, EfEntityRepositoryBase içinde ICategoryDal operasyonlar var zaten.
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
       
    }
}
