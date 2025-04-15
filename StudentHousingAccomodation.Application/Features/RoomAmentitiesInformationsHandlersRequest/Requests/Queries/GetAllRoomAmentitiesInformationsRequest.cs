using MediatR;
using StudentHousingAccomodation.Domain.Dtos.RoomAmentitiesInformationsDtos;
using StudentHousingAccomodation.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.RoomAmentitiesInformationsHandlersRequest.Requests.Queries
{
    public class GetAllRoomAmentitiesInformationsRequest : IRequest<List<GetTheRoomAmentitiesInformationDto>>
    {
        public Guid RoomInformationId { get; set; }
    }
}