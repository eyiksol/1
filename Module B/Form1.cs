using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void btntov_Click(object sender, EventArgs e)
        {
            loadform(new tovari());
        }

        private void btnzak_Click(object sender, EventArgs e)
        {
            loadform(new zakazi());
        }

        private void btnskl_Click(object sender, EventArgs e)
        {
            loadform(new sklad());
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsmoll_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnbig_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized; // Разворачивает окно приложения
            }
            else
            {
                this.WindowState = FormWindowState.Normal; // Восстанавливает окно приложения из свернутого состояния
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр окна, на которое мы хотим перейти
            Form1 newForm = new Form1();

            // Скрываем текущее окно
            this.Hide();

            // Показываем новое окно
            newForm.ShowDialog();

            // Показываем снова текущее окно после закрытия нового окна
            this.Show();
        }
    }
}
