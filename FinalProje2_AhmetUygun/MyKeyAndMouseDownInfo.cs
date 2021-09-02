using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProje2_AhmetUygun
{
    public partial class MyKeyAndMouseDownInfo : Control
    {
        Label lbl = new Label();

        public MyKeyAndMouseDownInfo()
        {
            InitializeComponent();
            lbl.AutoSize = true;
            lbl.Top = 10;
            lbl.Left = 10;
            lbl.BackColor = Color.BurlyWood;
            lbl.Font = new Font("Arial", 20);
            lbl.ForeColor = Color.Green;
            lbl.Text = "herhangi bir tuşa basın";
            this.Controls.Add(lbl);
            KeyPress += new KeyPressEventHandler(keypressed);
            MouseUp += new MouseEventHandler(Form1_MouseDown);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        private void keypressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                lbl.Text = "Enter";
            else if (e.KeyChar == (char)Keys.Escape)
                lbl.Text = "Escape";
            else if (e.KeyChar == (char)Keys.Space)
                lbl.Text = "Space";
            else // normal tuşlar...(qwert..)
                lbl.Text = e.KeyChar.ToString();
        }



        void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
                lbl.Text = "Mouse Right";
            else if (e.Button == MouseButtons.Left)
                lbl.Text = "Mouse Left";
            else if (e.Button == MouseButtons.Middle)
                lbl.Text = "Mouse Middle";
            else
                lbl.Text = "not defined";
        }
    }
}
