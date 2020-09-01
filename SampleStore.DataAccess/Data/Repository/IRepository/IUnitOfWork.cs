using System;
using System.Collections.Generic;
using System.Text;

namespace SampleStore.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        //access to all repositories
        ICategoryRepositry Category { get; }
        void Save();
    }
}
