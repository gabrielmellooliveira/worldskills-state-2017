namespace OC2017
{
    partial class FormFotos
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
            this.Flow = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // Flow
            // 
            this.Flow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flow.Location = new System.Drawing.Point(0, 0);
            this.Flow.Name = "Flow";
            this.Flow.Size = new System.Drawing.Size(750, 332);
            this.Flow.TabIndex = 0;
            this.Flow.WrapContents = false;
            this.Flow.Paint += new System.Windows.Forms.PaintEventHandler(this.Flow_Paint);
            // 
            // FormFotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 332);
            this.Controls.Add(this.Flow);
            this.Name = "FormFotos";
            this.Text = "Fotos";
            this.Load += new System.EventHandler(this.FormFotos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Flow;
    }
}