namespace Puzzle_Game
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.btnImageClip9 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnImageClip8 = new System.Windows.Forms.Button();
            this.btnImageClip7 = new System.Windows.Forms.Button();
            this.btnImageClip6 = new System.Windows.Forms.Button();
            this.btnImageClip5 = new System.Windows.Forms.Button();
            this.btnImageClip4 = new System.Windows.Forms.Button();
            this.btnImageClip3 = new System.Windows.Forms.Button();
            this.btnImageClip2 = new System.Windows.Forms.Button();
            this.btnImageClip1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExist = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLevel = new System.Windows.Forms.Panel();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.lblClock = new System.Windows.Forms.Label();
            this.Check = new System.Windows.Forms.Timer(this.components);
            this.panelPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnReset.Location = new System.Drawing.Point(225, 512);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(131, 50);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnShuffle.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnShuffle.FlatAppearance.BorderSize = 2;
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnShuffle.Location = new System.Drawing.Point(225, 434);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(131, 50);
            this.btnShuffle.TabIndex = 15;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnStart.FlatAppearance.BorderSize = 2;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnStart.Location = new System.Drawing.Point(839, 453);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(131, 50);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panelPicture
            // 
            this.panelPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelPicture.Controls.Add(this.btnImageClip9);
            this.panelPicture.Controls.Add(this.btnImageClip8);
            this.panelPicture.Controls.Add(this.btnImageClip7);
            this.panelPicture.Controls.Add(this.btnImageClip6);
            this.panelPicture.Controls.Add(this.btnImageClip5);
            this.panelPicture.Controls.Add(this.btnImageClip4);
            this.panelPicture.Controls.Add(this.btnImageClip3);
            this.panelPicture.Controls.Add(this.btnImageClip2);
            this.panelPicture.Controls.Add(this.btnImageClip1);
            this.panelPicture.Location = new System.Drawing.Point(50, 72);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(487, 329);
            this.panelPicture.TabIndex = 13;
            // 
            // btnImageClip9
            // 
            this.btnImageClip9.AutoSize = true;
            this.btnImageClip9.BackColor = System.Drawing.Color.SteelBlue;
            this.btnImageClip9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImageClip9.FlatAppearance.BorderSize = 0;
            this.btnImageClip9.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageClip9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnImageClip9.ImageKey = "9.JPG";
            this.btnImageClip9.ImageList = this.imageList1;
            this.btnImageClip9.Location = new System.Drawing.Point(321, 221);
            this.btnImageClip9.Name = "btnImageClip9";
            this.btnImageClip9.Size = new System.Drawing.Size(163, 109);
            this.btnImageClip9.TabIndex = 27;
            this.btnImageClip9.Tag = "9";
            this.btnImageClip9.UseVisualStyleBackColor = false;
            this.btnImageClip9.Click += new System.EventHandler(this.btnImageClip9_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.JPG");
            this.imageList1.Images.SetKeyName(1, "2.JPG");
            this.imageList1.Images.SetKeyName(2, "3.JPG");
            this.imageList1.Images.SetKeyName(3, "4.JPG");
            this.imageList1.Images.SetKeyName(4, "5.JPG");
            this.imageList1.Images.SetKeyName(5, "6.JPG");
            this.imageList1.Images.SetKeyName(6, "7.JPG");
            this.imageList1.Images.SetKeyName(7, "8.JPG");
            this.imageList1.Images.SetKeyName(8, "9.JPG");
            this.imageList1.Images.SetKeyName(9, "null.JPG");
            // 
            // btnImageClip8
            // 
            this.btnImageClip8.AutoSize = true;
            this.btnImageClip8.BackColor = System.Drawing.Color.SteelBlue;
            this.btnImageClip8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImageClip8.FlatAppearance.BorderSize = 0;
            this.btnImageClip8.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageClip8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnImageClip8.ImageKey = "8.JPG";
            this.btnImageClip8.ImageList = this.imageList1;
            this.btnImageClip8.Location = new System.Drawing.Point(162, 221);
            this.btnImageClip8.Name = "btnImageClip8";
            this.btnImageClip8.Size = new System.Drawing.Size(163, 109);
            this.btnImageClip8.TabIndex = 26;
            this.btnImageClip8.Tag = "8";
            this.btnImageClip8.UseVisualStyleBackColor = false;
            this.btnImageClip8.Click += new System.EventHandler(this.btnImageClip8_Click);
            // 
            // btnImageClip7
            // 
            this.btnImageClip7.AutoSize = true;
            this.btnImageClip7.BackColor = System.Drawing.Color.SteelBlue;
            this.btnImageClip7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImageClip7.FlatAppearance.BorderSize = 0;
            this.btnImageClip7.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageClip7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnImageClip7.ImageKey = "7.JPG";
            this.btnImageClip7.ImageList = this.imageList1;
            this.btnImageClip7.Location = new System.Drawing.Point(3, 221);
            this.btnImageClip7.Name = "btnImageClip7";
            this.btnImageClip7.Size = new System.Drawing.Size(163, 109);
            this.btnImageClip7.TabIndex = 25;
            this.btnImageClip7.Tag = "7";
            this.btnImageClip7.UseVisualStyleBackColor = false;
            this.btnImageClip7.Click += new System.EventHandler(this.btnImageClip7_Click);
            // 
            // btnImageClip6
            // 
            this.btnImageClip6.AutoSize = true;
            this.btnImageClip6.BackColor = System.Drawing.Color.SteelBlue;
            this.btnImageClip6.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnImageClip6.FlatAppearance.BorderSize = 0;
            this.btnImageClip6.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageClip6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnImageClip6.ImageKey = "6.JPG";
            this.btnImageClip6.ImageList = this.imageList1;
            this.btnImageClip6.Location = new System.Drawing.Point(321, 112);
            this.btnImageClip6.Name = "btnImageClip6";
            this.btnImageClip6.Size = new System.Drawing.Size(163, 109);
            this.btnImageClip6.TabIndex = 24;
            this.btnImageClip6.Tag = "6";
            this.btnImageClip6.UseVisualStyleBackColor = false;
            this.btnImageClip6.Click += new System.EventHandler(this.btnImageClip6_Click);
            // 
            // btnImageClip5
            // 
            this.btnImageClip5.AutoSize = true;
            this.btnImageClip5.BackColor = System.Drawing.Color.SteelBlue;
            this.btnImageClip5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImageClip5.FlatAppearance.BorderSize = 0;
            this.btnImageClip5.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageClip5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnImageClip5.ImageKey = "5.JPG";
            this.btnImageClip5.ImageList = this.imageList1;
            this.btnImageClip5.Location = new System.Drawing.Point(162, 112);
            this.btnImageClip5.Name = "btnImageClip5";
            this.btnImageClip5.Size = new System.Drawing.Size(163, 109);
            this.btnImageClip5.TabIndex = 23;
            this.btnImageClip5.Tag = "5";
            this.btnImageClip5.UseVisualStyleBackColor = false;
            this.btnImageClip5.Click += new System.EventHandler(this.btnImageClip5_Click);
            // 
            // btnImageClip4
            // 
            this.btnImageClip4.AutoSize = true;
            this.btnImageClip4.BackColor = System.Drawing.Color.SteelBlue;
            this.btnImageClip4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImageClip4.FlatAppearance.BorderSize = 0;
            this.btnImageClip4.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageClip4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnImageClip4.ImageKey = "4.JPG";
            this.btnImageClip4.ImageList = this.imageList1;
            this.btnImageClip4.Location = new System.Drawing.Point(3, 112);
            this.btnImageClip4.Name = "btnImageClip4";
            this.btnImageClip4.Size = new System.Drawing.Size(163, 109);
            this.btnImageClip4.TabIndex = 22;
            this.btnImageClip4.Tag = "4";
            this.btnImageClip4.UseVisualStyleBackColor = false;
            this.btnImageClip4.Click += new System.EventHandler(this.btnImageClip4_Click);
            // 
            // btnImageClip3
            // 
            this.btnImageClip3.AutoSize = true;
            this.btnImageClip3.BackColor = System.Drawing.Color.SteelBlue;
            this.btnImageClip3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImageClip3.FlatAppearance.BorderSize = 0;
            this.btnImageClip3.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageClip3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnImageClip3.ImageKey = "3.JPG";
            this.btnImageClip3.ImageList = this.imageList1;
            this.btnImageClip3.Location = new System.Drawing.Point(321, 3);
            this.btnImageClip3.Name = "btnImageClip3";
            this.btnImageClip3.Size = new System.Drawing.Size(163, 109);
            this.btnImageClip3.TabIndex = 21;
            this.btnImageClip3.Tag = "3";
            this.btnImageClip3.UseVisualStyleBackColor = false;
            this.btnImageClip3.Click += new System.EventHandler(this.btnImageClip3_Click);
            // 
            // btnImageClip2
            // 
            this.btnImageClip2.AutoSize = true;
            this.btnImageClip2.BackColor = System.Drawing.Color.SteelBlue;
            this.btnImageClip2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImageClip2.FlatAppearance.BorderSize = 0;
            this.btnImageClip2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageClip2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnImageClip2.ImageKey = "2.JPG";
            this.btnImageClip2.ImageList = this.imageList1;
            this.btnImageClip2.Location = new System.Drawing.Point(162, 3);
            this.btnImageClip2.Name = "btnImageClip2";
            this.btnImageClip2.Size = new System.Drawing.Size(163, 109);
            this.btnImageClip2.TabIndex = 20;
            this.btnImageClip2.Tag = "2";
            this.btnImageClip2.UseVisualStyleBackColor = false;
            this.btnImageClip2.Click += new System.EventHandler(this.btnImageClip2_Click);
            // 
            // btnImageClip1
            // 
            this.btnImageClip1.AutoSize = true;
            this.btnImageClip1.BackColor = System.Drawing.Color.SteelBlue;
            this.btnImageClip1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImageClip1.FlatAppearance.BorderSize = 0;
            this.btnImageClip1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageClip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnImageClip1.ImageKey = "1.JPG";
            this.btnImageClip1.ImageList = this.imageList1;
            this.btnImageClip1.Location = new System.Drawing.Point(3, 3);
            this.btnImageClip1.Name = "btnImageClip1";
            this.btnImageClip1.Size = new System.Drawing.Size(163, 109);
            this.btnImageClip1.TabIndex = 19;
            this.btnImageClip1.Tag = "1";
            this.btnImageClip1.UseVisualStyleBackColor = false;
            this.btnImageClip1.Click += new System.EventHandler(this.btnImageClip1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(415, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 57);
            this.label1.TabIndex = 17;
            this.label1.Text = "Picture Puzzle Game";
            // 
            // btnExist
            // 
            this.btnExist.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExist.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnExist.FlatAppearance.BorderSize = 2;
            this.btnExist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExist.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnExist.Location = new System.Drawing.Point(999, 537);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(131, 50);
            this.btnExist.TabIndex = 18;
            this.btnExist.Text = "Exist";
            this.btnExist.UseVisualStyleBackColor = false;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Puzzle_Game.Properties.Resources.original;
            this.pictureBox1.Location = new System.Drawing.Point(709, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panelLevel
            // 
            this.panelLevel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelLevel.Controls.Add(this.rbHard);
            this.panelLevel.Controls.Add(this.rbMedium);
            this.panelLevel.Controls.Add(this.rbEasy);
            this.panelLevel.Controls.Add(this.label2);
            this.panelLevel.Location = new System.Drawing.Point(669, 312);
            this.panelLevel.Name = "panelLevel";
            this.panelLevel.Size = new System.Drawing.Size(432, 135);
            this.panelLevel.TabIndex = 19;
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHard.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rbHard.Location = new System.Drawing.Point(309, 85);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(76, 24);
            this.rbHard.TabIndex = 23;
            this.rbHard.Tag = "3";
            this.rbHard.Text = "HARD";
            this.rbHard.UseVisualStyleBackColor = true;
            this.rbHard.CheckedChanged += new System.EventHandler(this.rbEasy_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedium.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rbMedium.Location = new System.Drawing.Point(170, 85);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(101, 24);
            this.rbMedium.TabIndex = 22;
            this.rbMedium.Tag = "2";
            this.rbMedium.Text = "MEDIUM";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbEasy_CheckedChanged);
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEasy.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rbEasy.Location = new System.Drawing.Point(46, 85);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(71, 24);
            this.rbEasy.TabIndex = 21;
            this.rbEasy.Tag = "1";
            this.rbEasy.Text = "EASY";
            this.rbEasy.UseVisualStyleBackColor = true;
            this.rbEasy.CheckedChanged += new System.EventHandler(this.rbEasy_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(90, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Please select a game level : ";
            // 
            // Clock
            // 
            this.Clock.Interval = 1000;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Segoe Marker", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.Lime;
            this.lblClock.Location = new System.Drawing.Point(97, 434);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(428, 40);
            this.lblClock.TabIndex = 24;
            this.lblClock.Text = "Remaining Time :  00 : 00 : 00 ";
            this.lblClock.Visible = false;
            // 
            // Check
            // 
            this.Check.Enabled = true;
            this.Check.Tick += new System.EventHandler(this.Check_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1142, 588);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.panelLevel);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panelPicture);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Puzzle Game";
            this.panelPicture.ResumeLayout(false);
            this.panelPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLevel.ResumeLayout(false);
            this.panelLevel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnImageClip9;
        private System.Windows.Forms.Button btnImageClip8;
        private System.Windows.Forms.Button btnImageClip7;
        private System.Windows.Forms.Button btnImageClip6;
        private System.Windows.Forms.Button btnImageClip5;
        private System.Windows.Forms.Button btnImageClip4;
        private System.Windows.Forms.Button btnImageClip3;
        private System.Windows.Forms.Button btnImageClip2;
        private System.Windows.Forms.Button btnImageClip1;
        private System.Windows.Forms.Panel panelLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer Check;
    }
}

