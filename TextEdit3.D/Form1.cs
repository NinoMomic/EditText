using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace TextEdit3.D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOtvori_Click(object sender, EventArgs e)
        {
            string put = @"C:\Users\ucenik\source\repos\TextEdit3.D\" + txtBoxIme.Text + ".txt";

            try
            {
               
                using (FileStream fs = File.Create(put))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(txtBoxZapis.Text);
                  
                    fs.Write(info, 0, info.Length);
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private void btnOtvoriNovi_Click(object sender, EventArgs e)
        {
            string put = @"C:\Users\ucenik\source\repos\TextEdit3.D\" + txtBoxIme.Text + ".txt";

            try
            {

                using (FileStream fs = File.Create(put))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(txtBoxZapis.Text);

                    fs.Write(info, 0, info.Length);
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string put = @"C:\Users\ucenik\source\repos\TextEdit3.D\" + txtBoxIme.Text + ".txt";

            try
            {

                using (FileStream fs = File.Create(put))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(txtBoxZapis.Text);

                    fs.Write(info, 0, info.Length);
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
