using MediatR;
using StudentHousingAccomodation.Domain.Dtos.PropertyImageDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.PropertyImageHandlersRequest.Requests.Queries
{
    public class GetAllPropertyImageRequests : IRequest<List<GetThePropertyImageDto>>
    {
        public Guid PropertyId { get; set; } // The ID of the property for which to get images
    }
}