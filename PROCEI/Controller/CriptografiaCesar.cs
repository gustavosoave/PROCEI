using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROCEI.Controller
{
    

    class CriptografiaCesar
    {
        private const int PULO = 4;

        public String encripta(String palavra) {          
            String encriptado = "";

            for (int i = 0; i < palavra.Length; i++)
            {
                //converte para inteiro para obter o ascii 
                int letra = Convert.ToInt32(palavra[i]) + PULO;
                encriptado += Convert.ToChar(letra);
            }
            return encriptado;
        }

        public String decripta(String palavra) {
            String decriptado = "";

            for (int i = 0; i < palavra.Length; i++) 
            {
                //converte para inteiro para obter o ascii 
                int letra = Convert.ToInt32(palavra[i]) - PULO;
                decriptado += Convert.ToChar(letra);
            }

            return decriptado;
        }

    }
}
