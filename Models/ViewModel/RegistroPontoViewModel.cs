using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Chronos.Models.ViewModel{
    [DataContract]
    public class RegistroPontoViewModel{
        
        [DataMember]
        public int Id{get;}
        [DataMember]
        public DateTime HoraMarcacao{get;}
        private RegistroPontoViewModel(int id, DateTime horaMarcacao){
            this.Id = id;
            this.HoraMarcacao = horaMarcacao;
        }

        public RegistroPontoViewModel(){}

        public static RegistroPontoViewModel ParaItem(RegistroPonto registroPonto){
            var viewModel = new RegistroPontoViewModel(registroPonto.Id, registroPonto.HoraMarcacao);
            return viewModel;
        }

        public static IList<RegistroPontoViewModel> ParaItens(IList<RegistroPonto> registros){
            var lista = new List<RegistroPontoViewModel>();
            foreach(var registro in registros){
                var viewModel = RegistroPontoViewModel.ParaItem(registro);
                lista.Add(viewModel);
            }
            return lista;
        }

        public RegistroPonto toModel()
        {
            var registro = new RegistroPonto(this.Id,this.HoraMarcacao);
            return registro;
        }
    }
}