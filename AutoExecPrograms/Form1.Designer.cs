namespace AutoExecPrograms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_appname = new System.Windows.Forms.Label();
            this.button_exec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_appname
            // 
            this.label_appname.AutoSize = true;
            this.label_appname.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_appname.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_appname.Location = new System.Drawing.Point(13, 13);
            this.label_appname.Name = "label_appname";
            this.label_appname.Size = new System.Drawing.Size(200, 37);
            this.label_appname.TabIndex = 0;
            this.label_appname.Text = "APP_NAME";
            // 
            // button_exec
            // 
            this.button_exec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exec.Location = new System.Drawing.Point(292, 119);
            this.button_exec.MaximumSize = new System.Drawing.Size(90, 30);
            this.button_exec.Name = "button_exec";
            this.button_exec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_exec.Size = new System.Drawing.Size(80, 30);
            this.button_exec.TabIndex = 1;
            this.button_exec.Text = "EXEC_BUTTON";
            this.button_exec.UseVisualStyleBackColor = true;
            this.button_exec.Click += new System.EventHandler(this.button_exec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.button_exec);
            this.Controls.Add(this.label_appname);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "Form1";
            this.Text = "Форма 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_appname;
        private System.Windows.Forms.Button button_exec;
    }
}

