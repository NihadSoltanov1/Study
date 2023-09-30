using Code8.Application.DTOs.Token;
using Code8.Domain.Identity;
using static System.Net.Mime.MediaTypeNames;

namespace Code8.Application.Common.Security.Jwt;
    public interface ITokenHandler
    {
        TokenDto CreateAccessToken(int minute, Admin appUser);
    }
