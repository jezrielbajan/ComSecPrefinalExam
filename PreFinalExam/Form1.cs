﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;

namespace PreFinalExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process[] process = Process.GetProcesses();

            foreach (Process prs in process)
            {
                listBox1.Items.Add(prs.ProcessName + "(" + prs.PrivateMemorySize64.ToString() + ")");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\PreFinalExam-Vargas");
            key.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
}
