﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjContato
{
    public class Telefone
    {
        private string tipo;
        private string numero;
        private bool principal;

        public string Tipo { get => tipo; set => tipo = value; }
        public string Numero { get => numero; set => numero = value; }
        public bool Principal { get => principal; set => principal = value; }
    }
}
