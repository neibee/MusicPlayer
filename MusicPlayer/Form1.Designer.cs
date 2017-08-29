namespace MusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox = new System.Windows.Forms.ListBox();
            this.playBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.songNameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.preBtn = new System.Windows.Forms.Button();
            this.volTrackBar = new System.Windows.Forms.TrackBar();
            this.posTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBox.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(456, 14);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(218, 355);
            this.listBox.TabIndex = 0;
            this.listBox.Click += new System.EventHandler(this.listBox_Click);
            this.listBox.DoubleClick += new System.EventHandler(this.listBox_DoubleClick);
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.playBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playBtn.BackgroundImage")));
            this.playBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playBtn.Location = new System.Drawing.Point(125, 57);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(35, 34);
            this.playBtn.TabIndex = 2;
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.openBtn.Location = new System.Drawing.Point(364, 51);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(65, 40);
            this.openBtn.TabIndex = 3;
            this.openBtn.Text = "Browse";
            this.openBtn.UseCompatibleTextRendering = true;
            this.openBtn.UseVisualStyleBackColor = false;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.Multiselect = true;
            // 
            // pauseBtn
            // 
            this.pauseBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pauseBtn.BackgroundImage = global::MusicPlayer.Properties.Resources.pause_128;
            this.pauseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pauseBtn.ForeColor = System.Drawing.Color.Transparent;
            this.pauseBtn.Location = new System.Drawing.Point(68, 57);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(35, 34);
            this.pauseBtn.TabIndex = 4;
            this.pauseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pauseBtn.UseVisualStyleBackColor = false;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // songNameLabel
            // 
            this.songNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.songNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.songNameLabel.Location = new System.Drawing.Point(12, 14);
            this.songNameLabel.Name = "songNameLabel";
            this.songNameLabel.Size = new System.Drawing.Size(435, 40);
            this.songNameLabel.TabIndex = 5;
            this.songNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.posTrackBar);
            this.groupBox1.Controls.Add(this.nextBtn);
            this.groupBox1.Controls.Add(this.preBtn);
            this.groupBox1.Controls.Add(this.volTrackBar);
            this.groupBox1.Controls.Add(this.playBtn);
            this.groupBox1.Controls.Add(this.pauseBtn);
            this.groupBox1.Controls.Add(this.openBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(12, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 104);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Buttons";
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nextBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextBtn.BackgroundImage")));
            this.nextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextBtn.Location = new System.Drawing.Point(182, 57);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(35, 34);
            this.nextBtn.TabIndex = 9;
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // preBtn
            // 
            this.preBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.preBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("preBtn.BackgroundImage")));
            this.preBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.preBtn.ForeColor = System.Drawing.Color.Transparent;
            this.preBtn.Location = new System.Drawing.Point(12, 57);
            this.preBtn.Name = "preBtn";
            this.preBtn.Size = new System.Drawing.Size(35, 34);
            this.preBtn.TabIndex = 8;
            this.preBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.preBtn.UseVisualStyleBackColor = false;
            this.preBtn.Click += new System.EventHandler(this.preBtn_Click);
            // 
            // volTrackBar
            // 
            this.volTrackBar.AutoSize = false;
            this.volTrackBar.BackColor = System.Drawing.SystemColors.Desktop;
            this.volTrackBar.Location = new System.Drawing.Point(240, 63);
            this.volTrackBar.Maximum = 100;
            this.volTrackBar.Name = "volTrackBar";
            this.volTrackBar.Size = new System.Drawing.Size(108, 22);
            this.volTrackBar.TabIndex = 7;
            this.volTrackBar.TickFrequency = 5;
            this.volTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volTrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.volTrackBar.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // posTrackBar
            // 
            this.posTrackBar.AutoSize = false;
            this.posTrackBar.BackColor = System.Drawing.SystemColors.Desktop;
            this.posTrackBar.Location = new System.Drawing.Point(12, 20);
            this.posTrackBar.Maximum = 100;
            this.posTrackBar.Name = "posTrackBar";
            this.posTrackBar.Size = new System.Drawing.Size(417, 22);
            this.posTrackBar.TabIndex = 10;
            this.posTrackBar.TickFrequency = 5;
            this.posTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(683, 383);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.songNameLabel);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Music Box";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.volTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Label songNameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar volTrackBar;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button preBtn;
        private System.Windows.Forms.TrackBar posTrackBar;
    }
}

