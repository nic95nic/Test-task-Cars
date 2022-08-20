using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Test_task_Cars.Enums;
using Test_task_Cars.Factory;
using Test_task_Cars.Models;
using DialogResult = System.Windows.Forms.DialogResult;

namespace Test_task_Cars.Views
{
    public partial class FNewAuto : Form
    {
        public FNewAuto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public Auto GetAuto()
        {
            TypeAuto typeAuto = TypeAuto.Cargo;
            if (rbCargoType.Checked)
                typeAuto = TypeAuto.Cargo;
            else if (rbPassengerType.Checked)
                typeAuto = TypeAuto.Passenger;
            else if (rbSportCar.Checked)
                typeAuto = TypeAuto.Sport;
            return CarFactory.GetAuto(typeAuto, textBoxNameAuto.Text.Trim());
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;
            DialogResult = DialogResult.OK;
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(Convert.ToString(textBoxNameAuto.Text)))
            {
                MessageBox.Show("Заполните наименование автомобиля!");
                return false;
            }

            return true;
        }
    }
}
