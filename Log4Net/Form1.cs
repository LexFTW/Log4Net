﻿using System;
using System.Configuration;
using System.Windows.Forms;
using log4net;

namespace Log4Net
{
    public partial class Form1 : Form
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(Form1));

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            logger.Info("Botón pulsado");
        }

        private void txtSettings_Click(object sender, EventArgs e)
        {
            var sAttr = ConfigurationManager.AppSettings["FileName"].ToString();
            MessageBox.Show(sAttr);
        }
    }
}
