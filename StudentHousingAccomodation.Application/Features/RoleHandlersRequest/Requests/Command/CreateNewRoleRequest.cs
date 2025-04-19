using MediatR;
using StudentHousingAccomodation.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.RoleHandlersRequest.Requests.Command
{
    public class CreateNewRoleRequest : IRequest<GeneralResponse>
    {
        public string RoleName { get; set; }
    }
}