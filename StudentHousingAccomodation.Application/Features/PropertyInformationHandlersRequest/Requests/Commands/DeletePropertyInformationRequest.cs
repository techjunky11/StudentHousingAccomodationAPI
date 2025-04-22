using MediatR;
using StudentHousingAccomodation.Domain.Records;

namespace StudentHousingAccomodation.Application.Features.PropertyInformationHandlersRequest.Requests.Commands
{
    public class DeletePropertyInformationRequest : IRequest<GeneralResponse>
    {
        public Guid PropertyInformationId { get; set; }
    }
}