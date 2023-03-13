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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public string filePath;
        public Form2()
        {
            InitializeComponent();
        }

        private void CreateFa_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == string.Empty)
                    throw new Exception("Напишите имя файла!");

                File.Create(filePath + "\\" + textBox1.Text);
                this.Close();

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

    }
}
