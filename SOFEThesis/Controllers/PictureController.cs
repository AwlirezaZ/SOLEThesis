using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOFEThesis.Context;
using SOFEThesis.Domain;
using System.Reflection.Metadata.Ecma335;

namespace SOFEThesis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PictureController : ControllerBase
    {
        private readonly SofeThesisContext _context;

        public PictureController(SofeThesisContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("/Pictures/Post")]
        public long CreatePicture(PictureDto dto)
        {
            var picture = new Picture()
            {
                Name = dto.Name,
                AmbiguousSituation = dto.AmbiguousSituation,
                Source = dto.Source,
            };
            _context.Pictures.Add(picture);
            _context.SaveChanges();
            return picture.Id;
        }
        
    }
    public class PictureDto
    {
        public string Name { get; set; }
        public string Source { get; set; }
        public string AmbiguousSituation { get; set; }
    }
}
