using System;
using System.Linq;
using System.Linq.Expressions;
using oasis.DataLayer.oasisEntitiesModel;
using oasis.Manager.Abstraction;

namespace oasis.Manager
{
    public class SqlDetail : IDetail
    {
        public OasisEntities Context;
        public SqlDetail()
        {
            Context = new OasisEntities();
        }
        public IQueryable<Detail> GetAll()
        {
            return Context.Details.AsQueryable();
        }

        public IQueryable<Detail> FindBy(Expression<Func<Detail, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(Detail entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Detail entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Detail entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
