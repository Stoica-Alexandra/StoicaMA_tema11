
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.changeBackground.Size = new System.Drawing.Size(267, 39);
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
            this.resetScene.Size = new System.Drawing.Size(267, 39);
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
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(267, 37);
            this.btnLoadFile.TabIndex = 8;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // btnTranslateObject
            // 
            this.btnTranslateObject.Location = new System.Drawing.Point(1116, 269);
            this.btnTranslateObject.Name = "btnTranslateObject";
            this.btnTranslateObject.Size = new System.Drawing.Size(267, 37);
            this.btnTranslateObject.TabIndex = 9;
            this.btnTranslateObject.Text = "Translate Object";
            this.btnTranslateObject.UseVisualStyleBackColor = true;
            this.btnTranslateObject.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // btnRotateObject
            // 
            this.btnRotateObject.Location = new System.Drawing.Point(1116, 312);
            this.btnRotateObject.Name = "btnRotateObject";
            this.btnRotateObject.Size = new System.Drawing.Size(267, 37);
            this.btnRotateObject.TabIndex = 10;
            this.btnRotateObject.Text = "Rotate Object";
            this.btnRotateObject.UseVisualStyleBackColor = true;
            this.btnRotateObject.Click += new System.EventHandler(this.rotateButton_Click);
            // 
            // bntScaleObject
            // 
            this.bntScaleObject.Location = new System.Drawing.Point(1116, 355);
            this.bntScaleObject.Name = "bntScaleObject";
            this.bntScaleObject.Size = new System.Drawing.Size(267, 37);
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
            this.ckbTimerMove.Location = new System.Drawing.Point(1119, 408);
            this.ckbTimerMove.Name = "ckbTimerMove";
            this.ckbTimerMove.Size = new System.Drawing.Size(222, 20);
            this.ckbTimerMove.TabIndex = 12;
            this.ckbTimerMove.Text = "Enable object translation (Timer)";
            this.ckbTimerMove.UseVisualStyleBackColor = true;
            // 
            // btntransparenta
            // 
            this.btntransparenta.Location = new System.Drawing.Point(1116, 434);
            this.btntransparenta.Name = "btntransparenta";
            this.btntransparenta.Size = new System.Drawing.Size(267, 37);
            this.btntransparenta.TabIndex = 13;
            this.btntransparenta.Text = "Alpha belnding";
            this.btntransparenta.UseVisualStyleBackColor = true;
            this.btntransparenta.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // lstbObjects
            // 
            this.lstbObjects.FormattingEnabled = true;
            this.lstbObjects.ItemHeight = 16;
            this.lstbObjects.Location = new System.Drawing.Point(1116, 493);
            this.lstbObjects.Name = "lstbObjects";
            this.lstbObjects.Size = new System.Drawing.Size(264, 36);
            this.lstbObjects.TabIndex = 14;
            this.lstbObjects.SelectedIndexChanged += new System.EventHandler(this.lstbObjects_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1116, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Select object from object list";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.rbTexture0);
            this.groupBox1.Location = new System.Drawing.Point(1485, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(112, 81);
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
            this.pictureBox1.Location = new System.Drawing.Point(1487, 102);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // btnTexture
            // 
            this.btnTexture.Location = new System.Drawing.Point(1487, 238);
            this.btnTexture.Name = "btnTexture";
            this.btnTexture.Size = new System.Drawing.Size(267, 37);
            this.btnTexture.TabIndex = 69;
            this.btnTexture.Text = "Texture";
            this.btnTexture.UseVisualStyleBackColor = true;
            this.btnTexture.Click += new System.EventHandler(this.btnTexture_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(1621, 102);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 68;
            this.pictureBox2.TabStop = false;
            // 
            // btnNoTexture
            // 
            this.btnNoTexture.Location = new System.Drawing.Point(1485, 281);
            this.btnNoTexture.Name = "btnNoTexture";
            this.btnNoTexture.Size = new System.Drawing.Size(267, 37);
            this.btnNoTexture.TabIndex = 70;
            this.btnNoTexture.Text = "No Texture";
            this.btnNoTexture.UseVisualStyleBackColor = true;
            this.btnNoTexture.Click += new System.EventHandler(this.btnNoTexture_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1772, 873);
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
    }
}

