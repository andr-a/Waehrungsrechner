namespace Währungsrechner
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
            this.btn_from = new System.Windows.Forms.Button();
            this.cbx_currency = new System.Windows.Forms.ComboBox();
            this.la_input = new System.Windows.Forms.Label();
            this.tbx_input = new System.Windows.Forms.TextBox();
            this.tbx_output = new System.Windows.Forms.TextBox();
            this.la_output = new System.Windows.Forms.Label();
            this.la_currency = new System.Windows.Forms.Label();
            this.btn_to = new System.Windows.Forms.Button();
            this.btn_database = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_from
            // 
            this.btn_from.Location = new System.Drawing.Point(37, 51);
            this.btn_from.Name = "btn_from";
            this.btn_from.Size = new System.Drawing.Size(75, 23);
            this.btn_from.TabIndex = 0;
            this.btn_from.Text = "From Euro";
            this.btn_from.UseVisualStyleBackColor = true;
            this.btn_from.Click += new System.EventHandler(this.btn_from_Click);
            // 
            // cbx_currency
            // 
            this.cbx_currency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_currency.FormattingEnabled = true;
            this.cbx_currency.Location = new System.Drawing.Point(197, 48);
            this.cbx_currency.Name = "cbx_currency";
            this.cbx_currency.Size = new System.Drawing.Size(47, 21);
            this.cbx_currency.TabIndex = 2;
            // 
            // la_input
            // 
            this.la_input.AutoSize = true;
            this.la_input.Location = new System.Drawing.Point(12, 9);
            this.la_input.Name = "la_input";
            this.la_input.Size = new System.Drawing.Size(34, 13);
            this.la_input.TabIndex = 3;
            this.la_input.Text = "Input:";
            // 
            // tbx_input
            // 
            this.tbx_input.Location = new System.Drawing.Point(12, 25);
            this.tbx_input.Name = "tbx_input";
            this.tbx_input.Size = new System.Drawing.Size(100, 20);
            this.tbx_input.TabIndex = 4;
            this.tbx_input.Text = "0";
            // 
            // tbx_output
            // 
            this.tbx_output.Location = new System.Drawing.Point(144, 25);
            this.tbx_output.Name = "tbx_output";
            this.tbx_output.ReadOnly = true;
            this.tbx_output.Size = new System.Drawing.Size(100, 20);
            this.tbx_output.TabIndex = 4;
            this.tbx_output.Text = "0";
            // 
            // la_output
            // 
            this.la_output.AutoSize = true;
            this.la_output.Location = new System.Drawing.Point(141, 9);
            this.la_output.Name = "la_output";
            this.la_output.Size = new System.Drawing.Size(42, 13);
            this.la_output.TabIndex = 3;
            this.la_output.Text = "Output:";
            // 
            // la_currency
            // 
            this.la_currency.AutoSize = true;
            this.la_currency.Location = new System.Drawing.Point(141, 51);
            this.la_currency.Name = "la_currency";
            this.la_currency.Size = new System.Drawing.Size(52, 13);
            this.la_currency.TabIndex = 3;
            this.la_currency.Text = "Currency:";
            // 
            // btn_to
            // 
            this.btn_to.Location = new System.Drawing.Point(37, 80);
            this.btn_to.Name = "btn_to";
            this.btn_to.Size = new System.Drawing.Size(75, 23);
            this.btn_to.TabIndex = 0;
            this.btn_to.Text = "To Euro";
            this.btn_to.Click += new System.EventHandler(this.btn_to_Click);
            // 
            // btn_database
            // 
            this.btn_database.Location = new System.Drawing.Point(171, 80);
            this.btn_database.Name = "btn_database";
            this.btn_database.Size = new System.Drawing.Size(75, 23);
            this.btn_database.TabIndex = 5;
            this.btn_database.Text = "Database";
            this.btn_database.UseVisualStyleBackColor = true;
            this.btn_database.Click += new System.EventHandler(this.btn_database_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 132);
            this.Controls.Add(this.btn_database);
            this.Controls.Add(this.tbx_output);
            this.Controls.Add(this.tbx_input);
            this.Controls.Add(this.la_currency);
            this.Controls.Add(this.la_output);
            this.Controls.Add(this.la_input);
            this.Controls.Add(this.cbx_currency);
            this.Controls.Add(this.btn_to);
            this.Controls.Add(this.btn_from);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_from;
        private System.Windows.Forms.ComboBox cbx_currency;
        private System.Windows.Forms.Label la_input;
        private System.Windows.Forms.TextBox tbx_input;
        private System.Windows.Forms.TextBox tbx_output;
        private System.Windows.Forms.Label la_output;
        private System.Windows.Forms.Label la_currency;
        private System.Windows.Forms.Button btn_to;
        private System.Windows.Forms.Button btn_database;
    }
}

