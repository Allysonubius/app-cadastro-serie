using System;
using DIO.Series.Enum;

namespace DIO.Series.Classes
{
    public class Serie : EntidadeBase
    {
        // Atributos
        private Genero Genero{
            get;set;
        }

        private string Titulo{
            get;
            set;
        }

        private string Descricao{
            get;
            set;
        }

        private int Ano{
            get;
            set;
        }

        private bool Excluido{
            get;
            set;
        }
        //Construtor
        public Serie(int id, Genero genero,string titulo,string descricao,int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }
        //Metodo toString
        public override string ToString()
        {
            //Enviroments.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Genero + Environment.NewLine;
            retorno += "Descrição: " + this.Genero + Environment.NewLine;
            retorno += "Ano de início: " + this.Genero + Environment.NewLine;
            return retorno;
        }
        //Encapsulamento
        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaId()
        {
            return this.Id;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}