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
        CRUDEntities1 db = new CRUDEntities1();
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
            foreach (var item in elems2)
            {
                UTableID.Items.Add(item.Id);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category Cat = new Category();
            Cat.Name = ProjectName.Text;
            db.Categories.Add(Cat);
            db.SaveChanges();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UTableID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as ComboBox).SelectedItem);
            var id1 = db.Galleries.Where((x) => x.Id == id).First();
            UTitle.Text = id1.Title;
            UClient.Text = id1.Client;
            UStartDate.Text = id1.Start_Date.ToString();
            UFinishDate.Text = id1.Finish_Date.ToString();
            UAddDate.Text = id1.Add_Date.ToString();
        }

        private void UUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UTableID.SelectedItem);
            var id1 = db.Galleries.Where((x) => x.Id == id).First();
            id1.Title = UTitle.Text;
            id1.Client = UClient.Text;
            id1.Start_Date = DateTime.Parse(UStartDate.Text);
            id1.Finish_Date = DateTime.Parse(UFinishDate.Text);
            id1.Add_Date = DateTime.Parse(UAddDate.Text);
            db.SaveChanges();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UTableID.SelectedItem);
            var id1 = db.Galleries.Where((x) => x.Id == id).First();
            db.Galleries.Remove(id1);
            db.SaveChanges();
            read();
        }
    }
}
