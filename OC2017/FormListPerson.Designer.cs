namespace OC2017
{
    partial class FormListPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListPerson));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPerfil = new System.Windows.Forms.ComboBox();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbEmail = new System.Windows.Forms.RadioButton();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.listPeople = new System.Windows.Forms.ListView();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cbPerfil
            // 
            this.cbPerfil.FormattingEnabled = true;
            resources.ApplyResources(this.cbPerfil, "cbPerfil");
            this.cbPerfil.Name = "cbPerfil";
            // 
            // rbName
            // 
            resources.ApplyResources(this.rbName, "rbName");
            this.rbName.Name = "rbName";
            this.rbName.TabStop = true;
            this.rbName.UseVisualStyleBackColor = true;
            // 
            // rbEmail
            // 
            resources.ApplyResources(this.rbEmail, "rbEmail");
            this.rbEmail.Name = "rbEmail";
            this.rbEmail.TabStop = true;
            this.rbEmail.UseVisualStyleBackColor = true;
            // 
            // tbFilter
            // 
            resources.ApplyResources(this.tbFilter, "tbFilter");
            this.tbFilter.Name = "tbFilter";
            // 
            // btnFilter
            // 
            resources.ApplyResources(this.btnFilter, "btnFilter");
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnShowAll
            // 
            resources.ApplyResources(this.btnShowAll, "btnShowAll");
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // listPeople
            // 
            this.listPeople.CheckBoxes = true;
            resources.ApplyResources(this.listPeople, "listPeople");
            this.listPeople.MultiSelect = false;
            this.listPeople.Name = "listPeople";
            this.listPeople.UseCompatibleStateImageBehavior = false;
            this.listPeople.View = System.Windows.Forms.View.Details;
            this.listPeople.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listPeople_ItemChecked);
            // 
            // btnAlter
            // 
            resources.ApplyResources(this.btnAlter, "btnAlter");
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // btnNew
            // 
            resources.ApplyResources(this.btnNew, "btnNew");
            this.btnNew.Name = "btnNew";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormListPerson
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.listPeople);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.rbEmail);
            this.Controls.Add(this.rbName);
            this.Controls.Add(this.cbPerfil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormListPerson";
            this.Load += new System.EventHandler(this.FormListPerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPerfil;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.RadioButton rbEmail;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ListView listPeople;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
    }
}