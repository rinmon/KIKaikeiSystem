using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace PasswordMaker
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string source = textBox1.Text;
            byte[] sourcebyte = System.Text.Encoding.GetEncoding("SHIFT_JIS").GetBytes(source);
 
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            //or//MD5 md5 = MD5.Create()
 
            byte[] md5byte = md5.ComputeHash(sourcebyte);
 
            StringBuilder result = new StringBuilder();
            for (int i=0; i < md5byte.Length; i++) {
            result.Append(md5byte[i].ToString("x2"));
            }
            //または
            /*
            foreach (byte b in md5byte) {
            result.Append(b.ToString("x2"));
            }
            */
            //もしくは
            //string result = BitConverter.ToString(md5byte).ToLower().Replace("-","");
 
            textBox2.Text=result.ToString();
        }
    }
}
