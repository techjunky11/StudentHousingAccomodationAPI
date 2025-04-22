using MediatR;
using StudentHousingAccomodation.Domain.Records;

namespace StudentHousingAccomodation.Application.Features.RoomInformationHandlersRequest.Requests.Commands
{
    public class DeleteRoomInformationRequest : IRequest<GeneralResponse>
    {
        public Guid RoomInformationId { get; set; }
    }
}