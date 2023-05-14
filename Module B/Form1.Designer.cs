namespace Module_B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelside = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnim = new System.Windows.Forms.Button();
            this.btnex = new System.Windows.Forms.Button();
            this.btnskl = new System.Windows.Forms.Button();
            this.btnzak = new System.Windows.Forms.Button();
            this.btntov = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelheader = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsmoll = new System.Windows.Forms.Button();
            this.btnbig = new System.Windows.Forms.Button();
            this.panelside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelheader.SuspendLayout();
            this.mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelside.Controls.Add(this.pictureBox1);
            this.panelside.Controls.Add(this.button6);
            this.panelside.Controls.Add(this.btnim);
            this.panelside.Controls.Add(this.btnex);
            this.panelside.Controls.Add(this.btnskl);
            this.panelside.Controls.Add(this.btnzak);
            this.panelside.Controls.Add(this.btntov);
            this.panelside.Controls.Add(this.label2);
            this.panelside.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelside.Location = new System.Drawing.Point(630, 30);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(200, 430);
            this.panelside.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.label2_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 397);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 30);
            this.button6.TabIndex = 5;
            this.button6.Text = "бэкап";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnim
            // 
            this.btnim.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnim.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnim.Location = new System.Drawing.Point(100, 361);
            this.btnim.Name = "btnim";
            this.btnim.Size = new System.Drawing.Size(100, 30);
            this.btnim.TabIndex = 4;
            this.btnim.Text = "импорт";
            this.btnim.UseVisualStyleBackColor = false;
            // 
            // btnex
            // 
            this.btnex.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnex.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnex.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnex.Location = new System.Drawing.Point(0, 361);
            this.btnex.Name = "btnex";
            this.btnex.Size = new System.Drawing.Size(100, 30);
            this.btnex.TabIndex = 3;
            this.btnex.Text = "экспорт";
            this.btnex.UseVisualStyleBackColor = false;
            // 
            // btnskl
            // 
            this.btnskl.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnskl.FlatAppearance.BorderSize = 0;
            this.btnskl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnskl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnskl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnskl.Image = ((System.Drawing.Image)(resources.GetObject("btnskl.Image")));
            this.btnskl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnskl.Location = new System.Drawing.Point(0, 160);
            this.btnskl.Name = "btnskl";
            this.btnskl.Size = new System.Drawing.Size(200, 30);
            this.btnskl.TabIndex = 2;
            this.btnskl.Text = "склад";
            this.btnskl.UseVisualStyleBackColor = false;
            this.btnskl.Click += new System.EventHandler(this.btnskl_Click);
            // 
            // btnzak
            // 
            this.btnzak.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnzak.FlatAppearance.BorderSize = 0;
            this.btnzak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnzak.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnzak.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnzak.Image = ((System.Drawing.Image)(resources.GetObject("btnzak.Image")));
            this.btnzak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnzak.Location = new System.Drawing.Point(0, 120);
            this.btnzak.Name = "btnzak";
            this.btnzak.Size = new System.Drawing.Size(200, 30);
            this.btnzak.TabIndex = 1;
            this.btnzak.Text = "заказы";
            this.btnzak.UseVisualStyleBackColor = false;
            this.btnzak.Click += new System.EventHandler(this.btnzak_Click);
            // 
            // btntov
            // 
            this.btntov.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btntov.FlatAppearance.BorderSize = 0;
            this.btntov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntov.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btntov.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btntov.Image = ((System.Drawing.Image)(resources.GetObject("btntov.Image")));
            this.btntov.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntov.Location = new System.Drawing.Point(0, 80);
            this.btntov.Name = "btntov";
            this.btntov.Size = new System.Drawing.Size(200, 30);
            this.btntov.TabIndex = 0;
            this.btntov.Text = "товары";
            this.btntov.UseVisualStyleBackColor = false;
            this.btntov.Click += new System.EventHandler(this.btntov_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(68, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "magentu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelheader.Controls.Add(this.btnbig);
            this.panelheader.Controls.Add(this.btnsmoll);
            this.panelheader.Controls.Add(this.btnclose);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(830, 30);
            this.panelheader.TabIndex = 1;
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnclose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(800, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(25, 25);
            this.btnclose.TabIndex = 6;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainpanel.Controls.Add(this.label1);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(0, 30);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(630, 430);
            this.mainpanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(632, 169);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnsmoll
            // 
            this.btnsmoll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsmoll.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnsmoll.FlatAppearance.BorderSize = 0;
            this.btnsmoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsmoll.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnsmoll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsmoll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsmoll.Location = new System.Drawing.Point(740, 0);
            this.btnsmoll.Name = "btnsmoll";
            this.btnsmoll.Size = new System.Drawing.Size(25, 25);
            this.btnsmoll.TabIndex = 7;
            this.btnsmoll.Text = "_";
            this.btnsmoll.UseVisualStyleBackColor = false;
            this.btnsmoll.Click += new System.EventHandler(this.btnsmoll_Click);
            // 
            // btnbig
            // 
            this.btnbig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnbig.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnbig.FlatAppearance.BorderSize = 0;
            this.btnbig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbig.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnbig.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnbig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbig.Location = new System.Drawing.Point(770, 3);
            this.btnbig.Name = "btnbig";
            this.btnbig.Size = new System.Drawing.Size(25, 25);
            this.btnbig.TabIndex = 8;
            this.btnbig.Text = "☐";
            this.btnbig.UseVisualStyleBackColor = false;
            this.btnbig.Click += new System.EventHandler(this.btnbig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(830, 460);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panelside);
            this.Controls.Add(this.panelheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelside.ResumeLayout(false);
            this.panelside.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelheader.ResumeLayout(false);
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Button btnskl;
        private System.Windows.Forms.Button btnzak;
        private System.Windows.Forms.Button btntov;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnim;
        private System.Windows.Forms.Button btnex;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnbig;
        private System.Windows.Forms.Button btnsmoll;
    }
}

