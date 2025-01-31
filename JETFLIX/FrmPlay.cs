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
    public partial class FrmPlay : Form
    {
        Form1 f = new Form1();
        public FrmPlay(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }
         
        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}