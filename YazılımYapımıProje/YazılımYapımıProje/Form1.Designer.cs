namespace YazılımYapımıProje
{
    partial class STORY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STORY));
            this.btnStoryEkle = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.lblStoryID = new System.Windows.Forms.Label();
            this.lblStoryTitle = new System.Windows.Forms.Label();
            this.listBoxCntrlStoryEkle = new DevExpress.XtraEditors.ListBoxControl();
            this.txtStoryId = new DevExpress.XtraEditors.TextEdit();
            this.txtStoryTitle = new DevExpress.XtraEditors.TextEdit();
            this.txtStoryDate = new DevExpress.XtraEditors.DateEdit();
            this.lblStoryDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.btnTablo = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStoryAuthor = new DevExpress.XtraEditors.TextEdit();
            this.btnTaskEkle = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxCntrlStoryEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoryId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoryTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoryDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoryAuthor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStoryEkle
            // 
            this.btnStoryEkle.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStoryEkle.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.btnStoryEkle.Appearance.Options.UseFont = true;
            this.btnStoryEkle.Appearance.Options.UseForeColor = true;
            this.btnStoryEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStoryEkle.ImageOptions.Image")));
            this.btnStoryEkle.Location = new System.Drawing.Point(360, 220);
            this.btnStoryEkle.Name = "btnStoryEkle";
            this.btnStoryEkle.Size = new System.Drawing.Size(155, 51);
            this.btnStoryEkle.TabIndex = 0;
            this.btnStoryEkle.Text = "Story Ekle";
            this.btnStoryEkle.Click += new System.EventHandler(this.btnStoryEkle_Click);
            // 
            // lblStoryID
            // 
            this.lblStoryID.AutoSize = true;
            this.lblStoryID.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStoryID.Location = new System.Drawing.Point(49, 34);
            this.lblStoryID.Name = "lblStoryID";
            this.lblStoryID.Size = new System.Drawing.Size(95, 21);
            this.lblStoryID.TabIndex = 1;
            this.lblStoryID.Text = "STORY ID:";
            // 
            // lblStoryTitle
            // 
            this.lblStoryTitle.AutoSize = true;
            this.lblStoryTitle.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStoryTitle.Location = new System.Drawing.Point(23, 78);
            this.lblStoryTitle.Name = "lblStoryTitle";
            this.lblStoryTitle.Size = new System.Drawing.Size(121, 21);
            this.lblStoryTitle.TabIndex = 2;
            this.lblStoryTitle.Text = "STORY TITLE:";
            // 
            // listBoxCntrlStoryEkle
            // 
            this.listBoxCntrlStoryEkle.Appearance.BackColor = System.Drawing.Color.White;
            this.listBoxCntrlStoryEkle.Appearance.Options.UseBackColor = true;
            this.listBoxCntrlStoryEkle.Location = new System.Drawing.Point(27, 206);
            this.listBoxCntrlStoryEkle.Name = "listBoxCntrlStoryEkle";
            this.listBoxCntrlStoryEkle.Size = new System.Drawing.Size(292, 206);
            this.listBoxCntrlStoryEkle.TabIndex = 3;
            this.listBoxCntrlStoryEkle.SelectedIndexChanged += new System.EventHandler(this.btnTaskEkle_Click);
            // 
            // txtStoryId
            // 
            this.txtStoryId.Location = new System.Drawing.Point(157, 33);
            this.txtStoryId.Name = "txtStoryId";
            this.txtStoryId.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtStoryId.Properties.Appearance.Options.UseBackColor = true;
            this.txtStoryId.Size = new System.Drawing.Size(100, 22);
            this.txtStoryId.TabIndex = 4;
            // 
            // txtStoryTitle
            // 
            this.txtStoryTitle.Location = new System.Drawing.Point(157, 79);
            this.txtStoryTitle.Name = "txtStoryTitle";
            this.txtStoryTitle.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtStoryTitle.Properties.Appearance.Options.UseBackColor = true;
            this.txtStoryTitle.Size = new System.Drawing.Size(100, 22);
            this.txtStoryTitle.TabIndex = 5;
            // 
            // txtStoryDate
            // 
            this.txtStoryDate.EditValue = null;
            this.txtStoryDate.Location = new System.Drawing.Point(518, 53);
            this.txtStoryDate.Name = "txtStoryDate";
            this.txtStoryDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtStoryDate.Properties.Appearance.Options.UseBackColor = true;
            this.txtStoryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStoryDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStoryDate.Properties.DisplayFormat.FormatString = "";
            this.txtStoryDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtStoryDate.Properties.EditFormat.FormatString = "";
            this.txtStoryDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtStoryDate.Properties.Mask.EditMask = "";
            this.txtStoryDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtStoryDate.Size = new System.Drawing.Size(229, 22);
            this.txtStoryDate.TabIndex = 8;
            // 
            // lblStoryDate
            // 
            this.lblStoryDate.AutoSize = true;
            this.lblStoryDate.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStoryDate.Location = new System.Drawing.Point(340, 52);
            this.lblStoryDate.Name = "lblStoryDate";
            this.lblStoryDate.Size = new System.Drawing.Size(155, 21);
            this.lblStoryDate.TabIndex = 9;
            this.lblStoryDate.Text = "STORY DEADLINE:";
            this.lblStoryDate.Click += new System.EventHandler(this.btnTaskEkle_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescription.Location = new System.Drawing.Point(20, 163);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(124, 21);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "DESCRIPTION:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(157, 160);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDescription.Properties.Appearance.Options.UseBackColor = true;
            this.txtDescription.Size = new System.Drawing.Size(494, 22);
            this.txtDescription.TabIndex = 11;
            // 
            // btnTablo
            // 
            this.btnTablo.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTablo.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.btnTablo.Appearance.Options.UseFont = true;
            this.btnTablo.Appearance.Options.UseForeColor = true;
            this.btnTablo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTablo.ImageOptions.Image")));
            this.btnTablo.Location = new System.Drawing.Point(360, 322);
            this.btnTablo.Name = "btnTablo";
            this.btnTablo.Size = new System.Drawing.Size(160, 56);
            this.btnTablo.TabIndex = 12;
            this.btnTablo.Text = "Tabloya Git";
            this.btnTablo.Click += new System.EventHandler(this.btnTablo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "AUTHOR:";
            // 
            // txtStoryAuthor
            // 
            this.txtStoryAuthor.EditValue = "";
            this.txtStoryAuthor.Location = new System.Drawing.Point(157, 122);
            this.txtStoryAuthor.Name = "txtStoryAuthor";
            this.txtStoryAuthor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtStoryAuthor.Properties.Appearance.Options.UseBackColor = true;
            this.txtStoryAuthor.Size = new System.Drawing.Size(265, 22);
            this.txtStoryAuthor.TabIndex = 14;
            // 
            // btnTaskEkle
            // 
            this.btnTaskEkle.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTaskEkle.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.btnTaskEkle.Appearance.Options.UseFont = true;
            this.btnTaskEkle.Appearance.Options.UseForeColor = true;
            this.btnTaskEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaskEkle.ImageOptions.Image")));
            this.btnTaskEkle.Location = new System.Drawing.Point(543, 220);
            this.btnTaskEkle.Name = "btnTaskEkle";
            this.btnTaskEkle.Size = new System.Drawing.Size(173, 51);
            this.btnTaskEkle.TabIndex = 15;
            this.btnTaskEkle.Text = "Task Ekle";
            this.btnTaskEkle.Visible = false;
            this.btnTaskEkle.Click += new System.EventHandler(this.btnTaskEkle_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(543, 322);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(173, 56);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Text = "Story Sil";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // STORY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(789, 444);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnTaskEkle);
            this.Controls.Add(this.txtStoryAuthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTablo);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblStoryDate);
            this.Controls.Add(this.txtStoryTitle);
            this.Controls.Add(this.txtStoryId);
            this.Controls.Add(this.listBoxCntrlStoryEkle);
            this.Controls.Add(this.lblStoryTitle);
            this.Controls.Add(this.lblStoryID);
            this.Controls.Add(this.btnStoryEkle);
            this.Controls.Add(this.txtStoryDate);
            this.Name = "STORY";
            this.Text = "STORY";
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxCntrlStoryEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoryId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoryTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoryDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoryAuthor.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnStoryEkle;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.Label lblStoryID;
        private System.Windows.Forms.Label lblStoryTitle;
        private DevExpress.XtraEditors.ListBoxControl listBoxCntrlStoryEkle;
        private DevExpress.XtraEditors.TextEdit txtStoryId;
        private DevExpress.XtraEditors.TextEdit txtStoryTitle;
        private DevExpress.XtraEditors.DateEdit txtStoryDate;
        private System.Windows.Forms.Label lblStoryDate;
        private System.Windows.Forms.Label lblDescription;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.SimpleButton btnTablo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtStoryAuthor;
        private DevExpress.XtraEditors.SimpleButton btnTaskEkle;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}

