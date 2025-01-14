
namespace OpenTK3_StandardTemplate_WinForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.showAxes = new System.Windows.Forms.CheckBox();
            this.changeBackground = new System.Windows.Forms.Button();
            this.lblOx = new System.Windows.Forms.Label();
            this.lblOy = new System.Windows.Forms.Label();
            this.lblOz = new System.Windows.Forms.Label();
            this.resetScene = new System.Windows.Forms.Button();
            this.enableRotation = new System.Windows.Forms.CheckBox();
            this.enableObjectRotation = new System.Windows.Forms.CheckBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnTranslateObject = new System.Windows.Forms.Button();
            this.btnRotateObject = new System.Windows.Forms.Button();
            this.bntScaleObject = new System.Windows.Forms.Button();
            this.ckbTimerMove = new System.Windows.Forms.CheckBox();
            this.btntransparenta = new System.Windows.Forms.Button();
            this.lstbObjects = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbTexture0 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTexture = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnNoTexture = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbColorBlue = new System.Windows.Forms.RadioButton();
            this.rbColorRed = new System.Windows.Forms.RadioButton();
            this.rbColorWhite = new System.Windows.Forms.RadioButton();
            this.btnLights = new System.Windows.Forms.Button();
            this.btnLight0 = new System.Windows.Forms.Button();
            this.btnLight0Reset = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.trackLight0PositionX = new System.Windows.Forms.TrackBar();
            this.trackLight0PositionY = new System.Windows.Forms.TrackBar();
            this.trackLight0PositionZ = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numericLight0Ambient_Red = new System.Windows.Forms.NumericUpDown();
            this.numericLight0Ambient_Green = new System.Windows.Forms.NumericUpDown();
            this.numericLight0Ambient_Blue = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numericLight0Difuse_Red = new System.Windows.Forms.NumericUpDown();
            this.numericLight0Difuse_Green = new System.Windows.Forms.NumericUpDown();
            this.numericLight0Difuse_Blue = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.numericLight0Specular_Red = new System.Windows.Forms.NumericUpDown();
            this.numericLight0Specular_Green = new System.Windows.Forms.NumericUpDown();
            this.numericLight0Specular_Blue = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Rotation = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Translation = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight0PositionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight0PositionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight0PositionZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Ambient_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Ambient_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Ambient_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Difuse_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Difuse_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Difuse_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Specular_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Specular_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Specular_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Rotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Translation)).BeginInit();
            this.SuspendLayout();
            // 
            // showAxes
            // 
            this.showAxes.AutoSize = true;
            this.showAxes.Checked = true;
            this.showAxes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showAxes.Location = new System.Drawing.Point(1116, 16);
            this.showAxes.Margin = new System.Windows.Forms.Padding(4);
            this.showAxes.Name = "showAxes";
            this.showAxes.Size = new System.Drawing.Size(95, 20);
            this.showAxes.TabIndex = 0;
            this.showAxes.Text = "Show Axes";
            this.showAxes.UseVisualStyleBackColor = true;
            this.showAxes.CheckedChanged += new System.EventHandler(this.showAxes_CheckedChanged);
            // 
            // changeBackground
            // 
            this.changeBackground.Location = new System.Drawing.Point(1116, 133);
            this.changeBackground.Margin = new System.Windows.Forms.Padding(4);
            this.changeBackground.Name = "changeBackground";
            this.changeBackground.Size = new System.Drawing.Size(303, 39);
            this.changeBackground.TabIndex = 1;
            this.changeBackground.Text = "Change background color";
            this.changeBackground.UseVisualStyleBackColor = true;
            this.changeBackground.Click += new System.EventHandler(this.changeBackground_Click);
            // 
            // lblOx
            // 
            this.lblOx.BackColor = System.Drawing.Color.Red;
            this.lblOx.Location = new System.Drawing.Point(1145, 43);
            this.lblOx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOx.Name = "lblOx";
            this.lblOx.Size = new System.Drawing.Size(53, 25);
            this.lblOx.TabIndex = 2;
            this.lblOx.Text = "Ox";
            this.lblOx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOy
            // 
            this.lblOy.BackColor = System.Drawing.Color.Green;
            this.lblOy.Location = new System.Drawing.Point(1207, 43);
            this.lblOy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOy.Name = "lblOy";
            this.lblOy.Size = new System.Drawing.Size(53, 25);
            this.lblOy.TabIndex = 3;
            this.lblOy.Text = "Oy";
            this.lblOy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOz
            // 
            this.lblOz.BackColor = System.Drawing.Color.Blue;
            this.lblOz.Location = new System.Drawing.Point(1268, 43);
            this.lblOz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOz.Name = "lblOz";
            this.lblOz.Size = new System.Drawing.Size(53, 25);
            this.lblOz.TabIndex = 4;
            this.lblOz.Text = "Oz";
            this.lblOz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetScene
            // 
            this.resetScene.Location = new System.Drawing.Point(1116, 180);
            this.resetScene.Margin = new System.Windows.Forms.Padding(4);
            this.resetScene.Name = "resetScene";
            this.resetScene.Size = new System.Drawing.Size(303, 39);
            this.resetScene.TabIndex = 5;
            this.resetScene.Text = "Reset scene";
            this.resetScene.UseVisualStyleBackColor = true;
            this.resetScene.Click += new System.EventHandler(this.resetScene_Click);
            // 
            // enableRotation
            // 
            this.enableRotation.AutoSize = true;
            this.enableRotation.Location = new System.Drawing.Point(1116, 71);
            this.enableRotation.Margin = new System.Windows.Forms.Padding(4);
            this.enableRotation.Name = "enableRotation";
            this.enableRotation.Size = new System.Drawing.Size(163, 20);
            this.enableRotation.TabIndex = 6;
            this.enableRotation.Text = "Enable mouse rotation";
            this.enableRotation.UseVisualStyleBackColor = true;
            // 
            // enableObjectRotation
            // 
            this.enableObjectRotation.AutoSize = true;
            this.enableObjectRotation.Location = new System.Drawing.Point(1116, 102);
            this.enableObjectRotation.Margin = new System.Windows.Forms.Padding(4);
            this.enableObjectRotation.Name = "enableObjectRotation";
            this.enableObjectRotation.Size = new System.Drawing.Size(159, 20);
            this.enableObjectRotation.TabIndex = 7;
            this.enableObjectRotation.Text = "Enable object rotation";
            this.enableObjectRotation.UseVisualStyleBackColor = true;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(1116, 226);
            this.btnLoadFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(303, 37);
            this.btnLoadFile.TabIndex = 8;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // btnTranslateObject
            // 
            this.btnTranslateObject.Location = new System.Drawing.Point(1116, 270);
            this.btnTranslateObject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTranslateObject.Name = "btnTranslateObject";
            this.btnTranslateObject.Size = new System.Drawing.Size(184, 37);
            this.btnTranslateObject.TabIndex = 9;
            this.btnTranslateObject.Text = "Translate Object";
            this.btnTranslateObject.UseVisualStyleBackColor = true;
            this.btnTranslateObject.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // btnRotateObject
            // 
            this.btnRotateObject.Location = new System.Drawing.Point(1116, 313);
            this.btnRotateObject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRotateObject.Name = "btnRotateObject";
            this.btnRotateObject.Size = new System.Drawing.Size(184, 37);
            this.btnRotateObject.TabIndex = 10;
            this.btnRotateObject.Text = "Rotate Object";
            this.btnRotateObject.UseVisualStyleBackColor = true;
            this.btnRotateObject.Click += new System.EventHandler(this.rotateButton_Click);
            // 
            // bntScaleObject
            // 
            this.bntScaleObject.Location = new System.Drawing.Point(1116, 354);
            this.bntScaleObject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntScaleObject.Name = "bntScaleObject";
            this.bntScaleObject.Size = new System.Drawing.Size(303, 37);
            this.bntScaleObject.TabIndex = 11;
            this.bntScaleObject.Text = "Scale Object";
            this.bntScaleObject.UseVisualStyleBackColor = true;
            this.bntScaleObject.Click += new System.EventHandler(this.scaleButton_Click);
            // 
            // ckbTimerMove
            // 
            this.ckbTimerMove.AutoSize = true;
            this.ckbTimerMove.Checked = true;
            this.ckbTimerMove.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbTimerMove.Location = new System.Drawing.Point(1119, 409);
            this.ckbTimerMove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbTimerMove.Name = "ckbTimerMove";
            this.ckbTimerMove.Size = new System.Drawing.Size(222, 20);
            this.ckbTimerMove.TabIndex = 12;
            this.ckbTimerMove.Text = "Enable object translation (Timer)";
            this.ckbTimerMove.UseVisualStyleBackColor = true;
            // 
            // btntransparenta
            // 
            this.btntransparenta.Location = new System.Drawing.Point(1116, 514);
            this.btntransparenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntransparenta.Name = "btntransparenta";
            this.btntransparenta.Size = new System.Drawing.Size(267, 37);
            this.btntransparenta.TabIndex = 13;
            this.btntransparenta.Text = "Alpha blending";
            this.btntransparenta.UseVisualStyleBackColor = true;
            this.btntransparenta.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // lstbObjects
            // 
            this.lstbObjects.FormattingEnabled = true;
            this.lstbObjects.ItemHeight = 16;
            this.lstbObjects.Location = new System.Drawing.Point(1116, 468);
            this.lstbObjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstbObjects.Name = "lstbObjects";
            this.lstbObjects.Size = new System.Drawing.Size(264, 36);
            this.lstbObjects.TabIndex = 14;
            this.lstbObjects.SelectedIndexChanged += new System.EventHandler(this.lstbObjects_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1116, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Select object from object list";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.rbTexture0);
            this.groupBox1.Location = new System.Drawing.Point(1437, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(155, 81);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Texture";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 49);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(107, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Logo (alpha!)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbTexture0
            // 
            this.rbTexture0.AutoSize = true;
            this.rbTexture0.Checked = true;
            this.rbTexture0.Location = new System.Drawing.Point(7, 22);
            this.rbTexture0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTexture0.Name = "rbTexture0";
            this.rbTexture0.Size = new System.Drawing.Size(65, 20);
            this.rbTexture0.TabIndex = 0;
            this.rbTexture0.TabStop = true;
            this.rbTexture0.Text = "Bricks";
            this.rbTexture0.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1439, 133);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // btnTexture
            // 
            this.btnTexture.Location = new System.Drawing.Point(1439, 268);
            this.btnTexture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTexture.Name = "btnTexture";
            this.btnTexture.Size = new System.Drawing.Size(292, 37);
            this.btnTexture.TabIndex = 69;
            this.btnTexture.Text = "Texture";
            this.btnTexture.UseVisualStyleBackColor = true;
            this.btnTexture.Click += new System.EventHandler(this.btnTexture_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(1573, 133);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 68;
            this.pictureBox2.TabStop = false;
            // 
            // btnNoTexture
            // 
            this.btnNoTexture.Location = new System.Drawing.Point(1439, 313);
            this.btnNoTexture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNoTexture.Name = "btnNoTexture";
            this.btnNoTexture.Size = new System.Drawing.Size(292, 37);
            this.btnNoTexture.TabIndex = 70;
            this.btnNoTexture.Text = "No Texture";
            this.btnNoTexture.UseVisualStyleBackColor = true;
            this.btnNoTexture.Click += new System.EventHandler(this.btnNoTexture_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbColorBlue);
            this.groupBox2.Controls.Add(this.rbColorRed);
            this.groupBox2.Controls.Add(this.rbColorWhite);
            this.groupBox2.Location = new System.Drawing.Point(1597, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(156, 110);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // rbColorBlue
            // 
            this.rbColorBlue.AutoSize = true;
            this.rbColorBlue.Location = new System.Drawing.Point(7, 79);
            this.rbColorBlue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbColorBlue.Name = "rbColorBlue";
            this.rbColorBlue.Size = new System.Drawing.Size(55, 20);
            this.rbColorBlue.TabIndex = 2;
            this.rbColorBlue.Text = "Blue";
            this.rbColorBlue.UseVisualStyleBackColor = true;
            // 
            // rbColorRed
            // 
            this.rbColorRed.AutoSize = true;
            this.rbColorRed.Location = new System.Drawing.Point(7, 49);
            this.rbColorRed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbColorRed.Name = "rbColorRed";
            this.rbColorRed.Size = new System.Drawing.Size(54, 20);
            this.rbColorRed.TabIndex = 1;
            this.rbColorRed.Text = "Red";
            this.rbColorRed.UseVisualStyleBackColor = true;
            // 
            // rbColorWhite
            // 
            this.rbColorWhite.AutoSize = true;
            this.rbColorWhite.Checked = true;
            this.rbColorWhite.Location = new System.Drawing.Point(7, 22);
            this.rbColorWhite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbColorWhite.Name = "rbColorWhite";
            this.rbColorWhite.Size = new System.Drawing.Size(62, 20);
            this.rbColorWhite.TabIndex = 0;
            this.rbColorWhite.TabStop = true;
            this.rbColorWhite.Text = "White";
            this.rbColorWhite.UseVisualStyleBackColor = true;
            // 
            // btnLights
            // 
            this.btnLights.Location = new System.Drawing.Point(1443, 363);
            this.btnLights.Name = "btnLights";
            this.btnLights.Size = new System.Drawing.Size(124, 34);
            this.btnLights.TabIndex = 72;
            this.btnLights.UseVisualStyleBackColor = true;
            this.btnLights.Click += new System.EventHandler(this.btnLights_Click);
            // 
            // btnLight0
            // 
            this.btnLight0.Location = new System.Drawing.Point(1573, 363);
            this.btnLight0.Name = "btnLight0";
            this.btnLight0.Size = new System.Drawing.Size(121, 34);
            this.btnLight0.TabIndex = 73;
            this.btnLight0.UseVisualStyleBackColor = true;
            this.btnLight0.Click += new System.EventHandler(this.btnLight0_Click);
            // 
            // btnLight0Reset
            // 
            this.btnLight0Reset.Location = new System.Drawing.Point(1699, 363);
            this.btnLight0Reset.Name = "btnLight0Reset";
            this.btnLight0Reset.Size = new System.Drawing.Size(138, 34);
            this.btnLight0Reset.TabIndex = 74;
            this.btnLight0Reset.Text = "Reset";
            this.btnLight0Reset.UseVisualStyleBackColor = true;
            this.btnLight0Reset.Click += new System.EventHandler(this.btnLight0Reset_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1446, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 16);
            this.label8.TabIndex = 75;
            this.label8.Text = "Manipulare pozitie sursă 0:";
            // 
            // trackLight0PositionX
            // 
            this.trackLight0PositionX.BackColor = System.Drawing.Color.Red;
            this.trackLight0PositionX.LargeChange = 10;
            this.trackLight0PositionX.Location = new System.Drawing.Point(1444, 420);
            this.trackLight0PositionX.Maximum = 50;
            this.trackLight0PositionX.Minimum = -50;
            this.trackLight0PositionX.Name = "trackLight0PositionX";
            this.trackLight0PositionX.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackLight0PositionX.Size = new System.Drawing.Size(56, 357);
            this.trackLight0PositionX.TabIndex = 76;
            this.trackLight0PositionX.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackLight0PositionX.Scroll += new System.EventHandler(this.trackLight0PositionX_Scroll);
            // 
            // trackLight0PositionY
            // 
            this.trackLight0PositionY.BackColor = System.Drawing.Color.Gold;
            this.trackLight0PositionY.LargeChange = 10;
            this.trackLight0PositionY.Location = new System.Drawing.Point(1511, 420);
            this.trackLight0PositionY.Maximum = 50;
            this.trackLight0PositionY.Minimum = -50;
            this.trackLight0PositionY.Name = "trackLight0PositionY";
            this.trackLight0PositionY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackLight0PositionY.Size = new System.Drawing.Size(56, 357);
            this.trackLight0PositionY.TabIndex = 77;
            this.trackLight0PositionY.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackLight0PositionY.Scroll += new System.EventHandler(this.trackLight0PositionY_Scroll);
            // 
            // trackLight0PositionZ
            // 
            this.trackLight0PositionZ.BackColor = System.Drawing.Color.LimeGreen;
            this.trackLight0PositionZ.LargeChange = 10;
            this.trackLight0PositionZ.Location = new System.Drawing.Point(1573, 420);
            this.trackLight0PositionZ.Maximum = 50;
            this.trackLight0PositionZ.Minimum = -50;
            this.trackLight0PositionZ.Name = "trackLight0PositionZ";
            this.trackLight0PositionZ.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackLight0PositionZ.Size = new System.Drawing.Size(56, 357);
            this.trackLight0PositionZ.TabIndex = 78;
            this.trackLight0PositionZ.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackLight0PositionZ.Scroll += new System.EventHandler(this.trackLight0PositionZ_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1653, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 16);
            this.label9.TabIndex = 79;
            this.label9.Text = "Manipulare culoare sursă 0:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1653, 450);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 80;
            this.label10.Text = "RED";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1653, 478);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 81;
            this.label11.Text = "GREEN";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1653, 506);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 16);
            this.label12.TabIndex = 82;
            this.label12.Text = "BLUE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1653, 421);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 16);
            this.label13.TabIndex = 83;
            this.label13.Text = "(iluminare ambientală)";
            // 
            // numericLight0Ambient_Red
            // 
            this.numericLight0Ambient_Red.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Ambient_Red.Location = new System.Drawing.Point(1719, 448);
            this.numericLight0Ambient_Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Ambient_Red.Name = "numericLight0Ambient_Red";
            this.numericLight0Ambient_Red.Size = new System.Drawing.Size(113, 22);
            this.numericLight0Ambient_Red.TabIndex = 84;
            this.numericLight0Ambient_Red.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Ambient_Red.ValueChanged += new System.EventHandler(this.numericLight0Ambient_Red_ValueChanged);
            // 
            // numericLight0Ambient_Green
            // 
            this.numericLight0Ambient_Green.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Ambient_Green.Location = new System.Drawing.Point(1719, 476);
            this.numericLight0Ambient_Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Ambient_Green.Name = "numericLight0Ambient_Green";
            this.numericLight0Ambient_Green.Size = new System.Drawing.Size(113, 22);
            this.numericLight0Ambient_Green.TabIndex = 85;
            this.numericLight0Ambient_Green.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Ambient_Green.ValueChanged += new System.EventHandler(this.numericLight0Ambient_Green_ValueChanged);
            // 
            // numericLight0Ambient_Blue
            // 
            this.numericLight0Ambient_Blue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Ambient_Blue.Location = new System.Drawing.Point(1719, 504);
            this.numericLight0Ambient_Blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Ambient_Blue.Name = "numericLight0Ambient_Blue";
            this.numericLight0Ambient_Blue.Size = new System.Drawing.Size(113, 22);
            this.numericLight0Ambient_Blue.TabIndex = 86;
            this.numericLight0Ambient_Blue.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Ambient_Blue.ValueChanged += new System.EventHandler(this.numericLight0Ambient_Blue_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1653, 529);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(171, 16);
            this.label18.TabIndex = 87;
            this.label18.Text = "Manipulare culoare sursă 0:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1653, 579);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 16);
            this.label17.TabIndex = 88;
            this.label17.Text = "RED";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1653, 607);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 16);
            this.label16.TabIndex = 89;
            this.label16.Text = "GREEN";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1653, 635);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 16);
            this.label15.TabIndex = 90;
            this.label15.Text = "BLUE";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1653, 550);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 16);
            this.label14.TabIndex = 91;
            this.label14.Text = "(iluminare difuză)";
            // 
            // numericLight0Difuse_Red
            // 
            this.numericLight0Difuse_Red.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Difuse_Red.Location = new System.Drawing.Point(1719, 577);
            this.numericLight0Difuse_Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Difuse_Red.Name = "numericLight0Difuse_Red";
            this.numericLight0Difuse_Red.Size = new System.Drawing.Size(113, 22);
            this.numericLight0Difuse_Red.TabIndex = 92;
            this.numericLight0Difuse_Red.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Difuse_Red.ValueChanged += new System.EventHandler(this.numericLight0Difuse_Red_ValueChanged);
            // 
            // numericLight0Difuse_Green
            // 
            this.numericLight0Difuse_Green.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Difuse_Green.Location = new System.Drawing.Point(1719, 605);
            this.numericLight0Difuse_Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Difuse_Green.Name = "numericLight0Difuse_Green";
            this.numericLight0Difuse_Green.Size = new System.Drawing.Size(113, 22);
            this.numericLight0Difuse_Green.TabIndex = 93;
            this.numericLight0Difuse_Green.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Difuse_Green.ValueChanged += new System.EventHandler(this.numericLight0Difuse_Green_ValueChanged);
            // 
            // numericLight0Difuse_Blue
            // 
            this.numericLight0Difuse_Blue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Difuse_Blue.Location = new System.Drawing.Point(1719, 633);
            this.numericLight0Difuse_Blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Difuse_Blue.Name = "numericLight0Difuse_Blue";
            this.numericLight0Difuse_Blue.Size = new System.Drawing.Size(113, 22);
            this.numericLight0Difuse_Blue.TabIndex = 94;
            this.numericLight0Difuse_Blue.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Difuse_Blue.ValueChanged += new System.EventHandler(this.numericLight0Difuse_Blue_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(1653, 658);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(171, 16);
            this.label23.TabIndex = 95;
            this.label23.Text = "Manipulare culoare sursă 0:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1653, 708);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 16);
            this.label22.TabIndex = 96;
            this.label22.Text = "RED";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1653, 736);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 16);
            this.label21.TabIndex = 97;
            this.label21.Text = "GREEN";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1653, 764);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 16);
            this.label20.TabIndex = 98;
            this.label20.Text = "BLUE";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1653, 679);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(132, 16);
            this.label19.TabIndex = 99;
            this.label19.Text = "(iluminare speculară)";
            // 
            // numericLight0Specular_Red
            // 
            this.numericLight0Specular_Red.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Specular_Red.Location = new System.Drawing.Point(1719, 706);
            this.numericLight0Specular_Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Specular_Red.Name = "numericLight0Specular_Red";
            this.numericLight0Specular_Red.Size = new System.Drawing.Size(113, 22);
            this.numericLight0Specular_Red.TabIndex = 100;
            this.numericLight0Specular_Red.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Specular_Red.ValueChanged += new System.EventHandler(this.numericLight0Specular_Red_ValueChanged);
            // 
            // numericLight0Specular_Green
            // 
            this.numericLight0Specular_Green.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Specular_Green.Location = new System.Drawing.Point(1719, 734);
            this.numericLight0Specular_Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Specular_Green.Name = "numericLight0Specular_Green";
            this.numericLight0Specular_Green.Size = new System.Drawing.Size(113, 22);
            this.numericLight0Specular_Green.TabIndex = 101;
            this.numericLight0Specular_Green.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Specular_Green.ValueChanged += new System.EventHandler(this.numericLight0Specular_Green_ValueChanged);
            // 
            // numericLight0Specular_Blue
            // 
            this.numericLight0Specular_Blue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Specular_Blue.Location = new System.Drawing.Point(1719, 762);
            this.numericLight0Specular_Blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Specular_Blue.Name = "numericLight0Specular_Blue";
            this.numericLight0Specular_Blue.Size = new System.Drawing.Size(113, 22);
            this.numericLight0Specular_Blue.TabIndex = 102;
            this.numericLight0Specular_Blue.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Specular_Blue.ValueChanged += new System.EventHandler(this.numericLight0Specular_Blue_ValueChanged);
            // 
            // numericUpDown_Rotation
            // 
            this.numericUpDown_Rotation.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_Rotation.Location = new System.Drawing.Point(1319, 321);
            this.numericUpDown_Rotation.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown_Rotation.Name = "numericUpDown_Rotation";
            this.numericUpDown_Rotation.Size = new System.Drawing.Size(100, 22);
            this.numericUpDown_Rotation.TabIndex = 103;
            this.numericUpDown_Rotation.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // numericUpDown_Translation
            // 
            this.numericUpDown_Translation.Location = new System.Drawing.Point(1319, 278);
            this.numericUpDown_Translation.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_Translation.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.numericUpDown_Translation.Name = "numericUpDown_Translation";
            this.numericUpDown_Translation.Size = new System.Drawing.Size(100, 22);
            this.numericUpDown_Translation.TabIndex = 104;
            this.numericUpDown_Translation.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1866, 803);
            this.Controls.Add(this.numericUpDown_Translation);
            this.Controls.Add(this.numericUpDown_Rotation);
            this.Controls.Add(this.numericLight0Specular_Blue);
            this.Controls.Add(this.numericLight0Specular_Green);
            this.Controls.Add(this.numericLight0Specular_Red);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.numericLight0Difuse_Blue);
            this.Controls.Add(this.numericLight0Difuse_Green);
            this.Controls.Add(this.numericLight0Difuse_Red);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.numericLight0Ambient_Blue);
            this.Controls.Add(this.numericLight0Ambient_Green);
            this.Controls.Add(this.numericLight0Ambient_Red);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.trackLight0PositionZ);
            this.Controls.Add(this.trackLight0PositionY);
            this.Controls.Add(this.trackLight0PositionX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLight0Reset);
            this.Controls.Add(this.btnLight0);
            this.Controls.Add(this.btnLights);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnNoTexture);
            this.Controls.Add(this.btnTexture);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbObjects);
            this.Controls.Add(this.btntransparenta);
            this.Controls.Add(this.ckbTimerMove);
            this.Controls.Add(this.bntScaleObject);
            this.Controls.Add(this.btnRotateObject);
            this.Controls.Add(this.btnTranslateObject);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.enableObjectRotation);
            this.Controls.Add(this.enableRotation);
            this.Controls.Add(this.resetScene);
            this.Controls.Add(this.lblOz);
            this.Controls.Add(this.lblOy);
            this.Controls.Add(this.lblOx);
            this.Controls.Add(this.changeBackground);
            this.Controls.Add(this.showAxes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenTK 3";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight0PositionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight0PositionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight0PositionZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Ambient_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Ambient_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Ambient_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Difuse_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Difuse_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Difuse_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Specular_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Specular_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Specular_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Rotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Translation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox showAxes;
        private System.Windows.Forms.Button changeBackground;
        private System.Windows.Forms.Label lblOx;
        private System.Windows.Forms.Label lblOy;
        private System.Windows.Forms.Label lblOz;
        private System.Windows.Forms.Button resetScene;
        private System.Windows.Forms.CheckBox enableRotation;
        private System.Windows.Forms.CheckBox enableObjectRotation;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnTranslateObject;
        private System.Windows.Forms.Button btnRotateObject;
        private System.Windows.Forms.Button bntScaleObject;
        private System.Windows.Forms.CheckBox ckbTimerMove;
        private System.Windows.Forms.Button btntransparenta;
        private System.Windows.Forms.ListBox lstbObjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTexture0;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTexture;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnNoTexture;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbColorBlue;
        private System.Windows.Forms.RadioButton rbColorRed;
        private System.Windows.Forms.RadioButton rbColorWhite;
        private System.Windows.Forms.Button btnLights;
        private System.Windows.Forms.Button btnLight0;
        private System.Windows.Forms.Button btnLight0Reset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackLight0PositionX;
        private System.Windows.Forms.TrackBar trackLight0PositionY;
        private System.Windows.Forms.TrackBar trackLight0PositionZ;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericLight0Ambient_Red;
        private System.Windows.Forms.NumericUpDown numericLight0Ambient_Green;
        private System.Windows.Forms.NumericUpDown numericLight0Ambient_Blue;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericLight0Difuse_Red;
        private System.Windows.Forms.NumericUpDown numericLight0Difuse_Green;
        private System.Windows.Forms.NumericUpDown numericLight0Difuse_Blue;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown numericLight0Specular_Red;
        private System.Windows.Forms.NumericUpDown numericLight0Specular_Green;
        private System.Windows.Forms.NumericUpDown numericLight0Specular_Blue;
        private System.Windows.Forms.NumericUpDown numericUpDown_Rotation;
        private System.Windows.Forms.NumericUpDown numericUpDown_Translation;
    }
}

