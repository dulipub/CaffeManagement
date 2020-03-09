using CaffeManagementCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaffeManagementCore.IServices
{
    //Defines the basic service interface with generic parameter of type BaseEntity
    public interface ICaffeService<TEntity> 
        where TEntity:IAggreagateRoot
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);

        TEntity GetEntity(Guid id);
        IQueryable<TEntity> GetAll();
    }
}
