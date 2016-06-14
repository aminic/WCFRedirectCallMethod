using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    [ServiceContract]
    public interface IMyService
    {

        [OperationContract]
        [MyOperationBehavoir]
        string Hello(string name);

        [OperationContract]
        [MyOperationBehavoir]
        string Welcome(string name);

    }
}
