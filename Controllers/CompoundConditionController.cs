using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SOFEThesis.Context;
using SOFEThesis.Contracts.CompoundCondition;
using SOFEThesis.Domain.Conditions;
using SOFEThesis.Exceptions;
using SOFEThesis.Mappers;

namespace SOFEThesis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompoundConditionController : ControllerBase
    {
        private readonly SofeThesisContext _context;

        public CompoundConditionController(SofeThesisContext context)
        {
            _context = context;
        }
        [HttpPost]
        [Route("Post")]
        public long Create(CreateCompoundConditionDto dto)
        {
            var compoundCondition = new CompoundCondition(dto.PictureId, dto.FirstFacePictureId, dto.SecondFacePictureId, dto.Order);
            _context.CompoundConditions.Add(compoundCondition);
            _context.SaveChanges();
            return compoundCondition.Id;
        }
        [HttpGet]
        public List<CompoundConditionDto> GetAll()
        {
            var conditions = _context.CompoundConditions
                .Include(a => a.Picture)
                .Include(a => a.FirstFacePicture)
                .Include(a => a.SecondFacePicture).ToList();
            return CompoundConditionMapper.Map(conditions);
        }
        [HttpGet]
        [Route("{id}")]
        public CompoundConditionDto GetById(long id)
        {
            var condition = _context.CompoundConditions.FirstOrDefault(a => a.Id == id);
            if (condition == null)
                throw new CompoundConditionNotFoundException();
            return CompoundConditionMapper.Map(condition);
        }
    }
}
