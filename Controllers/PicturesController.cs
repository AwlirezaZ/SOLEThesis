using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOFEThesis.Context;
using SOFEThesis.Contracts.Picture;
using SOFEThesis.Domain;
using SOFEThesis.Exceptions;
using SOFEThesis.Helpers;
using SOFEThesis.Mappers;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;

namespace SOFEThesis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PicturesController : ControllerBase
    {
        private readonly SofeThesisContext _context;

        public PicturesController(SofeThesisContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("Post")]
        public async Task<long> CreatePicture([FromForm] CreatePictureDto dto)
        {
            await FileHelper.SaveFile(dto.File);
            var picture = new Picture(dto.Name, dto.File.FileName, dto.AmbiguousSituation);
            _context.Pictures.Add(picture);
            await _context.SaveChangesAsync();
            return picture.Id;
        }
        [HttpGet]
        public List<PictrueDto> GetAll([FromQuery] string? name)
        {
            var pictures = _context.Pictures.Where(a => string.IsNullOrEmpty(name) || a.Name.Contains(name)).ToList();
            return PictureMapper.Map(pictures);
        }
        [HttpGet]
        [Route("{id}")]

        public PictrueDto GetById(long id)
        {

            var picture = _context.Pictures.FirstOrDefault(a => a.Id == id);
            if (picture == null)
                throw new PictureNotFoundException();
            return PictureMapper.Map(picture);
        }
    }
}
