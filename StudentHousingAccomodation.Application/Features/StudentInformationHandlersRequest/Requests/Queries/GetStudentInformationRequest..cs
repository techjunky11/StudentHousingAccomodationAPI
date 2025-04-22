using MediatR;
using StudentHousingAccomodation.Domain.Dtos.StudentInformationDtos;

namespace StudentHousingAccomodation.Application.Features.StudentInformationHandlersRequest.Requests.Queries
{
    public class GetStudentInformationRequest : IRequest<GetTheStudentInformationDto>
    {
        public Guid studentInformationId { get; set; } //e.g. "12345678-1234-1234-1234-123456789012"
    }
}