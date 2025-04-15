using MediatR;
using StudentHousingAccomodation.Domain.Dtos.StudentInformationDtos;
using StudentHousingAccomodation.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.StudentInformationHandlersRequest.Requests.Commands
{
    public class UpdateStudentInformationRequest : IRequest<GeneralResponse>
    {
        public Guid StudentInformationId { get; set; }
        public UpdateTheStudentInformationDto? updateTheStudentInformationDto { get; set; }
    }
}