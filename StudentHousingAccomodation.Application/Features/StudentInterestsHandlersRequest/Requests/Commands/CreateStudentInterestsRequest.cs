using MediatR;
using StudentHousingAccomodation.Domain.Dtos.StudentInterestsDtos;
using StudentHousingAccomodation.Domain.Records;

namespace StudentHousingAccomodation.Application.Features.StudentInterestsHandlersRequest.Requests.Commands
{
    public class CreateStudentInterestsRequest : IRequest<GeneralResponse>
    {
        public List<CreateNewStudentInterestsDto> CreateNewStudentInterestsDto { get; set; }
        public Guid StudentInformationId { get; set; } //Foreign key property
    }
}