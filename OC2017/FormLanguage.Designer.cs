namespace OC2017
{
    partial class FormLanguage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLanguage));
            this.lbName = new System.Windows.Forms.Label();
            this.lbSigla = new System.Windows.Forms.Label();
            this.tbSigla = new System.Windows.Forms.TextBox();
            this.tbIcon = new System.Windows.Forms.TextBox();
            this.lbIcon = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.listLanguages = new System.Windows.Forms.ListView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.Name = "lbName";
            // 
            // lbSigla
            // 
            resources.ApplyResources(this.lbSigla, "lbSigla");
            this.lbSigla.Name = "lbSigla";
            // 
            // tbSigla
            // 
            resources.ApplyResources(this.tbSigla, "tbSigla");
            this.tbSigla.Name = "tbSigla";
            // 
            // tbIcon
            // 
            resources.ApplyResources(this.tbIcon, "tbIcon");
            this.tbIcon.Name = "tbIcon";
            // 
            // lbIcon
            // 
            resources.ApplyResources(this.lbIcon, "lbIcon");
            this.lbIcon.Name = "lbIcon";
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.Name = "tbName";
            // 
            // btnSelectFile
            // 
            resources.ApplyResources(this.btnSelectFile, "btnSelectFile");
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // listLanguages
            // 
            this.listLanguages.CheckBoxes = true;
            resources.ApplyResources(this.listLanguages, "listLanguages");
            this.listLanguages.Name = "listLanguages";
            this.listLanguages.UseCompatibleStateImageBehavior = false;
            this.listLanguages.View = System.Windows.Forms.View.Details;
            this.listLanguages.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listLanguages_ItemChecked);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pbIcon
            // 
            resources.ApplyResources(this.pbIcon, "pbIcon");
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.TabStop = false;
            // 
            // FormLanguage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listLanguages);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbIcon);
            this.Controls.Add(this.lbIcon);
            this.Controls.Add(this.tbSigla);
            this.Controls.Add(this.lbSigla);
            this.Controls.Add(this.lbName);
            this.Name = "FormLanguage";
            this.Load += new System.EventHandler(this.FormLanguage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSigla;
        private System.Windows.Forms.TextBox tbSigla;
        private System.Windows.Forms.TextBox tbIcon;
        private System.Windows.Forms.Label lbIcon;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.ListView listLanguages;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}