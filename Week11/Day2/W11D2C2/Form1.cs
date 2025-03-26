using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace W11D2C2 {
    public partial class Form1 : Form {
        HttpClient moviesClient = new HttpClient();

        public Form1() {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e) {
            moviesClient.BaseAddress = new Uri("http://localhost:5033/api/Movies");
            var movieResponse = await moviesClient.GetAsync(moviesClient.BaseAddress);
            if (movieResponse.IsSuccessStatusCode) {
                var list = await movieResponse.Content.ReadFromJsonAsync<List<Movie>>();
                moviesGrid.DataSource = list;
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e) {
            using StringContent jsonContent = new StringContent(JsonSerializer.Serialize(new Movie() { MovieID = 5, Title = "The Wolf Of WallStreet", Rating = 9.2f, ReleaseYear = 2010, SuggestedAudience = "R" }), Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await moviesClient.PostAsync("Movies", jsonContent);
            if (response.IsSuccessStatusCode) { MessageBox.Show("Movie Added", "Success"); }
        }

        private async void btnGetWeather_Click(object sender, EventArgs e) {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://api.tomorrow.io/v4/weather/realtime?location=Seattle&apikey=uHxzCVQJVhwCkwIK3rYU1gFvMQpg7WEe");
            var response = await httpClient.GetAsync(httpClient.BaseAddress);
            Root root = await response.Content.ReadFromJsonAsync<Root>();

            MessageBox.Show($"Temp: {root.data.values.temperature}\nUV: {root.data.values.uvIndex}");

        }
    }
}
