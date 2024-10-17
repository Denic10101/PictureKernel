using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;
using System.Drawing.Imaging;

namespace PictureKernel
{
    public partial class fMain : Form
    {
        KerImage kImg;
        public fMain()
        {
            InitializeComponent();
        }

        private void pnlKernel_Refresh()
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btOpenWch_Click(object sender, EventArgs e)
        {
            opnfileImage.ShowDialog();

        }

        private void opnfileImage_FileOk(object sender, CancelEventArgs e)
        {
            tboxImagePath.Text = opnfileImage.FileName;
        }

        private void btInit_Click(object sender, EventArgs e)
        {
            kImg.InitImage(ref pbarInitProgress);
        }

        private void btLoadImage_Click(object sender, EventArgs e)
        {
            kImg = new KerImage(tboxImagePath.Text);
            pboxOutput.Image = kImg.GetImage();
            btInit.Enabled = true;
            btApply.Enabled = true;
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            kImg.ApplyKernel();
            pboxOutput.Image = kImg.getOutputBMP();
        }

        private void btInitKernel_Click(object sender, EventArgs e)
        {
            
            try
            {
                kImg.InitKernel();
                kImg.SetKernelValue(0, 0, Int32.Parse(tbV11.Text));
                kImg.SetKernelValue(0, 1, Int32.Parse(tbV12.Text));
                kImg.SetKernelValue(0, 2, Int32.Parse(tbV13.Text));
                kImg.SetKernelValue(1, 0, Int32.Parse(tbV21.Text));
                kImg.SetKernelValue(1, 1, Int32.Parse(tbV22.Text));
                kImg.SetKernelValue(1, 2, Int32.Parse(tbV23.Text));
                kImg.SetKernelValue(2, 0, Int32.Parse(tbV31.Text));
                kImg.SetKernelValue(2, 1, Int32.Parse(tbV32.Text));
                kImg.SetKernelValue(2, 2, Int32.Parse(tbV33.Text));
                kImg.SetKernelValue(-1, -1, float.Parse(tbVScalar.Text));
                kImg.SaveBrightness(chboxSaveBrig.Checked);
                kImg.MonochromeOutput(chboxMonochrome.Checked);
                Console.WriteLine("Kernel inited");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid kernel value");
                MessageBox.Show("Invalid kernel value");
            }

        }

        private void btSaveOutput_Click(object sender, EventArgs e)
        {
            savefileImage.ShowDialog();
        }

        private void savefileImage_FileOk(object sender, CancelEventArgs e)
        {
            kImg.getOutputBMP().Save(savefileImage.FileName, ImageFormat.Png);
        }

        private void radiobtFullSize_CheckedChanged(object sender, EventArgs e)
        {
            pboxOutput.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void radiobtStretch_CheckedChanged(object sender, EventArgs e)
        {
            pboxOutput.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void radiobtCenter_CheckedChanged(object sender, EventArgs e)
        {
            pboxOutput.SizeMode = PictureBoxSizeMode.CenterImage;
        }
    }
    public class KerImage 
    {
        Image imgSource;
        Image imgOutput;
        Bitmap bmpSource;
        Bitmap bmpOutput;
        byte[] rgbSource;
        byte[] rgbOutput;
        int[] kernel;
        int kerWidth;
        int kerHeight;
        int srcWidth;
        int srcHeight;
        float kerScalar;
        bool sourceIsInit;
        bool kernelIsInit;
        bool saveBrightness;
        bool monochromeOutput;

        public KerImage(string sourcePath) 
        {
            try
            {
                sourceIsInit = false;
                imgSource = Image.FromFile(sourcePath);
                Console.WriteLine("Image loaded");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Image not loaded");
                MessageBox.Show("Image not loaded");
            }
        }
        public void InitImage(ref ProgressBar pbar)
        {
            try
            {
                int initProgress;
                srcWidth = imgSource.Width;
                srcHeight = imgSource.Height;
                bmpSource = (Bitmap)imgSource;
                bmpOutput = new Bitmap(srcWidth, srcHeight);
                rgbSource = new byte[srcHeight * srcWidth * 3];
                rgbOutput = new byte[srcHeight * srcWidth * 3];
                for (int y = 0; y < imgSource.Height; y++)
                {
                    for (int x = 0; x < imgSource.Width; x++)
                    {
                        rgbSource[3 * (y * srcWidth + x) + 0] = bmpSource.GetPixel(x, y).R;
                        rgbSource[3 * (y * srcWidth + x) + 1] = bmpSource.GetPixel(x, y).G;
                        rgbSource[3 * (y * srcWidth + x) + 2] = bmpSource.GetPixel(x, y).B;
                    }
                    initProgress = (int)(y * 100 / srcHeight);
                    pbar.Value = initProgress;
                }
                pbar.Value = pbar.Maximum;
                sourceIsInit = true;
                Console.WriteLine("Image inited");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Image not inited");
                MessageBox.Show("Image not inited");
            }
        }
        public void ApplyKernel()
        {
            for (int y = 0; y < srcHeight; y++)
            {
                for (int x = 0; x < srcWidth; x++)
                {
                    double rSum = 0, gSum = 0, bSum = 0, kSum = 0, mono = 0;
                    for (int ky = 0; ky < kerHeight; ky++)
                    {
                        for (int kx = 0; kx < kerWidth; kx++)
                        {
                            int pixelPosX = x + (kx - (kerWidth / 2));
                            int pixelPosY = y + (ky - (kerHeight / 2));
                            if ((pixelPosX < 0) ||
                                (pixelPosX >= srcWidth) ||
                                (pixelPosY < 0) ||
                                (pixelPosY >= srcHeight)) continue;
                            byte r = rgbSource[3 * (srcWidth * pixelPosY + pixelPosX) + 0];
                            byte g = rgbSource[3 * (srcWidth * pixelPosY + pixelPosX) + 1];
                            byte b = rgbSource[3 * (srcWidth * pixelPosY + pixelPosX) + 2];
                            double kernelVal = kernel[ky * kerWidth + kx] * kerScalar;
                            rSum += r * kernelVal;
                            gSum += g * kernelVal;
                            bSum += b * kernelVal;
                            kSum += kernelVal;
                        }
                    }
                    if (kSum <= 0) kSum = 1;

                    if (saveBrightness) rSum /= kSum;
                    if (rSum < 0) rSum = 0;
                    if (rSum > 255) rSum = 255;

                    if (saveBrightness) gSum /= kSum;
                    if (gSum < 0) gSum = 0;
                    if (gSum > 255) gSum = 255;

                    if(saveBrightness) bSum /= kSum;
                    if (bSum < 0) bSum = 0;
                    if (bSum > 255) bSum = 255;

                    mono = (0.2125 * rSum) + (0.7154 * gSum) + (0.0721 * bSum);

                    if (monochromeOutput) bmpOutput.SetPixel(x, y, Color.FromArgb((byte)mono, (byte)mono, (byte)mono));
                    else bmpOutput.SetPixel(x, y, Color.FromArgb((byte)rSum, (byte)gSum, (byte)bSum));


                    rgbOutput[3 * (srcWidth * y + x) + 0] = (byte)rSum;
                    rgbOutput[3 * (srcWidth * y + x) + 1] = (byte)gSum;
                    rgbOutput[3 * (srcWidth * y + x) + 2] = (byte)bSum;
                }

            }
            for (int y = 0; y < srcHeight; y++)
            {
                for (int x = 0; x < srcWidth; x++)
                {
                    //bmpOutput[3 * (y * srcWidth + x) + 0] = 
                }
            }
            //bmpOutput = new Bitmap(new MemoryStream(rgbOutput));
            
        }
        public void InitKernel()
        {
            kerWidth = 3;
            kerHeight = 3;
            saveBrightness = true;
            kernel = new int[kerWidth * kerHeight];
        }

        public void SetKernelValue(int x, int y, float value)
        {
            if (x == -1 && y == -1) kerScalar = value;
            else kernel[y * kerWidth + x] = (int)value;
        }
        public int GetKernelValue(int x, int y)
        {
            return kernel[y * kerWidth + x];
        }
        public Image GetImage()
        {
            return imgSource;
        }
        public void SetImage(Image image)
        {
            imgSource = image;
            sourceIsInit = false;
        } 
        public Bitmap getOutputBMP()
        {
            return bmpOutput;
        }
        public void SaveBrightness(bool status)
        {
            saveBrightness = status;
        }
        public void MonochromeOutput(bool status)
        {
            monochromeOutput = status;
        }
    }
}
