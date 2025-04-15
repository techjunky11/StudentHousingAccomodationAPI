using MediatR;
using StudentHousingAccomodation.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.PropertyRatingHandlersRequest.Requests.Commands
{
    public class DeletePropertyRatingRequest : IRequest<GeneralResponse>
    {
        public Guid PropertyRatingId { get; set; }
    }
}