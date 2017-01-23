using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandsPreprocessor
{
    class cBitmapUtils
    {
        public static Image autoLevel(Image _image)
        {

            Bitmap temp = new Bitmap(_image.Width, _image.Height);

            temp = (Bitmap)_image;

            Color maxCol = new Color();
            Color minCol = new Color();

            for (int r = 0; r < _image.Width; r++)
            {
                for (int s = 0; s < _image.Height; s++)
                {

                    Color col = temp.GetPixel(r, s);

                    if (r == 0 && s == 0)
                    {
                        maxCol = col;
                        minCol = col;
                    }

                    if (col.R > maxCol.R) { maxCol = Color.FromArgb(255, col.R, maxCol.G, maxCol.B); }
                    if (col.G > maxCol.G) { maxCol = Color.FromArgb(255, maxCol.R, col.G, maxCol.B); }
                    if (col.B > maxCol.B) { maxCol = Color.FromArgb(255, maxCol.R, maxCol.G, col.B); }

                    if (col.R < minCol.R) { minCol = Color.FromArgb(255, col.R, minCol.G, minCol.B); }
                    if (col.G < minCol.G) { minCol = Color.FromArgb(255, minCol.R, col.G, minCol.B); }
                    if (col.B < minCol.B) { minCol = Color.FromArgb(255, minCol.R, minCol.G, col.B); }

                    // temp.SetPixel(r, s, Color.FromArgb(255, bandR.GetPixel(r, s).R, bandG.GetPixel(r, s).R, bandB.GetPixel(r, s).R));

                }
            }

            Color colorCorrection = Color.FromArgb(255, Convert.ToByte((255 / (maxCol.R - minCol.R))), Convert.ToByte((255 / (maxCol.G - minCol.G))), Convert.ToByte((255 / (maxCol.B - minCol.B))));

            for (int r = 0; r < _image.Width; r++)
            {
                for (int s = 0; s < _image.Height; s++)
                {

                    Color col = temp.GetPixel(r, s);

                    Color newColor = Color.FromArgb(col.A, Convert.ToByte(col.R * colorCorrection.R), Convert.ToByte(col.G * colorCorrection.G), Convert.ToByte(col.B * colorCorrection.B));

                    temp.SetPixel(r, s, newColor);

                }
            }

            return (Image)temp;
        }

        public static Image ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {

                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }

            }

            return (Image)destImage;
        }

    }
}
