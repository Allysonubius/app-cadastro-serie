using System;
using System.Collections.Generic;
using DIO.Series.Classes;
using DIO.Series.Interface;

namespace DIO.Series
{
    public class SerieRepository : IRepository<Serie>
    {
        //Variavel de lista no repositório. 
        private List<Serie> listaSerie = new List<Serie>();
        //Implementações
        public void Atualizar(int id, Serie entidade)
        {
            listaSerie[id] = entidade;
        }

        public void Excluir(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie entidade)
        {
            listaSerie.Add(entidade);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            throw new NotImplementedException();
        }

        public Serie RertornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}