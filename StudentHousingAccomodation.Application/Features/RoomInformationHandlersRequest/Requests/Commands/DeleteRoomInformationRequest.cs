using MediatR;
using StudentHousingAccomodation.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.RoomInformationHandlersRequest.Requests.Commands
{
    public class DeleteRoomInformationRequest : IRequest<GeneralResponse>
    {
        public Guid RoomInformationId { get; set; }
    }
}