using Newtonsoft.Json;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DolarCalc
{
    public partial class Form1 : Form
    {
        private double input, output;

        public Form1()
        {
            InitializeComponent();
            refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private async void refresh()
        {
            DateTime now = DateTime.Now;
            using (var httpClient = new HttpClient())
            {
                var uri = new Uri("https://dolarapi.com/v1/dolares/oficial");

                var response = await httpClient.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var datos = JsonConvert.DeserializeObject<dynamic>(json);

                    var venta = datos.venta;

                    txtOficial.Text = venta.ToString();
                    lOficial.Text = now.ToString();
                }
                else
                {
                    txtOficial.Text = "Error al obtener datos";
                }
            }


            using (var httpClient = new HttpClient())
            {
                var uri = new Uri("https://dolarapi.com/v1/dolares/blue");

                var response = await httpClient.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var datos = JsonConvert.DeserializeObject<dynamic>(json);

                    var venta = datos.venta;

                    txtBlue.Text = venta.ToString();
                    lBlue.Text = now.ToString();
                }
                else
                {
                    txtBlue.Text = "Error al obtener datos";
                }
            }

            using (var httpClient = new HttpClient())
            {
                var uri = new Uri("https://dolarapi.com/v1/dolares/bolsa");

                var response = await httpClient.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var datos = JsonConvert.DeserializeObject<dynamic>(json);

                    var venta = datos.venta;

                    txtMep.Text = venta.ToString();
                    lMep.Text = now.ToString();
                }
                else
                {
                    txtMep.Text = "Error al obtener datos";
                }
            }

            using (var httpClient = new HttpClient())
            {
                var uri = new Uri("https://dolarapi.com/v1/dolares/tarjeta");

                var response = await httpClient.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var datos = JsonConvert.DeserializeObject<dynamic>(json);

                    var venta = datos.venta;

                    txtTarjeta.Text = venta.ToString();
                    lTarjeta.Text = now.ToString();
                }
                else
                {
                    txtTarjeta.Text = "Error al obtener datos";
                }
            }

            lFecha.Visible = true;

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            ItemSelect();

            input = double.Parse(txtInput.Text);

            output *= input;

            txtOutput.Text = output.ToString();
        }



        private void ItemSelect()
        {

            if (rbOficial.Checked)
            {
                output = double.Parse(txtOficial.Text);
            }
            if (rbBlue.Checked)
            {
                output = double.Parse(txtBlue.Text);
            }
            if (rbMep.Checked)
            {
                output = double.Parse(txtMep.Text);
            }
            if (rbTarjeta.Checked)
            {
                output = double.Parse(txtTarjeta.Text);
            }

        }



    }
}
