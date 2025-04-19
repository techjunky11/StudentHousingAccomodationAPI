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
    public class UpdateRoomInformationRequest : IRequest<GeneralResponse>
    {
        public Guid RoomInformationId { get; set; } // Unique identifier for the room to be updated
        public UpdateTheRoomInformationDto RoomInformationDto { get; set; } // DTO containing the updated room information
    }
}