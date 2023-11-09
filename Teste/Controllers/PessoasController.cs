using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste.Models;
using Microsoft.EntityFrameworkCore;

namespace Teste.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoasController : ControllerBase
    {
        private readonly Context _context;

        public PessoasController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pessoa>>> GetAsync()
        {
            return await _context.Pessoas.ToListAsync();
        }
        [HttpGet("{idPessoa}")]
        public async Task<ActionResult<Pessoa>> GetByIdAsync(int idPessoa)
        {
            return await _context.Pessoas.FindAsync(idPessoa);
        }

        [HttpPost]
        public async Task<ActionResult> AddAsync(Pessoa pessoa)
        {
            await _context.Pessoas.AddAsync(pessoa);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync(Pessoa pessoa)
        {
            _context.Pessoas.Update(pessoa);
            await _context.SaveChangesAsync();

            return Ok();
        }
        [HttpDelete("{idPessoa}")]
        public async Task<ActionResult> DeleteAsync(int idPessoa)
        {
            Pessoa pessoa = await _context.Pessoas.FindAsync(idPessoa);
            _context.Remove(pessoa);
            _context.SaveChangesAsync();
            return Ok();
        }
    }

    
}
