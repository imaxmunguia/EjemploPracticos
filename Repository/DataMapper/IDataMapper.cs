using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMapper
{
    public interface IDataMapper<TObject> where TObject : class
    {
        void Insert(TObject obj);
        void Update(TObject obj);
        void Delete(TObject obj);

        IEnumerable<TObject> GetAll();
        IEnumerable<TObject> GetFiltered(string conditions, string order, int pageSize, int pageIndex);
    }
}
