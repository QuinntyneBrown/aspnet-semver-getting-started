using Chloe.Server.Models;

namespace Chloe.Server.Data.Contracts
{
    public interface IChloeUow
    {
        IRepository<Product> Products { get; }
        void SaveChanges();
    }
}
