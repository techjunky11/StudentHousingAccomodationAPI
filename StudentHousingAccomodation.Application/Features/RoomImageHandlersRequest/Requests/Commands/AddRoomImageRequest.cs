using MediatR;
using StudentHousingAccomodation.Domain.Dtos.RoomImageDtos;
using StudentHousingAccomodation.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.RoomImageHandlersRequest.Requests.Commands
{
    public class AddRoomImageRequest : IRequest<GeneralResponse>
    {
        public List<CreatNewRoomImageDto> creatNewRoomImageDto { get; set; }
    }
}