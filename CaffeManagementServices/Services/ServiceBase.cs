using CaffeManagementCore;
using CaffeManagementCore.IServices;
using CaffeManagementCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaffeManagementServices.Services
{
    public class ServiceBase<TEntity> : ICaffeService<TEntity>
        where TEntity : BaseEntity,IAggreagateRoot
    {
        protected CaffeContext _context;

        public ServiceBase(CaffeContext context)
        {
            _context = context;
        }

        public virtual void Add(TEntity entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        //configure for soft delete in next release
        public virtual void Delete(TEntity entity)
        {
            _context.Remove<TEntity>(entity);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().AsQueryable();
        }

        public virtual TEntity GetEntity(Guid id)
        {
            return _context.Find<TEntity>(id);
        }

        public virtual void Update(TEntity entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
