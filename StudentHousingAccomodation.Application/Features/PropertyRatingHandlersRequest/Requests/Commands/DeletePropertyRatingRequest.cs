using MediatR;
using StudentHousingAccomodation.Domain.Records;

namespace StudentHousingAccomodation.Application.Features.PropertyRatingHandlersRequest.Requests.Commands
{
    public class DeletePropertyRatingRequest : IRequest<GeneralResponse>
    {
        public Guid PropertyRatingId { get; set; }
    }
}