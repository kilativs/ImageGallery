using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageGallery
{
    public partial class FormFullScreen : Form, IFullScreener
    {

        public string Title
        {
            set 
            { 
                this.Text = value; 
            }
        }
        public FormFullScreen()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        byte[] imageData;
        public byte[] ImageData
        {
            set
            {
                imageData = value;
                ShowData();
            }
        }

        private void ShowData()
        {
            using (MemoryStream str = new MemoryStream(imageData))
            {
                Image img = Image.FromStream(str);
                pictureBox1.Image = img;
            }
        }

        private void FormFullScreen_Load(object sender, EventArgs e)
        {
            //using(MemoryStream str = new MemoryStream(Comunication.ImageData))
            //{
            //    Image img = Image.FromStream(str);
            //    pictureBox1.Image = img;
            //}
        }

        public void ShowModal()
        {
            this.ShowDialog();
        }
    }
}
