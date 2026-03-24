using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace QLKTX.Data
{
    public class QLKTXDbContextFactory : IDesignTimeDbContextFactory<QLKTXDbContext>
   
    {
        public QLKTXDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<QLKTXDbContext>();

            optionsBuilder.UseSqlServer(
                "Data Source=DESKTOP-8FQTHJ9\\SQLEXPRESS;Initial Catalog=QLKTX;Integrated Security=True;TrustServerCertificate=True");

            return new QLKTXDbContext(optionsBuilder.Options);
        }
    }
}
