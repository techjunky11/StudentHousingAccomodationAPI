using MediatR;
using StudentHousingAccomodation.Domain.Dtos.RoomInformationDto;
using StudentHousingAccomodation.Domain.Records;

namespace StudentHousingAccomodation.Application.Features.RoomInformationHandlersRequest.Requests.Commands
{
    public class UpdateRoomInformationRequest : IRequest<GeneralResponse>
    {
        public Guid RoomInformationId { get; set; } // Unique identifier for the room to be updated
        public UpdateTheRoomInformationDto RoomInformationDto { get; set; } // DTO containing the updated room information
    }
}