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
    public partial class FMain : Form
    {
       private FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

       private List<FileInfo> imageList = new List<FileInfo>();
       private int imageIndex = 0;

        int locX = 20;
        int locY = 10;
        int sizeWidth = 50;
        int sizeHeight = 50;

        public FMain()
        {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            DirectoryInfo folder;
            FileInfo[] images;
            this.folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.ShowNewFolderButton = false;
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folder = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                images = folder.GetFiles();
                pnControls.Controls.Clear();
                imageIndex = 0;
                imageList.AddRange(new DirectoryInfo(folderBrowserDialog.SelectedPath).GetFiles());


                int locnewX = locX;
                int locnewY = locY;

                foreach (FileInfo img in images)
                {
                    if (img.Extension.ToLower() == ".png" || img.Extension.ToLower() == ".jpg" ||
                        img.Extension.ToLower() == ".gif" || img.Extension.ToLower() == ".jpeg" ||
                        img.Extension.ToLower() == ".bmp" || img.Extension.ToLower() == ".tif")
                    {
                        
                        if (locnewX >= pnControls.Width - sizeWidth - 10)
                        {
                            locnewX = locX;
                            locY = locY + sizeHeight + 30;
                            locnewY = locY;
                        }
                        else
                        {

                            locnewY = locY;
                        }
                        loadImagestoPanel(img.Name, img.FullName, locnewX, locnewY);
                        locnewY = locY + sizeHeight + 10;
                        locnewX = locnewX + sizeWidth + 10;
                    }
                }
            }
        }

        private void loadImagestoPanel(string imageName, string imagesfullName, int locnewX, int locnewY)
        {
            
            PictureBox ctrl = new PictureBox();
            ctrl.Image = Image.FromFile(imagesfullName);
            ctrl.BackColor = Color.Black;
            ctrl.Location = new Point(locnewX, locnewY);
            ctrl.Size = new Size(sizeWidth, sizeHeight);
            ctrl.SizeMode = PictureBoxSizeMode.StretchImage;
            ctrl.MouseClick += new MouseEventHandler(pnControls_MouseClick);
            pnControls.Controls.Add(ctrl);
        }

        private void pnControls_MouseClick(object sender, MouseEventArgs e)
        {
           Control control = (Control)sender;
           PictureBox pic = (PictureBox)control;
           pictureBox.Image = pic.Image;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            pnControls.Controls.Clear();
            imageList.Clear();
            locX = 20;
            locY = 10;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pnControls.Width, pnControls.Height);
            pnControls.DrawToBitmap(bmp, new Rectangle(0, 0, pnControls.Width, pnControls.Height));
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "*";
            dlg.DefaultExt = "bmp";
            dlg.ValidateNames = true;
            dlg.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif |JPEG Image (.jpeg)|*.jpeg |Png Image (.png)|*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image.Save(dlg.FileName);
            }

        }

        private void btZoom_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(pictureBox.Image);
            int nw = pictureBox.Image.Width * 2;
            int nh = pictureBox.Image.Height * 2;
            pictureBox.Image = ResizeBitmap(b, nw, nh);
        }
        public Bitmap ResizeBitmap(Bitmap b, int nWidth, int nHeight)
        {
            Bitmap result = new Bitmap(nWidth, nHeight);
            using (Graphics g = Graphics.FromImage((Image)result))
                g.DrawImage(b, 0, 0, nWidth, nHeight);
            return result;
        }
        private void btSmall_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(pictureBox.Image);
            int nw = pictureBox.Image.Width / 2;
            int nh = pictureBox.Image.Height / 2;
            pictureBox.Image = ResizeBitmap(b, nw, nh);

        }

        private void btLeftMove_Click(object sender, EventArgs e)
        {
            pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox.Refresh();
        }

        private void btRightMove_Click(object sender, EventArgs e)
        {
            pictureBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox.Refresh();
        }
        
        private void btNext_Click(object sender, EventArgs e)
        {
            if (imageIndex != imageList.Count - 1 && imageList.Count > 0)
                pictureBox.Load(imageList[++imageIndex].FullName);
        }

        private void btPrev_Click(object sender, EventArgs e)
        {
            if (imageIndex > 0)
                pictureBox.Load(imageList[--imageIndex].FullName);
        }

        IFullScreener fullScreener;


        public IFullScreener FullScreener { 
            get {
                if (fullScreener == null)
                    fullScreener = new FormFullScreen();
                return fullScreener; 
            } 
            set => fullScreener = value; 
        }

        private void btFullScreen_Click(object sender, EventArgs e)
        {
            using (MemoryStream str = new MemoryStream())
            {
                pictureBox.Image.Save(str, System.Drawing.Imaging.ImageFormat.Png);

                //FormFullScreen form = new FormFullScreen();
                FullScreener.ImageData = str.ToArray();
                FullScreener.Title = imageList[imageIndex].Name;
                FullScreener.ShowModal();
            }
        }

    }
}
