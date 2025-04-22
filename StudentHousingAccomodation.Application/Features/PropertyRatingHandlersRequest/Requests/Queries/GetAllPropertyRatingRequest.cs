using MediatR;
using StudentHousingAccomodation.Domain.Dtos.PropertyRatingDtos;

namespace StudentHousingAccomodation.Application.Features.PropertyRatingHandlersRequest.Requests.Queries
{
    public class GetAllPropertyRatingRequest : IRequest<List<GetThePropertyRatingDto>>
    {
        public Guid PropertyId { get; set; } // The ID of the property for which to get ratings
    }
}