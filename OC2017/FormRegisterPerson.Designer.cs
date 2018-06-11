namespace OC2017
{
    partial class FormRegisterPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterPerson));
            this.lbName = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbLanguage = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPerfil = new System.Windows.Forms.Label();
            this.listPerfil = new System.Windows.Forms.ListBox();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pbConfirmLogin = new System.Windows.Forms.PictureBox();
            this.pbConfirmSenha = new System.Windows.Forms.PictureBox();
            this.pbConfirmEmail = new System.Windows.Forms.PictureBox();
            this.pbErrorEmail = new System.Windows.Forms.PictureBox();
            this.pbErrorLogin = new System.Windows.Forms.PictureBox();
            this.pbErrorSenha = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbErrorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbErrorLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbErrorSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.Name = "lbName";
            // 
            // lbEmail
            // 
            resources.ApplyResources(this.lbEmail, "lbEmail");
            this.lbEmail.Name = "lbEmail";
            // 
            // lbLogin
            // 
            resources.ApplyResources(this.lbLogin, "lbLogin");
            this.lbLogin.Name = "lbLogin";
            // 
            // lbPhone
            // 
            resources.ApplyResources(this.lbPhone, "lbPhone");
            this.lbPhone.Name = "lbPhone";
            // 
            // lbLanguage
            // 
            resources.ApplyResources(this.lbLanguage, "lbLanguage");
            this.lbLanguage.Name = "lbLanguage";
            // 
            // lbPassword
            // 
            resources.ApplyResources(this.lbPassword, "lbPassword");
            this.lbPassword.Name = "lbPassword";
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.Name = "tbName";
            // 
            // tbEmail
            // 
            resources.ApplyResources(this.tbEmail, "tbEmail");
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEmail_KeyDown);
            // 
            // tbPhone
            // 
            resources.ApplyResources(this.tbPhone, "tbPhone");
            this.tbPhone.Name = "tbPhone";
            // 
            // tbLogin
            // 
            resources.ApplyResources(this.tbLogin, "tbLogin");
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLogin_KeyDown);
            // 
            // tbPassword
            // 
            resources.ApplyResources(this.tbPassword, "tbPassword");
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // lbPerfil
            // 
            resources.ApplyResources(this.lbPerfil, "lbPerfil");
            this.lbPerfil.Name = "lbPerfil";
            // 
            // listPerfil
            // 
            this.listPerfil.FormattingEnabled = true;
            resources.ApplyResources(this.listPerfil, "listPerfil");
            this.listPerfil.Name = "listPerfil";
            // 
            // cbLanguage
            // 
            this.cbLanguage.FormattingEnabled = true;
            resources.ApplyResources(this.cbLanguage, "cbLanguage");
            this.cbLanguage.Name = "cbLanguage";
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
            // pbConfirmLogin
            // 
            resources.ApplyResources(this.pbConfirmLogin, "pbConfirmLogin");
            this.pbConfirmLogin.Name = "pbConfirmLogin";
            this.pbConfirmLogin.TabStop = false;
            // 
            // pbConfirmSenha
            // 
            resources.ApplyResources(this.pbConfirmSenha, "pbConfirmSenha");
            this.pbConfirmSenha.Name = "pbConfirmSenha";
            this.pbConfirmSenha.TabStop = false;
            // 
            // pbConfirmEmail
            // 
            resources.ApplyResources(this.pbConfirmEmail, "pbConfirmEmail");
            this.pbConfirmEmail.Name = "pbConfirmEmail";
            this.pbConfirmEmail.TabStop = false;
            // 
            // pbErrorEmail
            // 
            resources.ApplyResources(this.pbErrorEmail, "pbErrorEmail");
            this.pbErrorEmail.Name = "pbErrorEmail";
            this.pbErrorEmail.TabStop = false;
            // 
            // pbErrorLogin
            // 
            resources.ApplyResources(this.pbErrorLogin, "pbErrorLogin");
            this.pbErrorLogin.Name = "pbErrorLogin";
            this.pbErrorLogin.TabStop = false;
            // 
            // pbErrorSenha
            // 
            resources.ApplyResources(this.pbErrorSenha, "pbErrorSenha");
            this.pbErrorSenha.Name = "pbErrorSenha";
            this.pbErrorSenha.TabStop = false;
            // 
            // FormRegisterPerson
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbErrorSenha);
            this.Controls.Add(this.pbErrorLogin);
            this.Controls.Add(this.pbErrorEmail);
            this.Controls.Add(this.pbConfirmEmail);
            this.Controls.Add(this.pbConfirmSenha);
            this.Controls.Add(this.pbConfirmLogin);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.listPerfil);
            this.Controls.Add(this.lbPerfil);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbLanguage);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbName);
            this.Name = "FormRegisterPerson";
            this.Load += new System.EventHandler(this.FormRegisterPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbErrorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbErrorLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbErrorSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbLanguage;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPerfil;
        private System.Windows.Forms.ListBox listPerfil;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pbConfirmLogin;
        private System.Windows.Forms.PictureBox pbConfirmSenha;
        private System.Windows.Forms.PictureBox pbConfirmEmail;
        private System.Windows.Forms.PictureBox pbErrorEmail;
        private System.Windows.Forms.PictureBox pbErrorLogin;
        private System.Windows.Forms.PictureBox pbErrorSenha;
    }
}