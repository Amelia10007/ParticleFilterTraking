using System;
using System.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ParticleFilterTraking
{
    static class Drawer
    {
        public static Bitmap Draw(Backend.Size size, Func<Backend.Position, Color> pixelMapper)
        {
            var bitmap = new Bitmap(size.Width, size.Height);
            var data = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format32bppArgb);
            byte[] buf = new byte[bitmap.Width * bitmap.Height * 4];
            Marshal.Copy(data.Scan0, buf, 0, buf.Length);
            int index = 0;
            foreach (var y in Enumerable.Range(0, size.Height))
            {
                foreach (var x in Enumerable.Range(0, size.Width))
                {
                    var position = new Backend.Position(x, y);
                    var pixel = pixelMapper(position);
                    buf[index++] = pixel.R;
                    buf[index++] = pixel.G;
                    buf[index++] = pixel.B;
                    buf[index++] = pixel.A;
                }
            }
            Marshal.Copy(buf, 0, data.Scan0, buf.Length);
            bitmap.UnlockBits(data);
            return bitmap;
        }
        public static Bitmap MergeBitmap(Bitmap bitmap1, Bitmap bitmap2)
        {
            if (bitmap1.Size != bitmap2.Size) throw new ArgumentException("Invalid pair of images.");
            var bitmap = new Bitmap(bitmap1.Size.Width, bitmap1.Size.Height);
            var data = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format32bppArgb);
            byte[] buf = new byte[bitmap.Width * bitmap.Height * 4];
            Marshal.Copy(data.Scan0, buf, 0, buf.Length);
            //
            var data1 = bitmap1.LockBits(
                new Rectangle(0, 0, bitmap1.Width, bitmap1.Height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format32bppArgb);
            byte[] buf1 = new byte[bitmap1.Width * bitmap1.Height * 4];
            Marshal.Copy(data1.Scan0, buf1, 0, buf1.Length);
            //
            var data2 = bitmap2.LockBits(
                new Rectangle(0, 0, bitmap2.Width, bitmap2.Height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format32bppArgb);
            byte[] buf2 = new byte[bitmap2.Width * bitmap2.Height * 4];
            Marshal.Copy(data2.Scan0, buf2, 0, buf2.Length);
            //
            int index = 0;
            foreach (var y in Enumerable.Range(0, bitmap.Size.Height))
            {
                foreach (var x in Enumerable.Range(0, bitmap.Size.Width))
                {
                    var position = new Backend.Position(x, y);
                    var r = (byte)(buf1[index] / 2 + buf2[index] / 2);
                    var g = (byte)(buf1[index + 1] / 2 + buf2[index + 1] / 2);
                    var b = (byte)(buf1[index + 2] / 2 + buf2[index + 2] / 2);
                    var a = (byte)(buf1[index + 3] / 2 + buf2[index + 3] / 2);
                    buf[index++] = r;
                    buf[index++] = g;
                    buf[index++] = b;
                    buf[index++] = a;
                }
            }
            Marshal.Copy(buf, 0, data.Scan0, buf.Length);
            bitmap.UnlockBits(data);
            return bitmap;
        }

    }
}
