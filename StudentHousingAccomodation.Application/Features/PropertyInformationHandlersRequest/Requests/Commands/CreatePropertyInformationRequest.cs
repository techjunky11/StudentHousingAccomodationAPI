using MediatR;
using StudentHousingAccomodation.Domain.Dtos.PropertyInformationDtos;
using StudentHousingAccomodation.Domain.Records;

namespace StudentHousingAccomodation.Application.Features.PropertyInformationHandlersRequest.Requests.Commands
{
    public class CreatePropertyInformationRequest : IRequest<GeneralResponse>
    {
        public CreateNewPropertyInformationDto? PropertyInformation { get; set; }
    }
}