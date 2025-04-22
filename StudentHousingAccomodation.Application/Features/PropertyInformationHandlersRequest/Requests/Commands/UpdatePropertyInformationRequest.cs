using MediatR;
using StudentHousingAccomodation.Domain.Dtos.PropertyInformationDtos;
using StudentHousingAccomodation.Domain.Records;

namespace StudentHousingAccomodation.Application.Features.PropertyInformationHandlersRequest.Requests.Commands
{
    public class UpdatePropertyInformationRequest : IRequest<GeneralResponse>
    {
        public Guid PropertyInformationId { get; set; }
        public UpdateThePropertyInformationDto? UpdateThePropertyInformation { get; set; }
    }
}