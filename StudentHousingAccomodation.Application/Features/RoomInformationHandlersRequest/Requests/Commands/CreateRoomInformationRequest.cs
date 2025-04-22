using MediatR;
using StudentHousingAccomodation.Domain.Dtos.RoomInformationDto;
using StudentHousingAccomodation.Domain.Records;

namespace StudentHousingAccomodation.Application.Features.RoomInformationHandlersRequest.Requests.Commands
{
    public class CreateRoomInformationRequest : IRequest<GeneralResponse>
    {
        public CreateNewRoomInformationDto? RoomInformationDto { get; set; }
    }
}