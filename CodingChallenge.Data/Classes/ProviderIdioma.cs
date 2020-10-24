using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class ProviderIdioma
    {
        public TextoIdioma GetTextoIdioma(Idioma idioma)
        {
            if (idioma == Idioma.Castellano)
            {
                return new IdiomaCastellano();
            }

            if (idioma == Idioma.Ingles)
            {
                return new IdiomaIngles();
            }

            if (idioma == Idioma.Portugues)
            {
                return new IdiomaPortugues();
            }
            return null;
        }

        public TextoIdioma GetTextoIdioma(Idioma idioma, string forma)
        {
        
                if (idioma == Idioma.Castellano)
                {
                    return new IdiomaCastellano(forma);
                }

                if (idioma == Idioma.Ingles)
                {
                    return new IdiomaIngles(forma);
                }


                if (idioma == Idioma.Portugues)
                {
                    return new IdiomaPortugues(forma);
                }
            return null;
        }


    }
}
