using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SOFEThesis.Context;
using SOFEThesis.Contracts.SelfCondition;
using SOFEThesis.Domain.Conditions;
using SOFEThesis.Exceptions;
using SOFEThesis.Mappers;

namespace SOFEThesis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelfConditionController : ControllerBase
    {
        private readonly SofeThesisContext _context;

        public SelfConditionController(SofeThesisContext context)
        {
            _context = context;
        }
        [HttpPost]
        [Route("Post")]
        public long Create(CreateSelfConditionDto dto)
        {
            var selfCondition = new SelfCondition(dto.PictureId, dto.Order);
            _context.SelfConditions.Add(selfCondition);
            _context.SaveChanges();
            return selfCondition.Id;
        }
        [HttpGet]
        public List<SelfConditionDto> GetAll() 
        { 
            var conditions = _context.SelfConditions.Include(a => a.Picture).ToList();
            return SelfConditionMapper.Map(conditions);
        }
        [HttpGet]
        [Route("{id}")]
        public SelfConditionDto GetById(long id)
        {
           var condition = _context.SelfConditions.FirstOrDefault(a => a.Id == id);
           if (condition == null)
                throw new SelfConditionNotFoundException();
           return SelfConditionMapper.Map(condition);
        }
    }
}
