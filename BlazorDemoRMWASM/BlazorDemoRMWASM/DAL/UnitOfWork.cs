using Microsoft.EntityFrameworkCore;
using BlazorDemoRMWASM.Models;

namespace BlazorDemoRMWASM.DAL
{
    public class UnitOfWork : IDisposable
    {
        private readonly DataEntities _context;
        private GenericRepository<Menu> _menuRepository;
        private GenericRepository<ConfigSite> _configSiteRepository;

        public GenericRepository<Menu> MenuRepository =>
            _menuRepository ?? (_menuRepository = new GenericRepository<Menu>(_context));
        public GenericRepository<ConfigSite> ConfigSiteRepository =>
            _configSiteRepository ?? (_configSiteRepository = new GenericRepository<ConfigSite>(_context));

        public void Save()
        {
            _context.SaveChanges();
        }
        private bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
