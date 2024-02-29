
using System.Text.Json;

namespace Core.Interfaces.Repository
{
    public interface IUtilsRepository
    {
        Task<JsonDocument> GetCoordinateInformation(decimal latitud, decimal longitud);
    }
}
