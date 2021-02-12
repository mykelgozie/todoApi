using Microsoft.EntityFrameworkCore;
using Modelslibrary;
using serviceslibrary.data;
using serviceslibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serviceslibrary.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private AppDbContext _dataContext;


        public TaskRepository(AppDbContext dataContext)
        {
             _dataContext = dataContext;

        }

        public async Task<IEnumerable<Tasks>> FindAllAsync()
        {
            return await _dataContext.Tasks.Include(x=>x.Cartegory).Include(x=>x.Status).ToListAsync();
        }

         public async Task<Tasks> FindTaskAsync(int id)
        {
            var tasks =  await FindAllAsync();
           return   tasks.Where(x => x.Id == id).FirstOrDefault();    
        }

        public void AddTask(Tasks task)
        {
            _dataContext.Tasks.Add(task);
            _dataContext.SaveChanges();
        }



    }
    
}
