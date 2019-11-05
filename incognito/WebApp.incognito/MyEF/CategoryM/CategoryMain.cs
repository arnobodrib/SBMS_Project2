using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Model.Model;
using WebApp.BLL.BLL;

namespace MyEF.CategoryM
{
    class CategoryMain
    {
        static void Main(string[] args)
        {
            CategoryManager _categoryManager = new CategoryManager();

            Category category = new Category()
            {
                Id = 1,
                Code = "0001",
                Name = "Mobile",


            };

            //Add
            if (_categoryManager.Add(category))
            {
                Console.WriteLine("Product is Saved");
            }
            else
            {
                Console.WriteLine("Product Not Saved");
            }


            ////Update

            //category.Id = 4;
            //category.Code = "0002";
            //category.Name = "Laptop";

            //if (_categoryManager.Update(category))
            //{
            //    Console.WriteLine("Updated");
            //}
            //else
            //{
            //    Console.WriteLine("Not Updated");
            //}


        }

    }
}
