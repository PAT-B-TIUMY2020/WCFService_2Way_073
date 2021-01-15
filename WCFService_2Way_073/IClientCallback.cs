using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFService_2Way_073
{
    interface IClientCallback
    {
        interface IClientCallback
        {
            [OperationContract(IsOneWay = true)]
            void pesankirim(string user, string pesan);

        }
    }
}
