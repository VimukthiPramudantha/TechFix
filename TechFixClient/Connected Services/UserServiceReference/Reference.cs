﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechFixClient.UserServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserServiceReference.UserServiceSoap")]
    public interface UserServiceSoap {
        
        // CODEGEN: Generating message contract since element name userName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddSupplier", ReplyAction="*")]
        TechFixClient.UserServiceReference.AddSupplierResponse AddSupplier(TechFixClient.UserServiceReference.AddSupplierRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddSupplier", ReplyAction="*")]
        System.Threading.Tasks.Task<TechFixClient.UserServiceReference.AddSupplierResponse> AddSupplierAsync(TechFixClient.UserServiceReference.AddSupplierRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddSupplierRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddSupplier", Namespace="http://tempuri.org/", Order=0)]
        public TechFixClient.UserServiceReference.AddSupplierRequestBody Body;
        
        public AddSupplierRequest() {
        }
        
        public AddSupplierRequest(TechFixClient.UserServiceReference.AddSupplierRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddSupplierRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string userName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string contactNo;
        
        public AddSupplierRequestBody() {
        }
        
        public AddSupplierRequestBody(string userName, string email, string password, string contactNo) {
            this.userName = userName;
            this.email = email;
            this.password = password;
            this.contactNo = contactNo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddSupplierResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddSupplierResponse", Namespace="http://tempuri.org/", Order=0)]
        public TechFixClient.UserServiceReference.AddSupplierResponseBody Body;
        
        public AddSupplierResponse() {
        }
        
        public AddSupplierResponse(TechFixClient.UserServiceReference.AddSupplierResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddSupplierResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string AddSupplierResult;
        
        public AddSupplierResponseBody() {
        }
        
        public AddSupplierResponseBody(string AddSupplierResult) {
            this.AddSupplierResult = AddSupplierResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UserServiceSoapChannel : TechFixClient.UserServiceReference.UserServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceSoapClient : System.ServiceModel.ClientBase<TechFixClient.UserServiceReference.UserServiceSoap>, TechFixClient.UserServiceReference.UserServiceSoap {
        
        public UserServiceSoapClient() {
        }
        
        public UserServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TechFixClient.UserServiceReference.AddSupplierResponse TechFixClient.UserServiceReference.UserServiceSoap.AddSupplier(TechFixClient.UserServiceReference.AddSupplierRequest request) {
            return base.Channel.AddSupplier(request);
        }
        
        public string AddSupplier(string userName, string email, string password, string contactNo) {
            TechFixClient.UserServiceReference.AddSupplierRequest inValue = new TechFixClient.UserServiceReference.AddSupplierRequest();
            inValue.Body = new TechFixClient.UserServiceReference.AddSupplierRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.email = email;
            inValue.Body.password = password;
            inValue.Body.contactNo = contactNo;
            TechFixClient.UserServiceReference.AddSupplierResponse retVal = ((TechFixClient.UserServiceReference.UserServiceSoap)(this)).AddSupplier(inValue);
            return retVal.Body.AddSupplierResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TechFixClient.UserServiceReference.AddSupplierResponse> TechFixClient.UserServiceReference.UserServiceSoap.AddSupplierAsync(TechFixClient.UserServiceReference.AddSupplierRequest request) {
            return base.Channel.AddSupplierAsync(request);
        }
        
        public System.Threading.Tasks.Task<TechFixClient.UserServiceReference.AddSupplierResponse> AddSupplierAsync(string userName, string email, string password, string contactNo) {
            TechFixClient.UserServiceReference.AddSupplierRequest inValue = new TechFixClient.UserServiceReference.AddSupplierRequest();
            inValue.Body = new TechFixClient.UserServiceReference.AddSupplierRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.email = email;
            inValue.Body.password = password;
            inValue.Body.contactNo = contactNo;
            return ((TechFixClient.UserServiceReference.UserServiceSoap)(this)).AddSupplierAsync(inValue);
        }
    }
}
