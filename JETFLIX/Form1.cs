using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace JETFLIX
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-LM4ASFG;Initial Catalog=JETFLIX;Integrated Security=True;TrustServerCertificate=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
            LoadMovie();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadMovie(string description = "")
        {
            PanMain.Controls.Clear();
            cn.Open();

            string query = string.IsNullOrEmpty(description)
                ? "SELECT * FROM JETFLIX"
                : "SELECT * FROM JETFLIX WHERE Description = @description";

            cm = new SqlCommand(query, cn);
            if (!string.IsNullOrEmpty(description))
            {
                cm.Parameters.AddWithValue("@description", description);
            }

            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                PictureBox pic = new PictureBox
                {
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Width = 150,
                    Height = 150,
                    Tag = dr["Pathmovie"]
                };

                long len = dr.GetBytes(4, 0, null, 0, 0);
                byte[] arry = new byte[len + 1];
                dr.GetBytes(4, 0, arry, 0, Convert.ToInt32(len));
                MemoryStream ms = new MemoryStream(arry);
                Bitmap btm = new Bitmap(ms);
                pic.BackgroundImage = btm;

                Label lbl = new Label
                {
                    Text = dr["MovieName"].ToString(),
                    BackColor = Color.DarkGreen,
                    ForeColor = Color.Black,
                    Dock = DockStyle.Bottom
                };

                pic.Controls.Add(lbl);
                PanMain.Controls.Add(pic);
                pic.Click += OpenVideo;
            }
            dr.Close();
            cn.Close();
        }

        private void LoadDescriptions()
        {
            cn.Open();
            string query = "SELECT DISTINCT Description FROM JETFLIX";
            cm = new SqlCommand(query, cn);

            dr = cm.ExecuteReader();
            genresToolStripMenuItem.DropDownItems.Clear();

            while (dr.Read())
            {
                string description = dr["Description"].ToString();
                ToolStripMenuItem item = new ToolStripMenuItem(description);
                item.Click += DescriptionsToolStripMenuItem_Click;
                genresToolStripMenuItem.DropDownItems.Add(item);
            }

            dr.Close();
            cn.Close();
        }

        private void DescriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
            LoadMovie(clickedItem.Text);
        }

        private void OpenVideo(object sender, EventArgs e)
        {
            string str = ((PictureBox)sender).Tag.ToString();
            FrmPlay f = new FrmPlay(this);
            f.wmp.URL = str;
            f.wmp.Ctlcontrols.play();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMovie();
            LoadDescriptions();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AddNew f = new AddNew(this);
            f.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LoadMovie();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Uncomment the line below if you want live search.
            // LoadMovieBySearchTerm(searchtextBox.Text);
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchtextBox.Text.Trim();
            LoadMovieBySearchTerm(searchTerm);
        }

        public void LoadMovieBySearchTerm(string searchTerm)
        {
            PanMain.Controls.Clear();
            cn.Open();

            string query = "SELECT * FROM JETFLIX WHERE MovieName LIKE @searchTerm";
            cm = new SqlCommand(query, cn);
            cm.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                PictureBox pic = new PictureBox
                {
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Width = 150,
                    Height = 150,
                    Tag = dr["Pathmovie"]
                };

                long len = dr.GetBytes(4, 0, null, 0, 0);
                byte[] arry = new byte[len + 1];
                dr.GetBytes(4, 0, arry, 0, Convert.ToInt32(len));
                MemoryStream ms = new MemoryStream(arry);
                Bitmap btm = new Bitmap(ms);
                pic.BackgroundImage = btm;

                Label lbl = new Label
                {
                    Text = dr["MovieName"].ToString(),
                    BackColor = Color.DarkGreen,
                    ForeColor = Color.Black,
                    Dock = DockStyle.Bottom
                };

                pic.Controls.Add(lbl);
                PanMain.Controls.Add(pic);
                pic.Click += OpenVideo;
            }
            dr.Close();
            cn.Close();
        }
    }
}