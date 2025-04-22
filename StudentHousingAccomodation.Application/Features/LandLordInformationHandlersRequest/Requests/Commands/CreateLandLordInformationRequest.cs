using MediatR;
using StudentHousingAccomodation.Domain.Dtos.LandLordInformationDtos;
using StudentHousingAccomodation.Domain.Records;

namespace StudentHousingAccomodation.Application.Features.LandLordInformationHandlersRequest.Requests.Commands
{
    public class CreateLandLordInformationRequest : IRequest<GeneralResponse>
    {
        public CreateNewLandLordInformationDto? CreateNewLandLord { get; set; }
    }
}