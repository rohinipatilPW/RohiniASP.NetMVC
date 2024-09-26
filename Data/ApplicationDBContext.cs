using Microsoft.EntityFrameworkCore;
using RohiniASP.NetMVC.Models.Entities;

namespace RohiniASP.NetMVC.Data
{
    public class ApplicationDBContext: DbContext

    {
        //Constructoor
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {  
        }

        public  DbSet<User> Users { get; set; }

    }
}
