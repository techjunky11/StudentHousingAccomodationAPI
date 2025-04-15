using MediatR;
using StudentHousingAccomodation.Domain.Dtos.StudentInformationDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.StudentInformationHandlersRequest.Requests.Queries
{
    public class GetStudentInformationRequest : IRequest<GetTheStudentInformationDto>
    {
        public Guid studentInformationId { get; set; } //e.g. "12345678-1234-1234-1234-123456789012"
    }
}