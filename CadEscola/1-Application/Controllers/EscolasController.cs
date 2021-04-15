using CadEscola._2_Domain.Entities;
using CadEscola._2_Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadEscola._1_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EscolasController : ControllerBase
    {
        private readonly IEscolaRepository _escolasRepository;

        public EscolasController(IEscolaRepository escolasRepository)
        {
            _escolasRepository = escolasRepository;
        }

        [HttpGet]
        [Route("escolas")]
        public async Task<ActionResult<List<Escola>>> GetEscolas() => await _escolasRepository.Get();

        [HttpGet]
        [Route("escola/{id}")]
        public async Task<ActionResult<Escola>> GetEscola(string id)
        {
            try
            {
                Escola escola = await _escolasRepository.Get(id);
                return escola == null ? NotFound() : (ActionResult<Escola>)escola;
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        [Route("createEscola")]
        public async Task<IActionResult> Create(Escola escola)
        {
            try
            {
                var success = await _escolasRepository.Create(escola);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        [Route("updateEscola")]
        public async Task<IActionResult> Update(string id, Escola escolaIn)
        {
            try
            {
                var escola = await _escolasRepository.Get(id);
                if (escola == null)
                    return NotFound();

                _escolasRepository.Update(id, escolaIn);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        [Route("deleteEscola/{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                var escola = await _escolasRepository.Get(id);
                if (escola == null)
                    return NotFound();

                _escolasRepository.Remove(escola.Id);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
