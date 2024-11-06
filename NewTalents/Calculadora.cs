using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {

        public List<string> listaHistorico;

        public Calculadora(){
            listaHistorico = new List<string>();
        }


        public int Somar(int num1, int num2){

            int result = num1 + num2;

            listaHistorico.Insert(0, $"Resultado: {result}.");

            return result;
        }
        public int Subtrair(int num1, int num2){
            int result = num1 - num2;

            listaHistorico.Insert(0, $"Resultado: {result}.");

            return result;
        }
        public int Multiplicar(int num1, int num2){
            int result = num1 * num2;
            
            listaHistorico.Insert(0, $"Resultado: {result}.");

            return result;
        }
        public int Dividir(int num1, int num2){
            int result = num1 / num2;

            listaHistorico.Insert(0, $"Resultado: {result}.");

            return result;
            
        }
       public List<string> Historico()
        {
            if (listaHistorico.Count > 3)
            {
                listaHistorico.RemoveRange(2, listaHistorico.Count - 3);
            }

            return new List<string>(listaHistorico);
        }

    }
}