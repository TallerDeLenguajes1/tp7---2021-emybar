using System;

namespace CAL
{
    class Calculadora
    {
        private float numero1;
        private float numero2;
        private DateTime fechaHora ;
        private string operador;
        private string resultado;
      

        public float Numero1 { get => numero1; set => numero1 = value; }
        public float Numero2 { get => numero2; set => numero2 = value; }
        public DateTime FechaHora { get => fechaHora; set => fechaHora = value; }
        public string Operador { get => operador; set => operador = value; }
        public string Resultado { get => resultado; set => resultado = value; }

        public float Sumar()
        {
            return Numero1 + Numero2;
        }

        public float Restar()
        {
            return Numero1 - Numero2;
        }

        public float Multiplicar ()
        {
            return Numero1 * Numero2;
        }

        public float Dividir()
        {
           
                return Numero1 / Numero2;
       

        }

       



    }





}
