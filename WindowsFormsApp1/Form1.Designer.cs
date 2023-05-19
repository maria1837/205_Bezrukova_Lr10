using System;

namespace WindowsFormsApp1
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
            this.Label1 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(37, 206);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(130, 80);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Вид";
            this.Label1.UseVisualStyleBackColor = true;
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(211, 206);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(130, 80);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Форма";
            this.Label2.UseVisualStyleBackColor = true;
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(392, 206);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(130, 80);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Информация";
            this.Label3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(559, 284);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 308);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button Label1;
        private System.Windows.Forms.Button Label2;
        private System.Windows.Forms.Button Label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

