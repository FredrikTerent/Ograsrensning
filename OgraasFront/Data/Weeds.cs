using OgraasFront.Dto;

namespace OgraasFront.Data
{
    public class Weeds : IWeeds
    {
        private readonly HttpClient _http;

        public Weeds(HttpClient http)
        {
            _http = http;
        }
        public async Task<ResponseDto> Click(ClickDto click)
        {
            var response = await _http.PostAsJsonAsync("api/ClickDto", click);
            return (await response.Content.ReadFromJsonAsync<ResponseDto>()) ?? new ResponseDto();

        }

        public int GetPlayerId() => 1;
    }
}