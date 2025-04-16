using MediatR;
using StudentHousingAccomodation.Domain.Dtos.RoomInformationDto;
using StudentHousingAccomodation.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.RoomInformationHandlersRequest.Requests.Commands
{
    public class CreateRoomInformationRequest : IRequest<GeneralResponse>
    {
        public CreateNewRoomInformationDto? RoomInformationDto { get; set; }
    }
}