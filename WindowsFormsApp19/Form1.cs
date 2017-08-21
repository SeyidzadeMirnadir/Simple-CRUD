using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            read();
        }
        // CRUDEntities db = new CRUDEntities();
        CRUDEntities1 db = new CRUDEntities1();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void read()
        {
            var elems = db.Categories.ToList();
            var elems2 = db.Galleries.ToList();
            CategoryID.Items.Clear();
            TableID.Items.Clear();
            foreach (var item in elems)
            {
                CategoryID.Items.Add(item.Id);
            }
            foreach (var item in elems2)
            {
                TableID.Items.Add(item.Id);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string ISBNData = ISBN.Text;
            //string PublishDateData = PublishDate.Text; 
            //if (string.IsNullOrEmpty(BookData) || string.IsNullOrEmpty(ISBNData) || string.IsNullOrEmpty(PublishDateData))
            //{
            //    MessageBox.Show("Bosh Buraxma");
            //    return;
            //}
            
            Category Cat = new Category();
            //bugunun.book_name = BookData;
            //bugunun.ISBN = Convert.ToInt32(ISBNData);
            //bugunun.Publish_date = DateTime.Parse(PublishDateData);
            Cat.Name = ProjectName.Text;
            db.Categories.Add(Cat);
            db.SaveChanges();
            //read();

        }

        private void CreateGallery_Click(object sender, EventArgs e)
        {
            Gallery Gall = new Gallery();
            Gall.Title = Title.Text;
            Gall.Client = Client.Text;
            Gall.Start_Date = DateTime.Parse(StartDate.Text);
            Gall.Finish_Date = DateTime.Parse(FinishDate.Text);
            Gall.Add_Date = DateTime.Parse(AddDate.Text);
            Gall.Category_ID = Convert.ToInt32(CategoryID.SelectedItem);
            db.Galleries.Add(Gall);
            db.SaveChanges();
            read();
        }

        

        private void TableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as ComboBox).SelectedItem);
            var id1 = db.Galleries.Where((x) => x.Id == id).First();
            RTitle.Text = id1.Title;
            RClient.Text = id1.Client;
            RStartDate.Text = id1.Start_Date.ToString();
            RFinishDate.Text = id1.Finish_Date.ToString();
            RAddDate.Text = id1.Add_Date.ToString();

        }

        //private void idData_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int id = Convert.ToInt32((sender as ComboBox).SelectedItem);
        //    var id1 = db.Tables.Where((x) => x.Id == id).First();
        //    NameList.Text = id1.book_name;
        //    ISBNList.Text = id1.ISBN.ToString();
        //    DataList.Text = id1.Publish_date.ToString();
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (IdList.SelectedItem == null)
        //    {
        //        MessageBox.Show("Combobox seçilməyib");
        //        return;
        //    }
        //    int id = Convert.ToInt32(IdList.SelectedItem);
        //    var id1 = db.Tables.Where((x) => x.Id == id).First();
        //    db.Tables.Remove(id1);
        //    db.SaveChanges();
        //    read();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (IdList.SelectedItem == null)
        //    {
        //        MessageBox.Show("Olmaz");
        //        return;
        //    }
        //    int id = Convert.ToInt32(IdList.SelectedItem);
        //    var id1 = db.Tables.Where((x) => x.Id == id).First();
        //    if (string.IsNullOrEmpty(textBox1.Text))
        //    {

        //    }
        //    id1.book_name = textBox1.Text;
        //    id1.ISBN = Convert.ToInt32(textBox2.Text);
        //    id1.Publish_date = DateTime.Parse(textBox3.Text);
        //    db.SaveChanges();
        //}
    }
}
