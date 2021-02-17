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
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Insere(Serie entidade)
        {
            throw new NotImplementedException();
        }

        public List<Serie> Lista()
        {
            throw new NotImplementedException();
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