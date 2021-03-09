using Microsoft.EntityFrameworkCore;
using NopCommerceClone.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NopCommerceClone.Web.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        
        #region fields
        private DbContextOptions<NopCommereceCloneDbContext> _contextOptions = new DbContextOptionsBuilder<NopCommereceCloneDbContext>()
                                            .UseSqlServer(@"server=DESKTOP-IE13SOT;Database=nopcommerce_clone;Trusted_Connection=True;MultipleActiveResultSets=true")
                                            .Options;

        protected NopCommereceCloneDbContext _context;// = new NopCommereceCloneDbContext();


        #endregion
        #region Methods
        public Repository()
        {
            _context = new NopCommereceCloneDbContext(_contextOptions);
        }

        public void Delete(object id)
        {
            _context.Set<TEntity>().Remove(GetId(id));
            _context.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }


        public TEntity GetId(object id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Insert(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        #endregion
    }
}
