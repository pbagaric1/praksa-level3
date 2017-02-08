﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository.Common
{
    public interface IGenericRepository<T> where T: class
    {
        Task <IEnumerable<T>> GetAllAsync<T>() where T: class;
        Task<int> AddAsync<T>(T entity) where T: class;
        Task<int> DeleteAsync<T>(T entity) where T : class;
        Task<int> DeleteAllAsync<T>(IEnumerable<T> entity) where T: class;
        Task<int> UpdateAsync<T>(T entity) where T: class;
        //bool Any();
    }
}
