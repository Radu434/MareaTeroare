namespace Marea_Teroare
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTask = new System.Windows.Forms.Panel();
            this.btnStalin = new System.Windows.Forms.Button();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblBar = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinMax = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlTask.SuspendLayout();
            this.pnlBar.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTask
            // 
            this.pnlTask.BackColor = System.Drawing.Color.Brown;
            this.pnlTask.Controls.Add(this.button4);
            this.pnlTask.Controls.Add(this.button3);
            this.pnlTask.Controls.Add(this.button2);
            this.pnlTask.Controls.Add(this.button1);
            this.pnlTask.Controls.Add(this.btnStalin);
            this.pnlTask.Controls.Add(this.pnlBar);
            this.pnlTask.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTask.Location = new System.Drawing.Point(0, 0);
            this.pnlTask.Name = "pnlTask";
            this.pnlTask.Size = new System.Drawing.Size(201, 671);
            this.pnlTask.TabIndex = 0;
            // 
            // btnStalin
            // 
            this.btnStalin.BackColor = System.Drawing.Color.Brown;
            this.btnStalin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStalin.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnStalin.FlatAppearance.BorderSize = 0;
            this.btnStalin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStalin.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStalin.ForeColor = System.Drawing.Color.Yellow;
            this.btnStalin.Image = ((System.Drawing.Image)(resources.GetObject("btnStalin.Image")));
            this.btnStalin.Location = new System.Drawing.Point(0, 27);
            this.btnStalin.Name = "btnStalin";
            this.btnStalin.Size = new System.Drawing.Size(201, 53);
            this.btnStalin.TabIndex = 1;
            this.btnStalin.Text = "Stalin";
            this.btnStalin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStalin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStalin.UseVisualStyleBackColor = false;
            this.btnStalin.Click += new System.EventHandler(this.btnStalin_Click);
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBar.Controls.Add(this.lblBar);
            this.pnlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBar.ForeColor = System.Drawing.Color.White;
            this.pnlBar.Location = new System.Drawing.Point(0, 0);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(201, 27);
            this.pnlBar.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.OrangeRed;
            this.pnlTop.Controls.Add(this.panel1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(201, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(926, 27);
            this.pnlTop.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 27);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnMinMax);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(926, 27);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Stalin";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(0, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "Stalin";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Brown;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Yellow;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(0, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 53);
            this.button3.TabIndex = 4;
            this.button3.Text = "Stalin";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Brown;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Yellow;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(0, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(201, 53);
            this.button4.TabIndex = 5;
            this.button4.Text = "Stalin";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // lblBar
            // 
            this.lblBar.AutoSize = true;
            this.lblBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBar.Font = new System.Drawing.Font("David Libre", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBar.ForeColor = System.Drawing.Color.White;
            this.lblBar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBar.Location = new System.Drawing.Point(0, 0);
            this.lblBar.Name = "lblBar";
            this.lblBar.Size = new System.Drawing.Size(206, 30);
            this.lblBar.TabIndex = 0;
            this.lblBar.Text = "Marea Teroare";
            this.lblBar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBar.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(891, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 27);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnMinMax
            // 
            this.btnMinMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMinMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinMax.BackgroundImage")));
            this.btnMinMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinMax.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnMinMax.FlatAppearance.BorderSize = 0;
            this.btnMinMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinMax.Location = new System.Drawing.Point(856, 0);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(35, 27);
            this.btnMinMax.TabIndex = 5;
            this.btnMinMax.UseVisualStyleBackColor = false;
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click_1);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMinimize.Location = new System.Drawing.Point(823, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(33, 27);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1127, 671);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlTask);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlTask.ResumeLayout(false);
            this.pnlBar.ResumeLayout(false);
            this.pnlBar.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTask;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnStalin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblBar;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMinMax;
        private System.Windows.Forms.Button btnClose;
    }
}

