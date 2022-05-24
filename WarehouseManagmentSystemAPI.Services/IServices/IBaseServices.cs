using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagmentSystemAPI.Services.IServices
{
    public interface IBaseServices<T> where T: class
    {
        public T Create(T TT);
        public T Update(Guid id);
        public void Delete(Guid id);
        public IEnumerable<T> Read();
    }
}
