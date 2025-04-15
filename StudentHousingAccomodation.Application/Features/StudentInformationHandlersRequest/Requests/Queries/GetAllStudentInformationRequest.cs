using MediatR;
using StudentHousingAccomodation.Domain.Dtos.StudentInformationDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.StudentInformationHandlersRequest.Requests.Queries
{
    public class GetAllStudentInformationRequest : IRequest<List<GetTheStudentInformationDto>>
    {
         public Guid UserRoleId { get; set; } 
    }
}