using System;
using System.Collections.Generic;
using System.Linq;
using core.Entities;
using core.Interfaces;

namespace infrastructure.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        public Task<T> GetByIdAsync(int id)
        {
            return Ok();
        }
        public Task<IReadOnlyList<T>> lISTAllAsync()
        {

        }
    }
}