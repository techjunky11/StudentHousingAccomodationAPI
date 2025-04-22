using MediatR;
using StudentHousingAccomodation.Domain.Dtos.LandLordInformationDtos;
using StudentHousingAccomodation.Domain.Records;

namespace StudentHousingAccomodation.Application.Features.LandLordInformationHandlersRequest.Requests.Commands
{
    public class UpdateLandLordInformationRequest : IRequest<GeneralResponse>
    {
        public Guid LandLordInformationId { get; set; } = Guid.Empty;
        public UpdateTheLandLordInformationDto? updateTheLandLordInformation { get; set; }
    }
}