﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cliente_Cara.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.Service1Soap")]
    public interface Service1Soap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento BirByte del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WS_Enroll_Venas", ReplyAction="*")]
        Cliente_Cara.ServiceReference1.WS_Enroll_VenasResponse WS_Enroll_Venas(Cliente_Cara.ServiceReference1.WS_Enroll_VenasRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento usr del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WS_Verify_Venas", ReplyAction="*")]
        Cliente_Cara.ServiceReference1.WS_Verify_VenasResponse WS_Verify_Venas(Cliente_Cara.ServiceReference1.WS_Verify_VenasRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento imgByte del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WS_Enroll_Cara", ReplyAction="*")]
        Cliente_Cara.ServiceReference1.WS_Enroll_CaraResponse WS_Enroll_Cara(Cliente_Cara.ServiceReference1.WS_Enroll_CaraRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento imgByte del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WS_Verify_Cara", ReplyAction="*")]
        Cliente_Cara.ServiceReference1.WS_Verify_CaraResponse WS_Verify_Cara(Cliente_Cara.ServiceReference1.WS_Verify_CaraRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WS_Enroll_VenasRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WS_Enroll_Venas", Namespace="http://tempuri.org/", Order=0)]
        public Cliente_Cara.ServiceReference1.WS_Enroll_VenasRequestBody Body;
        
        public WS_Enroll_VenasRequest() {
        }
        
        public WS_Enroll_VenasRequest(Cliente_Cara.ServiceReference1.WS_Enroll_VenasRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class WS_Enroll_VenasRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] BirByte;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string usr;
        
        public WS_Enroll_VenasRequestBody() {
        }
        
        public WS_Enroll_VenasRequestBody(byte[] BirByte, string usr) {
            this.BirByte = BirByte;
            this.usr = usr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WS_Enroll_VenasResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WS_Enroll_VenasResponse", Namespace="http://tempuri.org/", Order=0)]
        public Cliente_Cara.ServiceReference1.WS_Enroll_VenasResponseBody Body;
        
        public WS_Enroll_VenasResponse() {
        }
        
        public WS_Enroll_VenasResponse(Cliente_Cara.ServiceReference1.WS_Enroll_VenasResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class WS_Enroll_VenasResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int WS_Enroll_VenasResult;
        
        public WS_Enroll_VenasResponseBody() {
        }
        
        public WS_Enroll_VenasResponseBody(int WS_Enroll_VenasResult) {
            this.WS_Enroll_VenasResult = WS_Enroll_VenasResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WS_Verify_VenasRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WS_Verify_Venas", Namespace="http://tempuri.org/", Order=0)]
        public Cliente_Cara.ServiceReference1.WS_Verify_VenasRequestBody Body;
        
        public WS_Verify_VenasRequest() {
        }
        
        public WS_Verify_VenasRequest(Cliente_Cara.ServiceReference1.WS_Verify_VenasRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class WS_Verify_VenasRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string usr;
        
        public WS_Verify_VenasRequestBody() {
        }
        
        public WS_Verify_VenasRequestBody(string usr) {
            this.usr = usr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WS_Verify_VenasResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WS_Verify_VenasResponse", Namespace="http://tempuri.org/", Order=0)]
        public Cliente_Cara.ServiceReference1.WS_Verify_VenasResponseBody Body;
        
        public WS_Verify_VenasResponse() {
        }
        
        public WS_Verify_VenasResponse(Cliente_Cara.ServiceReference1.WS_Verify_VenasResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class WS_Verify_VenasResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] WS_Verify_VenasResult;
        
        public WS_Verify_VenasResponseBody() {
        }
        
        public WS_Verify_VenasResponseBody(byte[] WS_Verify_VenasResult) {
            this.WS_Verify_VenasResult = WS_Verify_VenasResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WS_Enroll_CaraRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WS_Enroll_Cara", Namespace="http://tempuri.org/", Order=0)]
        public Cliente_Cara.ServiceReference1.WS_Enroll_CaraRequestBody Body;
        
        public WS_Enroll_CaraRequest() {
        }
        
        public WS_Enroll_CaraRequest(Cliente_Cara.ServiceReference1.WS_Enroll_CaraRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class WS_Enroll_CaraRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] imgByte;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string usr;
        
        public WS_Enroll_CaraRequestBody() {
        }
        
        public WS_Enroll_CaraRequestBody(byte[] imgByte, string usr) {
            this.imgByte = imgByte;
            this.usr = usr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WS_Enroll_CaraResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WS_Enroll_CaraResponse", Namespace="http://tempuri.org/", Order=0)]
        public Cliente_Cara.ServiceReference1.WS_Enroll_CaraResponseBody Body;
        
        public WS_Enroll_CaraResponse() {
        }
        
        public WS_Enroll_CaraResponse(Cliente_Cara.ServiceReference1.WS_Enroll_CaraResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class WS_Enroll_CaraResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int WS_Enroll_CaraResult;
        
        public WS_Enroll_CaraResponseBody() {
        }
        
        public WS_Enroll_CaraResponseBody(int WS_Enroll_CaraResult) {
            this.WS_Enroll_CaraResult = WS_Enroll_CaraResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WS_Verify_CaraRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WS_Verify_Cara", Namespace="http://tempuri.org/", Order=0)]
        public Cliente_Cara.ServiceReference1.WS_Verify_CaraRequestBody Body;
        
        public WS_Verify_CaraRequest() {
        }
        
        public WS_Verify_CaraRequest(Cliente_Cara.ServiceReference1.WS_Verify_CaraRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class WS_Verify_CaraRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] imgByte;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string usr;
        
        public WS_Verify_CaraRequestBody() {
        }
        
        public WS_Verify_CaraRequestBody(byte[] imgByte, string usr) {
            this.imgByte = imgByte;
            this.usr = usr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WS_Verify_CaraResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WS_Verify_CaraResponse", Namespace="http://tempuri.org/", Order=0)]
        public Cliente_Cara.ServiceReference1.WS_Verify_CaraResponseBody Body;
        
        public WS_Verify_CaraResponse() {
        }
        
        public WS_Verify_CaraResponse(Cliente_Cara.ServiceReference1.WS_Verify_CaraResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class WS_Verify_CaraResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int WS_Verify_CaraResult;
        
        public WS_Verify_CaraResponseBody() {
        }
        
        public WS_Verify_CaraResponseBody(int WS_Verify_CaraResult) {
            this.WS_Verify_CaraResult = WS_Verify_CaraResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Service1SoapChannel : Cliente_Cara.ServiceReference1.Service1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1SoapClient : System.ServiceModel.ClientBase<Cliente_Cara.ServiceReference1.Service1Soap>, Cliente_Cara.ServiceReference1.Service1Soap {
        
        public Service1SoapClient() {
        }
        
        public Service1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Cliente_Cara.ServiceReference1.WS_Enroll_VenasResponse Cliente_Cara.ServiceReference1.Service1Soap.WS_Enroll_Venas(Cliente_Cara.ServiceReference1.WS_Enroll_VenasRequest request) {
            return base.Channel.WS_Enroll_Venas(request);
        }
        
        public int WS_Enroll_Venas(byte[] BirByte, string usr) {
            Cliente_Cara.ServiceReference1.WS_Enroll_VenasRequest inValue = new Cliente_Cara.ServiceReference1.WS_Enroll_VenasRequest();
            inValue.Body = new Cliente_Cara.ServiceReference1.WS_Enroll_VenasRequestBody();
            inValue.Body.BirByte = BirByte;
            inValue.Body.usr = usr;
            Cliente_Cara.ServiceReference1.WS_Enroll_VenasResponse retVal = ((Cliente_Cara.ServiceReference1.Service1Soap)(this)).WS_Enroll_Venas(inValue);
            return retVal.Body.WS_Enroll_VenasResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Cliente_Cara.ServiceReference1.WS_Verify_VenasResponse Cliente_Cara.ServiceReference1.Service1Soap.WS_Verify_Venas(Cliente_Cara.ServiceReference1.WS_Verify_VenasRequest request) {
            return base.Channel.WS_Verify_Venas(request);
        }
        
        public byte[] WS_Verify_Venas(string usr) {
            Cliente_Cara.ServiceReference1.WS_Verify_VenasRequest inValue = new Cliente_Cara.ServiceReference1.WS_Verify_VenasRequest();
            inValue.Body = new Cliente_Cara.ServiceReference1.WS_Verify_VenasRequestBody();
            inValue.Body.usr = usr;
            Cliente_Cara.ServiceReference1.WS_Verify_VenasResponse retVal = ((Cliente_Cara.ServiceReference1.Service1Soap)(this)).WS_Verify_Venas(inValue);
            return retVal.Body.WS_Verify_VenasResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Cliente_Cara.ServiceReference1.WS_Enroll_CaraResponse Cliente_Cara.ServiceReference1.Service1Soap.WS_Enroll_Cara(Cliente_Cara.ServiceReference1.WS_Enroll_CaraRequest request) {
            return base.Channel.WS_Enroll_Cara(request);
        }
        
        public int WS_Enroll_Cara(byte[] imgByte, string usr) {
            Cliente_Cara.ServiceReference1.WS_Enroll_CaraRequest inValue = new Cliente_Cara.ServiceReference1.WS_Enroll_CaraRequest();
            inValue.Body = new Cliente_Cara.ServiceReference1.WS_Enroll_CaraRequestBody();
            inValue.Body.imgByte = imgByte;
            inValue.Body.usr = usr;
            Cliente_Cara.ServiceReference1.WS_Enroll_CaraResponse retVal = ((Cliente_Cara.ServiceReference1.Service1Soap)(this)).WS_Enroll_Cara(inValue);
            return retVal.Body.WS_Enroll_CaraResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Cliente_Cara.ServiceReference1.WS_Verify_CaraResponse Cliente_Cara.ServiceReference1.Service1Soap.WS_Verify_Cara(Cliente_Cara.ServiceReference1.WS_Verify_CaraRequest request) {
            return base.Channel.WS_Verify_Cara(request);
        }
        
        public int WS_Verify_Cara(byte[] imgByte, string usr) {
            Cliente_Cara.ServiceReference1.WS_Verify_CaraRequest inValue = new Cliente_Cara.ServiceReference1.WS_Verify_CaraRequest();
            inValue.Body = new Cliente_Cara.ServiceReference1.WS_Verify_CaraRequestBody();
            inValue.Body.imgByte = imgByte;
            inValue.Body.usr = usr;
            Cliente_Cara.ServiceReference1.WS_Verify_CaraResponse retVal = ((Cliente_Cara.ServiceReference1.Service1Soap)(this)).WS_Verify_Cara(inValue);
            return retVal.Body.WS_Verify_CaraResult;
        }
    }
}
