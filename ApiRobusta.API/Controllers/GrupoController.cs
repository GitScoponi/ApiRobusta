using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ApiRobusta.API.Controllers.Base;
using ApiRobusta.Infra.Repositories.Transactions;
using ApiRobustaCurso.Command.Grupo;
using ApiRobustaCurso.Command.Grupo.AlterarGrupo;
using ApiRobustaCurso.Command.Grupo.ExcluirGrupo;
using ApiRobustaCurso.Command.Usuario.AutenticarUsuario;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiRobusta.API.Controllers
{
   
    public class GrupoController : BaseController
    {
        private readonly IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public GrupoController(IHttpContextAccessor httpContextAccessor, IMediator mediator, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _mediator = mediator;
            _httpContextAccessor = httpContextAccessor;
        }

        [Authorize]
        [HttpGet]
        [Route("api/Grupo/Listar")]
        public async Task<IActionResult> ListarGrupo()
        {
            try
            {
                var request = new ListarGrupoRequest();
                var result = await _mediator.Send(request, CancellationToken.None);
                return Ok(result);
            }
            catch (System.Exception ex)
            {

                return NotFound(ex.Message);
            }
        }

        [Authorize]
        [HttpPost]
        [Route("api/Grupo/Adicionar")]
        public async Task<IActionResult> AdicionarGrupo([FromBody]AdicionarGrupoRequest request)
        {
            try
            {
                string usuarioClaims = _httpContextAccessor.HttpContext.User.FindFirst("Usuario").Value;
                AutenticarUsuarioResponse usuarioResponse = JsonConvert.DeserializeObject<AutenticarUsuarioResponse>(usuarioClaims);

                request.IdUsuario = usuarioResponse.Id;

                var response = await _mediator.Send(request, CancellationToken.None);
                return await ResponseAsync(response);
            }
            catch (System.Exception ex)
            {

                return BadRequest(ex.Message);
            }



        }

        [Authorize]
        [HttpPut]
        [Route("api/grupo/alterar")]
        public async Task<IActionResult> alterargrupo([FromBody]AlterarGrupoRequest request)
        {
            try
            {
                string usuarioclaims = _httpContextAccessor.HttpContext.User.FindFirst("usuario").Value;
                AutenticarUsuarioResponse usuarioresponse = JsonConvert.DeserializeObject<AutenticarUsuarioResponse>(usuarioclaims);

                request.IdUsuario = usuarioresponse.Id;

                var response = await _mediator.Send(request, CancellationToken.None);
                return await ResponseAsync(response);
            }
            catch (System.Exception ex)
            {

                return BadRequest(ex.Message);
            }



        }

        [Authorize]
        [HttpDelete]
        [Route("api/Grupo/Remover/{id:Guid}")]
        public async Task<IActionResult> RemoverGrupo(Guid id)
        {
            try
            {
                var request = new RemoverGrupoRequest(id);
                var result = await _mediator.Send(request, CancellationToken.None);
                return await ResponseAsync(result);

            }
            catch (System.Exception ex)
            {

                return NotFound(ex.Message);
            }
        }



    }
}