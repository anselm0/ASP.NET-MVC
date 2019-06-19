using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EComm.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EComm.Web.ViewComponents
{
    public class ProductList : ViewComponent
    {

        private readonly ECommDataContext _dataContext;

        public ProductList(ECommDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            var products = _dataContext.Products.Include(p => p.Supplier).ToList();
            return Task.FromResult<IViewComponentResult>(View(products));
        }
    }
}
