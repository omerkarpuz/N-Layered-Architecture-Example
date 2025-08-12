using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TDelete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public List<Category> TGetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void TInsert(Category entity)
        {
            if (entity.CategoryName != null)
            {
                //ekleme yap
                _categoryDal.Insert(entity);
            }
            else
            {
                //ekleme yapma
            }
        }

        public void TUpdate(Category entity)
        {
            if (entity.CategoryName != null)
            {
                _categoryDal.Update(entity);
            }
        }
    }
}
