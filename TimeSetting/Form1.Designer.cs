namespace TimeSetting
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
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonSetTime = new System.Windows.Forms.Button();
            this.buttonOpenLast = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(12, 9);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(91, 13);
            this.labelOutput.TabIndex = 0;
            this.labelOutput.Text = "Время сервера: ";
            // 
            // buttonSetTime
            // 
            this.buttonSetTime.Location = new System.Drawing.Point(12, 28);
            this.buttonSetTime.Name = "buttonSetTime";
            this.buttonSetTime.Size = new System.Drawing.Size(133, 23);
            this.buttonSetTime.TabIndex = 1;
            this.buttonSetTime.Text = "Установить это время";
            this.buttonSetTime.UseVisualStyleBackColor = true;
            this.buttonSetTime.Click += new System.EventHandler(this.buttonSetTime_Click);
            this.buttonSetTime.MouseEnter += new System.EventHandler(this.buttonSetTime_MouseEnter);
            this.buttonSetTime.MouseLeave += new System.EventHandler(this.buttonRefresh_MouseLeave);
            // 
            // buttonOpenLast
            // 
            this.buttonOpenLast.Location = new System.Drawing.Point(12, 57);
            this.buttonOpenLast.Name = "buttonOpenLast";
            this.buttonOpenLast.Size = new System.Drawing.Size(248, 23);
            this.buttonOpenLast.TabIndex = 2;
            this.buttonOpenLast.Text = "Открыть последнее установленное";
            this.buttonOpenLast.UseVisualStyleBackColor = true;
            this.buttonOpenLast.Click += new System.EventHandler(this.buttonOpenLast_Click);
            this.buttonOpenLast.MouseEnter += new System.EventHandler(this.buttonOpenLast_MouseEnter);
            this.buttonOpenLast.MouseLeave += new System.EventHandler(this.buttonRefresh_MouseLeave);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(151, 28);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(54, 23);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Обнов.";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            this.buttonRefresh.MouseEnter += new System.EventHandler(this.buttonRefresh_MouseEnter);
            this.buttonRefresh.MouseLeave += new System.EventHandler(this.buttonRefresh_MouseLeave);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelInfo.Controls.Add(this.labelInfo);
            this.panelInfo.Location = new System.Drawing.Point(-1, 81);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(274, 23);
            this.panelInfo.TabIndex = 4;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(3, 4);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(35, 13);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "label1";
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(211, 28);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(49, 23);
            this.buttonWrite.TabIndex = 5;
            this.buttonWrite.Text = "Запис.";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            this.buttonWrite.MouseEnter += new System.EventHandler(this.buttonWrite_MouseEnter);
            this.buttonWrite.MouseLeave += new System.EventHandler(this.buttonRefresh_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 102);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonOpenLast);
            this.Controls.Add(this.buttonSetTime);
            this.Controls.Add(this.labelOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Синхронизация времени";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonSetTime;
        private System.Windows.Forms.Button buttonOpenLast;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonWrite;
    }
}

