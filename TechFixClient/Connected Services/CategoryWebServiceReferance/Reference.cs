﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechFixClient.CategoryWebServiceReferance {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CategoryWebServiceReferance.CategoryWebServiceSoap")]
    public interface CategoryWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddCategory", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool AddCategory(string categoryName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddCategory", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> AddCategoryAsync(string categoryName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCategories", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetCategories();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCategories", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetCategoriesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CategoryWebServiceSoapChannel : TechFixClient.CategoryWebServiceReferance.CategoryWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CategoryWebServiceSoapClient : System.ServiceModel.ClientBase<TechFixClient.CategoryWebServiceReferance.CategoryWebServiceSoap>, TechFixClient.CategoryWebServiceReferance.CategoryWebServiceSoap {
        
        public CategoryWebServiceSoapClient() {
        }
        
        public CategoryWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CategoryWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CategoryWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CategoryWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddCategory(string categoryName) {
            return base.Channel.AddCategory(categoryName);
        }
        
        public System.Threading.Tasks.Task<bool> AddCategoryAsync(string categoryName) {
            return base.Channel.AddCategoryAsync(categoryName);
        }
        
        public System.Data.DataTable GetCategories() {
            return base.Channel.GetCategories();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetCategoriesAsync() {
            return base.Channel.GetCategoriesAsync();
        }
    }
}
