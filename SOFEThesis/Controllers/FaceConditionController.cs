using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SOFEThesis.Context;
using SOFEThesis.Contracts.FaceCondition;
using SOFEThesis.Domain.Conditions;
using SOFEThesis.Exceptions;
using SOFEThesis.Mappers;

namespace SOFEThesis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaceConditionController : ControllerBase
    {
        private readonly SofeThesisContext _context;

        public FaceConditionController(SofeThesisContext context)
        {
            _context = context;
        }
        [HttpPost]
        [Route("Post")]
        public long Create(CreateFaceConditionDto dto)
        {
            var faceCondition = new FaceCondition(dto.FacePictureId, dto.Order);
            _context.FaceConditions.Add(faceCondition);
            _context.SaveChanges();
            return faceCondition.Id;
        }
        [HttpGet]
        public List<FaceConditionDto> GetAll()
        {
            var conditions = _context.FaceConditions.Include(a => a.FacePicture).ToList();
            return FaceConditionMapper.Map(conditions);
        }
        [HttpGet]
        [Route("{id}")]
        public FaceConditionDto GetById(long id)
        {
            var condition = _context.FaceConditions.FirstOrDefault(a => a.Id == id);
            if (condition == null)
                throw new FaceConditionNotFoundException();
            return FaceConditionMapper.Map(condition);
        }
    }
}
