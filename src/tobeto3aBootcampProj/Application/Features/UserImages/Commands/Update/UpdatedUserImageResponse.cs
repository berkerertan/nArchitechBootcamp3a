using NArchitecture.Core.Application.Responses;

namespace Application.Features.UserImages.Commands.Update;

public class UpdatedUserImageResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string ImagePath { get; set; }
}
