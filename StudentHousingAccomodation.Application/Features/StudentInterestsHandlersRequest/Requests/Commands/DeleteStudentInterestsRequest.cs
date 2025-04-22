using MediatR;
using StudentHousingAccomodation.Domain.Records;

namespace StudentHousingAccomodation.Application.Features.StudentInterestsHandlersRequest.Requests.Commands
{
    public class DeleteStudentInterestsRequest : IRequest<GeneralResponse>
    {
        public Guid StudentInterestId { get; set; }
    }
}