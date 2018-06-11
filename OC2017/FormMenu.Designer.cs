namespace OC2017
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.btnPerfis = new System.Windows.Forms.Button();
            this.btnCad = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnIdiomas = new System.Windows.Forms.Button();
            this.btnPessoas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPerfis
            // 
            resources.ApplyResources(this.btnPerfis, "btnPerfis");
            this.btnPerfis.Name = "btnPerfis";
            this.btnPerfis.UseVisualStyleBackColor = true;
            this.btnPerfis.Click += new System.EventHandler(this.btnPerfis_Click);
            // 
            // btnCad
            // 
            resources.ApplyResources(this.btnCad, "btnCad");
            this.btnCad.Name = "btnCad";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // btnInfo
            // 
            resources.ApplyResources(this.btnInfo, "btnInfo");
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnIdiomas
            // 
            resources.ApplyResources(this.btnIdiomas, "btnIdiomas");
            this.btnIdiomas.Name = "btnIdiomas";
            this.btnIdiomas.UseVisualStyleBackColor = true;
            this.btnIdiomas.Click += new System.EventHandler(this.btnIdiomas_Click);
            // 
            // btnPessoas
            // 
            resources.ApplyResources(this.btnPessoas, "btnPessoas");
            this.btnPessoas.Name = "btnPessoas";
            this.btnPessoas.UseVisualStyleBackColor = true;
            this.btnPessoas.Click += new System.EventHandler(this.btnPessoas_Click);
            // 
            // FormMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPessoas);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnIdiomas);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.btnPerfis);
            this.Name = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPerfis;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnIdiomas;
        private System.Windows.Forms.Button btnPessoas;
    }
}