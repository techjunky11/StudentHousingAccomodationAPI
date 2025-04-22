using MediatR;
using StudentHousingAccomodation.Domain.Dtos.PropertyInformationDtos;

namespace StudentHousingAccomodation.Application.Features.PropertyInformationHandlersRequest.Requests.Queries
{
    public class GetAllPropertyInformationRequest : IRequest<List<GetThePropertyInformationDto>>
    {
    }
}