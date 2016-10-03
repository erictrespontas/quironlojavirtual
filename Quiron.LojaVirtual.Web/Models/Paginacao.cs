using System;

namespace Quiron.LojaVirtual.Web.Models
{
    public class Paginacao
    {
        public int ItensTotal { get; set; } //Para obter quantos itens eu tenho no banco
        public int ItensPorPagina { get; set; } //Quantos itens eu quero por página
        public int PaginaAtual { get; set; } //Qual a página que está sendo exibida no momento
        public int TotalPagina //Quantas páginas eu vou ter
        {
            get
            {
                return (int)Math.Ceiling((decimal)ItensTotal / ItensPorPagina);
            }
        }
    }
}