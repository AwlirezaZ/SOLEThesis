using Microsoft.AspNetCore.Mvc;
using SOFEThesis.Context;
using SOFEThesis.Contracts.FacePicture;
using SOFEThesis.Domain;
using SOFEThesis.Exceptions;
using SOFEThesis.Helpers;
using SOFEThesis.Mappers;

namespace SOFEThesis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacePicturesController : ControllerBase
    {
        private readonly SofeThesisContext _context;

        public FacePicturesController(SofeThesisContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("Post")]
        public long CreateFacePicture([FromForm] CreateFacePictureDto dto)
        {
            FileHelper.SaveFile(dto.File);
            var facePicture = new FacePicture(dto.Name, dto.File.FileName);
            _context.FacePictures.Add(facePicture);
            _context.SaveChanges();
            return facePicture.Id;
        }
        [HttpGet]
        public List<FacePictureDto> GetAll([FromQuery] string? name)
        {
            var facePictures = _context.FacePictures.Where(a => string.IsNullOrEmpty(name) || a.Name.Contains(name)).ToList();
            return FacePictureMapper.Map(facePictures);
        }
        [HttpGet]
        [Route("{id}")]

        public FacePictureDto GetById(long id)
        {

            var facePicture = _context.FacePictures.FirstOrDefault(a => a.Id == id);
            if (facePicture == null)
                throw new FacePictureNotFoundException();
            return FacePictureMapper.Map(facePicture);
        }
    }
}
