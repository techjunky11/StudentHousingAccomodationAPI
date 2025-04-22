using MediatR;
using StudentHousingAccomodation.Domain.Records;

namespace StudentHousingAccomodation.Application.Features.PropertyAmentitiesInformationHandlersRequest.Requests.Commands
{
    public class DeletePropertyAmentitiesInformationRequest : IRequest<GeneralResponse>
    {
        public Guid PropertyAmentiesId { get; set; } //e.g. "12345678-1234-1234-1234-123456789012"
    }
}