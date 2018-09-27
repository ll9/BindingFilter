namespace BindingFilter
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.FeaturesGrid = new System.Windows.Forms.DataGridView();
            this.FeaturesBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.FeaturesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FeaturesGrid
            // 
            this.FeaturesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FeaturesGrid.Location = new System.Drawing.Point(27, 32);
            this.FeaturesGrid.Name = "FeaturesGrid";
            this.FeaturesGrid.Size = new System.Drawing.Size(279, 180);
            this.FeaturesGrid.TabIndex = 0;
            // 
            // FeaturesBox
            // 
            this.FeaturesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FeaturesBox.FormattingEnabled = true;
            this.FeaturesBox.Location = new System.Drawing.Point(382, 34);
            this.FeaturesBox.Name = "FeaturesBox";
            this.FeaturesBox.Size = new System.Drawing.Size(217, 21);
            this.FeaturesBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FeaturesBox);
            this.Controls.Add(this.FeaturesGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FeaturesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FeaturesGrid;
        private System.Windows.Forms.ComboBox FeaturesBox;
    }
}

