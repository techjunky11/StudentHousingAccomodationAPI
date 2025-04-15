using MediatR;
using StudentHousingAccomodation.Domain.Dtos.RoomInformationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.RoomInformationHandlersRequest.Requests.Queries
{
    public class GetAllRoomPropertyInformationRequest : IRequest<List<GetTheRoomInformationDto>>
    {
        public Guid PropertyInformationId { get; set; } // Foreign key property
    }
}