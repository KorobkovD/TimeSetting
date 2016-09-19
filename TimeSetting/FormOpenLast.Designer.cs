namespace TimeSetting
{
    partial class FormOpenLast
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxHour = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(12, 12);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(36, 20);
            this.textBoxDay.TabIndex = 0;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "Января",
            "Февраля",
            "Марта",
            "Апреля",
            "Мая",
            "Июня",
            "Июля",
            "Августа",
            "Сентября",
            "Октября",
            "Ноября",
            "Декабря"});
            this.comboBoxMonth.Location = new System.Drawing.Point(54, 12);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMonth.TabIndex = 1;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(181, 12);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(51, 20);
            this.textBoxYear.TabIndex = 2;
            // 
            // textBoxHour
            // 
            this.textBoxHour.Location = new System.Drawing.Point(255, 12);
            this.textBoxHour.Name = "textBoxHour";
            this.textBoxHour.Size = new System.Drawing.Size(34, 20);
            this.textBoxHour.TabIndex = 3;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(294, 12);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(34, 20);
            this.textBoxMin.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = ":";
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(255, 38);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(75, 23);
            this.buttonSet.TabIndex = 6;
            this.buttonSet.Text = "Установить";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // FormOpenLast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 71);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxHour);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormOpenLast";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Последние записанные настройки времени";
            this.Load += new System.EventHandler(this.FormOpenLast_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxHour;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSet;
    }
}