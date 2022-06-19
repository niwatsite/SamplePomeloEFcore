using Microsoft.AspNetCore.Mvc;
using SamplePomeloEFcore.Context;
using SamplePomeloEFcore.Models;

namespace SamplePomeloEFcore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {

        private ApplicationDbContext context;
        public SampleController(ApplicationDbContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public IList<sample> Get()
        {
            return (this.context.samples.ToList());
        }

    }
}