using Core.Interfaces.Repository;
using System.Text.Json;

namespace Infrastructure.Repositories
{
    public class UtilsRepository : IUtilsRepository
    {
        private const string NominatimBaseUrl = "https://nominatim.openstreetmap.org/reverse";
        public async Task<JsonDocument> GetCoordinateInformation(decimal latitud, decimal longitud)
        {

        string url = $"{NominatimBaseUrl}?format=jsonv2&lat={latitud}&lon={longitud}";

            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; AcmeInc/1.0)");
            var finalUrl = url.Replace(",", ".");
            var response = await httpClient.GetAsync(finalUrl);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var json = JsonDocument.Parse(jsonString);
                return json;
            }
            else
            {
                throw new HttpRequestException($"Error al obtener la información de coordenadas: {response.StatusCode}");
            }
        }
    }
}
