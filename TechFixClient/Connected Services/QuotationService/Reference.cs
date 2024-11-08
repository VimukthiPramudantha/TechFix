﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechFixClient.QuotationService {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="QuotationService.QuotationWebServiceSoap")]
    public interface QuotationWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetQuotationsByProduct", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetQuotationsByProduct(int productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetQuotationsByProduct", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetQuotationsByProductAsync(int productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SaveQuotationResponse", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool SaveQuotationResponse(int quotationId, int userId, int quantity, decimal price, string response);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SaveQuotationResponse", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> SaveQuotationResponseAsync(int quotationId, int userId, int quantity, decimal price, string response);
        
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PlaceQuotation", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool PlaceQuotation(int productId, int categoryId, int quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PlaceQuotation", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> PlaceQuotationAsync(int productId, int categoryId, int quantity);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface QuotationWebServiceSoapChannel : TechFixClient.QuotationService.QuotationWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class QuotationWebServiceSoapClient : System.ServiceModel.ClientBase<TechFixClient.QuotationService.QuotationWebServiceSoap>, TechFixClient.QuotationService.QuotationWebServiceSoap {
        
        public QuotationWebServiceSoapClient() {
        }
        
        public QuotationWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public QuotationWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuotationWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuotationWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable GetQuotationsByProduct(int productId) {
            return base.Channel.GetQuotationsByProduct(productId);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetQuotationsByProductAsync(int productId) {
            return base.Channel.GetQuotationsByProductAsync(productId);
        }
        
        public bool SaveQuotationResponse(int quotationId, int userId, int quantity, decimal price, string response) {
            return base.Channel.SaveQuotationResponse(quotationId, userId, quantity, price, response);
        }
        
        public System.Threading.Tasks.Task<bool> SaveQuotationResponseAsync(int quotationId, int userId, int quantity, decimal price, string response) {
            return base.Channel.SaveQuotationResponseAsync(quotationId, userId, quantity, price, response);
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
        
        public bool PlaceQuotation(int productId, int categoryId, int quantity) {
            return base.Channel.PlaceQuotation(productId, categoryId, quantity);
        }
        
        public System.Threading.Tasks.Task<bool> PlaceQuotationAsync(int productId, int categoryId, int quantity) {
            return base.Channel.PlaceQuotationAsync(productId, categoryId, quantity);
        }
    }
}
