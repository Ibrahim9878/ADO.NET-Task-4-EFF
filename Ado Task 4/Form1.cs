using Microsoft.IdentityModel.Tokens;

namespace Ado_Task_4
{
    public partial class Form1 : Form
    {
        List<Car> cars { get; set; }
        public Form1()
        {
            InitializeComponent();
            using CarContext carContext = new CarContext();
            CarBox.DataSource = carContext.cars.ToList();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (makeBox.Text != null || modelBox.Text != null || yearBox.Text != null || numberBox1.Text != null)
            {
                using CarContext carContext = new CarContext();
                Car car = new Car(makeBox.Text, modelBox.Text, int.Parse(yearBox.Text), numberBox1.Text);
                carContext.Add(car);
                carContext.SaveChanges();
                CarBox.DataSource = carContext.cars.ToList();
                CarBox.Refresh();
            }

            makeBox.Text = string.Empty;
            modelBox.Text = string.Empty;
            yearBox.Text = string.Empty;
            numberBox1.Text = string.Empty;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            using (CarContext carContext = new())
            {
                Car? car = CarBox.SelectedItem as Car;

                //var car1 = carContext.cars.FirstOrDefault(c => c.Id == car!.Id);

                car.Model = modelBox.Text;
                car.Make = makeBox.Text;
                car.Year = int.Parse(yearBox.Text);
                car.StNumber = numberBox1.Text;
                carContext.cars.Update(car);
                carContext.SaveChanges();
                CarBox.DataSource = carContext.cars.ToList();
                CarBox.Refresh();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (CarContext carContext = new())
            {
                Car? car = CarBox.SelectedItem as Car;

                var car1 = carContext.cars.FirstOrDefault(c => c.Model == car!.Model && c.Make == car.Make && c.Year == car.Year && c.StNumber == car.StNumber);

                carContext.cars.Remove(car1);
                carContext.SaveChanges();
                CarBox.DataSource = carContext.cars.ToList();
                CarBox.Refresh();
            }
        }

        private void CarBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var carContext = new CarContext())
            {
                Car? car = CarBox.SelectedItem as Car;

                var car1 = carContext.cars.FirstOrDefault(c => c.Id == car.Id);
                makeBox.Text = car1.Make;
                modelBox.Text = car1.Model;
                yearBox.Text = car1.Year.ToString();
                numberBox1.Text = car1.StNumber;
            }
        }
    }
}
