﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cromo.WsRndc {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WsRndc.IBPMServices")]
    public interface IBPMServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:BPMServicesIntf-IBPMServices#AtenderMensajeRNDC", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        cromo.WsRndc.AtenderMensajeRNDCResponse AtenderMensajeRNDC(cromo.WsRndc.AtenderMensajeRNDCRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:BPMServicesIntf-IBPMServices#AtenderMensajeRNDC", ReplyAction="*")]
        System.Threading.Tasks.Task<cromo.WsRndc.AtenderMensajeRNDCResponse> AtenderMensajeRNDCAsync(cromo.WsRndc.AtenderMensajeRNDCRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:BPMServicesIntf-IBPMServices#AtenderMensajeBPM", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        cromo.WsRndc.AtenderMensajeBPMResponse AtenderMensajeBPM(cromo.WsRndc.AtenderMensajeBPMRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:BPMServicesIntf-IBPMServices#AtenderMensajeBPM", ReplyAction="*")]
        System.Threading.Tasks.Task<cromo.WsRndc.AtenderMensajeBPMResponse> AtenderMensajeBPMAsync(cromo.WsRndc.AtenderMensajeBPMRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AtenderMensajeRNDC", WrapperNamespace="urn:BPMServicesIntf-IBPMServices", IsWrapped=true)]
    public partial class AtenderMensajeRNDCRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string Request;
        
        public AtenderMensajeRNDCRequest() {
        }
        
        public AtenderMensajeRNDCRequest(string Request) {
            this.Request = Request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AtenderMensajeRNDCResponse", WrapperNamespace="urn:BPMServicesIntf-IBPMServices", IsWrapped=true)]
    public partial class AtenderMensajeRNDCResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string @return;
        
        public AtenderMensajeRNDCResponse() {
        }
        
        public AtenderMensajeRNDCResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AtenderMensajeBPM", WrapperNamespace="urn:BPMServicesIntf-IBPMServices", IsWrapped=true)]
    public partial class AtenderMensajeBPMRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string Request;
        
        public AtenderMensajeBPMRequest() {
        }
        
        public AtenderMensajeBPMRequest(string Request) {
            this.Request = Request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AtenderMensajeBPMResponse", WrapperNamespace="urn:BPMServicesIntf-IBPMServices", IsWrapped=true)]
    public partial class AtenderMensajeBPMResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string @return;
        
        public AtenderMensajeBPMResponse() {
        }
        
        public AtenderMensajeBPMResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBPMServicesChannel : cromo.WsRndc.IBPMServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BPMServicesClient : System.ServiceModel.ClientBase<cromo.WsRndc.IBPMServices>, cromo.WsRndc.IBPMServices {
        
        public BPMServicesClient() {
        }
        
        public BPMServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BPMServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BPMServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BPMServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public cromo.WsRndc.AtenderMensajeRNDCResponse AtenderMensajeRNDC(cromo.WsRndc.AtenderMensajeRNDCRequest request) {
            return base.Channel.AtenderMensajeRNDC(request);
        }
        
        public System.Threading.Tasks.Task<cromo.WsRndc.AtenderMensajeRNDCResponse> AtenderMensajeRNDCAsync(cromo.WsRndc.AtenderMensajeRNDCRequest request) {
            return base.Channel.AtenderMensajeRNDCAsync(request);
        }
        
        public cromo.WsRndc.AtenderMensajeBPMResponse AtenderMensajeBPM(cromo.WsRndc.AtenderMensajeBPMRequest request) {
            return base.Channel.AtenderMensajeBPM(request);
        }
        
        public System.Threading.Tasks.Task<cromo.WsRndc.AtenderMensajeBPMResponse> AtenderMensajeBPMAsync(cromo.WsRndc.AtenderMensajeBPMRequest request) {
            return base.Channel.AtenderMensajeBPMAsync(request);
        }
    }
}
