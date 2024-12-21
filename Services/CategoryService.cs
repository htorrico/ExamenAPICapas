using Azure;
using Domain;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CategoryService
    {

        public void Insert(Category category)
        {
            using (var context = new AppDbContext())
            {                            
             
                context.Categories.Add(category);                
                context.SaveChanges();                              
            }
        }

        public List<Category> Get()
        {
            using (var context = new AppDbContext())
            {
                var categories = context.Categories.ToList();
                return categories;
            }
        }

    }
}
