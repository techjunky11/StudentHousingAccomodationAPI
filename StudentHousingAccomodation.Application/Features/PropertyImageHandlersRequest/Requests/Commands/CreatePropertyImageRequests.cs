using MediatR;
using StudentHousingAccomodation.Domain.Dtos.PropertyImageDtos;
using StudentHousingAccomodation.Domain.Records;

namespace StudentHousingAccomodation.Application.Features.PropertyImageHandlersRequest.Requests.Commands
{
    public class CreatePropertyImageRequests : IRequest<GeneralResponse>
    {
        public List<CreateNewPropertyImageDto> PropertyImages { get; set; } // List of property images
    }
}