using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROCEI.Controller
{
    class Captcha
    {
        CaptchaItem[] captchaItens = new CaptchaItem[10];

        public Captcha() 
        {

            for (int i = 0; i < 10; i++)
                captchaItens[i] = new CaptchaItem();

            captchaItens[0].Valor = "RA5MN";
            captchaItens[0].Imagem = PROCEI.Properties.Resources._0;
            captchaItens[1].Valor = "666AP";
            captchaItens[1].Imagem = PROCEI.Properties.Resources._1;
            captchaItens[2].Valor = "C8RSM";
            captchaItens[2].Imagem = PROCEI.Properties.Resources._2;
            captchaItens[3].Valor = "K8VKJ";
            captchaItens[3].Imagem = PROCEI.Properties.Resources._3;
            captchaItens[4].Valor = "9H8NK";
            captchaItens[4].Imagem = PROCEI.Properties.Resources._4;
            captchaItens[5].Valor = "EVBJS";
            captchaItens[5].Imagem = PROCEI.Properties.Resources._5;
            captchaItens[6].Valor = "VRYM3";
            captchaItens[6].Imagem = PROCEI.Properties.Resources._6;
            captchaItens[7].Valor = "MT4BY";
            captchaItens[7].Imagem = PROCEI.Properties.Resources._7;
            captchaItens[8].Valor = "6N8E9";
            captchaItens[8].Imagem = PROCEI.Properties.Resources._8;
            captchaItens[9].Valor = "HX3AY";
            captchaItens[9].Imagem = PROCEI.Properties.Resources._9;
            
        }

        public CaptchaItem sorteio() {
            Random rdn = new Random();
            int imagem = rdn.Next(0, 9);

            return captchaItens[imagem];

        }

    }
}
