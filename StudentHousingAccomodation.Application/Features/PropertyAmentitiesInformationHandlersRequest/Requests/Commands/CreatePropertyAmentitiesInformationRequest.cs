using MediatR;
using StudentHousingAccomodation.Domain.Dtos.PropertyAmentitiesInformationDtos;
using StudentHousingAccomodation.Domain.Records;

namespace StudentHousingAccomodation.Application.Features.PropertyAmentitiesInformationHandlersRequest.Requests.Commands
{
    public class CreatePropertyAmentitiesInformationRequest : IRequest<GeneralResponse>
    {
        public List<CreateNewPropertyAmentitiesInformationDto>? AmentitiesInformationDto { get; set; } //e.g. "Sports", "Music", "Art", etc
    }
}