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
    public partial class Camera_final : Form
    {
        /*public static Dictionary<string, string> Assign(List<string> participants)
        {
            Random random = new Random();
            List<string> givers = new List<string>(participants);
            List<string> receivers = new List<string>(participants);
            Dictionary<string, string> assignments = new Dictionary<string, string>();

            foreach (string giver in givers)
            {
                List<string> possibleReceivers = receivers.FindAll(r => r != giver);
                if (possibleReceivers.Count == 0)
                {
                    return Assign(participants);
                }

                string receiver = possibleReceivers[random.Next(possibleReceivers.Count)];
                receivers.Remove(receiver);
                assignments[giver] = receiver;
            }

            return assignments;
        }*/

        static string GetRandomTerm(string input)
        {
            // Separăm termenii din string folosind ; ca separator
            string[] terms = input.Split(';');

            // Inițializăm generatorul de numere aleatoare
            Random random = new Random();

            // Selectăm un termen aleator
            int randomIndex = random.Next(terms.Length);

            return terms[randomIndex];
        }
        public Camera_final()
        {
            InitializeComponent();
            string input = "Dovlecel Maria; Florea Dinu; Hanna John; Klaus Johann; Ursut Grigore";
            string term1 = GetRandomTerm(input);
            string detalii = "Robot; Ciocolata; Trenulet; Pistol de jucarie; Ursulet de plus";
            string term2 = GetRandomTerm(detalii);
            Nume_spiridus.Text = term1 + Environment.NewLine + "Si isi doreste:" + term2;
        }

        private void Back_to_menu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var Meniu_principal = new Main_Menu();
            Meniu_principal.Show();
        }

        private void Copy_data_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Nume_spiridus.Text);
        }

        private void Camera_final_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
