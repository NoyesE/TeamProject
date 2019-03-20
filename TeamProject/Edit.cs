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

        private void btnSaveCoffee_Click(object sender, EventArgs e)
        {
            
            Drink drink = (Drink)cmbCoffee.SelectedItem;
            if(drink == null)
            {
                Drink newDrink = new Drink();
                newDrink.DrinkName = cmbCoffee.Text;
                newDrink.BaseCost = Convert.ToDecimal(txtCost.Text);
                newDrink.AddOn1 = txtAdd1.Text;
                newDrink.AddOn2 = txtAdd2.Text;
                newDrink.AddOn3 = txtAdd3.Text;
                CoffeeDb.AddCoffee(newDrink);
                MessageBox.Show("Coffee Added");
            }

            else
            {
                drink.DrinkName = cmbCoffee.Text;
                drink.BaseCost = Convert.ToDecimal(txtCost.Text);
                drink.AddOn1 = txtAdd1.Text;
                drink.AddOn2 = txtAdd2.Text;
                drink.AddOn3 = txtAdd3.Text;
                CoffeeDb.Update(drink);
                MessageBox.Show("Coffee Updated");
            }
            
            
        }

        private void cmbCoffee_SelectedIndexChanged(object sender, EventArgs e)
        {
            Drink drink = (Drink)cmbCoffee.SelectedItem;
             

            txtCost.Text = drink.BaseCost.ToString();
            txtAdd1.Text = drink.AddOn1;
            txtAdd2.Text = drink.AddOn2;
            txtAdd3.Text = drink.AddOn3;

        }

        private void Edit_Load(object sender, EventArgs e)
        {
            PopulateCoffeeList();
        }

        private void PopulateCoffeeList()
        {
            List<Drink> drink = CoffeeDb.GetAllCoffee();

            cmbCoffee.DataSource = drink;
            cmbCoffee.DisplayMember = nameof(Drink.DrinkName);
        }
    }
}
