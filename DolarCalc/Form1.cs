using DolarCalc.Clases;
using Newtonsoft.Json;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DolarCalc
{
    public partial class Form1 : Form
    {
        private double input, output;
        private List<TipoCambio> _tipoCambios;

        public Form1()
        {
            InitializeComponent();
            GetPrice();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetPrice();
        }

        private async void GetPrice()
        {
            using (var httpClient = new HttpClient())
            {
                var uri = new Uri("https://dolarapi.com/v1/dolares");

                var response = await httpClient.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    _tipoCambios = JsonConvert.DeserializeObject<List<TipoCambio>>(json);

                    ActualizarTextBoxes();
                }
                else
                {
                    txtOficial.Text = "Error al obtener datos";
                }
                lFecha.Visible = true;
            }

            using (var httpClient = new HttpClient())
            {
                var uri = new Uri("https://dolarapi.com/v1/cotizaciones/eur");

                var response = await httpClient.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();

                    // Check if the response is an array before deserializing
                    if (json.StartsWith("["))
                    {
                        _tipoCambios = JsonConvert.DeserializeObject<List<TipoCambio>>(json);
                    }
                    else
                    {
                        // If not an array, deserialize to a single TipoCambio object
                        _tipoCambios = new List<TipoCambio>() { JsonConvert.DeserializeObject<TipoCambio>(json) };
                    }

                    ActualizarTextBoxes();
                }
                else
                {
                    txtEuro.Text = "Error al obtener datos del Euro";
                }
            }

            using (var httpClient = new HttpClient())
            {
                var uri = new Uri("https://dolarapi.com/v1/cotizaciones/brl");

                var response = await httpClient.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();

                   
                    if (json.StartsWith("["))
                    {
                        _tipoCambios = JsonConvert.DeserializeObject<List<TipoCambio>>(json);
                    }
                    else
                    {
                        _tipoCambios = new List<TipoCambio>() { JsonConvert.DeserializeObject<TipoCambio>(json) };
                    }

                    ActualizarTextBoxes();
                }
                else
                {
                    txtReal.Text = "Error al obtener datos del Real"; // Update Textbox for Euro
                }
            }

            using (var httpClient = new HttpClient())
            {
                var uri = new Uri("https://dolarapi.com/v1/cotizaciones/clp");

                var response = await httpClient.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();

                    if (json.StartsWith("["))
                    {
                        _tipoCambios = JsonConvert.DeserializeObject<List<TipoCambio>>(json);
                    }
                    else
                    {
                        _tipoCambios = new List<TipoCambio>() { JsonConvert.DeserializeObject<TipoCambio>(json) };
                    }

                    ActualizarTextBoxes();
                }
                else
                {
                    txtChileno.Text = "Error al obtener datos del Peso Chileno"; 
                }
            }

            using (var httpClient = new HttpClient())
            {
                var uri = new Uri("https://dolarapi.com/v1/cotizaciones/uyu");

                var response = await httpClient.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();

                    if (json.StartsWith("["))
                    {
                        _tipoCambios = JsonConvert.DeserializeObject<List<TipoCambio>>(json);
                    }
                    else
                    {
                        _tipoCambios = new List<TipoCambio>() { JsonConvert.DeserializeObject<TipoCambio>(json) };
                    }

                    ActualizarTextBoxes();
                }
                else
                {
                    txtUruguayo.Text = "Error al obtener datos del Peso Uruguayo"; 
                }
            }
        }

        private void ActualizarTextBoxes()
        {
            if (_tipoCambios != null)
            {
                foreach (var tipoCambio in _tipoCambios)
                {
                    if (tipoCambio.Moneda == "USD")
                    {
                        switch (tipoCambio.Casa)
                        {
                            case "oficial":
                                txtOficial.Text = tipoCambio.Venta.ToString();
                                lOficial.Text = tipoCambio.FechaActualizacion.ToString();
                                lOficial.Visible = true;
                                break;
                            case "blue":
                                txtBlue.Text = tipoCambio.Venta.ToString();
                                lBlue.Text = tipoCambio.FechaActualizacion.ToString();
                                lBlue.Visible = true;
                                break;
                            case "bolsa":
                                txtMep.Text = tipoCambio.Venta.ToString();
                                lMep.Text = tipoCambio.FechaActualizacion.ToString();
                                lMep.Visible = true;
                                break;
                            case "tarjeta":
                                txtTarjeta.Text = tipoCambio.Venta.ToString();
                                lTarjeta.Text = tipoCambio.FechaActualizacion.ToString();
                                lTarjeta.Visible = true;
                                break;
                        }
                    }

                    if (tipoCambio.Moneda == "EUR")
                    {
                        txtEuro.Text = tipoCambio.Venta.ToString();
                        lEuro.Text = tipoCambio.FechaActualizacion.ToString();
                        lEuro.Visible = true;
                    }
                    if (tipoCambio.Moneda == "BRL")
                    {
                        txtReal.Text = tipoCambio.Venta.ToString();
                        lReal.Text = tipoCambio.FechaActualizacion.ToString();
                        lReal.Visible = true;
                    }
                    if (tipoCambio.Moneda == "CLP")
                    {
                        txtChileno.Text = tipoCambio.Venta.ToString();
                        lChileno.Text = tipoCambio.FechaActualizacion.ToString();
                        lChileno.Visible = true;
                    }
                    if (tipoCambio.Moneda == "UYU")
                    {
                        txtUruguayo.Text = tipoCambio.Venta.ToString();
                        lUruguayo.Text = tipoCambio.FechaActualizacion.ToString();
                        lUruguayo.Visible = true;
                    }

                }
            }


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
            if (rbEuro.Checked)
            {
                output = double.Parse(txtEuro.Text);
            }
            if (rbReal.Checked)
            {
                output = double.Parse(txtReal.Text);
            }
            if (rbChileno.Checked)
            {
                output = double.Parse(txtChileno.Text);
            }
            if (rbUruguayo.Checked)
            {
                output = double.Parse(txtUruguayo.Text);
            }

        }

    }
}
