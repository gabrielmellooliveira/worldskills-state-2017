namespace OC2017
{
    partial class FormPerfis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerfis));
            this.btnSave = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.listPerfis = new System.Windows.Forms.ListView();
            this.lbName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFunctions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.Name = "tbName";
            // 
            // listPerfis
            // 
            this.listPerfis.CheckBoxes = true;
            resources.ApplyResources(this.listPerfis, "listPerfis");
            this.listPerfis.Name = "listPerfis";
            this.listPerfis.UseCompatibleStateImageBehavior = false;
            this.listPerfis.View = System.Windows.Forms.View.Details;
            this.listPerfis.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listPerfis_ItemChecked);
            // 
            // lbName
            // 
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.Name = "lbName";
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFunctions
            // 
            resources.ApplyResources(this.btnFunctions, "btnFunctions");
            this.btnFunctions.Name = "btnFunctions";
            this.btnFunctions.UseVisualStyleBackColor = true;
            this.btnFunctions.Click += new System.EventHandler(this.btnFunctions_Click);
            // 
            // FormPerfis
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFunctions);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.listPerfis);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnSave);
            this.Name = "FormPerfis";
            this.Load += new System.EventHandler(this.FormPerfis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ListView listPerfis;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFunctions;
    }
}