using System;
using System.Runtime.Serialization;

namespace Chronos.Models{
    [DataContract]
    public class RegistroPonto {
        
        public RegistroPonto(){}
        public RegistroPonto(DateTime horaMarcacao){
            this.HoraMarcacao = horaMarcacao;
        }

        public RegistroPonto(int id, DateTime horaMarcacao)
        {
            Id = id;
            HoraMarcacao = horaMarcacao;
        }

        [DataMember]
        public int Id{get; private set;}
        [DataMember]
        public DateTime HoraMarcacao{get; private set;}
    }
}