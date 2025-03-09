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
    public partial class Camera_creata : Form
    {
        public Camera_creata(int participanti,int cod,string nume)
        {
            InitializeComponent();
            Lista_useri.Text += " " + participanti.ToString();
            nr_useri.Text = nume + Environment.NewLine;
            if (cod == 0)
            {
                Random rnd = new Random();
                Actual_room_code.Text = rnd.Next(100000, 999999).ToString();
            }
            else Actual_room_code.Text = cod.ToString();
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var Camera_de_final = new Camera_final();
            Camera_de_final.Show();
        }

        private void Camera_creata_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
