using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcf_assignment3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IFlowerService
    {

        // TODO: Add your service operations here

        [OperationContract]
        string InsertFlower(FlowerDetails flower);

        [OperationContract]
        FlowerDetails GetFlower(int value);
        [OperationContract]
        FlowerDetails[] GetFlowers();

        [OperationContract]
        string UpdateFlower(FlowerDetails flower,int value);

        [OperationContract]
        string DeleteFlower(int value);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class FlowerDetails
    {
        int flowerId = -1;
        string name = string.Empty;
        string colour = string.Empty;
        decimal price = -1;
        int stock = 0;
        string species = string.Empty;
        [DataMember]
        public int FlowerId
        {
            get { return flowerId; }
            set { flowerId = value; }
        }
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [DataMember]
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        [DataMember]
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        [DataMember]
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        [DataMember]
        public string Species
        {
            get { return species; }
            set { species = value; }
        }
    }
}
