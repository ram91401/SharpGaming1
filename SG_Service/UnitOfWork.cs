using SharpGaming;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SG_Database.Model;

namespace SG_Service
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        private IRepository<Sport> _sportServiceRepository;
        private IRepository<Country> _countryRepository;
        public IRepository<Sport> SportServiceRepository => _sportServiceRepository ?? (_sportServiceRepository = new GenericRepository<Sport>(_context));
        public IRepository<Country> CountryServiceRepository => _countryRepository ?? (_countryRepository = new GenericRepository<Country>(_context));

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context?.Dispose();
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }
    }
}
