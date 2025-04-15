using MediatR;
using StudentHousingAccomodation.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.RoomAmentitiesInformationsHandlersRequest.Requests.Commands
{
    public class DeleteRoomAmentitiesInformationsRequest : IRequest<GeneralResponse>
    {
        public Guid RoomAmentitiesId { get; set; }
    }
}