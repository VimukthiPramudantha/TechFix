﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechFixClient.LoginServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LoginServiceReference.LoginServiceSoap")]
    public interface LoginServiceSoap {
        
        // CODEGEN: Generating message contract since element name email from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        TechFixClient.LoginServiceReference.LoginResponse Login(TechFixClient.LoginServiceReference.LoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        System.Threading.Tasks.Task<TechFixClient.LoginServiceReference.LoginResponse> LoginAsync(TechFixClient.LoginServiceReference.LoginRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Login", Namespace="http://tempuri.org/", Order=0)]
        public TechFixClient.LoginServiceReference.LoginRequestBody Body;
        
        public LoginRequest() {
        }
        
        public LoginRequest(TechFixClient.LoginServiceReference.LoginRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LoginRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public LoginRequestBody() {
        }
        
        public LoginRequestBody(string email, string password) {
            this.email = email;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LoginResponse", Namespace="http://tempuri.org/", Order=0)]
        public TechFixClient.LoginServiceReference.LoginResponseBody Body;
        
        public LoginResponse() {
        }
        
        public LoginResponse(TechFixClient.LoginServiceReference.LoginResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LoginResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool LoginResult;
        
        public LoginResponseBody() {
        }
        
        public LoginResponseBody(bool LoginResult) {
            this.LoginResult = LoginResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface LoginServiceSoapChannel : TechFixClient.LoginServiceReference.LoginServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoginServiceSoapClient : System.ServiceModel.ClientBase<TechFixClient.LoginServiceReference.LoginServiceSoap>, TechFixClient.LoginServiceReference.LoginServiceSoap {
        
        public LoginServiceSoapClient() {
        }
        
        public LoginServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LoginServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TechFixClient.LoginServiceReference.LoginResponse TechFixClient.LoginServiceReference.LoginServiceSoap.Login(TechFixClient.LoginServiceReference.LoginRequest request) {
            return base.Channel.Login(request);
        }
        
        public bool Login(string email, string password) {
            TechFixClient.LoginServiceReference.LoginRequest inValue = new TechFixClient.LoginServiceReference.LoginRequest();
            inValue.Body = new TechFixClient.LoginServiceReference.LoginRequestBody();
            inValue.Body.email = email;
            inValue.Body.password = password;
            TechFixClient.LoginServiceReference.LoginResponse retVal = ((TechFixClient.LoginServiceReference.LoginServiceSoap)(this)).Login(inValue);
            return retVal.Body.LoginResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TechFixClient.LoginServiceReference.LoginResponse> TechFixClient.LoginServiceReference.LoginServiceSoap.LoginAsync(TechFixClient.LoginServiceReference.LoginRequest request) {
            return base.Channel.LoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<TechFixClient.LoginServiceReference.LoginResponse> LoginAsync(string email, string password) {
            TechFixClient.LoginServiceReference.LoginRequest inValue = new TechFixClient.LoginServiceReference.LoginRequest();
            inValue.Body = new TechFixClient.LoginServiceReference.LoginRequestBody();
            inValue.Body.email = email;
            inValue.Body.password = password;
            return ((TechFixClient.LoginServiceReference.LoginServiceSoap)(this)).LoginAsync(inValue);
        }
    }
}