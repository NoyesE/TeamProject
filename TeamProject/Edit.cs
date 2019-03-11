using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace TeamProject
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = "";
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open text file";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string location = theDialog.FileName.ToString();
                txt = System.IO.File.ReadAllText(location);
            }
            txtField.Text = txt;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txtField.Text = Encrypt.EncryptString(txtField.Text, "123");
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            txtField.Text = Encrypt.DecryptString(txtField.Text, "123");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            
                string data = txtField.Text;

                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Text File (*.txt)|*.txt";
                dialog.FileName = "example";
                //File.WriteAllText(@"C:\test.txt", data);

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    //Filename includes full path
                    string fileName = dialog.FileName;
                    File.WriteAllText(fileName, data);
                    MessageBox.Show("Data Saved");
                }

            
        }
    }
}
