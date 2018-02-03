using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroFeliz.Library
{
    public class NumeroFeliz
    {
       
        public static List<int> GerarListaNumeros()
        {
            List<int> lista = new List<int>();
            for (int i = 0; i < 100; i++)
                if (ComprovarNumero(i)) lista.Add(i);
            return lista;
        }

        public static bool ComprovarNumero(int numero)
        {
            bool numeroFeliz = false;
            List<int> listaDigitos = new List<int>();
            listaDigitos = DividirDigitos(numero);
            for (int i = 0; i < 20 && !numeroFeliz; i++)
            {
                int sumaActual = SomarQuadrados(listaDigitos); 
                if (sumaActual != 1)
                    listaDigitos = DividirDigitos(sumaActual);
                else numeroFeliz = true;
            }
            return numeroFeliz;
        }


      
        public static List<int> DividirDigitos(int digito)
        {
            List<int> digitos = new List<int>();
            while (digito != 0)
            {
                digitos.Add(digito % 10); 
                digito = digito / 10;
            }
            return digitos;
        }

       
        public static int SomarQuadrados(List<int> listaDigitos)
        {
            int resultado = 0;
            foreach (int elem in listaDigitos) resultado += elem * elem;
            return resultado;
        }

        



    }
}

