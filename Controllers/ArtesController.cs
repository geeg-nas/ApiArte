using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiArte.Models;
using ApiArte.Data;
using Microsoft.EntityFrameworkCore;




namespace ApiArte.Controllers
{
      
   
      
    [ApiController]
    [Route("[controller]")]

    public class ArtesController : ControllerBase
    {
       private readonly DataContext _context;
        public ArtesController(DataContext context)
        {
            _context = context;
        }
      

               private static List<Arte> artes = new List<Arte>()
              {
              new Arte() { Id = 1, Titulo = "Monalisa", Categoria = "Pintura", Artista = "Leonardo da Vinci", Data=1503, Descricao = "Mona Lisa também conhecida como A Gioconda ou ainda Mona Lisa del Giocondo é a mais notável e conhecida obra de Leonardo da Vinci", Localizacao = "Museu lo Louvre"},
              new Arte() { Id = 2, Titulo = "Einstein mostrando a língua", Categoria = "Fotográfia", Artista = "Arthur Sasse", Data=1951, Descricao = "Uma das imagens mais conhecidas da história é a do físico Albert Einstein mostrando a língua.", Localizacao = "indefinida"},
              new Arte() { Id = 3, Titulo = "Lírios", Categoria = "Pintura", Artista = " Vincent van Gogh", Data=1889, Descricao = "Lírios é uma das várias pinturas de íris do artista holandês Vincent van Gogh e uma obra da série de pinturas que ele fez no asilo Saint Paul-de-Mausole em Saint-Rémy-de-Provence, França, no último ano antes sua morte em 1890.", Localizacao = "França"},
              new Arte() { Id = 4, Titulo = "Guernica", Categoria = "Pintura", Artista = "Pablo Picasso", Data=1503, Descricao = "Com 349 cm de altura por 776,5 cm de comprimento, Guernica, uma das obras mais famosas de Pablo Picasso, pintada a óleo em 1937, é uma “declaração de guerra contra a guerra e um manifesto contra a violência", Localizacao = "Paris"},
              new Arte() { Id = 5, Titulo = "Unhas", Categoria = "Canção", Artista = "Gabriel Ventura", Data=2022, Descricao = "roduto da parceria entre o ex-integrante da Ventre e o produtor Patrick Laplan (Los Hermanos, Duda Beat), o trabalho de nove faixas começa manso, quase misterioso, porém, sustenta na permanente colisão", Localizacao = "São Paulo"},
              new Arte() { Id = 6, Titulo = "Vénus de Willendorf", Categoria = "Escultura", Artista = "Autor desconhecido", Data=22000, Descricao = "hoje também conhecida como Mulher de Willendorf, é uma estatueta de Vénus estimada como esculpida entre 28 000 e 25 000 anos antes de Cristo", Localizacao = "Áustria"},
              };  
  
    
      
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            try
            {
                Arte a = await _context.Artes.FirstOrDefaultAsync(aBusca => aBusca.Id == id);
                return Ok(a);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Arte> lista = await _context.Artes.ToListAsync();
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(Arte novoArte)
        {
            try
            {
                await _context.Artes.AddAsync(novoArte);
                await _context.SaveChangesAsync();

                return Ok(novoArte.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update(Arte novoArte)
        {
            try
            {
                _context.Artes.Update(novoArte);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Arte aRemover = await _context.Artes.FirstOrDefaultAsync(a => a.Id == id);
                
                if (aRemover == null)
                {
                    throw new Exception("Não existe esse afazer");
                }
                _context.Artes.Remove(aRemover);
                int linhaAfetadas = await _context.SaveChangesAsync();
                return Ok(linhaAfetadas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        

      
  
    }
    }
