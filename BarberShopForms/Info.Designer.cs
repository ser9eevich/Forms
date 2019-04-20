namespace BarberShopForms
{
    partial class Info
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
            this.name = new System.Windows.Forms.TextBox();
            this.birthday = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.visitDate = new System.Windows.Forms.TextBox();
            this.service = new System.Windows.Forms.TextBox();
            this.worker = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(98, 52);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(274, 20);
            this.name.TabIndex = 0;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // birthday
            // 
            this.birthday.Location = new System.Drawing.Point(98, 95);
            this.birthday.Name = "birthday";
            this.birthday.ReadOnly = true;
            this.birthday.Size = new System.Drawing.Size(274, 20);
            this.birthday.TabIndex = 1;
            this.birthday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(98, 140);
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Size = new System.Drawing.Size(274, 20);
            this.phone.TabIndex = 2;
            this.phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // visitDate
            // 
            this.visitDate.Location = new System.Drawing.Point(98, 188);
            this.visitDate.Name = "visitDate";
            this.visitDate.ReadOnly = true;
            this.visitDate.Size = new System.Drawing.Size(274, 20);
            this.visitDate.TabIndex = 3;
            this.visitDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // service
            // 
            this.service.Location = new System.Drawing.Point(98, 236);
            this.service.Name = "service";
            this.service.ReadOnly = true;
            this.service.Size = new System.Drawing.Size(274, 20);
            this.service.TabIndex = 4;
            this.service.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // worker
            // 
            this.worker.Location = new System.Drawing.Point(98, 287);
            this.worker.Name = "worker";
            this.worker.ReadOnly = true;
            this.worker.Size = new System.Drawing.Size(274, 20);
            this.worker.TabIndex = 5;
            this.worker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дата рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата посещения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Услуга";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Имя барбера";
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.worker);
            this.Controls.Add(this.service);
            this.Controls.Add(this.visitDate);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Info";
            this.Text = "Информация о клиенте";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox birthday;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox visitDate;
        private System.Windows.Forms.TextBox service;
        private System.Windows.Forms.TextBox worker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}