using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
    public interface ICategoryService
    {
        List<Category> GetAll(); //hepsini listeler.
        Category GetById(int categoryId); //ilgili category'i listeler.

    }
}
