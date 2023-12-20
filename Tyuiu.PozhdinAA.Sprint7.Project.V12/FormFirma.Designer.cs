
namespace Tyuiu.PozhdinAA.Sprint7.Project.V12
{
    partial class FormFirma
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
            this.dataGridViewInFirma_PAA = new System.Windows.Forms.DataGridView();
            this.buttonBrowser_PAA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInFirma_PAA)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInFirma_PAA
            // 
            this.dataGridViewInFirma_PAA.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewInFirma_PAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInFirma_PAA.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewInFirma_PAA.Name = "dataGridViewInFirma_PAA";
            this.dataGridViewInFirma_PAA.Size = new System.Drawing.Size(480, 275);
            this.dataGridViewInFirma_PAA.TabIndex = 0;
            // 
            // buttonBrowser_PAA
            // 
            this.buttonBrowser_PAA.Location = new System.Drawing.Point(10, 291);
            this.buttonBrowser_PAA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBrowser_PAA.Name = "buttonBrowser_PAA";
            this.buttonBrowser_PAA.Size = new System.Drawing.Size(121, 37);
            this.buttonBrowser_PAA.TabIndex = 2;
            this.buttonBrowser_PAA.Text = "Открыть браузер";
            this.buttonBrowser_PAA.UseVisualStyleBackColor = true;
            // 
            // FormFirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 335);
            this.Controls.Add(this.buttonBrowser_PAA);
            this.Controls.Add(this.dataGridViewInFirma_PAA);
            this.Name = "FormFirma";
            this.Text = "Фирмы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInFirma_PAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInFirma_PAA;
        private System.Windows.Forms.Button buttonBrowser_PAA;
    }
}