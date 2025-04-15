using MediatR;
using StudentHousingAccomodation.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.StudentInterestsHandlersRequest.Requests.Commands
{
    public class DeleteStudentInterestsRequest : IRequest<GeneralResponse>
    {
        public Guid StudentInterestId { get; set; }
    }
}