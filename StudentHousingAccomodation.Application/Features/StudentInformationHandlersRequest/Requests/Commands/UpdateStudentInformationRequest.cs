using MediatR;
using StudentHousingAccomodation.Domain.Dtos.StudentInformationDtos;
using StudentHousingAccomodation.Domain.Records;

namespace StudentHousingAccomodation.Application.Features.StudentInformationHandlersRequest.Requests.Commands
{
    public class UpdateStudentInformationRequest : IRequest<GeneralResponse>
    {
        public Guid StudentInformationId { get; set; }
        public UpdateTheStudentInformationDto? updateTheStudentInformationDto { get; set; }
    }
}