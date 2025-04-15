using MediatR;
using StudentHousingAccomodation.Domain.Dtos.RoomRatingDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.RoomRatingHandlersRequest.Requests.Queries
{
    public class GetAllRoomRatingRequest : IRequest<List<GetTheRoomRatingDto>>
    {
        public Guid RoomInformationId { get; set; } // The ID of the room for which to get ratings
    }
}