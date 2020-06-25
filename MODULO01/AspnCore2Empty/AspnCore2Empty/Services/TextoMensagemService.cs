using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnCore2Empty.Services
{
    public class TextoMensagemService : IMensagemService
    {
        public string GetMensagem()
        {
            return "Texto de getMensagem - Felipe";
        }
    }
}
