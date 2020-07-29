using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageAnalyzer
{
    class Analyze
    {
        private const byte delta = 10;

        ImagePart customise = new ImagePart();
        ImagePart[] customises = new ImagePart[8];

        ImagePart newItemSend = new ImagePart();
        ImagePart newItemKeep = new ImagePart();
        ImagePart newItemQuick = new ImagePart();

        public Analyze()
        {
            
            customise.coords = new Point[]
            {
                new Point(387, 125),
                new Point(462, 134)
            };
            customise.colors = new Color[]
            {
                Color.FromArgb(79, 241, 238),
                Color.FromArgb(78, 242, 238)
            };

            newItemSend.coords = new Point[]
            {
                new Point(411, 116),
                new Point(500, 116)
            };
            newItemSend.colors = new Color[]
            {
                Color.FromArgb(239, 64, 99),
                Color.FromArgb(239, 64, 99)
            };


            newItemKeep.coords = new Point[]
            {
                new Point(233, 171),
                new Point(292, 171)
            };
            newItemKeep.colors = new Color[]
            {
                Color.FromArgb(239, 64, 99),
                Color.FromArgb(239, 64, 99)
            };
            
            newItemQuick.coords = new Point[]
            {
                new Point(100, 422),
                new Point(146, 422)
            };
            newItemQuick.colors = new Color[]
            {
                Color.FromArgb(239, 64, 99),
                Color.FromArgb(239, 64, 99)
            };

            customises[0].colors = new Color[]
            {
                Color.FromArgb(239, 64, 99)
            };
            customises[0].coords = new Point[]
            {
                new Point(190, 240)
            };
            customises[1].colors = new Color[]
            {
                Color.FromArgb(239, 64, 99)
            };
            customises[1].coords = new Point[]
            {
                new Point(380, 240)
            };
            customises[2].colors = new Color[]
            {
                Color.FromArgb(239, 64, 99)
            };
            customises[2].coords = new Point[]
            {
                new Point(550, 240)
            };
            customises[3].colors = new Color[]
            {
                Color.FromArgb(239, 64, 99)
            };
            customises[3].coords = new Point[]
            {
                new Point(730, 240)
            };
            customises[4].colors = new Color[]
            {
                Color.FromArgb(239, 64, 99)
            };
            customises[4].coords = new Point[]
            {
                new Point(190, 390)
            };
            customises[5].colors = new Color[]
            {
                Color.FromArgb(239, 64, 99)
            };
            customises[5].coords = new Point[]
            {
                new Point(380, 390)
            };
            customises[6].colors = new Color[]
            {
                Color.FromArgb(239, 64, 99)
            };
            customises[6].coords = new Point[]
            {
                new Point(550, 390)
            };
            customises[7].colors = new Color[]
            {
                Color.FromArgb(239, 64, 99)
            };
            customises[7].coords = new Point[]
            {
                new Point(730, 390)
            };
        }

        public string CheckTag(Bitmap image)
        {
            string s = "CUSTOMISE";
            for (int i = 0; i < customise.colors.Length; i++)
            {
                if (image.GetPixel(customise.coords[i].X, customise.coords[i].Y) != customise.colors[i])
                {
                    s = "";
                    break;
                }
            }
            if (s != "")
                return s;

            s = "SEND";
            for (int i = 0; i < newItemSend.colors.Length; i++)
            {
                if (image.GetPixel(newItemSend.coords[i].X, newItemSend.coords[i].Y) != newItemSend.colors[i])
                {
                    s = "";
                    break;
                }
            }
            if (s != "")
                return s;

            s = "KEEP";
            for (int i = 0; i < newItemKeep.colors.Length; i++)
            {
                if (image.GetPixel(newItemKeep.coords[i].X, newItemKeep.coords[i].Y) != newItemKeep.colors[i])
                {
                    s = "";
                    break;
                }
            }
            if (s != "")
                return s;

            s = "QUICK";
            for (int i = 0; i < newItemQuick.colors.Length; i++)
            {
                if (image.GetPixel(newItemQuick.coords[i].X, newItemQuick.coords[i].Y) != newItemQuick.colors[i])
                {
                    s = "";
                    break;
                }
            }
            if (s != "")
                return s;

            return "не подлежит анализу";
        }

        public void AnalyzeCustomise(Bitmap image, Label label)
        {
            for(int i = 0; i < customises.Length; i++)
                for(int k = 0; k < customises[i].coords.Length; k++)
                {
                    if (image.GetPixel(customises[i].coords[k].X, customises[i].coords[k].Y) != customises[i].colors[k])
                        break;

                    if(k == customises[i].coords.Length - 1)
                    {
                        label.Text = "Position: " + (i + 1).ToString();
                        return;
                    }
                }
        }
        public int CheckNewItems(Bitmap image)
        {

            return 0;
        }
        //public void AnalyzeKeepItem(Label elementsAmount, Label )
        //{

        //}

        struct ImagePart
        {
            public Point[] coords;
            public Color[] colors;
        }
    }
}
