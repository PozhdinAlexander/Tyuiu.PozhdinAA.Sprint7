
namespace Tyuiu.PozhdinAA.Sprint7.Project.V12
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDone_PAA = new System.Windows.Forms.Button();
            this.pictureBoxDeveloper_PAA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeveloper_PAA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // buttonDone_PAA
            // 
            this.buttonDone_PAA.Location = new System.Drawing.Point(345, 133);
            this.buttonDone_PAA.Name = "buttonDone_PAA";
            this.buttonDone_PAA.Size = new System.Drawing.Size(75, 23);
            this.buttonDone_PAA.TabIndex = 1;
            this.buttonDone_PAA.Text = "Ok";
            this.buttonDone_PAA.UseVisualStyleBackColor = true;
            // 
            // pictureBoxDeveloper_PAA
            // 
            this.pictureBoxDeveloper_PAA.Image = global::Tyuiu.PozhdinAA.Sprint7.Project.V12.Properties.Resources.Без_имениsssss_1;
            this.pictureBoxDeveloper_PAA.Location = new System.Drawing.Point(13, 9);
            this.pictureBoxDeveloper_PAA.Name = "pictureBoxDeveloper_PAA";
            this.pictureBoxDeveloper_PAA.Size = new System.Drawing.Size(100, 140);
            this.pictureBoxDeveloper_PAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDeveloper_PAA.TabIndex = 2;
            this.pictureBoxDeveloper_PAA.TabStop = false;
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 165);
            this.Controls.Add(this.pictureBoxDeveloper_PAA);
            this.Controls.Add(this.buttonDone_PAA);
            this.Controls.Add(this.label1);
            this.Name = "FormInfo";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeveloper_PAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDone_PAA;
        private System.Windows.Forms.PictureBox pictureBoxDeveloper_PAA;
    }
}