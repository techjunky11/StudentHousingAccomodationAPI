using MediatR;
using StudentHousingAccomodation.Domain.Dtos.PropertyAmentitiesInformationDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.PropertyAmentitiesInformationHandlersRequest.Requests.Queries
{
    public class GetAllPropertyAmentitiesInformationRequest : IRequest<List<GetThePropertyAmentitiesInformationDto>>
    {
        public Guid PropertyId { get; set; } // Foreign key property
    }
}