using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_task_Cars.Interfaces;
using Test_task_Cars.Models;

namespace Test_task_Cars.Views
{
    public partial class FMain : Form
    {
        private Dictionary<Guid, Auto> Cars;
        public FMain()
        {
            InitializeComponent();
            Cars = new Dictionary<Guid, Auto>();
        }

        private void btnCreateAuto_Click(object sender, EventArgs e)
        {
            using FNewAuto createAuto = new FNewAuto();
            if (createAuto.ShowDialog() == DialogResult.OK)
            {
                Cars.Add(Guid.NewGuid(), createAuto.GetAuto());
                ReBindingCarsList();
            }
        }

        private void ReBindingCarsList()
        {
            listBoxCarsList.DataSource = Cars.Values.ToList();
            listBoxCarsList.DisplayMember = "NameAuto";
        }

        private Auto? getSelectedAuto()
        {
            return listBoxCarsList.SelectedItem as Auto;
        }

        private void btnAddPassenger_Click(object sender, EventArgs e)
        {
            if (getSelectedAuto() is IPassengerCarOperation selectedPassangerAuto)
                selectedPassangerAuto.AddPassenger();
            UpdateAdditionalInfo();

        }

        private void btnRemovePassenger_Click(object sender, EventArgs e)
        {
            if (getSelectedAuto() is IPassengerCarOperation selectedPassangerAuto)
                selectedPassangerAuto.RemovePassenger();
            UpdateAdditionalInfo();
        }

        private void UpdateAdditionalInfo()
        {
            ClearAdditionalInfo();
            Auto? selectedAuto = getSelectedAuto();
            textBoxEngine.Text = selectedAuto?.AutoEngine.ToString();
            textBoxFuel.Text = Convert.ToString(selectedAuto?.Fuel);
            textBoxKmPerFuel.Text = Convert.ToString(selectedAuto.GetDistanseByFuelVolume(selectedAuto.Fuel));
            textBoxTankFuel.Text = Convert.ToString(selectedAuto.TankVolume);
            if (selectedAuto is IPassengerCarOperation)
                textBoxPassenger.Text = Convert.ToString(((IPassengerCarOperation)selectedAuto).CurrentPassengerCount);
            if(selectedAuto is ICargoCarOperations)
                textBoxWeight.Text = Convert.ToString(((ICargoCarOperations)selectedAuto).CurrentWeight);

        }

        private void ClearAdditionalInfo()
        {
            textBoxEngine.Text = string.Empty;
            textBoxFuel.Text = string.Empty;
            textBoxKmPerFuel.Text = string.Empty;
            textBoxTankFuel.Text = string.Empty;
            textBoxPassenger.Text = string.Empty;
            textBoxWeight.Text= string.Empty;
        }

        private void listBoxCarsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAdditionalInfo();
        }

        private void btnAddWeight_Click(object sender, EventArgs e)
        {
            if (getSelectedAuto() is ICargoCarOperations selectedCargoAuto)
                selectedCargoAuto.AddWeight(50);
            UpdateAdditionalInfo();
        }

        private void btnRemoveWeight_Click(object sender, EventArgs e)
        {
            if (getSelectedAuto() is ICargoCarOperations selectedCargoAuto)
                selectedCargoAuto.RemoveWeight(50);
            UpdateAdditionalInfo();
        }
    }
}
