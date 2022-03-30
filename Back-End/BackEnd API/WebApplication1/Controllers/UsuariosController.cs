using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.Response;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route(template: "[controller]")]
    public class UsuariosController : ControllerBase
    {
        

        
        private readonly DataContext _context;

        public UsuariosController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
       public async Task<ActionResult<List<Usuarios>>> get()
        {
                Respuesta<List<Usuarios>> oRespuesta = new Respuesta<List<Usuarios>>();
            try
            {
                var lst = await _context.Usuarios.ToListAsync();
                oRespuesta.Exito = 1;
                oRespuesta.Data = lst;

            }
            catch (Exception ex)
            {

                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<List<Usuarios>>> get(int id)
        {
            Respuesta<Usuarios> oRespuesta = new Respuesta<Usuarios>();
            try
            {
                var lst = await _context.Usuarios.FindAsync(id);
                oRespuesta.Exito = 1;
                oRespuesta.Data = lst;

            }
            catch (Exception ex)
            {

                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }
        [HttpPost]
        public async Task<ActionResult<List<Usuarios>>> addUsuario(Usuarios usuario)
        {
            Respuesta<object> oRespuesta = new Respuesta<object>();
            try
            {
                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();
                var lst = await _context.Usuarios.ToListAsync();
                oRespuesta.Exito = 1;
                oRespuesta.Data = lst;

            }
            catch (Exception ex)
            {

                oRespuesta.Mensaje = ex.Message;
            } 
           return Ok(oRespuesta);
            
        }
        [HttpPut]
        public async Task<ActionResult<List<Usuarios>>> updateUsuario(Usuarios request)
        {
            Respuesta<object> oRespuesta = new Respuesta<object>();
            try
            {
                var dbUsuario = await _context.Usuarios.FindAsync(request.IdUsuario);
                if (dbUsuario == null)
                {
                    return BadRequest("Error, usuario no existente.");
                }
                dbUsuario.UserName = request.UserName;
                dbUsuario.Nombre = request.Nombre;
                dbUsuario.Email = request.Email;
                dbUsuario.Telefono = request.Telefono;

                await _context.SaveChangesAsync();
                var lst = await _context.Usuarios.ToListAsync();
                oRespuesta.Exito = 1;
                oRespuesta.Data = lst;
                return Ok(oRespuesta);

            }
            catch (Exception ex)
            {

                oRespuesta.Mensaje = ex.Message;
            }
            return Ok(oRespuesta);

        }
        [HttpDelete ("{id}")]
        public async Task<ActionResult<List<Usuarios>>> deleteUsuario(int id)

        {
            Respuesta<object> oRespuesta = new Respuesta<object>();

            var dbUsuario = await _context.Usuarios.FindAsync(id);
            if (dbUsuario == null)
            {
                return BadRequest("Error, usuario no existente.");
            }
            _context.Remove(dbUsuario);
            await _context.SaveChangesAsync();
            oRespuesta.Exito = 1;
            var lst = await _context.Usuarios.ToListAsync();
            oRespuesta.Data=lst;
            return Ok(oRespuesta);
        }
    }
}
