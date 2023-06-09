﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FlowerDetails", Namespace="http://schemas.datacontract.org/2004/07/wcf_assignment3")]
    public partial class FlowerDetails : object
    {
        
        private string ColourField;
        
        private int FlowerIdField;
        
        private string NameField;
        
        private decimal PriceField;
        
        private string SpeciesField;
        
        private int StockField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Colour
        {
            get
            {
                return this.ColourField;
            }
            set
            {
                this.ColourField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FlowerId
        {
            get
            {
                return this.FlowerIdField;
            }
            set
            {
                this.FlowerIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price
        {
            get
            {
                return this.PriceField;
            }
            set
            {
                this.PriceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Species
        {
            get
            {
                return this.SpeciesField;
            }
            set
            {
                this.SpeciesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Stock
        {
            get
            {
                return this.StockField;
            }
            set
            {
                this.StockField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IFlowerService")]
    public interface IFlowerService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlowerService/InsertFlower", ReplyAction="http://tempuri.org/IFlowerService/InsertFlowerResponse")]
        ServiceReference1.InsertFlowerResponse InsertFlower(ServiceReference1.InsertFlowerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlowerService/InsertFlower", ReplyAction="http://tempuri.org/IFlowerService/InsertFlowerResponse")]
        System.Threading.Tasks.Task<ServiceReference1.InsertFlowerResponse> InsertFlowerAsync(ServiceReference1.InsertFlowerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlowerService/GetFlower", ReplyAction="http://tempuri.org/IFlowerService/GetFlowerResponse")]
        ServiceReference1.GetFlowerResponse GetFlower(ServiceReference1.GetFlowerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlowerService/GetFlower", ReplyAction="http://tempuri.org/IFlowerService/GetFlowerResponse")]
        System.Threading.Tasks.Task<ServiceReference1.GetFlowerResponse> GetFlowerAsync(ServiceReference1.GetFlowerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlowerService/GetFlowers", ReplyAction="http://tempuri.org/IFlowerService/GetFlowersResponse")]
        ServiceReference1.GetFlowersResponse GetFlowers(ServiceReference1.GetFlowersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlowerService/GetFlowers", ReplyAction="http://tempuri.org/IFlowerService/GetFlowersResponse")]
        System.Threading.Tasks.Task<ServiceReference1.GetFlowersResponse> GetFlowersAsync(ServiceReference1.GetFlowersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlowerService/UpdateFlower", ReplyAction="http://tempuri.org/IFlowerService/UpdateFlowerResponse")]
        ServiceReference1.UpdateFlowerResponse UpdateFlower(ServiceReference1.UpdateFlowerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlowerService/UpdateFlower", ReplyAction="http://tempuri.org/IFlowerService/UpdateFlowerResponse")]
        System.Threading.Tasks.Task<ServiceReference1.UpdateFlowerResponse> UpdateFlowerAsync(ServiceReference1.UpdateFlowerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlowerService/DeleteFlower", ReplyAction="http://tempuri.org/IFlowerService/DeleteFlowerResponse")]
        ServiceReference1.DeleteFlowerResponse DeleteFlower(ServiceReference1.DeleteFlowerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlowerService/DeleteFlower", ReplyAction="http://tempuri.org/IFlowerService/DeleteFlowerResponse")]
        System.Threading.Tasks.Task<ServiceReference1.DeleteFlowerResponse> DeleteFlowerAsync(ServiceReference1.DeleteFlowerRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertFlower", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class InsertFlowerRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.FlowerDetails flower;
        
        public InsertFlowerRequest()
        {
        }
        
        public InsertFlowerRequest(ServiceReference1.FlowerDetails flower)
        {
            this.flower = flower;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertFlowerResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class InsertFlowerResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string InsertFlowerResult;
        
        public InsertFlowerResponse()
        {
        }
        
        public InsertFlowerResponse(string InsertFlowerResult)
        {
            this.InsertFlowerResult = InsertFlowerResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetFlower", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetFlowerRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int value;
        
        public GetFlowerRequest()
        {
        }
        
        public GetFlowerRequest(int value)
        {
            this.value = value;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetFlowerResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetFlowerResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.FlowerDetails GetFlowerResult;
        
        public GetFlowerResponse()
        {
        }
        
        public GetFlowerResponse(ServiceReference1.FlowerDetails GetFlowerResult)
        {
            this.GetFlowerResult = GetFlowerResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetFlowers", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetFlowersRequest
    {
        
        public GetFlowersRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetFlowersResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetFlowersResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.FlowerDetails[] GetFlowersResult;
        
        public GetFlowersResponse()
        {
        }
        
        public GetFlowersResponse(ServiceReference1.FlowerDetails[] GetFlowersResult)
        {
            this.GetFlowersResult = GetFlowersResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateFlower", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdateFlowerRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.FlowerDetails flower;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int value;
        
        public UpdateFlowerRequest()
        {
        }
        
        public UpdateFlowerRequest(ServiceReference1.FlowerDetails flower, int value)
        {
            this.flower = flower;
            this.value = value;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateFlowerResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdateFlowerResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string UpdateFlowerResult;
        
        public UpdateFlowerResponse()
        {
        }
        
        public UpdateFlowerResponse(string UpdateFlowerResult)
        {
            this.UpdateFlowerResult = UpdateFlowerResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteFlower", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DeleteFlowerRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int value;
        
        public DeleteFlowerRequest()
        {
        }
        
        public DeleteFlowerRequest(int value)
        {
            this.value = value;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteFlowerResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DeleteFlowerResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string DeleteFlowerResult;
        
        public DeleteFlowerResponse()
        {
        }
        
        public DeleteFlowerResponse(string DeleteFlowerResult)
        {
            this.DeleteFlowerResult = DeleteFlowerResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IFlowerServiceChannel : ServiceReference1.IFlowerService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class FlowerServiceClient : System.ServiceModel.ClientBase<ServiceReference1.IFlowerService>, ServiceReference1.IFlowerService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public FlowerServiceClient() : 
                base(FlowerServiceClient.GetDefaultBinding(), FlowerServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IFlowerService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FlowerServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(FlowerServiceClient.GetBindingForEndpoint(endpointConfiguration), FlowerServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FlowerServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(FlowerServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FlowerServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(FlowerServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FlowerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public ServiceReference1.InsertFlowerResponse InsertFlower(ServiceReference1.InsertFlowerRequest request)
        {
            return base.Channel.InsertFlower(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.InsertFlowerResponse> InsertFlowerAsync(ServiceReference1.InsertFlowerRequest request)
        {
            return base.Channel.InsertFlowerAsync(request);
        }
        
        public ServiceReference1.GetFlowerResponse GetFlower(ServiceReference1.GetFlowerRequest request)
        {
            return base.Channel.GetFlower(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.GetFlowerResponse> GetFlowerAsync(ServiceReference1.GetFlowerRequest request)
        {
            return base.Channel.GetFlowerAsync(request);
        }
        
        public ServiceReference1.GetFlowersResponse GetFlowers(ServiceReference1.GetFlowersRequest request)
        {
            return base.Channel.GetFlowers(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.GetFlowersResponse> GetFlowersAsync(ServiceReference1.GetFlowersRequest request)
        {
            return base.Channel.GetFlowersAsync(request);
        }
        
        public ServiceReference1.UpdateFlowerResponse UpdateFlower(ServiceReference1.UpdateFlowerRequest request)
        {
            return base.Channel.UpdateFlower(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.UpdateFlowerResponse> UpdateFlowerAsync(ServiceReference1.UpdateFlowerRequest request)
        {
            return base.Channel.UpdateFlowerAsync(request);
        }
        
        public ServiceReference1.DeleteFlowerResponse DeleteFlower(ServiceReference1.DeleteFlowerRequest request)
        {
            return base.Channel.DeleteFlower(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.DeleteFlowerResponse> DeleteFlowerAsync(ServiceReference1.DeleteFlowerRequest request)
        {
            return base.Channel.DeleteFlowerAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IFlowerService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IFlowerService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:58372/Service1.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return FlowerServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IFlowerService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return FlowerServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IFlowerService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IFlowerService,
        }
    }
}
