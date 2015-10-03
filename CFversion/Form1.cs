using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;


namespace CFversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getFrameworkVersion();
        }


        public void getFrameworkVersion()
        {

            RegistryKey cfReg = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\.NETCompactFramework", true);
            String[] values = cfReg.GetValueNames();
            label2.Text = values[0];
        }
    
    
    }
}