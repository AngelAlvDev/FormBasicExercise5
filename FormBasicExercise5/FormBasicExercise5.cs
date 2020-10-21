using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBasicExercise5
{
    public partial class FormBasicExercise5 : Form
    {
        public FormBasicExercise5()
        {
            InitializeComponent();
        }

        private void iniciarButton_Click(object sender, EventArgs e)
        {
            Int32 resultado = 0;
            for(Int32 iterator = 1; iterator <= numericUpDown.Value; iterator++)
            {
                resultado += iterator;
                if((parcialCheckBox.Checked == true) && (iterator != numericUpDown.Value))
                {
                    resultadoListBox.Items.Add("sumando: " + iterator + ". Suma parcial: " + resultado);
                }
            }
            resultadoListBox.Items.Add("La suma total es " + resultado);
            resultadoListBox.EndUpdate();
        }
    }
}
