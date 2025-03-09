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
    public partial class Camera_Join : Form
    {
        private string nume;
        public Camera_Join(string nume)
        {
            InitializeComponent();
            this.nume = nume;
        }

        private void Join_the_room_Click(object sender, EventArgs e)
        {
           
            if (Write_room.Text.Length > 0 && Write_room.Text.Length < 7)
            {
                this.Visible = false;
                int code = int.Parse(Write_room.Text);
                var Intra_in_camera = new Camera_creata(5, code, nume);
                Intra_in_camera.Show();
            }
            else
            {
                Add_room.Text = "Introduceti un cod valid!";
            }
            
        }

        private void Camera_Join_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
