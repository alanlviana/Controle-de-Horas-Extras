using System.Collections.Generic;
using Chronos.Models;
using Chronos.Models.ViewModel;
using Chronos.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Chronos.Controllers{

    [Route("api/[controller]")]
    public class RegistroPontoController{

        public IRegistroPontoRepository RegistroPontoRepository { get; }
        public RegistroPontoController(IRegistroPontoRepository registroPontoRepository){
            RegistroPontoRepository = registroPontoRepository;
        }


        [HttpGet]
        public IEnumerable<RegistroPontoViewModel> getAllRegistroPonto(){
            var registros = RegistroPontoRepository.ObterTodos();
            var viewModel = RegistroPontoViewModel.ParaItens(registros);
            return viewModel;
        }

        [HttpPost]
        public void Inserir(RegistroPontoViewModel registroViewModel){
            RegistroPonto registro = registroViewModel.toModel();
            RegistroPontoRepository.InserirNovo(registro);
        }
    }
}