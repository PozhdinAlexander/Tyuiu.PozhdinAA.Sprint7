
namespace Tyuiu.PozhdinAA.Sprint7.Project.V12
{
    partial class FormAbout
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
            this.label_PAA = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClose_PAA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_PAA
            // 
            this.label_PAA.AutoSize = true;
            this.label_PAA.Location = new System.Drawing.Point(106, 9);
            this.label_PAA.Name = "label_PAA";
            this.label_PAA.Size = new System.Drawing.Size(284, 104);
            this.label_PAA.TabIndex = 0;
            this.label_PAA.Text = "Разработчик: Пождин А.А\r\nгруппа АСОиУБ-23-1\r\n\r\nПрограмма разработана в рамках изу" +
    "чения языка C#\r\n\r\nТюменский индустриальный университет (с) 2023\r\nВысшая школа ци" +
    "фровых технологий (с) 2023\r\n\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.PozhdinAA.Sprint7.Project.V12.Properties.Resources.Без_имениsssss_1;
            this.pictureBox1.Location = new System.Drawing.Point(7, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 143);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonClose_PAA
            // 
            this.buttonClose_PAA.Location = new System.Drawing.Point(274, 119);
            this.buttonClose_PAA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose_PAA.Name = "buttonClose_PAA";
            this.buttonClose_PAA.Size = new System.Drawing.Size(111, 34);
            this.buttonClose_PAA.TabIndex = 4;
            this.buttonClose_PAA.Text = "OK";
            this.buttonClose_PAA.UseVisualStyleBackColor = true;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 163);
            this.Controls.Add(this.buttonClose_PAA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_PAA);
            this.Name = "FormAbout";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_PAA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClose_PAA;
    }
}

