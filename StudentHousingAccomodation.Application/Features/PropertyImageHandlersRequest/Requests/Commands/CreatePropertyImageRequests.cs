using MediatR;
using StudentHousingAccomodation.Domain.Dtos.PropertyImageDtos;
using StudentHousingAccomodation.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.PropertyImageHandlersRequest.Requests.Commands
{
    public class CreatePropertyImageRequests : IRequest<GeneralResponse>
    {
        public List<CreateNewPropertyImageDto> PropertyImages { get; set; } // List of property images
    }
}