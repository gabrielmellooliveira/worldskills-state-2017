namespace OC2017
{
    partial class FormFuncionalidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuncionalidades));
            this.label1 = new System.Windows.Forms.Label();
            this.lbPerfil = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbUrl = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.listFuncionalidades = new System.Windows.Forms.ListView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lbPerfil
            // 
            resources.ApplyResources(this.lbPerfil, "lbPerfil");
            this.lbPerfil.Name = "lbPerfil";
            // 
            // lbName
            // 
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.Name = "lbName";
            // 
            // lbUrl
            // 
            resources.ApplyResources(this.lbUrl, "lbUrl");
            this.lbUrl.Name = "lbUrl";
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.Name = "tbName";
            // 
            // tbUrl
            // 
            resources.ApplyResources(this.tbUrl, "tbUrl");
            this.tbUrl.Name = "tbUrl";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listFuncionalidades
            // 
            this.listFuncionalidades.CheckBoxes = true;
            resources.ApplyResources(this.listFuncionalidades, "listFuncionalidades");
            this.listFuncionalidades.Name = "listFuncionalidades";
            this.listFuncionalidades.UseCompatibleStateImageBehavior = false;
            this.listFuncionalidades.View = System.Windows.Forms.View.Details;
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormFuncionalidades
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listFuncionalidades);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbUrl);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbPerfil);
            this.Controls.Add(this.label1);
            this.Name = "FormFuncionalidades";
            this.Load += new System.EventHandler(this.FormFuncionalidades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPerfil;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbUrl;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView listFuncionalidades;
        private System.Windows.Forms.Button btnDelete;
    }
}