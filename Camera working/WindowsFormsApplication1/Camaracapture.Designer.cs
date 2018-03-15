namespace WindowsFormsApplication1
{
    partial class Camaracapture
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
            this.components = new System.ComponentModel.Container();
            this.camimagebox = new System.Windows.Forms.PictureBox();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cuboidbtn = new System.Windows.Forms.Button();
            this.cylinderbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cropbtn = new System.Windows.Forms.Button();
            this.Rmax = new System.Windows.Forms.TrackBar();
            this.heighttbx = new System.Windows.Forms.TextBox();
            this.Rmin = new System.Windows.Forms.TrackBar();
            this.Gmax = new System.Windows.Forms.TrackBar();
            this.seriallbl = new System.Windows.Forms.Label();
            this.Gmin = new System.Windows.Forms.TrackBar();
            this.Bmax = new System.Windows.Forms.TrackBar();
            this.widthtbx = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Bmin = new System.Windows.Forms.TrackBar();
            this.cuboidbtnsdaf = new System.Windows.Forms.Button();
            this.cylinderbtnasd = new System.Windows.Forms.Button();
            this.processedimagebox = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.camimagebox)).BeginInit();
            this.toolPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedimagebox)).BeginInit();
            this.SuspendLayout();
            // 
            // camimagebox
            // 
            this.camimagebox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.camimagebox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.camimagebox.Location = new System.Drawing.Point(0, -1);
            this.camimagebox.Name = "camimagebox";
            this.camimagebox.Size = new System.Drawing.Size(510, 504);
            this.camimagebox.TabIndex = 4;
            this.camimagebox.TabStop = false;
            this.camimagebox.Click += new System.EventHandler(this.camimagebox_Click);
            this.camimagebox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.camimagebox_MouseDown);
            this.camimagebox.MouseEnter += new System.EventHandler(this.camimagebox_MouseEnter);
            this.camimagebox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.camimagebox_MouseMove);
            this.camimagebox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.camimagebox_MouseUp);
            // 
            // toolPanel
            // 
            this.toolPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toolPanel.BackColor = System.Drawing.Color.SeaShell;
            this.toolPanel.Controls.Add(this.connect);
            this.toolPanel.Controls.Add(this.label1);
            this.toolPanel.Controls.Add(this.cuboidbtn);
            this.toolPanel.Controls.Add(this.cylinderbtn);
            this.toolPanel.Controls.Add(this.label2);
            this.toolPanel.Controls.Add(this.label3);
            this.toolPanel.Controls.Add(this.cropbtn);
            this.toolPanel.Controls.Add(this.Rmax);
            this.toolPanel.Controls.Add(this.heighttbx);
            this.toolPanel.Controls.Add(this.Rmin);
            this.toolPanel.Controls.Add(this.Gmax);
            this.toolPanel.Controls.Add(this.seriallbl);
            this.toolPanel.Controls.Add(this.Gmin);
            this.toolPanel.Controls.Add(this.Bmax);
            this.toolPanel.Controls.Add(this.widthtbx);
            this.toolPanel.Controls.Add(this.comboBox1);
            this.toolPanel.Controls.Add(this.Bmin);
            this.toolPanel.Controls.Add(this.cuboidbtnsdaf);
            this.toolPanel.Controls.Add(this.cylinderbtnasd);
            this.toolPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toolPanel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolPanel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toolPanel.Location = new System.Drawing.Point(0, 368);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(1028, 154);
            this.toolPanel.TabIndex = 6;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(430, 16);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(73, 24);
            this.connect.TabIndex = 60;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 59;
            // 
            // cuboidbtn
            // 
            this.cuboidbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cuboidbtn.Location = new System.Drawing.Point(917, 66);
            this.cuboidbtn.Name = "cuboidbtn";
            this.cuboidbtn.Size = new System.Drawing.Size(75, 23);
            this.cuboidbtn.TabIndex = 58;
            this.cuboidbtn.Text = "Cuboid";
            this.cuboidbtn.UseVisualStyleBackColor = true;
            this.cuboidbtn.Click += new System.EventHandler(this.cuboidbtn_Click);
            // 
            // cylinderbtn
            // 
            this.cylinderbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cylinderbtn.Location = new System.Drawing.Point(824, 66);
            this.cylinderbtn.Name = "cylinderbtn";
            this.cylinderbtn.Size = new System.Drawing.Size(75, 23);
            this.cylinderbtn.TabIndex = 57;
            this.cylinderbtn.Text = "Cylinder";
            this.cylinderbtn.UseVisualStyleBackColor = true;
            this.cylinderbtn.Click += new System.EventHandler(this.cylinderbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 51;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 52;
            this.label3.Text = "Height";
            // 
            // cropbtn
            // 
            this.cropbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cropbtn.BackColor = System.Drawing.Color.White;
            this.cropbtn.Location = new System.Drawing.Point(863, 16);
            this.cropbtn.Name = "cropbtn";
            this.cropbtn.Size = new System.Drawing.Size(75, 29);
            this.cropbtn.TabIndex = 50;
            this.cropbtn.Text = "Crop";
            this.cropbtn.UseVisualStyleBackColor = false;
            this.cropbtn.Click += new System.EventHandler(this.cropbtn_Click_1);
            // 
            // Rmax
            // 
            this.Rmax.Location = new System.Drawing.Point(479, 105);
            this.Rmax.Maximum = 256;
            this.Rmax.Name = "Rmax";
            this.Rmax.Size = new System.Drawing.Size(227, 45);
            this.Rmax.TabIndex = 47;
            this.Rmax.TickFrequency = 25;
            this.Rmax.Value = 255;
            // 
            // heighttbx
            // 
            this.heighttbx.Location = new System.Drawing.Point(272, 43);
            this.heighttbx.Name = "heighttbx";
            this.heighttbx.Size = new System.Drawing.Size(135, 26);
            this.heighttbx.TabIndex = 54;
            this.heighttbx.Text = "10";
            // 
            // Rmin
            // 
            this.Rmin.Location = new System.Drawing.Point(479, 66);
            this.Rmin.Maximum = 256;
            this.Rmin.Name = "Rmin";
            this.Rmin.Size = new System.Drawing.Size(227, 45);
            this.Rmin.TabIndex = 43;
            this.Rmin.TickFrequency = 25;
            // 
            // Gmax
            // 
            this.Gmax.Location = new System.Drawing.Point(251, 105);
            this.Gmax.Maximum = 256;
            this.Gmax.Name = "Gmax";
            this.Gmax.Size = new System.Drawing.Size(227, 45);
            this.Gmax.TabIndex = 46;
            this.Gmax.TickFrequency = 25;
            this.Gmax.Value = 255;
            // 
            // seriallbl
            // 
            this.seriallbl.AutoSize = true;
            this.seriallbl.Location = new System.Drawing.Point(19, 16);
            this.seriallbl.Name = "seriallbl";
            this.seriallbl.Size = new System.Drawing.Size(110, 19);
            this.seriallbl.TabIndex = 49;
            this.seriallbl.Text = "Select any ports";
            // 
            // Gmin
            // 
            this.Gmin.Location = new System.Drawing.Point(251, 66);
            this.Gmin.Maximum = 256;
            this.Gmin.Name = "Gmin";
            this.Gmin.Size = new System.Drawing.Size(227, 45);
            this.Gmin.TabIndex = 44;
            this.Gmin.TickFrequency = 25;
            // 
            // Bmax
            // 
            this.Bmax.Location = new System.Drawing.Point(18, 105);
            this.Bmax.Maximum = 256;
            this.Bmax.Name = "Bmax";
            this.Bmax.Size = new System.Drawing.Size(227, 45);
            this.Bmax.TabIndex = 45;
            this.Bmax.TickFrequency = 25;
            this.Bmax.Value = 255;
            // 
            // widthtbx
            // 
            this.widthtbx.Location = new System.Drawing.Point(74, 40);
            this.widthtbx.Name = "widthtbx";
            this.widthtbx.Size = new System.Drawing.Size(135, 26);
            this.widthtbx.TabIndex = 53;
            this.widthtbx.Text = "10";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(272, 27);
            this.comboBox1.TabIndex = 48;
            // 
            // Bmin
            // 
            this.Bmin.Location = new System.Drawing.Point(18, 66);
            this.Bmin.Maximum = 256;
            this.Bmin.Name = "Bmin";
            this.Bmin.Size = new System.Drawing.Size(227, 45);
            this.Bmin.TabIndex = 42;
            this.Bmin.TickFrequency = 25;
            // 
            // cuboidbtnsdaf
            // 
            this.cuboidbtnsdaf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cuboidbtnsdaf.BackColor = System.Drawing.Color.SaddleBrown;
            this.cuboidbtnsdaf.Location = new System.Drawing.Point(824, 217);
            this.cuboidbtnsdaf.Name = "cuboidbtnsdaf";
            this.cuboidbtnsdaf.Size = new System.Drawing.Size(75, 23);
            this.cuboidbtnsdaf.TabIndex = 56;
            this.cuboidbtnsdaf.UseVisualStyleBackColor = false;
            // 
            // cylinderbtnasd
            // 
            this.cylinderbtnasd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cylinderbtnasd.Location = new System.Drawing.Point(743, 217);
            this.cylinderbtnasd.Name = "cylinderbtnasd";
            this.cylinderbtnasd.Size = new System.Drawing.Size(75, 23);
            this.cylinderbtnasd.TabIndex = 55;
            this.cylinderbtnasd.Text = "Cylinder";
            this.cylinderbtnasd.UseVisualStyleBackColor = true;
            // 
            // processedimagebox
            // 
            this.processedimagebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.processedimagebox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.processedimagebox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.processedimagebox.Location = new System.Drawing.Point(523, 0);
            this.processedimagebox.Name = "processedimagebox";
            this.processedimagebox.Size = new System.Drawing.Size(505, 504);
            this.processedimagebox.TabIndex = 43;
            this.processedimagebox.TabStop = false;
            // 
            // Camaracapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 521);
            this.Controls.Add(this.toolPanel);
            this.Controls.Add(this.camimagebox);
            this.Controls.Add(this.processedimagebox);
            this.Name = "Camaracapture";
            this.Text = "Camara Output";
            this.Load += new System.EventHandler(this.Camaracapture_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Camaracapture_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.camimagebox)).EndInit();
            this.toolPanel.ResumeLayout(false);
            this.toolPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedimagebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox camimagebox;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cropbtn;
        private System.Windows.Forms.TrackBar Rmax;
        private System.Windows.Forms.TextBox heighttbx;
        private System.Windows.Forms.TrackBar Rmin;
        private System.Windows.Forms.TrackBar Gmax;
        private System.Windows.Forms.Label seriallbl;
        private System.Windows.Forms.TrackBar Gmin;
        private System.Windows.Forms.TrackBar Bmax;
        private System.Windows.Forms.TextBox widthtbx;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TrackBar Bmin;
        private System.Windows.Forms.Button cuboidbtnsdaf;
        private System.Windows.Forms.Button cylinderbtnasd;
        private System.Windows.Forms.PictureBox processedimagebox;
        private System.Windows.Forms.Button cuboidbtn;
        private System.Windows.Forms.Button cylinderbtn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connect;
    }
}

