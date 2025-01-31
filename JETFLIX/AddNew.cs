using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace JETFLIX
{
    public partial class AddNew : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-LM4ASFG;Initial Catalog=JETFLIX;Integrated Security=True;TrustServerCertificate=True");
        SqlCommand cm = new SqlCommand();
        OpenFileDialog ofdv = new OpenFileDialog();
        string strpath;

         
        Form1 F = new Form1();

        public AddNew(Form1 f)
        {
            InitializeComponent();
            this.F = f;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image|*.jpg;*.png;*.bmp;*.jfif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic.Image = Image.FromFile(ofd.FileName);
                 
            }
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("INSERT INTO jetflix (MovieName, Description, Pathmovie, img) VALUES (@MovieName, @Description, @Pathmovie, @img)", cn);
                cm.Parameters.AddWithValue("@MovieName", TxtName.Text);
                cm.Parameters.AddWithValue("@Description", TxtDescription.Text);
                cm.Parameters.AddWithValue("@Pathmovie", strpath);
                 
                using (MemoryStream ms = new MemoryStream())
                {
                    pic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);  
                    byte[] data = ms.ToArray();  
                    cm.Parameters.AddWithValue("@img", data);  
                }

                cm.ExecuteNonQuery();
                MessageBox.Show("Movie has been Saved");
                 
                pic.Image = null;  
                TxtDescription.Clear();
                TxtName.Clear();
                 
                F.LoadMovie(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }
        private void BtnUploadVidow_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Video MP$|*.mp4";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                strpath = ofd.FileName;

            }
        }
    }
}