using MediatR;
using StudentHousingAccomodation.Domain.Dtos.PropertyRatingDtos;
using StudentHousingAccomodation.Domain.Records;

namespace StudentHousingAccomodation.Application.Features.PropertyRatingHandlersRequest.Requests.Commands
{
    public class CreatePropertyRatingRequest : IRequest<GeneralResponse>
    {
        public CreateNewPropertyRatingDto? NewPropertyRatingDto { get; set; }
    }
}