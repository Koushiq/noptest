using System;
using System.Collections.Generic;
using System.Text;

namespace NopCommerceClone.Data
{
    public interface IRepository<TEntity> where TEntity:class
    {
        #region Methods
        List<TEntity> GetAll();
        TEntity GetId(object id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(object id);
        #endregion
    }
}
