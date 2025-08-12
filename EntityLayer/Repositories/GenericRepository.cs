
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Repositories
{
    public class GenericRepository<T>:IGenericDal<T> where T : class
    {
    }

    public interface IGenericDal<T> where T : class
    {
    }
}
