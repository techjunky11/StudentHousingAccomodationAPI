using MediatR;
using StudentHousingAccomodation.Domain.Dtos.RoomRatingDtos;
using StudentHousingAccomodation.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.RoomRatingHandlersRequest.Requests.Commands
{
    public class CreateRoomRatingRequest : IRequest<GeneralResponse>
    {
        public Guid RoomInformationId { get; set; } //e.g. "12345678-1234-1234-1234-123456789012"
        public CreateNewRoomRatingDto NewRoomRatingDto { get; set; }
    }
}