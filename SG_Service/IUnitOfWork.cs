using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SG_Database.Model;
namespace SG_Service
{
    public interface IUnitOfWork : IDisposable
    {       
        IRepository<Sport> SportServiceRepository { get; }
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
