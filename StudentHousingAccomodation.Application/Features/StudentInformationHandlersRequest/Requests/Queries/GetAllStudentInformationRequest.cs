using MediatR;
using StudentHousingAccomodation.Domain.Dtos.StudentInformationDtos;

namespace StudentHousingAccomodation.Application.Features.StudentInformationHandlersRequest.Requests.Queries
{
    public class GetAllStudentInformationRequest : IRequest<List<GetTheStudentInformationDto>>
    {
        public Guid UserRoleId { get; set; }
    }
}