using SistemaCompra.Domain.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolicitacaoCompraAgg = SistemaCompra.Domain.SolicitacaoCompraAggregate;

namespace SistemaCompra.Infra.Data.SolicitacaoCompra
{
    public class SolicitacaoCompraRepository : SolicitacaoCompraAgg.ISolicitacaoCompraRepository
    {
        private readonly SistemaCompraContext context;

        public SolicitacaoCompraRepository(SistemaCompraContext context)
        {
            this.context = context;
        }

        public SolicitacaoCompraAgg.SolicitacaoCompra Obter(Guid id)
        {
            return context.Set<SolicitacaoCompraAgg.SolicitacaoCompra>().Where(c => c.Id == id).FirstOrDefault();
        }

        public void RegistrarCompra(SolicitacaoCompraAgg.SolicitacaoCompra solicitacaoCompra)
        {
            context.Set<SolicitacaoCompraAgg.SolicitacaoCompra>().Add(solicitacaoCompra);
        }
    }
}
