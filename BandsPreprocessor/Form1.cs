using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BandsPreprocessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbBands.Text = cmbBands.Items[0].ToString();
            List<string> dirs = new List<string>(Directory.EnumerateDirectories(toolStripTextBox1.Text));
            for (int r = 0; r < dirs.Count; r++)
            {
                string path = dirs[r].Substring(toolStripTextBox1.Text.Length);
                if (r == 0) { cmbInputDirs.Text = path; }
                cmbInputDirs.Items.Add(path);
            }
        }

        string getBands(string _bands)
        {

            string bands = _bands; //  toolStripComboBox2.Text.ToString().Substring(0, 3);
            string output = "";
            output += "B" + bands[0] + ",";
            output += "B" + bands[1] + ",";
            output += "B" + bands[2];
            return output;
        }

        static List<string> bandsFullpathNoext = new List<string>();

        private string  getBandFromFileList(string _bandName)
        {
            for (int r = 0; r < bandsFullpathNoext.Count(); r++)
            {
                string bandFullPathNoExt = bandsFullpathNoext[r];

                if (bandFullPathNoExt.EndsWith(_bandName))
                {
                    return bandFullPathNoExt;
                }
            }

            return "";
        }

        string bands;
        string[] splitBands;

        private void getBandFiles(string _bands)
        {

            bands = getBands(_bands);

            splitBands = bands.Split(',');

            IEnumerable<string> files = Directory.EnumerateFiles(toolStripTextBox1.Text + cmbInputDirs.Text);

            string[] filesArray = files.ToArray();

            for (int r = 0; r < filesArray.Count(); r++)
            {
                filesArray[r] = filesArray[r].Remove(filesArray[r].Length - 4);

                for (int s = 0; s < splitBands.Count(); s++)
                {
                    if (filesArray[r].EndsWith(splitBands[s]))
                    {
                        System.Console.WriteLine(filesArray[r]);
                        bandsFullpathNoext.Add(filesArray[r]);
                    }
                }
            }

        }

        private void convertFiles(string _filename,string _bands)
        {

            getBandFiles(_bands);

            // toolStripButton2.Text = bands;

            string imageFile;

            Bitmap bandR = new Bitmap(1, 1);
            Bitmap bandG = new Bitmap(1, 1);
            Bitmap bandB = new Bitmap(1, 1);

            for (int r = 0; r < splitBands.Count(); r++)
            {
                imageFile = getBandFromFileList(splitBands[r]) + ".png";

                Image image; //  = new Image();
                image = Image.FromFile(imageFile);
                if (image == null) { return; }
                System.Console.WriteLine(imageFile);

                switch (r)
                {
                    case 0:
                        bandR = (Bitmap)image;
                        picBandR.Image = image;
                        picBandR.Height = image.Height;
                        picBandR.Width = image.Width;
                        break;
                    case 1:
                        bandG = (Bitmap)image;
                        picBandG.Image = image;
                        picBandG.Height = image.Height;
                        picBandG.Width = image.Width;
                        break;
                    case 2:
                        bandB = (Bitmap)image;
                        picBandB.Image = image;
                        picBandB.Height = image.Height;
                        picBandB.Width = image.Width;
                        break;
                }
            }

            // picBandR.Image = cBitmapUtils.autoLevel(picBandR.Image);
            // picBandG.Image = cBitmapUtils.autoLevel(picBandG.Image);
            // picBandB.Image = cBitmapUtils.autoLevel(picBandB.Image);

            Bitmap temp = new Bitmap(picBandR.Image.Width, picBandR.Image.Height);

            for (int r = 0; r < picBandR.Image.Width; r++)
            {
                for (int s = 0; s < picBandR.Image.Height; s++)
                {
                    temp.SetPixel(r, s, Color.FromArgb(255, bandR.GetPixel(r, s).R, bandG.GetPixel(r, s).R, bandB.GetPixel(r, s).R));
                }
            }

            picViewport.Image = (Image)temp;

            System.IO.Directory.CreateDirectory(txtOutputPath.Text +  _filename);

            string fileName = txtOutputPath.Text + _filename + "\\" + _bands.ToString().Substring(0, 3) + "_" + _filename;

            temp.Save(fileName + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            // picViewport.Image = cBitmapUtils.autoLevel(picViewport.Image);
            
            // picViewport.Image = cBitmapUtils.ResizeImage(picViewport.Image, Convert.ToInt32((Convert.ToSingle(picViewport.Image.Width) / 1.25)), Convert.ToInt32((Convert.ToSingle(picViewport.Image.Height) / 1.25)));



        }

        static int dirCount = 0;
        static float progressDelta = 0;
        static float totalProgress = 0;

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // convertFiles(cmbInputDirs.Text, cmbBands.Text);
            dirCount = -1;
            progBar.Value = 0;
            timer1.Enabled = !timer1.Enabled;
            progressDelta = 0;
            totalProgress = 0;
            progressDelta =  100.0f / (float)cmbInputDirs.Items.Count;
            labelProgress.Text = "Progress : " + 0 + "/" + cmbInputDirs.Items.Count;
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dirCount++;
            for (int r = 0; r < cmbBands.Items.Count; r++)
            {
                convertFiles(cmbInputDirs.Items[dirCount].ToString(), cmbBands.Items[r].ToString());
            }
            totalProgress += progressDelta;
            progBar.Value = (int)totalProgress;
            labelProgress.Text = "Progress : " + dirCount + "/" + cmbInputDirs.Items.Count;
            if (dirCount >= cmbInputDirs.Items.Count) { timer1.Enabled = false; }
        }
    }
}
