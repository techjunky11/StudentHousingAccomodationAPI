using MediatR;
using StudentHousingAccomodation.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.PropertyImageHandlersRequest.Requests.Commands
{
    public class DeletePropertyImageRequests : IRequest<GeneralResponse>
    {
        public Guid PropertyImageId { get; set; }
    }
}