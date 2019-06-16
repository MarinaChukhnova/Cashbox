using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashOption
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonPKO_Click(object sender, EventArgs e)
        {
            FormPrihod FormPrihod = new FormPrihod();
            FormPrihod.Show();
            this.Hide();
        }

        private void buttonRKO_Click(object sender, EventArgs e)
        {
            FormRashod FormRashod = new FormRashod();
            FormRashod.Show();
            this.Hide();
        }

        private void buttonJurnal_Click(object sender, EventArgs e)
        {
            FormJurnal FormJurnal = new FormJurnal();
            FormJurnal.Show();
            this.Hide();
        }

        private void счетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormScheta FormScheta = new FormScheta();
            FormScheta.Show();
            this.Hide();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSotrudniki FormSotrudniki = new FormSotrudniki();
            FormSotrudniki.Show();
            this.Hide();
        }

        private void лимитКассыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLimit FormLimit = new FormLimit();
            FormLimit.Show();
            this.Hide();
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            FormCassBook FormCassBook = new FormCassBook();
            FormCassBook.Show();
            this.Hide();
        }

        private void приходныйКассовыйОрдерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrihod FormPrihod = new FormPrihod();
            FormPrihod.Show();
            this.Hide();
        }

        private void расходныйКассовыйОрдерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRashod FormRashod = new FormRashod();
            FormRashod.Show();
            this.Hide();
        }

        private void кассоваяКнигаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCassBook FormCassBook = new FormCassBook();
            FormCassBook.Show();
            this.Hide();
        }

        private void журналРегистрацииКассовыхОрдеровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJurnal FormJurnal = new FormJurnal();
            FormJurnal.Show();
            this.Hide();
        }
    }
}
