using MediatR;
using StudentHousingAccomodation.Domain.Dtos.PropertyInformationDtos;

namespace StudentHousingAccomodation.Application.Features.PropertyInformationHandlersRequest.Requests.Queries
{
    public class GetPropertyInformationRequest : IRequest<GetThePropertyInformationDto>
    {
        public Guid PropertyInformationId { get; set; } //e.g. "12345678-1234-1234-1234-123456789012"
    }
}