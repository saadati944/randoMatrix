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
            cd.Color = ((Control)sender).BackColor;
            if (cd.ShowDialog() == DialogResult.OK)
                ((Control)sender).BackColor = cd.Color;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (btnDraw.Text == "Draw")
            {
                log("drawing ...");
                Task.Run(new Action(() => draw((int)numCount.Value, (int)numCons.Value, (int)numPointSize.Value, (int)numLineWidth.Value, (int)numWidth.Value, (int)numHeight.Value, clrBackcolor.BackColor, clrPointColor.BackColor, clrLineColor.BackColor, txtSaveTo.Text)));
                stoped(false);
            }
            else
            {
                stop = true;
                btnDraw.Enabled = false;
                log("process is stoping !!!");
            }
        }

        void draw(int points, int cons, int psize, int lsize, int width, int height, Color bcolor, Color pcolor, Color lcolor, string path)
        {
            try
            {
                Bitmap b = new Bitmap(width, height);
                Graphics g = Graphics.FromImage(b as Image);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                if (stop) throw new Exception("user canseled.");
                log($"set background color to {bcolor.ToString()}");
                g.Clear(bcolor);
                if (stop) throw new Exception("user canseled.");

                Random r = new Random();
                if (stop) throw new Exception("user canseled.");

                log("create points list");
                List<Point> ps = new List<Point>();
                if (stop) throw new Exception("user canseled.");
                for (int i = 0; i < points; i++)
                    ps.Add(new Point(r.Next(0, width), r.Next(0, height)));
                if (stop) throw new Exception("user canseled.");
                log($"{points} points created");


                log("creating connections list");
                List<Rectangle> ls = new List<Rectangle>();
                if (stop) throw new Exception("user canseled.");
                for (int i = 0; i < cons; i++)
                {
                    if (stop) throw new Exception("user canseled.");
                    //maybe all connections are avaliable so app shouldn`t hang.
                    for (int j = 0; j < 100; j++)
                    {
                        if (stop) throw new Exception("user canseled.");
                        Point p1 = ps[r.Next(0, points)];
                        Point p2 = ps[r.Next(0, points)];
                        if (!ls.Contains(new Rectangle(p1.X, p1.Y, p2.X, p2.Y)) && !ls.Contains(new Rectangle(p2.X, p2.Y, p1.X, p1.Y)))
                        {
                            ls.Add(new Rectangle(p1.X, p1.Y, p2.X, p2.Y));
                            break;
                        }
                        log($"can`t create line {i}");
                    }
                }
                log($"{ls.Count}connections created");


                log("drawing lines");
                Pen lp = new Pen(lcolor, lsize);
                for (int i = 0; i < ls.Count; i++)
                {
                    if (stop) throw new Exception("user canseled.");
                    g.DrawLine(lp,ls[i].X,ls[i].Y, ls[i].Width, ls[i].Height);
                }
                log($"{ls.Count} lines drawed with this color : {lcolor.ToString()}");

                if (stop) throw new Exception("user canseled.");
                log("drawing points");
                for (int i = 0; i < points; i++)
                {
                    if (stop) throw new Exception("user canseled.");
                    g.FillEllipse(new SolidBrush(pcolor), ps[i].X - psize / 2, ps[i].Y - psize / 2, psize, psize);
                }
                log($"points drawed with this color : {pcolor.ToString()}");

                log("save file");
                if (stop) throw new Exception("user canseled.");
                b.Save(path);
                log($"file saved in {path}");
            }
            catch (Exception ex) { log(ex.Message); log("process ended because of errors."); }
            log("finish");
            stoped();
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
                    if (x != lblLog)
                        Invoke(new Action(() => x.Enabled = true));
                stop = true;
                Invoke(new Action(() => btnDraw.Text = "Draw"));

            }
            else
            {
                foreach (Control x in this.Controls)
                    if (x != lblLog && x != btnDraw)
                        Invoke(new Action(() => x.Enabled = false));
                stop = false;
                Invoke(new Action(() => btnDraw.Text = "Stop"));
            }
        }
    }
}