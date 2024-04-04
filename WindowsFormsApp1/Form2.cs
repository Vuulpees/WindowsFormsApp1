using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.ModelData;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private Product _product;
        //поле для хранения объекта класса Product
        public Form2(Product product)
        {
            InitializeComponent();
            _product = product;
            LoadData();
        }
        //Метод для загрузки данных в элементы
        private void LoadData()
        {
            textBoxName.Text = _product.Title;
            textBoxCost.Text = _product.Cost.ToString();
            textBoxManufacture.Text = _product.Manufacturer.Name;
            textBoxDescription.Text = _product.Description;
            checkBoxActive.Checked = _product.IsActive;
            try
            {
                pictureBox1.Image = Image.FromFile(_product.MainImagePath);
            }
            catch
            {
                pictureBox1.Image = WindowsFormsApp1.Properties.Resources.beauty_logo;
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}