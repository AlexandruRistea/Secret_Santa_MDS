using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }



        private void Create_Room_Click(object sender, EventArgs e)
        {
            if (Nume_Util.Text.Length >0)
            {
                this.Visible = false;
                var Camera_Noua = new Camera_creata(5, 0,Nume_Util.Text);
                Camera_Noua.Show();
            }
            else Nume_Util.Text = "Trebuie introdus un nume!";

        }

        private void Join_Room_Click(object sender, EventArgs e)
        {
            if (Nume_Util.Text.Length > 0)
            {
                this.Visible = false;
                var Camera_de_intrat = new Camera_Join(Nume_Util.Text);
                Camera_de_intrat.Show();
            }
            else Nume_Util.Text = "Trebuie introdus un nume!";
        }

        private void Main_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
