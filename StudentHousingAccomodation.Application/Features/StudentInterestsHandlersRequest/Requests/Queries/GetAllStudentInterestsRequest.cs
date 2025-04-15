using MediatR;
using StudentHousingAccomodation.Domain.Dtos.StudentInterestsDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.StudentInterestsHandlersRequest.Requests.Queries
{
    public class GetAllStudentInterestsRequest : IRequest<GetTheStudentInterestsDto>
    {
        public Guid StudentId { get; set; } //e.g. "12345678-abcd-1234-abcd-1234567890ab"
    }
}