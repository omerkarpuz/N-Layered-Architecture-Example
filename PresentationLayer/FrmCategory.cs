using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;

        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }


        //Listeleme

        private void btnListele_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }


        //ID'ye göre getirme
        private void btnIdGoreGetir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtKategoriId.Text);
            dataGridView1.DataSource = _categoryService.TGetById(id);
           
        }
        

        //Ekleme
        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtKategoriAd.Text;
            category.CategoryStatus = true;
            _categoryService.TInsert(category);
            MessageBox.Show("Kategori başarıyla eklendi.");
        }

        //Silme
        private void btnSil_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(txtKategoriId.Text);
            var deletedValues = _categoryService.TGetById(id);
            _categoryService.TDelete(deletedValues);
            MessageBox.Show("Kategori başarıyla silindi.");
        }

        //Güncelleme
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int updatedId = int.Parse(txtKategoriId.Text);
            var updatedValue = _categoryService.TGetById(updatedId);
            updatedValue.CategoryName = txtKategoriAd.Text;
            updatedValue.CategoryStatus = true;
            _categoryService.TUpdate(updatedValue);
            MessageBox.Show("Kategori başarıyla güncellendi.");
        }
    }
}
