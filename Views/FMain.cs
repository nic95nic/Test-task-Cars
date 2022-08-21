using System.Globalization;
using Test_task_Cars.Interfaces;
using Test_task_Cars.Models;

namespace Test_task_Cars.Views
{
    public partial class FMain : Form
    {
        private readonly Dictionary<Guid, Auto> _cars;
        public FMain()
        {
            InitializeComponent();
            _cars = new Dictionary<Guid, Auto>();
        }

        private void btnCreateAuto_Click(object sender, EventArgs e)
        {
            using var createAuto = new FNewAuto();
            if (createAuto.ShowDialog() != DialogResult.OK) return;
            _cars.Add(Guid.NewGuid(), createAuto.GetAuto());
            ReBindingCarsList();
        }

        private void ReBindingCarsList()
        {
            listBoxCarsList.DataSource = _cars.Values.ToList();
            listBoxCarsList.DisplayMember = "NameAuto";
        }

        private Auto? GetSelectedAuto()
        {
            return listBoxCarsList.SelectedItem as Auto;
        }

        private void btnAddPassenger_Click(object sender, EventArgs e)
        {
            if (GetSelectedAuto() is IPassengerCarOperations selectedPassengerAuto)
                selectedPassengerAuto.AddPassenger();
            UpdateAdditionalInfo();

        }

        private void btnRemovePassenger_Click(object sender, EventArgs e)
        {
            if (GetSelectedAuto() is IPassengerCarOperations selectedPassengerAuto)
                selectedPassengerAuto.RemovePassenger();
            UpdateAdditionalInfo();
        }

        private void UpdateAdditionalInfo()
        {
            ClearAdditionalInfo();
            var selectedAuto = GetSelectedAuto();
            if (selectedAuto == null) return;
            textBoxEngine.Text = selectedAuto.AutoEngine.ToString();
            textBoxFuelСonsumption.Text = Convert.ToString(selectedAuto.AutoEngine.FuelСonsumptionPerOneHundredKm);
            textBoxFuel.Text = Convert.ToString(selectedAuto.Fuel);
            textBoxKmPerFuel.Text = Convert.ToString(selectedAuto.GetDistanseByFuelVolume(selectedAuto.Fuel), CultureInfo.InvariantCulture);
            textBoxTankFuel.Text = Convert.ToString(selectedAuto.TankVolume);
            switch (selectedAuto)
            {
                case IPassengerCarOperations passengerOperations:
                    textBoxPassenger.Text = Convert.ToString(passengerOperations.CurrentPassengerCount);
                    break;
                case ICargoCarOperations cargoOperations:
                    textBoxWeight.Text = Convert.ToString(cargoOperations.CurrentWeight, CultureInfo.InvariantCulture);
                    break;
            }
        }

        private void ClearAdditionalInfo()
        {
            textBoxEngine.Text = string.Empty;
            textBoxFuel.Text = string.Empty;
            textBoxKmPerFuel.Text = string.Empty;
            textBoxTankFuel.Text = string.Empty;
            textBoxPassenger.Text = string.Empty;
            textBoxWeight.Text= string.Empty;
            textBoxFuelСonsumption.Text = string.Empty;
        }

        private void listBoxCarsList_SelectedIndexChanged(object sender, EventArgs e) => UpdateAdditionalInfo();

        private void btnAddWeight_Click(object sender, EventArgs e)
        {
            if (GetSelectedAuto() is ICargoCarOperations selectedCargoAuto)
                selectedCargoAuto.AddWeight(50);
            UpdateAdditionalInfo();
        }

        private void btnRemoveWeight_Click(object sender, EventArgs e)
        {
            if (GetSelectedAuto() is ICargoCarOperations selectedCargoAuto)
                selectedCargoAuto.RemoveWeight(50);
            UpdateAdditionalInfo();
        }
    }
}
