using MediatR;
using StudentHousingAccomodation.Domain.Dtos.RoomAmentitiesInformationsDtos;
using StudentHousingAccomodation.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.RoomAmentitiesInformationsHandlersRequest.Requests.Commands
{
    public class AddRoomAmentitiesInformationsRequest : IRequest<GeneralResponse>
    {
        public List<CreateNewRoomAmentitiesInformationDto> roomAmentitiesInformationDtos { get; set; }
    }
}