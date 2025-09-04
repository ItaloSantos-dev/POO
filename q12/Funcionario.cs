﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q12
{
    internal class Funcionario
    {

        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }


        public void AumentarSalario(double percentual)
        {
            Salario += Salario * (percentual / 100);
        }


        
    }
}
