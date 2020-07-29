using Emgu.CV;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ImageAnalyzer
{
    public partial class MainForm : Form
    {
        Analyze analyze = new Analyze();
        Bitmap image;
        public MainForm()
        {
            InitializeComponent();
            LoadAndCheck();
        }

        private void LoadAndCheck()
        {
            pictureBox.Image = ImageLoader.Load(errorText, "http://185.80.129.249:4222/getImage");
            image = (Bitmap)pictureBox.Image;

            string tagStr = analyze.CheckTag(image);

            if (tagStr == "CUSTOMISE")
            {
                analyze.AnalyzeCustomise(image, customisesPos);
                customisePanel.Visible = true;
            }
            else
                customisePanel.Visible = false;

            if (tagStr == "KEEP" || tagStr == "QUICK" || tagStr == "SEND")
            {
                newItemPanel.Visible = true;
                sectionLabel.Text = "FUCK";
                if (tagStr == "KEEP")
                {
                    sectionLabel.Text = "Active section: KEEP ITEMS";
                    needToScroll.Text = "";
                }
                else if (tagStr == "QUICK")
                {
                    sectionLabel.Text = "Active section: QUICK SELL NOW";
                    needToScroll.Text = "Press up";
                }
                else
                {
                    sectionLabel.Text = "Active section: QUICK SELL NOW";
                    needToScroll.Text = "Press down";
                }

                tagStr = "NEW ITEM";
            }
            else
                newItemPanel.Visible = false;

            tag.Text = tagStr;
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            LoadAndCheck();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pos = int.Parse(customisesPos.Text.Remove(0, 10));
            int newPos = comboBox1.SelectedIndex + 1;
            string strMoves = "";
            while (pos != newPos)
            {
                if ((pos - 1) % 4 < (newPos - 1) % 4)
                {
                    strMoves += "right + ";
                    pos++;
                    continue;
                }
                else if ((pos - 1) % 4 > (newPos - 1) % 4)
                {
                    strMoves += "left + ";
                    pos--;
                    continue;
                }

                if (pos > newPos)
                {
                    strMoves += "up + ";
                    pos -= 4;
                }
                else if (pos < newPos)
                {
                    strMoves += "down + ";
                    pos += 4;
                }
            }

            if (strMoves != "")
                strMoves = strMoves.Remove(strMoves.Length - 3);

            moves.Text = strMoves;
        }
    }
}
