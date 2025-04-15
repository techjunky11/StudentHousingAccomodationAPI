using MediatR;
using StudentHousingAccomodation.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.RoomImageHandlersRequest.Requests.Commands
{
    public class DeleteRoomImageRequest : IRequest<GeneralResponse>
    {
        public Guid RoomImageId { get; set; }
    }
}