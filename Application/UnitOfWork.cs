using Storeak.Demo.Api.Infrastructure;
using Storeak.Demo.Api.Infrastructure.DataModel;
using StoreakApiService.Core.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storeak.Demo.Api.Application
{
    public class UnitOfWork
    {
        private DemoContext _context;
        public UnitOfWork(DemoContext context)
        {
            _context = context;
        }

        public GenericRepository<EmployeeDto> EmployeeRepository
        {
            get
            {
                return new GenericRepository<EmployeeDto>(_context.Employees);
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
