using MediatR;
using StudentHousingAccomodation.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.UserHandlersRequest.Requests.Commands
{
    public class DeleteUserRequest : IRequest<GeneralResponse>
    {
        public Guid userId { get; set; }
    }
}