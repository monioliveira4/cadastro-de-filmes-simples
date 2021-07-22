using System;
using System.Collections.Generic;
using cadastroSeries.NET.Interfaces;

namespace cadastroSeries.NET
{
    public class SerieRepositorio : iRepositorio<Series>
    {
        private List<Series> listaSeries = new List<Series>();
        public void Atualiza(int id, Series objeto)
        {
            listaSeries[id]=objeto;
        }

        public void Exclui(int id)
        {
            listaSeries[id].Exclui();
        }

        public void Insere(Series objeto)
        {
            listaSeries.Add(objeto);
        }

        public List<Series> Lista()
        {
            return listaSeries;
        }

        public int ProximoId()
        {
            return listaSeries.Count;
        }

        public Series RetornaId(int id)
        {
            return listaSeries[id];
        }
    }
}