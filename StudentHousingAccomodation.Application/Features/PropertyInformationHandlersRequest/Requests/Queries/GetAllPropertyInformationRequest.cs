using MediatR;
using StudentHousingAccomodation.Domain.Dtos.PropertyInformationDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.PropertyInformationHandlersRequest.Requests.Queries
{
    public class GetAllPropertyInformationRequest : IRequest<List<GetThePropertyInformationDto>>
    {
    }
}