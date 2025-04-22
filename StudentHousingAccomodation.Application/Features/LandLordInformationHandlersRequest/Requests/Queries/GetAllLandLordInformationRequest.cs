using MediatR;
using StudentHousingAccomodation.Domain.Dtos.LandLordInformationDtos;

namespace StudentHousingAccomodation.Application.Features.LandLordInformationHandlersRequest.Requests.Queries
{
    public class GetAllLandLordInformationRequest : IRequest<List<GetTheLandLordInformationDto>>
    {
    }
}