namespace BandsPreprocessor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.cmbInputDirs = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.cmbBands = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtOutputPath = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.labelProgress = new System.Windows.Forms.ToolStripLabel();
            this.progBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picViewport = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.picBandB = new System.Windows.Forms.PictureBox();
            this.picBandG = new System.Windows.Forms.PictureBox();
            this.picBandR = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picViewport)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBandB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBandG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBandR)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel4,
            this.cmbInputDirs,
            this.toolStripSeparator4,
            this.toolStripLabel3,
            this.cmbBands,
            this.toolStripTextBox1,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.txtOutputPath,
            this.toolStripSeparator2,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.labelProgress,
            this.progBar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1078, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabel4.Text = "Folders:";
            // 
            // cmbInputDirs
            // 
            this.cmbInputDirs.DropDownWidth = 200;
            this.cmbInputDirs.Name = "cmbInputDirs";
            this.cmbInputDirs.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(70, 22);
            this.toolStripLabel3.Text = "Band Types:";
            // 
            // cmbBands
            // 
            this.cmbBands.DropDownWidth = 300;
            this.cmbBands.Items.AddRange(new object[] {
            "432 - Color Natural",
            "764 - Falso Color Urbano",
            "543 - Color Infrarrojo Vegetacion",
            "652 - Agricultura",
            "765 - Penetracion atmosferica",
            "562 - Vegetacion Saludable",
            "564 - Tierra/Agua",
            "753 - Natural con remocion atmosferica",
            "754 - Infrarrojo onda corta",
            "654 - Analisis vegetacion"});
            this.cmbBands.Name = "cmbBands";
            this.cmbBands.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox1.Text = "c:\\wel\\amba\\toprocess\\";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(63, 22);
            this.toolStripLabel1.Text = "OutputDir:";
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(100, 25);
            this.txtOutputPath.Text = "c:\\wel\\amba\\output\\";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(92, 22);
            this.toolStripButton2.Text = "Process Images";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // labelProgress
            // 
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(58, 22);
            this.labelProgress.Text = "Progress :";
            this.labelProgress.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // progBar
            // 
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(100, 22);
            this.progBar.Step = 1;
            this.progBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.21125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.78875F));
            this.tableLayoutPanel1.Controls.Add(this.picViewport, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1078, 681);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // picViewport
            // 
            this.picViewport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picViewport.Location = new System.Drawing.Point(3, 3);
            this.picViewport.Name = "picViewport";
            this.picViewport.Size = new System.Drawing.Size(793, 675);
            this.picViewport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picViewport.TabIndex = 2;
            this.picViewport.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.picBandB, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.picBandG, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.picBandR, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(802, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(273, 675);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // picBandB
            // 
            this.picBandB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBandB.Location = new System.Drawing.Point(3, 453);
            this.picBandB.Name = "picBandB";
            this.picBandB.Size = new System.Drawing.Size(267, 219);
            this.picBandB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBandB.TabIndex = 2;
            this.picBandB.TabStop = false;
            // 
            // picBandG
            // 
            this.picBandG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBandG.Location = new System.Drawing.Point(3, 228);
            this.picBandG.Name = "picBandG";
            this.picBandG.Size = new System.Drawing.Size(267, 219);
            this.picBandG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBandG.TabIndex = 1;
            this.picBandG.TabStop = false;
            // 
            // picBandR
            // 
            this.picBandR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBandR.Location = new System.Drawing.Point(3, 3);
            this.picBandR.Name = "picBandR";
            this.picBandR.Size = new System.Drawing.Size(267, 219);
            this.picBandR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBandR.TabIndex = 0;
            this.picBandR.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 706);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bands Combiner";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picViewport)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBandB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBandG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBandR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox cmbInputDirs;
        private System.Windows.Forms.ToolStripComboBox cmbBands;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picViewport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox picBandB;
        private System.Windows.Forms.PictureBox picBandG;
        private System.Windows.Forms.PictureBox picBandR;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtOutputPath;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripProgressBar progBar;
        private System.Windows.Forms.ToolStripLabel labelProgress;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

