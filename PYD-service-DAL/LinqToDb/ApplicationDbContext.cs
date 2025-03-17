using LinqToDB;
using LinqToDB.Data;
using PYD_service_DAL.Models;

namespace PYD_service_DAL.LinqToDb
{
    public class ApplicationDbContext : DataConnection
    {
        public ApplicationDbContext() : base(new DataOptions()
            .UsePostgreSQL("User ID=postgres;Password=123456;Host=localhost;Port=15432;Database=pyd-server;Pooling=true;"))
        {
        }

        public ITable<PYD> PYDQuery => this.GetTable<PYD>();
    }
}