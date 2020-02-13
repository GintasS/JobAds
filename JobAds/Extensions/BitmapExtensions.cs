using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace JobAds.Extensions
{
    // Custom Bitmap extensions.
    public static class BitmapExtensions
    {
        // Compare two bitmaps for their bytes.
        // This code snippet was copied from stackoverflow.
        public static bool CompareBitmapsFast(this Bitmap bmp1, Bitmap bmp2)
        {
            if (bmp1 == null || bmp2 == null)
            {
                return false;
            }
            if (Equals(bmp1, bmp2))
            {
                return true;
            }
            if (!bmp1.Size.Equals(bmp2.Size) || !bmp1.PixelFormat.Equals(bmp2.PixelFormat))
            {
                return false;
            }

            var bytes = bmp1.Width * bmp1.Height * (Image.GetPixelFormatSize(bmp1.PixelFormat) / 8);

            var result = true;
            var b1bytes = new byte[bytes];
            var b2bytes = new byte[bytes];

            var bitmapData1 = bmp1.LockBits(new Rectangle(0, 0, bmp1.Width, bmp1.Height), ImageLockMode.ReadOnly, bmp1.PixelFormat);
            var bitmapData2 = bmp2.LockBits(new Rectangle(0, 0, bmp2.Width, bmp2.Height), ImageLockMode.ReadOnly, bmp2.PixelFormat);

            Marshal.Copy(bitmapData1.Scan0, b1bytes, 0, bytes);
            Marshal.Copy(bitmapData2.Scan0, b2bytes, 0, bytes);

            for (int n = 0; n <= bytes - 1; n++)
            {
                if (b1bytes[n] != b2bytes[n])
                {
                    result = false;
                    break;
                }
            }
            
            bmp1.UnlockBits(bitmapData1);
            bmp2.UnlockBits(bitmapData2);

            return result;
        }



    }
}
