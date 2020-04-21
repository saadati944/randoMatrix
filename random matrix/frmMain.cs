using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_matrix
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        bool stop = false;

        private void clrLineColor_Click(object sender, EventArgs e)
        {
            cd.Color=((Control)sender).BackColor;
            if (cd.ShowDialog() == DialogResult.OK)
                ((Control)sender).BackColor = cd.Color;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (btnDraw.Text == "Draw")
            {
                log("drawing ...");
                stoped(false);
            }
            else
            {
                log("process stoped !!!");
                stoped();
            }
        }

        void log(string mes)
        {
            try
            {
                Invoke(new Action(() => lstLog.Items.Add(mes)));
            }
            catch { }
        }

        void stoped(bool istrue = true)
        {
            if (istrue)
            {
                foreach (Control x in this.Controls)
                    if (x != lblLog && x != btnDraw)
                        x.Enabled = true;
                stop = true;
                btnDraw.Text = "Draw";
            }
            else
            {       foreach (Control x in this.Controls)
                    if (x != lblLog && x != btnDraw)
                        x.Enabled = false;
                stop = false;
                btnDraw.Text = "Stop";
            }
        }
    }
}
