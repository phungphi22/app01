﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace app01.store {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="store.storeSoap")]
    public interface storeSoap {
        
        // CODEGEN: Generating message contract since element name sMaDienLuc from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OKToPay", ReplyAction="*")]
        app01.store.OKToPayResponse OKToPay(app01.store.OKToPayRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OKToPay", ReplyAction="*")]
        System.Threading.Tasks.Task<app01.store.OKToPayResponse> OKToPayAsync(app01.store.OKToPayRequest request);
        
        // CODEGEN: Generating message contract since element name sMaDienLuc from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InValid", ReplyAction="*")]
        app01.store.InValidResponse InValid(app01.store.InValidRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InValid", ReplyAction="*")]
        System.Threading.Tasks.Task<app01.store.InValidResponse> InValidAsync(app01.store.InValidRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class OKToPayRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="OKToPay", Namespace="http://tempuri.org/", Order=0)]
        public app01.store.OKToPayRequestBody Body;
        
        public OKToPayRequest() {
        }
        
        public OKToPayRequest(app01.store.OKToPayRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class OKToPayRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sMaDienLuc;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int iSoTienDaNop;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int iMonth;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int iYear;
        
        public OKToPayRequestBody() {
        }
        
        public OKToPayRequestBody(string sMaDienLuc, int iSoTienDaNop, int iMonth, int iYear) {
            this.sMaDienLuc = sMaDienLuc;
            this.iSoTienDaNop = iSoTienDaNop;
            this.iMonth = iMonth;
            this.iYear = iYear;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class OKToPayResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="OKToPayResponse", Namespace="http://tempuri.org/", Order=0)]
        public app01.store.OKToPayResponseBody Body;
        
        public OKToPayResponse() {
        }
        
        public OKToPayResponse(app01.store.OKToPayResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class OKToPayResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int OKToPayResult;
        
        public OKToPayResponseBody() {
        }
        
        public OKToPayResponseBody(int OKToPayResult) {
            this.OKToPayResult = OKToPayResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InValidRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InValid", Namespace="http://tempuri.org/", Order=0)]
        public app01.store.InValidRequestBody Body;
        
        public InValidRequest() {
        }
        
        public InValidRequest(app01.store.InValidRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InValidRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sMaDienLuc;
        
        public InValidRequestBody() {
        }
        
        public InValidRequestBody(string sMaDienLuc) {
            this.sMaDienLuc = sMaDienLuc;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InValidResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InValidResponse", Namespace="http://tempuri.org/", Order=0)]
        public app01.store.InValidResponseBody Body;
        
        public InValidResponse() {
        }
        
        public InValidResponse(app01.store.InValidResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InValidResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValidResult;
        
        public InValidResponseBody() {
        }
        
        public InValidResponseBody(string InValidResult) {
            this.InValidResult = InValidResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface storeSoapChannel : app01.store.storeSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class storeSoapClient : System.ServiceModel.ClientBase<app01.store.storeSoap>, app01.store.storeSoap {
        
        public storeSoapClient() {
        }
        
        public storeSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public storeSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public storeSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public storeSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        app01.store.OKToPayResponse app01.store.storeSoap.OKToPay(app01.store.OKToPayRequest request) {
            return base.Channel.OKToPay(request);
        }
        
        public int OKToPay(string sMaDienLuc, int iSoTienDaNop, int iMonth, int iYear) {
            app01.store.OKToPayRequest inValue = new app01.store.OKToPayRequest();
            inValue.Body = new app01.store.OKToPayRequestBody();
            inValue.Body.sMaDienLuc = sMaDienLuc;
            inValue.Body.iSoTienDaNop = iSoTienDaNop;
            inValue.Body.iMonth = iMonth;
            inValue.Body.iYear = iYear;
            app01.store.OKToPayResponse retVal = ((app01.store.storeSoap)(this)).OKToPay(inValue);
            return retVal.Body.OKToPayResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<app01.store.OKToPayResponse> app01.store.storeSoap.OKToPayAsync(app01.store.OKToPayRequest request) {
            return base.Channel.OKToPayAsync(request);
        }
        
        public System.Threading.Tasks.Task<app01.store.OKToPayResponse> OKToPayAsync(string sMaDienLuc, int iSoTienDaNop, int iMonth, int iYear) {
            app01.store.OKToPayRequest inValue = new app01.store.OKToPayRequest();
            inValue.Body = new app01.store.OKToPayRequestBody();
            inValue.Body.sMaDienLuc = sMaDienLuc;
            inValue.Body.iSoTienDaNop = iSoTienDaNop;
            inValue.Body.iMonth = iMonth;
            inValue.Body.iYear = iYear;
            return ((app01.store.storeSoap)(this)).OKToPayAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        app01.store.InValidResponse app01.store.storeSoap.InValid(app01.store.InValidRequest request) {
            return base.Channel.InValid(request);
        }
        
        public string InValid(string sMaDienLuc) {
            app01.store.InValidRequest inValue = new app01.store.InValidRequest();
            inValue.Body = new app01.store.InValidRequestBody();
            inValue.Body.sMaDienLuc = sMaDienLuc;
            app01.store.InValidResponse retVal = ((app01.store.storeSoap)(this)).InValid(inValue);
            return retVal.Body.InValidResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<app01.store.InValidResponse> app01.store.storeSoap.InValidAsync(app01.store.InValidRequest request) {
            return base.Channel.InValidAsync(request);
        }
        
        public System.Threading.Tasks.Task<app01.store.InValidResponse> InValidAsync(string sMaDienLuc) {
            app01.store.InValidRequest inValue = new app01.store.InValidRequest();
            inValue.Body = new app01.store.InValidRequestBody();
            inValue.Body.sMaDienLuc = sMaDienLuc;
            return ((app01.store.storeSoap)(this)).InValidAsync(inValue);
        }
    }
}
