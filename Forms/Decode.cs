using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPv4.Forms
{
    public partial class Decode : Form
    {
        public Decode()
        {
            InitializeComponent();
        }

        private void Decode_Load(object sender, EventArgs e)
        {
            setExercice(0);
            setError(0);
        }

        private void setExercice(int number)
        {
            lblExercice.Text = $"Nombre d'exercice(s) : {number.ToString()}";
        }

        private void setError(int number)
        {
            lblError.Text = $"Nombre d'erreur(s) : {number.ToString()}";
        }
    }
}
