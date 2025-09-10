using System;

namespace API.DTOs;

public class RegisterRequest
{
    public required string DisplayName { get; set; } = "aRTURO BaRaJas";
    public required string Email { get; set; }
    public required string Password { get; set; }

}
