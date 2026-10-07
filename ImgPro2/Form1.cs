using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
using Emgu.CV.UI;
using System.Linq;

namespace ImgPro2
{
    public partial class Form1 : Form
    {
        static int height = 1190; 
        static int width = 120;
        Image<Bgr, Byte> OriImage = new Image<Bgr, byte>(height, width);
        byte[,,] color_matrix_1 = new byte[256, 256, 256];
        private int color_flag;
        int click_num = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //菜单栏  
                      
        }


        private void File_Open(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openImgDlg = new System.Windows.Forms.OpenFileDialog();
            openImgDlg.Filter = "图片文件|*.jpg;*.bmp;*.png";

            if (openImgDlg.ShowDialog() == DialogResult.OK)
            {
                OriImage = new Image<Bgr, byte>(openImgDlg.FileName);
                imageBox1.Image = OriImage.Resize(imageBox1.Width, imageBox1.Height, Emgu.CV.CvEnum.Inter.Linear);
            }
            width = OriImage.Height;
            height = OriImage.Width;
        }


        private void File_Save(object sender, EventArgs e)
        {
            if (imageBox1.Image != null)
            {
                SaveFileDialog sfdlg = new SaveFileDialog();
                sfdlg.Filter = "bmp文件|*.bmp";
                sfdlg.FilterIndex = 2;
                sfdlg.RestoreDirectory = true;

                if (sfdlg.ShowDialog() == DialogResult.OK)
                {
                    string fname = sfdlg.FileName;
                    Bitmap bmp = new Bitmap((Image)imageBox1.Image); // 从 PictureBox 获取 Bitmap
                    Mat matImage = new Mat(bmp.Height, bmp.Width, Emgu.CV.CvEnum.DepthType.Cv8U, 4);
                   
                    using (matImage)
                    {
                        Emgu.CV.CvInvoke.Imwrite(fname, matImage); // 使用 Emgu CV 的方法保存图像
                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("请先打开图像！");
                return;
            }
        }

        private void File_Click(object sender, EventArgs e)
        {

        }

        private void ImageBox1_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> tem_bgr = new Image<Bgr, byte>(1, 1);
            Image<Lab, byte> tem_lab = new Image<Lab, byte>(1, 1);

            Color nowcolor;
            int temcolorB = 0;
            int temcolorG = 0;
            int temcolorR = 0;

            var scrBound = Screen.PrimaryScreen.Bounds;

            using (var bmp = new Bitmap(scrBound.Width, scrBound.Height))
            {
                using (var g = Graphics.FromImage(bmp))
                {
                    g.CopyFromScreen(scrBound.Location,
                                        scrBound.Location,
                                        scrBound.Size);
                }
                nowcolor = bmp.GetPixel(Cursor.Position.X, Cursor.Position.Y);
            }
            tem_bgr.Data[0, 0, 0] = nowcolor.B;
            tem_bgr.Data[0, 0, 1] = nowcolor.G;
            tem_bgr.Data[0, 0, 2] = nowcolor.R;

            //for (int kk = -2; kk < 3; kk++)
            //{
            //    for (int ii = -2; ii < 3; ii++)
            //    {
            //        temcolorB = OriImage.Data[Cursor.Position.Y + kk, Cursor.Position.X + ii, 0] + temcolorB;
            //        temcolorG = OriImage.Data[Cursor.Position.Y + kk, Cursor.Position.X + ii, 1] + temcolorG;
            //        temcolorR = OriImage.Data[Cursor.Position.Y + kk, Cursor.Position.X + ii, 2] + temcolorR; 
            //    }
            //}
            //tem_bgr.Data[0, 0, 0] = (byte)(temcolorB / 9);
            //tem_bgr.Data[0, 0, 1] = (byte)(temcolorG / 9);
            //tem_bgr.Data[0, 0, 2] = (byte)(temcolorR / 9);
            tem_lab = tem_bgr.Convert<Lab, Byte>();
            //tem_lab.Data = tem_bgr.Data;
            //tem_lab = tem_bgr.Convert<Hsv, Byte>();

            for (int i = -5; i < 6; i++)
            {
                for (int j = -5; j < 6; j++)
                {
                    for (int k = -5; k < 6; k++)
                    {
                        if (tem_lab.Data[0, 0, 0] > 5 && tem_lab.Data[0, 0, 0] < 249 && tem_lab.Data[0, 0, 1] > 5 && tem_lab.Data[0, 0, 1] < 249 && tem_lab.Data[0, 0, 2] < 249 && tem_lab.Data[0, 0, 2] > 5)
                        {
                            color_matrix_1[tem_lab.Data[0, 0, 0] + i, tem_lab.Data[0, 0, 1] + j, tem_lab.Data[0, 0, 2] + k] = (byte)color_flag;
                        }
                        else
                        {
                            color_matrix_1[tem_lab.Data[0, 0, 0], tem_lab.Data[0, 0, 1], tem_lab.Data[0, 0, 2]] = (byte)color_flag;
                        }
                        //    byte aa = color_matrix_1[0, 128, 128];
                    }
                }
            }


            click_num = click_num + 1;
            string message1 = "";
            message1 = string.Format("R：{0:F}  G：{1:F} B：{2:F} Lab：{3:F} {4:F} {5:F}     点击次数：{6:F}",
                                    nowcolor.R, nowcolor.G, nowcolor.B, tem_lab.Data[0, 0, 0], tem_lab.Data[0, 0, 1], tem_lab.Data[0, 0, 2], click_num);
            textBox1.Text = message1;

        }

        private void 单色ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void R_Danse(object sender, EventArgs e)
        {
            Image<Bgr, byte> r = new Image<Bgr, byte>(height, width);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    r.Data[i, j, 2] = OriImage.Data[i, j, 2];
                }
            }
            imageBox1.Image = r.Resize(imageBox1.Width, imageBox1.Height, Emgu.CV.CvEnum.Inter.Linear);
        }

        private void 绿ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> g = new Image<Bgr, byte>(height, width);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {   
                    g.Data[i, j, 1] = OriImage.Data[i, j, 1];
                }
            }
            imageBox1.Image = g.Resize(imageBox1.Width, imageBox1.Height, Emgu.CV.CvEnum.Inter.Linear);
        }

        private void 蓝ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> b = new Image<Bgr, byte>(height, width);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    b.Data[i, j, 0] = OriImage.Data[i, j, 0];
                }
            }
            imageBox1.Image = b.Resize(imageBox1.Width, imageBox1.Height, Emgu.CV.CvEnum.Inter.Linear);
        }

        private void HSI空间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Hsv, byte> HsvImg = OriImage.Convert<Hsv, byte>();
            imageBox1.Image = HsvImg.Resize(imageBox1.Width, imageBox1.Height, Emgu.CV.CvEnum.Inter.Cubic);

        }

        private void Lab空间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Lab, byte> LabImg = OriImage.Convert<Lab, byte>();
            imageBox1.Image = LabImg.Resize(imageBox1.Width, imageBox1.Height, Emgu.CV.CvEnum.Inter.Cubic);

        }

        private void 图像处理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> MFImg = new Image<Bgr, byte>(height, width);
            MFImg = OriImage.SmoothMedian(5);
            imageBox1.Image = MFImg.Resize(imageBox1.Width, imageBox1.Height, Emgu.CV.CvEnum.Inter.Linear);
            
        }

        private void 图像分割ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 颜色识别训练ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 橘黄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color_flag = 1;
        }

        private void 柠黄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color_flag = 2;
        }

        private void 青黄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color_flag = 3;
        }

        private void 棕红ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color_flag = 4;
        }

        private void 颜色分割ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void Segmentation(int colorFlag, ref Image<Bgr, Byte> ImageSegment)
        {
            Image<Lab, Byte> ImageLab = OriImage.Convert<Lab, Byte>();

            ImageSegment = new Image<Bgr, byte>(ImageLab.Width, ImageLab.Height);

            for (int m = 2; m < ImageLab.Height - 2; m++)
            {
                for (int n = 2; n < ImageLab.Width - 2; n++)
                {
                    if (color_matrix_1[ImageLab.Data[m, n, 0], ImageLab.Data[m, n, 1], ImageLab.Data[m, n, 2]] == colorFlag)
                    {
                        ImageSegment.Data[m, n, 0] = OriImage.Data[m, n, 0];
                        ImageSegment.Data[m, n, 1] = OriImage.Data[m, n, 1];
                        ImageSegment.Data[m, n, 2] = OriImage.Data[m, n, 2];
                        for (int i = -2; i < 3; i++)
                        {
                            for (int j = -2; j < 3; j++)
                            {
                                ImageSegment.Data[m + i, n + j, 0] = OriImage.Data[m + i, n + j, 0];
                                ImageSegment.Data[m + i, n + j, 1] = OriImage.Data[m + i, n + j, 1];
                                ImageSegment.Data[m + i, n + j, 2] = OriImage.Data[m + i, n + j, 2];
                            }
                        }
                    }
                }
            }
        }
        private void 橘黄ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int colorFlag = 1;
            Image<Bgr, Byte> ImageSegJH = new Image<Bgr, byte>(width, height);
            Segmentation(colorFlag, ref ImageSegJH);
            imageBox1.Image = ImageSegJH.Resize(imageBox1.Width, imageBox1.Height, Emgu.CV.CvEnum.Inter.Linear);
        }

        private void 柠黄ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int colorFlag = 2;
            Image<Bgr, Byte> ImageSegNH = new Image<Bgr, byte>(width, height);
            Segmentation(colorFlag, ref ImageSegNH);
            imageBox1.Image = ImageSegNH.Resize(imageBox1.Width, imageBox1.Height, Emgu.CV.CvEnum.Inter.Linear);
        }

        private void 青黄ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int colorFlag = 3;
            Image<Bgr, Byte> ImageSegQH = new Image<Bgr, byte>(width, height);
            Segmentation(colorFlag, ref ImageSegQH);
            imageBox1.Image = ImageSegQH.Resize(imageBox1.Width, imageBox1.Height, Emgu.CV.CvEnum.Inter.Linear);
        }

        private void 棕红ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int colorFlag = 4;
            Image<Bgr, Byte> ImageSegZH = new Image<Bgr, byte>(width, height);
            Segmentation(colorFlag, ref ImageSegZH);
            imageBox1.Image = ImageSegZH.Resize(imageBox1.Width, imageBox1.Height, Emgu.CV.CvEnum.Inter.Linear);
        }

        private void TextBox1(object sender, EventArgs e)
        {

        }

        private void 种类识别ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //逐行扫描每一行像素直到遍历完一张照片，存入一个地方
            //注意，我们的四种颜色是由鼠标点击的方式学得的，即上面的imgBox_Click
            //将存入的像素点分为四部分（颜色分割），计算每一部分的百分比，占比最高的就判断为这个颜色

            // 初始化颜色计数器，假设有4种颜色
            int[] colorCounts = new int[4];

            // 遍历图像的每个像素
            for (int i = 0; i < OriImage.Height; i++)
            {
                for (int j = 0; j < OriImage.Width; j++)
                {
                    byte b = OriImage.Data[i, j, 0]; // BGR中的蓝色通道
                    byte g = OriImage.Data[i, j, 1]; // BGR中的绿色通道
                    byte r = OriImage.Data[i, j, 2]; // BGR中的红色通道

                    // 根据color_matrix_1中的标记增加相应颜色的计数
                    if (color_matrix_1[b, g, r] > 0)
                    {
                        colorCounts[color_matrix_1[b, g, r] - 1]++;
                    }
                }
            }

            // 假设 color_matrix_1 初始化为全0
            bool isColorMatrixPopulated = false;
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    for (int k = 0; k < 256; k++)
                    {
                        if (color_matrix_1[i, j, k] > 0)
                        {
                            isColorMatrixPopulated = true;
                            break;
                        }
                    }
                    if (isColorMatrixPopulated) break;
                }
                if (isColorMatrixPopulated) break;
            }

            if (!isColorMatrixPopulated)
            {
                textBox2.AppendText("颜色矩阵未正确初始化或更新。");
            }
            else
            {
                // 计算并显示每种颜色的占比
                double totalPixels = OriImage.Width * OriImage.Height;
                for (int i = 0; i < colorCounts.Length; i++)
                {
                    double percentage = (colorCounts[i] / totalPixels) * 100.0;
                    textBox2.AppendText($"颜色 {i + 1} 占比: {percentage:F2}     \n");

                }
                // 找出占比最高的颜色
                int maxCountIndex = Array.IndexOf(colorCounts, colorCounts.Max());
                textBox2.AppendText($"占比最高的颜色索引是: {maxCountIndex + 1}");

            }

        }

        private void SaveData(string filename)
        {
            try
            {
                FileStream fileStream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, color_matrix_1);
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败: " + ex.Message);
            }
        }

        private void LoadData(string filename)
        {
            try
            {
                FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                color_matrix_1 = (byte[,,])formatter.Deserialize(fileStream);
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取失败: " + ex.Message);
            }
        }

        private void 存档ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Data Files|*.dat";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveData(saveFileDialog.FileName);
            }
        }

        private void 读档ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Data Files|*.dat";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadData(openFileDialog.FileName);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    