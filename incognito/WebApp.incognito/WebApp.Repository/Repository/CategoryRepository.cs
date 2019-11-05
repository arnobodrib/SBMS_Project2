using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Model.Model;
using WebApp.DatabaseContext.DatabaseContext;


namespace WebApp.Repository.Repository
{
    public class CategoryRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();

        public bool Add(Category category)
        {
            _dbContext.Categories.Add(category);

            return _dbContext.SaveChanges() > 0;
        }





    }
}
