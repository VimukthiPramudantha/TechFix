﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechFixClient.OrderServiceReference {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OrderServiceReference.OrderServiceSoap")]
    public interface OrderServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetOrders", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetOrders", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetOrdersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PlaceOrder", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool PlaceOrder(int quotationId, int userId, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PlaceOrder", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> PlaceOrderAsync(int quotationId, int userId, string status);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface OrderServiceSoapChannel : TechFixClient.OrderServiceReference.OrderServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrderServiceSoapClient : System.ServiceModel.ClientBase<TechFixClient.OrderServiceReference.OrderServiceSoap>, TechFixClient.OrderServiceReference.OrderServiceSoap {
        
        public OrderServiceSoapClient() {
        }
        
        public OrderServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrderServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable GetOrders() {
            return base.Channel.GetOrders();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetOrdersAsync() {
            return base.Channel.GetOrdersAsync();
        }
        
        public bool PlaceOrder(int quotationId, int userId, string status) {
            return base.Channel.PlaceOrder(quotationId, userId, status);
        }
        
        public System.Threading.Tasks.Task<bool> PlaceOrderAsync(int quotationId, int userId, string status) {
            return base.Channel.PlaceOrderAsync(quotationId, userId, status);
        }
    }
}
