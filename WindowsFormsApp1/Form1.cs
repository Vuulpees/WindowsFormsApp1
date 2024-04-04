using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.ModelData;
using WindowsFormsApp1.UserElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private enum SvipeType
        {
            Left,
            Right
        }
        //Перечесление для удобной перемотки элеметов
        private Model1 model = new Model1();
        //model объект для работы с БД
        private List<Product> products = new List<Product>();
        //products список для хранения данных из таблицы Product
        private int SvipeID;
        //SvipeID переменная для номера записи текущего элемента

        public Form1()
        {
            InitializeComponent();
            Loadproducts();
            CreateTile();
        }

        //Метод для загрузки первоначальных данных
        private void Loadproducts()
        {
            products.Clear();
            SvipeID = 0;
            products = model.Product.ToList();
            comboBox1.SelectedIndex = 0;
        }

        private void Sort()
        {
            if (checkBox1.Checked == false)
            {
                if (comboBox1.SelectedIndex == 0)
                    products = products.OrderBy(x => x.ID).ToList();
                else if (comboBox1.SelectedIndex == 1)
                    products = products.OrderBy(x => x.Title).ToList();
                else if (comboBox1.SelectedIndex == 2)
                    products = products.OrderBy(x => x.Cost).ToList();
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                    products = products.OrderByDescending(x => x.ID).ToList();
                else if (comboBox1.SelectedIndex == 1)
                    products = products.OrderByDescending(x => x.Title).ToList();
                else if (comboBox1.SelectedIndex == 2)
                    products = products.OrderByDescending(x => x.Cost).ToList();
            }
            CreateTile();
        }
        //Метод для загрузки первоначальных данных
        private void SetTextlabel()
        {
            if (products.Count != 0)
            {
                labelCount.Text = products.Count >= 6 ?
                $"с {SvipeID + 1} по {SvipeID + 6}  из {products.Count} Товаров" :
                $"с 1 по {products.Count} Товаров";
            }
            else
                labelCount.Text = $"с 0 из {products.Count} Товаров";
        }

        //Метод для добавления элементов
        private void CreateTile()
        {
            //Метод удаления ввсех элементов из FlowLayoutPanel
            FLPTile.Controls.Clear();
            //FLPTile - моё имя элемента FlowLayoutPanel
            SetTextlabel();
            for (int i = 0; i < 6; i++)
            {
                if (products.Count > i)
                {
                    int count = i + SvipeID;
                    //Создание нового объекта элемента UserTile
                    UserTile tile = new UserTile(products[count]);
                    //Добавление созданного объекта элемента UserTile
                    //в FLPTile (отображения на экране)
                    FLPTile.Controls.Add(tile);
                    //FLPTile - моё имя элемента FlowLayoutPanel
                }
            }
        }

        //Метод для поиска элементов в БД по имени
        private void Search()
        {
            products.Clear();
            SvipeID = 0;
            //Поиск в БД где Поле Title содержит написанное в textBoxSearch
            products = model.Product.Where(
            x => x.Title.Contains(textBoxSearch.Text)).ToList();
            labelNothing.Visible = products.Count == 0 ? true : false;
            CreateTile();
        }

        //Метод перемотки элементов
        private void Svipe(SvipeType svipeType)
        {
            if (svipeType == SvipeType.Left &&
            SvipeID != 0)
            {
                SvipeID--;
                CreateTile();
            }
            if (svipeType == SvipeType.Right &&
            SvipeID + 5 < products.Count - 1)
            {
                SvipeID++;
                CreateTile();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            Svipe(SvipeType.Left);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            Svipe(SvipeType.Right);
        }

        private void buttonLeftx2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
                Svipe(SvipeType.Left);
        }

        private void buttonRightx2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
                Svipe(SvipeType.Right);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sort();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Sort();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
