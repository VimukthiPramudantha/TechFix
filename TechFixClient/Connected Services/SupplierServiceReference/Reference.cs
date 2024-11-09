﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechFixClient.SupplierServiceReference {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SupplierServiceReference.SupplierServiceSoap")]
    public interface SupplierServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCategories", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetCategories();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCategories", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetCategoriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetProductsByCategory", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetProductsByCategory(int categoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetProductsByCategory", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetProductsByCategoryAsync(int categoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RespondToQuotation", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool RespondToQuotation(int quotationId, string responseMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RespondToQuotation", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> RespondToQuotationAsync(int quotationId, string responseMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetOrderStatus", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetOrderStatus();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetOrderStatus", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetOrderStatusAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SupplierServiceSoapChannel : TechFixClient.SupplierServiceReference.SupplierServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SupplierServiceSoapClient : System.ServiceModel.ClientBase<TechFixClient.SupplierServiceReference.SupplierServiceSoap>, TechFixClient.SupplierServiceReference.SupplierServiceSoap {
        
        public SupplierServiceSoapClient() {
        }
        
        public SupplierServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SupplierServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SupplierServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SupplierServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable GetCategories() {
            return base.Channel.GetCategories();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetCategoriesAsync() {
            return base.Channel.GetCategoriesAsync();
        }
        
        public System.Data.DataTable GetProductsByCategory(int categoryId) {
            return base.Channel.GetProductsByCategory(categoryId);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetProductsByCategoryAsync(int categoryId) {
            return base.Channel.GetProductsByCategoryAsync(categoryId);
        }
        
        public bool RespondToQuotation(int quotationId, string responseMessage) {
            return base.Channel.RespondToQuotation(quotationId, responseMessage);
        }
        
        public System.Threading.Tasks.Task<bool> RespondToQuotationAsync(int quotationId, string responseMessage) {
            return base.Channel.RespondToQuotationAsync(quotationId, responseMessage);
        }
        
        public System.Data.DataTable GetOrderStatus() {
            return base.Channel.GetOrderStatus();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetOrderStatusAsync() {
            return base.Channel.GetOrderStatusAsync();
        }
    }
}