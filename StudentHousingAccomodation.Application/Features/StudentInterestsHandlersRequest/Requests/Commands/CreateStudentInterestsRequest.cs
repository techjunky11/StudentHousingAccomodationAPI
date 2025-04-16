using MediatR;
using StudentHousingAccomodation.Domain.Dtos.StudentInterestsDtos;
using StudentHousingAccomodation.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.StudentInterestsHandlersRequest.Requests.Commands
{
    public class CreateStudentInterestsRequest : IRequest<GeneralResponse>
    {
        public List<CreateNewStudentInterestsDto> CreateNewStudentInterestsDto { get; set; }
        public Guid StudentInformationId { get; set; } //Foreign key property
    }
}