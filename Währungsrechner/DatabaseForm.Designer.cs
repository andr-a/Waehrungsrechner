namespace Währungsrechner
{
    partial class DatabaseForm
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
            this.btn_write = new System.Windows.Forms.Button();
            this.btn_drop = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_write
            // 
            this.btn_write.Location = new System.Drawing.Point(12, 41);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(236, 23);
            this.btn_write.TabIndex = 0;
            this.btn_write.Text = "(Re-) Write DB";
            this.btn_write.UseVisualStyleBackColor = true;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // btn_drop
            // 
            this.btn_drop.Location = new System.Drawing.Point(12, 99);
            this.btn_drop.Name = "btn_drop";
            this.btn_drop.Size = new System.Drawing.Size(236, 23);
            this.btn_drop.TabIndex = 0;
            this.btn_drop.Text = "Drop DB";
            this.btn_drop.UseVisualStyleBackColor = true;
            this.btn_drop.Click += new System.EventHandler(this.btn_drop_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(13, 12);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(236, 23);
            this.btn_create.TabIndex = 0;
            this.btn_create.Text = "Create DB";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(12, 70);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(236, 23);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "Delete Data";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 138);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_drop);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_write);
            this.Name = "DatabaseForm";
            this.Text = "DatabaseForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_write;
        private System.Windows.Forms.Button btn_drop;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_delete;
    }
}