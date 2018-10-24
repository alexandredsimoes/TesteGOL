using System;
using System.Collections.Generic;
using System.Linq;
using TesteGOL.Domain.Core.Models;

namespace TesteGOL.Domain.Cadastros.Entidades
{
    public class Airplane : Entity
    {
        public string CodigoAviao { get; private set; }
        public string Modelo { get; private set; }
        public int Passageiros { get; private set; }
        public DateTime DataRegistro { get; private set; }

        protected Airplane()
        {
        }

        public Airplane(Guid id, string codigoAviao, string modelo, int passageiros, DateTime dataRegistro)
        {
            Id = id;
            CodigoAviao = codigoAviao;
            Modelo = modelo;
            Passageiros = passageiros;
            DataRegistro = dataRegistro;
        }
    }
}
