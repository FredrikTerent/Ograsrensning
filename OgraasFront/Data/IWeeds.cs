using OgraasFront.Dto;

namespace OgraasFront.Data
{
    public interface IWeeds
    {
        public Task<ResponseDto> Click(ClickDto click);
    }
}
