using Fuels.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fuels.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FuelsPrices : ContentPage
    {
        public FuelsPrices()
        {
            InitializeComponent();
            LoadData();
        }

        public async void LoadData()
        {
            var content = "";
            HttpClient client = new HttpClient();
            var RestUrl = "http://dominicanwhocodes.somee.com/api/fuels";
            client.BaseAddress = new Uri(RestUrl);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(RestUrl);
            content = await response.Content.ReadAsStringAsync();
            var items = JsonConvert.DeserializeObject<List<FuelsModel>>(content);
            ListaPrices.HasUnevenRows = true;
            ListaPrices.ItemsSource = items;
        }
    }
}