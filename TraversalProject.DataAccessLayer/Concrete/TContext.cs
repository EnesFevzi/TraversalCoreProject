using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.DataAccessLayer.Concrete
{
    public class TContext : IdentityDbContext<AppUser, AppRole, int>
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=TraversalProject;integrated security=true");
            //optionsBuilder.UseSqlServer("server=DESKTOP-QMOGCM6; database=Test; integrated security=true;Encrypt=False;");
            //"Data Source=DESKTOP-SM0VBLO;Initial Catalog =IsSureciDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

        }
    }
}
