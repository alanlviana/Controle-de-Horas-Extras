using System.Collections.Generic;
using System.Linq;
using Chronos.Models;

namespace Chronos.Repository{
    public interface IRegistroPontoRepository{
        IList<RegistroPonto> ObterTodos();
        RegistroPonto InserirNovo(RegistroPonto registroPonto);
    }

    public class RegistroPontoRepository : IRegistroPontoRepository
    {
        public ExtraContext DbContext { get; }
        public RegistroPontoRepository(ExtraContext dbContext){
            DbContext = dbContext;
        }


        public IList<RegistroPonto> ObterTodos()
        {
            return DbContext.RegistrosPonto.ToList();
        }

        public RegistroPonto InserirNovo(RegistroPonto registroPonto)
        {
            DbContext.RegistrosPonto.Add(registroPonto);
            DbContext.SaveChanges();
            return registroPonto;
        }
    }
}