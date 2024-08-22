using Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace FailteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        readonly private IUserWriteRepository _userWriteRepository;
        readonly private IUserReadRepository _userReadRepository;

        public UsersController(IUserWriteRepository userWriteRepository, IUserReadRepository userReadRepository)
        {
            _userWriteRepository = userWriteRepository;
            _userReadRepository = userReadRepository;
        }
        [HttpGet]
        public async Task Get() {
            await _userWriteRepository.AddRangeAsync(new()
            {
                new(){ Id = Guid.NewGuid(),UserName ="Kaan", Email="kaan@gmail.com", Password="klm", Phone="030302" },
                new(){ Id = Guid.NewGuid(),UserName ="James", Email="James@gmail.com", Password="asd", Phone="234" },
                new(){ Id = Guid.NewGuid(),UserName ="Frigolli", Email="Frigolli@gmail.com", Password="cvdf", Phone="2324"}
            }
                );
            await _userWriteRepository.SaveAsync();
        }
    }
}
