using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageAnalyzer
{
    static class ImageLoader
    {
        public static Bitmap Load(Label errorText, string url)
        {
            errorText.Text = "";
            try
            {
                var request = System.Net.WebRequest.Create(url);
                var response = request.GetResponse();

                using (var responseStream = response.GetResponseStream())
                {
                    return new Bitmap(responseStream);
                }
            }
            catch (System.Net.WebException ex)
            {
                errorText.Text = ex.Message;
                return null;
            }
        }
    }
}
