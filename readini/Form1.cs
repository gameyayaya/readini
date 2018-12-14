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

        public Form1()
        {
            InitializeComponent();
            ReadIniToMyApp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ini_1);
        }

        //要从Ini存进来的String , 
        string ini_1;
        string ini_2;
        string ini_3;
        string ini_4;
        string ini_5;
        string ini_6;
        string ini_7;
        string ini_8;
        string ini_9;
        private void ReadIniToMyApp()
        {
            //开Ini file
            var MyIni = new Ini(Application.StartupPath + "\\setting.ini");

            //读Ini 内容进来
            ini_1 = MyIni.GetValue("ini_1", "a");
            ini_2 = MyIni.GetValue("ini_2", "a");
            ini_3 = MyIni.GetValue("ini_3", "a");
            ini_4 = MyIni.GetValue("ini_4", "a");
            ini_5 = MyIni.GetValue("ini_5", "a");
            ini_6 = MyIni.GetValue("ini_6", "a");
            ini_7 = MyIni.GetValue("ini_7", "a");
            ini_8 = MyIni.GetValue("ini_8", "a");
            ini_9 = MyIni.GetValue("ini_9", "a");
        }

    }

        

}
