using MediatR;
using StudentHousingAccomodation.Domain.Dtos.PropertyRatingDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.PropertyRatingHandlersRequest.Requests.Queries
{
    public class GetAllPropertyRatingRequest : IRequest<List<GetThePropertyRatingDto>>
    {
        public Guid PropertyId { get; set; } // The ID of the property for which to get ratings
    }
}