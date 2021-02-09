using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsApp_Robot
{
    class messageBox
    {

        //public string Message;

        public string MessageShow(string Message)
        {
            #region Message
            if (Message == "Saved")
            {
                //////////////////Saved//////////////

                Message = "A informação foi salva com sucesso!";


            }
            if (Message == "Update")
            {
                //////////////////Update//////////////

                Message = "A informação foi atualizada com sucesso!";


            }
            if (Message == "Delete")
            {
                //////////////////Delete//////////////
                Message = "A informação foi excluída com sucesso!";

            }

            #endregion

            return Message;
        }

    }
}
