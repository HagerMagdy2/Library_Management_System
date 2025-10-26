using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Library_Management_System.Models
{
    public class StoreContext:IdentityDbContext
    {
        public StoreContext()
        {
            
        }
        public StoreContext(DbContextOptions<StoreContext> op):base(op) 
        {
            
        }
    }
}
