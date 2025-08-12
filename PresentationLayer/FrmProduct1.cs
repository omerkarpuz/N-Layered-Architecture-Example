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
    public partial class FrmCategory1 : Form
    {
        private readonly IProductService _productService;

        //kategori listesini almak için kategoris service'i kullanıyoruz
        private readonly ICategoryService _categoryService;


        public FrmCategory1()
        {
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }



        private void btnListele_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetAll();
            dataGridView1.DataSource = values;
        }

        private void btnListeleKategorili_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetProductsWithCategory();
            dataGridView1.DataSource = values;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductName = txtAd.Text;
            product.ProductDescription = txtUrunAciklama.Text;
            product.ProductStok = Convert.ToInt32(txtUrunStok.Text);
            product.ProductPrice = Convert.ToDecimal(txtUrunFiyat.Text);
            product.CategoryId= Convert.ToInt32(cmbKategori.SelectedValue.ToString());
            _productService.TInsert(product);
            MessageBox.Show("Ürün Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtId.Text);
            var deletedProduct = _productService.TGetById(id);
            _productService.TDelete(deletedProduct);
            MessageBox.Show("Ürün Silindi");
        }

        private void btnIdGetir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var product = _productService.TGetById(id);
            dataGridView1.DataSource =product;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updatedProduct = _productService.TGetById(id);
            updatedProduct.CategoryId = Convert.ToInt32(cmbKategori.Text);
            updatedProduct.ProductName = txtAd.Text;
            updatedProduct.ProductStok = Convert.ToInt32(txtUrunStok.Text);
            updatedProduct.ProductPrice = Convert.ToDecimal(txtUrunFiyat.Text);
            updatedProduct.ProductDescription = txtUrunAciklama.Text;
            _productService.TUpdate(updatedProduct);
            MessageBox.Show("Ürün Güncellendi");

        }

        private void FrmCategory1_Load(object sender, EventArgs e)
        {
            var categories = _categoryService.TGetAll();
            cmbKategori.DataSource = categories;
            cmbKategori.DisplayMember = "CategoryName";
            cmbKategori.ValueMember = "CategoryId";
        }
    }
}
