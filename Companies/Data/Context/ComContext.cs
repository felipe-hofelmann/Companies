using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context  
{
    public class ComContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Jobs> Jobs { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public ComContext(): base ("Data Source=192.168.0.184;Initial Catalog=Companies;Persist Security Info=True;User ID=Companies;Password=@devlabs1")
        {

        }
    }
}
