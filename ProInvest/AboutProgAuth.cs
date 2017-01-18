using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProInvest
{
    public partial class AboutProgAuth : Form
    {
        public AboutProgAuth()
        {
            InitializeComponent();
        }

        // Событие возникающее при клике на кнопку Ок
        private void OkBut_Click(object sender, EventArgs e)
        {
            // Закрываем форму
            this.Close();
        }
    }
}
