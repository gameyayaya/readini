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
using System.Reflection;
using System.Runtime.InteropServices;


namespace readini
{
    public partial class Form1 : Form
    {
        //要从Ini存进来的String , 
        string DefaultVolume;
        string HomePage;
        string Author;

        public Form1()
        {
            InitializeComponent();
            ReadIniToMyApp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Author);
        }

        private void ReadIniToMyApp()
        {
            //开Ini file
            var MyIni = new Ini(Application.StartupPath + "\\setting.ini");

            //读Ini 内容进来
            Author = MyIni.GetValue("Author", "a");
            DefaultVolume = MyIni.GetValue("DefaultVolume", "a");
            HomePage = MyIni.GetValue("HomePage", "a");
            

        }

    }

        

}
