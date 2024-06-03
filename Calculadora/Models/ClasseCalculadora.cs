using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class Calculadora
    {
        public List<string> listaHistorico;
        public Calculadora(){
            listaHistorico = new List<string>();
        }
        public int Somar (int a, int b){
            listaHistorico.Insert(0, $"Res: {a+b}" );
            return a + b;
            }

        public int Subtrair (int a, int b){
            listaHistorico.Insert(0, $"Res: {a-b}" );

            return a - b;
        }

        public int Multiplicar (int a, int b){
            listaHistorico.Insert(0, $"Res: {a*b}" );

            return a * b;
        }

        public int Dividir (int a, int b){
            listaHistorico.Insert(0, $"Res: {a/b}" );

            return a / b;
        }

        public List <string> Historico(){
            List <string> TresUltimasOperacoes;
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}