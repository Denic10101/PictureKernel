namespace PictureKernel
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.pboxOutput = new System.Windows.Forms.PictureBox();
            this.btApply = new System.Windows.Forms.Button();
            this.tboxImagePath = new System.Windows.Forms.TextBox();
            this.btOpenWch = new System.Windows.Forms.Button();
            this.btLoadImage = new System.Windows.Forms.Button();
            this.opnfileImage = new System.Windows.Forms.OpenFileDialog();
            this.btInit = new System.Windows.Forms.Button();
            this.tbV11 = new System.Windows.Forms.TextBox();
            this.tbV12 = new System.Windows.Forms.TextBox();
            this.tbV13 = new System.Windows.Forms.TextBox();
            this.tbV21 = new System.Windows.Forms.TextBox();
            this.tbV22 = new System.Windows.Forms.TextBox();
            this.tbV23 = new System.Windows.Forms.TextBox();
            this.tbV31 = new System.Windows.Forms.TextBox();
            this.tbV32 = new System.Windows.Forms.TextBox();
            this.tbV33 = new System.Windows.Forms.TextBox();
            this.pbarInitProgress = new System.Windows.Forms.ProgressBar();
            this.btInitKernel = new System.Windows.Forms.Button();
            this.panelMatrix = new System.Windows.Forms.Panel();
            this.lbMult = new System.Windows.Forms.Label();
            this.tbVScalar = new System.Windows.Forms.TextBox();
            this.chboxSaveBrig = new System.Windows.Forms.CheckBox();
            this.chboxMonochrome = new System.Windows.Forms.CheckBox();
            this.btSaveOutput = new System.Windows.Forms.Button();
            this.savefileImage = new System.Windows.Forms.SaveFileDialog();
            this.panelOutputImage = new System.Windows.Forms.Panel();
            this.radiobtStretch = new System.Windows.Forms.RadioButton();
            this.radiobtFullSize = new System.Windows.Forms.RadioButton();
            this.radiobtCenter = new System.Windows.Forms.RadioButton();
            this.lbImageSizeMode = new System.Windows.Forms.Label();
            this.lbOutputParams = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxOutput)).BeginInit();
            this.panelMatrix.SuspendLayout();
            this.panelOutputImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pboxOutput
            // 
            this.pboxOutput.BackColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.pboxOutput, "pboxOutput");
            this.pboxOutput.Name = "pboxOutput";
            this.pboxOutput.TabStop = false;
            // 
            // btApply
            // 
            resources.ApplyResources(this.btApply, "btApply");
            this.btApply.Name = "btApply";
            this.btApply.UseVisualStyleBackColor = true;
            this.btApply.Click += new System.EventHandler(this.btApply_Click);
            // 
            // tboxImagePath
            // 
            resources.ApplyResources(this.tboxImagePath, "tboxImagePath");
            this.tboxImagePath.Name = "tboxImagePath";
            // 
            // btOpenWch
            // 
            resources.ApplyResources(this.btOpenWch, "btOpenWch");
            this.btOpenWch.Name = "btOpenWch";
            this.btOpenWch.UseVisualStyleBackColor = true;
            this.btOpenWch.Click += new System.EventHandler(this.btOpenWch_Click);
            // 
            // btLoadImage
            // 
            resources.ApplyResources(this.btLoadImage, "btLoadImage");
            this.btLoadImage.Name = "btLoadImage";
            this.btLoadImage.UseVisualStyleBackColor = true;
            this.btLoadImage.Click += new System.EventHandler(this.btLoadImage_Click);
            // 
            // opnfileImage
            // 
            this.opnfileImage.FileName = "openFileDialog1";
            this.opnfileImage.FileOk += new System.ComponentModel.CancelEventHandler(this.opnfileImage_FileOk);
            // 
            // btInit
            // 
            resources.ApplyResources(this.btInit, "btInit");
            this.btInit.Name = "btInit";
            this.btInit.UseVisualStyleBackColor = true;
            this.btInit.Click += new System.EventHandler(this.btInit_Click);
            // 
            // tbV11
            // 
            resources.ApplyResources(this.tbV11, "tbV11");
            this.tbV11.Name = "tbV11";
            // 
            // tbV12
            // 
            resources.ApplyResources(this.tbV12, "tbV12");
            this.tbV12.Name = "tbV12";
            // 
            // tbV13
            // 
            resources.ApplyResources(this.tbV13, "tbV13");
            this.tbV13.Name = "tbV13";
            // 
            // tbV21
            // 
            resources.ApplyResources(this.tbV21, "tbV21");
            this.tbV21.Name = "tbV21";
            // 
            // tbV22
            // 
            resources.ApplyResources(this.tbV22, "tbV22");
            this.tbV22.Name = "tbV22";
            // 
            // tbV23
            // 
            resources.ApplyResources(this.tbV23, "tbV23");
            this.tbV23.Name = "tbV23";
            // 
            // tbV31
            // 
            resources.ApplyResources(this.tbV31, "tbV31");
            this.tbV31.Name = "tbV31";
            // 
            // tbV32
            // 
            resources.ApplyResources(this.tbV32, "tbV32");
            this.tbV32.Name = "tbV32";
            // 
            // tbV33
            // 
            resources.ApplyResources(this.tbV33, "tbV33");
            this.tbV33.Name = "tbV33";
            // 
            // pbarInitProgress
            // 
            resources.ApplyResources(this.pbarInitProgress, "pbarInitProgress");
            this.pbarInitProgress.Name = "pbarInitProgress";
            // 
            // btInitKernel
            // 
            resources.ApplyResources(this.btInitKernel, "btInitKernel");
            this.btInitKernel.Name = "btInitKernel";
            this.btInitKernel.UseVisualStyleBackColor = true;
            this.btInitKernel.Click += new System.EventHandler(this.btInitKernel_Click);
            // 
            // panelMatrix
            // 
            this.panelMatrix.Controls.Add(this.lbMult);
            this.panelMatrix.Controls.Add(this.tbV11);
            this.panelMatrix.Controls.Add(this.tbV33);
            this.panelMatrix.Controls.Add(this.tbV21);
            this.panelMatrix.Controls.Add(this.tbV23);
            this.panelMatrix.Controls.Add(this.tbV31);
            this.panelMatrix.Controls.Add(this.tbVScalar);
            this.panelMatrix.Controls.Add(this.tbV13);
            this.panelMatrix.Controls.Add(this.tbV12);
            this.panelMatrix.Controls.Add(this.tbV32);
            this.panelMatrix.Controls.Add(this.tbV22);
            resources.ApplyResources(this.panelMatrix, "panelMatrix");
            this.panelMatrix.Name = "panelMatrix";
            // 
            // lbMult
            // 
            resources.ApplyResources(this.lbMult, "lbMult");
            this.lbMult.Name = "lbMult";
            // 
            // tbVScalar
            // 
            resources.ApplyResources(this.tbVScalar, "tbVScalar");
            this.tbVScalar.Name = "tbVScalar";
            // 
            // chboxSaveBrig
            // 
            resources.ApplyResources(this.chboxSaveBrig, "chboxSaveBrig");
            this.chboxSaveBrig.Checked = true;
            this.chboxSaveBrig.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chboxSaveBrig.Name = "chboxSaveBrig";
            this.chboxSaveBrig.UseVisualStyleBackColor = true;
            // 
            // chboxMonochrome
            // 
            resources.ApplyResources(this.chboxMonochrome, "chboxMonochrome");
            this.chboxMonochrome.Checked = true;
            this.chboxMonochrome.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chboxMonochrome.Name = "chboxMonochrome";
            this.chboxMonochrome.UseVisualStyleBackColor = true;
            // 
            // btSaveOutput
            // 
            resources.ApplyResources(this.btSaveOutput, "btSaveOutput");
            this.btSaveOutput.Name = "btSaveOutput";
            this.btSaveOutput.UseVisualStyleBackColor = true;
            this.btSaveOutput.Click += new System.EventHandler(this.btSaveOutput_Click);
            // 
            // savefileImage
            // 
            this.savefileImage.FileOk += new System.ComponentModel.CancelEventHandler(this.savefileImage_FileOk);
            // 
            // panelOutputImage
            // 
            resources.ApplyResources(this.panelOutputImage, "panelOutputImage");
            this.panelOutputImage.Controls.Add(this.pboxOutput);
            this.panelOutputImage.Name = "panelOutputImage";
            // 
            // radiobtStretch
            // 
            resources.ApplyResources(this.radiobtStretch, "radiobtStretch");
            this.radiobtStretch.Name = "radiobtStretch";
            this.radiobtStretch.UseVisualStyleBackColor = true;
            this.radiobtStretch.CheckedChanged += new System.EventHandler(this.radiobtStretch_CheckedChanged);
            // 
            // radiobtFullSize
            // 
            resources.ApplyResources(this.radiobtFullSize, "radiobtFullSize");
            this.radiobtFullSize.Checked = true;
            this.radiobtFullSize.Name = "radiobtFullSize";
            this.radiobtFullSize.TabStop = true;
            this.radiobtFullSize.UseVisualStyleBackColor = true;
            this.radiobtFullSize.CheckedChanged += new System.EventHandler(this.radiobtFullSize_CheckedChanged);
            // 
            // radiobtCenter
            // 
            resources.ApplyResources(this.radiobtCenter, "radiobtCenter");
            this.radiobtCenter.Name = "radiobtCenter";
            this.radiobtCenter.UseVisualStyleBackColor = true;
            this.radiobtCenter.CheckedChanged += new System.EventHandler(this.radiobtCenter_CheckedChanged);
            // 
            // lbImageSizeMode
            // 
            resources.ApplyResources(this.lbImageSizeMode, "lbImageSizeMode");
            this.lbImageSizeMode.Name = "lbImageSizeMode";
            // 
            // lbOutputParams
            // 
            resources.ApplyResources(this.lbOutputParams, "lbOutputParams");
            this.lbOutputParams.Name = "lbOutputParams";
            // 
            // fMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbOutputParams);
            this.Controls.Add(this.lbImageSizeMode);
            this.Controls.Add(this.radiobtCenter);
            this.Controls.Add(this.radiobtFullSize);
            this.Controls.Add(this.radiobtStretch);
            this.Controls.Add(this.panelOutputImage);
            this.Controls.Add(this.chboxMonochrome);
            this.Controls.Add(this.chboxSaveBrig);
            this.Controls.Add(this.pbarInitProgress);
            this.Controls.Add(this.btInit);
            this.Controls.Add(this.btLoadImage);
            this.Controls.Add(this.btOpenWch);
            this.Controls.Add(this.tboxImagePath);
            this.Controls.Add(this.btInitKernel);
            this.Controls.Add(this.btSaveOutput);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.panelMatrix);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxOutput)).EndInit();
            this.panelMatrix.ResumeLayout(false);
            this.panelMatrix.PerformLayout();
            this.panelOutputImage.ResumeLayout(false);
            this.panelOutputImage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxOutput;
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.Button btLoadImage;
        private System.Windows.Forms.Button btOpenWch;
        private System.Windows.Forms.TextBox tboxImagePath;
        private System.Windows.Forms.OpenFileDialog opnfileImage;
        private System.Windows.Forms.Button btInit;
        private System.Windows.Forms.TextBox tbV11;
        private System.Windows.Forms.TextBox tbV12;
        private System.Windows.Forms.TextBox tbV13;
        private System.Windows.Forms.TextBox tbV21;
        private System.Windows.Forms.TextBox tbV22;
        private System.Windows.Forms.TextBox tbV23;
        private System.Windows.Forms.TextBox tbV31;
        private System.Windows.Forms.TextBox tbV32;
        private System.Windows.Forms.TextBox tbV33;
        private System.Windows.Forms.ProgressBar pbarInitProgress;
        private System.Windows.Forms.Button btInitKernel;
        private System.Windows.Forms.Panel panelMatrix;
        private System.Windows.Forms.TextBox tbVScalar;
        private System.Windows.Forms.Label lbMult;
        private System.Windows.Forms.CheckBox chboxSaveBrig;
        private System.Windows.Forms.CheckBox chboxMonochrome;
        private System.Windows.Forms.Button btSaveOutput;
        private System.Windows.Forms.SaveFileDialog savefileImage;
        private System.Windows.Forms.Panel panelOutputImage;
        private System.Windows.Forms.RadioButton radiobtStretch;
        private System.Windows.Forms.RadioButton radiobtFullSize;
        private System.Windows.Forms.RadioButton radiobtCenter;
        private System.Windows.Forms.Label lbImageSizeMode;
        private System.Windows.Forms.Label lbOutputParams;
    }
}

