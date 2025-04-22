using MediatR;
using StudentHousingAccomodation.Domain.Dtos.PropertyAmentitiesInformationDtos;

namespace StudentHousingAccomodation.Application.Features.PropertyAmentitiesInformationHandlersRequest.Requests.Queries
{
    public class GetAllPropertyAmentitiesInformationRequest : IRequest<List<GetThePropertyAmentitiesInformationDto>>
    {
        public Guid PropertyId { get; set; } // Foreign key property
    }
}