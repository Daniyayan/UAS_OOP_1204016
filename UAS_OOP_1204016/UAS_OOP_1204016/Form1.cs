﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UAS_OOP_1204016
{
    public partial class Form1 : Form
    {
        private MySqlCommand cmd;
        private MySqlDataAdapter da;
        int result;
        private string url = "server=localhost;userid=root;password=;database=uas";
        public MySqlConnection GetConn()
        {
            MySqlConnection Conn = new MySqlConnection(url);
            return Conn;
        }

     
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void daftarIsiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transaksi frmtransaksi = new transaksi();
        }

        

        private void mahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputmhs frmmhs = new inputmhs();
        }

        private void prodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputprodi frmprodi = new inputprodi();
        }

        private void mahasiswaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            updatemhs frmupdate = new updatemhs();
        }

        private void prodiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            updateprodi frmupdatepro = new updateprodi();
        }

       
        private void mahasiswaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viewmhs frmviewmhs = new viewmhs();
          
        }

        
        private void prodiToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            viewprodi frmviewpro = new viewprodi();
        }

        private void dataTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewtransaksi frmupdatetrs = new viewtransaksi();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}