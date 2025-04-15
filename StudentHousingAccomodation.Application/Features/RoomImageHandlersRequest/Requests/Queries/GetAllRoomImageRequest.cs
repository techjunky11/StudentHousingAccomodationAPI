using MediatR;
using StudentHousingAccomodation.Domain.Dtos.RoomImageDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.RoomImageHandlersRequest.Requests.Queries
{
    public class GetAllRoomImageRequest : IRequest<List<GetTheRoomImageDto>>
    {
        public Guid RoomInformationId { get; set; }
    }
}