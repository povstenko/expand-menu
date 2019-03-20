using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpandMenuDemo
{
    public partial class fDemo : Form
    {
        const int offset = 10;

        public fDemo()
        {
            InitializeComponent();
            InitializeExpandMenu();
        }

        // ExpandMenu
        private void InitializeExpandMenu()
        {
            b1.Tag = 0;
            b2.Tag = 0;
            b3.Tag = 0;

            b2.Width = b1.Width;
            b3.Width = b1.Width;

            b2.Height = b1.Height;
            b3.Height = b1.Height;

            p1.Width = b1.Width;
            p2.Width = b2.Width;
            p3.Width = b3.Width;

            b1.Top = offset;
            b2.Top = b1.Bottom + offset;
            b3.Top = b2.Bottom + offset;
        }
        private void ExpandMenu1_Click(object sender, EventArgs e)
        {
            if ((int)b1.Tag == 0)
            {
                // expand
                b1.Image = global::ExpandMenuDemo.Properties.Resources.icons8_collapse_arrow_24;
                p1.Top = b1.Bottom;
                p1.Visible = true;

                b2.Top = p1.Bottom + offset;
                p2.Top = b2.Bottom;

                if ((int)b2.Tag == 0)
                    b3.Top = b2.Bottom + offset;
                else
                    b3.Top = p2.Bottom + offset;

                p3.Top = b3.Bottom;

                b1.Tag = 1;
            }
            else
            {
                // hide
                b1.Image = global::ExpandMenuDemo.Properties.Resources.icons8_expand_arrow_24;
                p1.Visible = false;

                b2.Top = b1.Bottom + offset;
                p2.Top = b2.Bottom;

                if ((int)b2.Tag == 0)
                    b3.Top = b2.Bottom + offset;
                else
                    b3.Top = p2.Bottom + offset;

                p3.Top = b3.Bottom;

                b1.Tag = 0;
            }
        }
        private void ExpandMenu2_Click(object sender, EventArgs e)
        {
            if ((int)b2.Tag == 0)
            {
                // expand
                b2.Image = global::ExpandMenuDemo.Properties.Resources.icons8_collapse_arrow_24;
                p2.Top = b2.Bottom;
                p2.Visible = true;

                b3.Top = p2.Bottom + offset;
                p3.Top = b3.Bottom;

                b2.Tag = 1;
            }
            else
            {
                // hide
                b2.Image = global::ExpandMenuDemo.Properties.Resources.icons8_expand_arrow_24;
                p2.Visible = false;

                b3.Top = b2.Bottom + offset;
                p3.Top = b3.Bottom;

                b2.Tag = 0;
            }
        }
        private void ExpandMenu3_Click(object sender, EventArgs e)
        {
            if ((int)b3.Tag == 0)
            {
                // expand
                b3.Image = global::ExpandMenuDemo.Properties.Resources.icons8_collapse_arrow_24;
                p3.Top = b3.Bottom;
                p3.Visible = true;

                b3.Tag = 1;
            }
            else
            {
                // hide
                b3.Image = global::ExpandMenuDemo.Properties.Resources.icons8_expand_arrow_24;
                p3.Visible = false;

                b3.Tag = 0;
            }
        }
    }
}