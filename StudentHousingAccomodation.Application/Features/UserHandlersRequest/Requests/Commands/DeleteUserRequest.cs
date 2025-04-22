using MediatR;
using StudentHousingAccomodation.Domain.Records;

namespace StudentHousingAccomodation.Application.Features.UserHandlersRequest.Requests.Commands
{
    public class DeleteUserRequest : IRequest<GeneralResponse>
    {
        public Guid userId { get; set; }
    }
}