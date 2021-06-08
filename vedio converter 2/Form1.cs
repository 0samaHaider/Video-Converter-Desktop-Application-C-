using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vedio_converter_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            try
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    label1.Text = "Wait, Converting !! ";
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(fileDialog.FileName, @"C:\data\vedios.mp4", NReco.VideoConverter.Format.mp4);
                    MessageBox.Show("Convert Successfully !!");
                    label1.Text = "";
                }
                else
                {
                    MessageBox.Show("Try Again !");
                }
            }
            catch
            {
                MessageBox.Show("Invalid File ! \n Try Again with valid file  !");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }
    }
}
