using MediatR;
using StudentHousingAccomodation.Domain.Records;

namespace StudentHousingAccomodation.Application.Features.PropertyImageHandlersRequest.Requests.Commands
{
    public class DeletePropertyImageRequests : IRequest<GeneralResponse>
    {
        public Guid PropertyImageId { get; set; }
    }
}