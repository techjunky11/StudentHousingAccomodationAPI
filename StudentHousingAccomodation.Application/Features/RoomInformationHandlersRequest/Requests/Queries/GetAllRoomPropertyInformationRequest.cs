using MediatR;
using StudentHousingAccomodation.Domain.Dtos.RoomInformationDto;

namespace StudentHousingAccomodation.Application.Features.RoomInformationHandlersRequest.Requests.Queries
{
    public class GetAllRoomPropertyInformationRequest : IRequest<List<GetTheRoomInformationDto>>
    {
        public Guid PropertyInformationId { get; set; } // Foreign key property
    }
}