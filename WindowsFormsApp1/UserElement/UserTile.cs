using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.ModelData;

namespace WindowsFormsApp1.UserElement
{
    public partial class UserTile : UserControl
    {

        private Product _product;
        //объект Класса Product для хранения информации об объекте
        private Model1 model = new Model1();
        //объект для работы с БД

        public UserTile(Product product)
        {
            InitializeComponent();
            Fill(product);
        }

        //Метод заполнения данными элемента
        public void Fill(Product product)
        {
            _product = product;
            labelName.Text = _product.Title;
            labelCost.Text = $"Стоимость: {_product.Cost} руб.";
            try
            {
                pictureBox1.Image = Image.FromFile(_product.MainImagePath);
            }
            catch
            {
                pictureBox1.Image = WindowsFormsApp1.Properties.Resources.beauty_logo;
            }
            BackColor = _product.IsActive ? Color.White : Color.LightGray;
        }

        //Метод попытки удаления данного элемента
        private void Delete()
        {
            DialogResult result = MessageBox.Show(
            $"Вы действительно хотите удалить товар с ID {_product.ID}", 
            "Сообщение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    model.Product.Remove(
                    model.Product.First(x=>x.ID == _product.ID));
                    model.SaveChanges();
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Метод проверки нажатия правой или левой кнопки мыши 
        public void Clicking(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Form2 f = new Form2(_product);
                f.ShowDialog();
            }
            else if (e.Button == MouseButtons.Right)
            {
                Delete();
            }
        }

        private void Controls_Click(object sender, MouseEventArgs e)
        {
            Clicking(e);
        }
    }
}