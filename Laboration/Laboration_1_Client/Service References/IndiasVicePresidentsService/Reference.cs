﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Laboration_1_Client.IndiasVicePresidentsService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IndiasVicePresidentsService.IndiaVicePresidentServiceSoap")]
    public interface IndiaVicePresidentServiceSoap {
        
        // CODEGEN: Generating message contract since element name year from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IndiaVicePresidentGivenYear", ReplyAction="*")]
        Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentGivenYearResponse IndiaVicePresidentGivenYear(Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentGivenYearRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IndiaVicePresidentGivenYear", ReplyAction="*")]
        System.Threading.Tasks.Task<Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentGivenYearResponse> IndiaVicePresidentGivenYearAsync(Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentGivenYearRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class IndiaVicePresidentGivenYearRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="IndiaVicePresidentGivenYear", Namespace="http://tempuri.org/", Order=0)]
        public Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentGivenYearRequestBody Body;
        
        public IndiaVicePresidentGivenYearRequest() {
        }
        
        public IndiaVicePresidentGivenYearRequest(Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentGivenYearRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class IndiaVicePresidentGivenYearRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string year;
        
        public IndiaVicePresidentGivenYearRequestBody() {
        }
        
        public IndiaVicePresidentGivenYearRequestBody(string year) {
            this.year = year;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class IndiaVicePresidentGivenYearResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="IndiaVicePresidentGivenYearResponse", Namespace="http://tempuri.org/", Order=0)]
        public Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentGivenYearResponseBody Body;
        
        public IndiaVicePresidentGivenYearResponse() {
        }
        
        public IndiaVicePresidentGivenYearResponse(Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentGivenYearResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class IndiaVicePresidentGivenYearResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string IndiaVicePresidentGivenYearResult;
        
        public IndiaVicePresidentGivenYearResponseBody() {
        }
        
        public IndiaVicePresidentGivenYearResponseBody(string IndiaVicePresidentGivenYearResult) {
            this.IndiaVicePresidentGivenYearResult = IndiaVicePresidentGivenYearResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IndiaVicePresidentServiceSoapChannel : Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IndiaVicePresidentServiceSoapClient : System.ServiceModel.ClientBase<Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentServiceSoap>, Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentServiceSoap {
        
        public IndiaVicePresidentServiceSoapClient() {
        }
        
        public IndiaVicePresidentServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IndiaVicePresidentServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IndiaVicePresidentServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IndiaVicePresidentServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentGivenYearResponse Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentServiceSoap.IndiaVicePresidentGivenYear(Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentGivenYearRequest request) {
            return base.Channel.IndiaVicePresidentGivenYear(request);
        }
        
        public string IndiaVicePresidentGivenYear(string year) {
            Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentGivenYearRequest inValue = new Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentGivenYearRequest();
            inValue.Body = new Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentGivenYearRequestBody();
            inValue.Body.year = year;
            Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentGivenYearResponse retVal = ((Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentServiceSoap)(this)).IndiaVicePresidentGivenYear(inValue);
            return retVal.Body.IndiaVicePresidentGivenYearResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentGivenYearResponse> Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentServiceSoap.IndiaVicePresidentGivenYearAsync(Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentGivenYearRequest request) {
            return base.Channel.IndiaVicePresidentGivenYearAsync(request);
        }
        
        public System.Threading.Tasks.Task<Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentGivenYearResponse> IndiaVicePresidentGivenYearAsync(string year) {
            Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentGivenYearRequest inValue = new Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentGivenYearRequest();
            inValue.Body = new Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentGivenYearRequestBody();
            inValue.Body.year = year;
            return ((Laboration_1_Client.IndiasVicePresidentsService.IndiaVicePresidentServiceSoap)(this)).IndiaVicePresidentGivenYearAsync(inValue);
        }
    }
}
