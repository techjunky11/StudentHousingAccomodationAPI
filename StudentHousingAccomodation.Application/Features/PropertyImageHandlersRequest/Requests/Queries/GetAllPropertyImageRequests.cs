using MediatR;
using StudentHousingAccomodation.Domain.Dtos.PropertyImageDtos;

namespace StudentHousingAccomodation.Application.Features.PropertyImageHandlersRequest.Requests.Queries
{
    public class GetAllPropertyImageRequests : IRequest<List<GetThePropertyImageDto>>
    {
        public Guid PropertyId { get; set; } // The ID of the property for which to get images
    }
}