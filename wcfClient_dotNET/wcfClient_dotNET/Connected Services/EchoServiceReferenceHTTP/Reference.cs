﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wcfClient_dotNET.EchoServiceReferenceHTTP {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EchoMessage", Namespace="http://schemas.datacontract.org/2004/07/CoreWCfDemoServer")]
    [System.SerializableAttribute()]
    public partial class EchoMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text {
            get {
                return this.TextField;
            }
            set {
                if ((object.ReferenceEquals(this.TextField, value) != true)) {
                    this.TextField = value;
                    this.RaisePropertyChanged("Text");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EchoFault", Namespace="http://schemas.datacontract.org/2004/07/CoreWCfDemoServer")]
    [System.SerializableAttribute()]
    public partial class EchoFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text {
            get {
                return this.TextField;
            }
            set {
                if ((object.ReferenceEquals(this.TextField, value) != true)) {
                    this.TextField = value;
                    this.RaisePropertyChanged("Text");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EchoServiceReferenceHTTP.IEchoService")]
    public interface IEchoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEchoService/Echo", ReplyAction="http://tempuri.org/IEchoService/EchoResponse")]
        string Echo(string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEchoService/Echo", ReplyAction="http://tempuri.org/IEchoService/EchoResponse")]
        System.Threading.Tasks.Task<string> EchoAsync(string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEchoService/ComplexEcho", ReplyAction="http://tempuri.org/IEchoService/ComplexEchoResponse")]
        string ComplexEcho(wcfClient_dotNET.EchoServiceReferenceHTTP.EchoMessage text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEchoService/ComplexEcho", ReplyAction="http://tempuri.org/IEchoService/ComplexEchoResponse")]
        System.Threading.Tasks.Task<string> ComplexEchoAsync(wcfClient_dotNET.EchoServiceReferenceHTTP.EchoMessage text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEchoService/FailEcho", ReplyAction="http://tempuri.org/IEchoService/FailEchoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(wcfClient_dotNET.EchoServiceReferenceHTTP.EchoFault), Action="http://tempuri.org/IEchoService/FailEchoEchoFaultFault", Name="EchoFault", Namespace="http://schemas.datacontract.org/2004/07/CoreWCfDemoServer")]
        string FailEcho(string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEchoService/FailEcho", ReplyAction="http://tempuri.org/IEchoService/FailEchoResponse")]
        System.Threading.Tasks.Task<string> FailEchoAsync(string text);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEchoServiceChannel : wcfClient_dotNET.EchoServiceReferenceHTTP.IEchoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EchoServiceClient : System.ServiceModel.ClientBase<wcfClient_dotNET.EchoServiceReferenceHTTP.IEchoService>, wcfClient_dotNET.EchoServiceReferenceHTTP.IEchoService {
        
        public EchoServiceClient() {
        }
        
        public EchoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EchoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EchoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EchoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Echo(string text) {
            return base.Channel.Echo(text);
        }
        
        public System.Threading.Tasks.Task<string> EchoAsync(string text) {
            return base.Channel.EchoAsync(text);
        }
        
        public string ComplexEcho(wcfClient_dotNET.EchoServiceReferenceHTTP.EchoMessage text) {
            return base.Channel.ComplexEcho(text);
        }
        
        public System.Threading.Tasks.Task<string> ComplexEchoAsync(wcfClient_dotNET.EchoServiceReferenceHTTP.EchoMessage text) {
            return base.Channel.ComplexEchoAsync(text);
        }
        
        public string FailEcho(string text) {
            return base.Channel.FailEcho(text);
        }
        
        public System.Threading.Tasks.Task<string> FailEchoAsync(string text) {
            return base.Channel.FailEchoAsync(text);
        }
    }
}
