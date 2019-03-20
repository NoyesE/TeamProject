using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopluateCoffeeList();
        }
        public void PopluateCoffeeList()
        {
            cboCoffee.DataSource = null;
            List<Drink> coffee = CoffeeDb.GetAllCoffee();

            //throw new NotImplementedException();
            cboCoffee.DataSource = coffee;
            cboCoffee.DisplayMember = nameof(Drink.DrinkName);
            chkPopulate();
        }

        private void chkPopulate()
        {
            Drink drink = (Drink)cboCoffee.SelectedItem;
            if (drink == null)
            {
                drink = new Drink();
            }
            chk1.Text = drink.AddOn1;
            chk2.Text = drink.AddOn2;
            chk3.Text = drink.AddOn3;
        }

        private void btnAddCoffee_Click(object sender, EventArgs e)
        {
            Drink d = new Drink();
            d.DrinkName = "Mocha";
            d.BaseCost = 7;

            CoffeeDb.AddCoffee(d);
            MessageBox.Show("Coffee Added!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit(this);
            edit.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer newCust = new Customer()
            {
                FirstName = "Candy",
                LastName = "Something",
                DateOfBirth = new DateTime(1980, 1, 1),
                DrinkName = "Iced Coffee"
            };

            newCust = CustomerDb.AddCustomer(newCust);
            MessageBox.Show("Customer added!");

            newCust.FirstName = "Jim";
            CustomerDb.Update(newCust);
            MessageBox.Show("Customer Updated!");

            CustomerDb.DeleteCustomer(newCust);
            MessageBox.Show("Customer deleted!");
        }

        private void cboCoffee_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkPopulate();
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            PopluateCoffeeList();
        }
    }
    public static class Encrypt
    {
        // This size of the IV (in bytes) must = (keysize / 8).  Default keysize is 256, so the IV must be
        // 32 bytes long.  Using a 16 character string here gives us 32 bytes when converted to a byte array.
        private const string initVector = "pemgail9uzpgzl88";
        // This constant is used to determine the keysize of the encryption algorithm
        private const int keysize = 256;
        //Encrypt
        public static string EncryptString(string plainText, string passPhrase)
        {
            byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
            byte[] keyBytes = password.GetBytes(keysize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] cipherTextBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            return Convert.ToBase64String(cipherTextBytes);
        }
        //Decrypt
        public static string DecryptString(string cipherText, string passPhrase)
        {
            byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
            byte[] keyBytes = password.GetBytes(keysize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
        }
    }
}
