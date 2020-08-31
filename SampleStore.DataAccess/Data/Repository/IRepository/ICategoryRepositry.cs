using Microsoft.AspNetCore.Mvc.Rendering;
using SampleStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleStore.DataAccess.Data.Repository.IRepository
{
    public interface ICategoryRepositry : IRepository<Category>
    {
        IEnumerable<SelectListItem> GetCategoryListForDropDown();

        void Update(Category category);
    }
}
