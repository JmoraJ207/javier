using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Ulatina.PrograAvanzada.BL.AplicacionWeb
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]// modificador que se aplica a nivel de ejecutacion 
    public interface IService1
    {

        [OperationContract]

        string WhatDateIsToday();
        

        [OperationContract] // modificador que se aplica a nivel de ejecutacion , que puede ser invocado
        string GetData(int value);

        [OperationContract]// modificador que se aplica a nivel de ejecutacion 
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]// modificador que se aplica a nivel de ejecutacion 
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]// modificador que se aplica a nivel de ejecutacion 
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]// modificador que se aplica a nivel de ejecutacion 
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
