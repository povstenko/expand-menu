namespace ExpandMenuDemo
{
    partial class fDemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDemo));
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.Panel();
            this.p2 = new System.Windows.Forms.Panel();
            this.p3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p1.SuspendLayout();
            this.p2.SuspendLayout();
            this.p3.SuspendLayout();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.Menu;
            this.b1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b1.FlatAppearance.BorderSize = 0;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b1.Image = ((System.Drawing.Image)(resources.GetObject("b1.Image")));
            this.b1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b1.Location = new System.Drawing.Point(12, 12);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(588, 40);
            this.b1.TabIndex = 0;
            this.b1.Tag = "0";
            this.b1.Text = "Item1";
            this.b1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.ExpandMenu1_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.SystemColors.Menu;
            this.b2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b2.FlatAppearance.BorderSize = 0;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b2.Image = ((System.Drawing.Image)(resources.GetObject("b2.Image")));
            this.b2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b2.Location = new System.Drawing.Point(12, 147);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(267, 23);
            this.b2.TabIndex = 1;
            this.b2.Tag = "0";
            this.b2.Text = "Item2";
            this.b2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.ExpandMenu2_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.SystemColors.Menu;
            this.b3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b3.FlatAppearance.BorderSize = 0;
            this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b3.Image = ((System.Drawing.Image)(resources.GetObject("b3.Image")));
            this.b3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b3.Location = new System.Drawing.Point(12, 282);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(267, 23);
            this.b3.TabIndex = 2;
            this.b3.Tag = "0";
            this.b3.Text = "Item3";
            this.b3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.ExpandMenu3_Click);
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Silver;
            this.p1.Controls.Add(this.label1);
            this.p1.Location = new System.Drawing.Point(12, 41);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(267, 100);
            this.p1.TabIndex = 3;
            this.p1.Visible = false;
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.Silver;
            this.p2.Controls.Add(this.label2);
            this.p2.Location = new System.Drawing.Point(12, 176);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(267, 100);
            this.p2.TabIndex = 4;
            this.p2.Visible = false;
            // 
            // p3
            // 
            this.p3.BackColor = System.Drawing.Color.Silver;
            this.p3.Controls.Add(this.label3);
            this.p3.Location = new System.Drawing.Point(12, 311);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(267, 100);
            this.p3.TabIndex = 5;
            this.p3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "content1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "content2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "content3";
            // 
            // fDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 461);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Name = "fDemo";
            this.Text = "ExpandMenu Demo";
            this.p1.ResumeLayout(false);
            this.p1.PerformLayout();
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            this.p3.ResumeLayout(false);
            this.p3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Panel p3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

