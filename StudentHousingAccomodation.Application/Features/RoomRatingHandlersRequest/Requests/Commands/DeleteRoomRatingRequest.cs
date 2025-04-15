using MediatR;
using StudentHousingAccomodation.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.RoomRatingHandlersRequest.Requests.Commands
{
    public class DeleteRoomRatingRequest : IRequest<GeneralResponse>
    {
        public Guid RoomRatingId { get; set; }
    }
}
