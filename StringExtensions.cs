using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace JobAds.Extensions
{
    // Custom string extensions.
    public static class StringExtensions
    {
        public static string CustomReplace(this string str, string[][] needles)
        {
            if (needles == null)
            {
                return str;
            }

            foreach (var item in needles)
            {
                // Will only allow to use jagged aray with the length of 3.
                if (item.Length != 3)
                {
                    continue;
                }

                if (str.IndexOf(item[0]) == 0)
                {
                    str = str.Replace(item[0], item[1]) + item[2];
                }
            }

            return str.Trim();
        }

        public static string ReplaceWhiteSpace(this string str)
        {
            return new Regex(Constants.Regex.WhitespaceReplace)
                .Replace(str, Constants.Character.Space);
        }

        public static Bitmap SaveImage(this string imageUrl)
        {
            var client = new WebClient();
            Stream stream = null;
            Bitmap bitmap = null;

            try
            {
                stream = client.OpenRead(imageUrl);
                bitmap = new Bitmap(stream);
            }
            catch
            {
                bitmap = null;
            }
            finally
            {
                stream?.Flush();
                stream?.Close();
                client?.Dispose();
            }

            return bitmap;
        }

        public static string ReplaceNonDigit(this string str)
        {
            return new Regex(Constants.Regex.NonDigits)
                .Replace(str, string.Empty);
        }



    }
}