using Microsoft.EntityFrameworkCore;
using ToDoListProject.DAL.Entities;

namespace ToDoListProject.DAL.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=FRKN\\SQLEXPRESS;initial catalog=ToDoList;integrated Security=True");
        }

        public DbSet<Event> Events { get; set; }
       
    }
}
