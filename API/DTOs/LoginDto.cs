using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.DTOs
{

    public class LoginDto
    {
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";


    }

}
