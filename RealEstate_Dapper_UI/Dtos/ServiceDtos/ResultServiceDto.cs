using Newtonsoft.Json;

namespace RealEstate_Dapper_UI.Dtos.ServiceDtos
{
    public class ResultServiceDto
    {
        [JsonProperty("ServiceID")] public int ServiceID { get; set; }
        [JsonProperty("ServiceName")] public string ServiceName { get; set; }
        [JsonProperty("ServiceStatus")] public bool ServiceStatus { get; set; }
    }
}
