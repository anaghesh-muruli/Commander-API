using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Commander.Data;
using Commander.DTOs;
using Commander.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    [Route("api/commands")]
    [ApiController] //decorators ?? 
    public class CommandsController : ControllerBase
    {

        private readonly ICommanderRepo _repository;
        private readonly IMapper _mapper;

        public CommandsController(ICommanderRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        //GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(commandItems);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<CommandReadDto> GetCommandById(int id)
        {
            var commandItems = _repository.getCommandByID(id);
            if(commandItems != null)
            {
                return Ok(_mapper.Map<CommandReadDto>(commandItems));
            }
            return NotFound("Command Not found");
          
        }
    }
}