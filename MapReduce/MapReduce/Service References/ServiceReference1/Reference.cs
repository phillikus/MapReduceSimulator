﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.34014
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MapReduce.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IWCMapReduce", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IWCMapReduce {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCMapReduce/Map", ReplyAction="http://tempuri.org/IWCMapReduce/MapResponse")]
        System.Collections.Generic.KeyValuePair<string, int>[] Map(System.Collections.Generic.KeyValuePair<string, string> record);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCMapReduce/Map", ReplyAction="http://tempuri.org/IWCMapReduce/MapResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.KeyValuePair<string, int>[]> MapAsync(System.Collections.Generic.KeyValuePair<string, string> record);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCMapReduce/Reduce", ReplyAction="http://tempuri.org/IWCMapReduce/ReduceResponse")]
        string Reduce(string key, int[] values);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCMapReduce/Reduce", ReplyAction="http://tempuri.org/IWCMapReduce/ReduceResponse")]
        System.Threading.Tasks.Task<string> ReduceAsync(string key, int[] values);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWCMapReduceChannel : MapReduce.ServiceReference1.IWCMapReduce, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WCMapReduceClient : System.ServiceModel.ClientBase<MapReduce.ServiceReference1.IWCMapReduce>, MapReduce.ServiceReference1.IWCMapReduce {
        
        public WCMapReduceClient() {
        }
        
        public WCMapReduceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WCMapReduceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCMapReduceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCMapReduceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.KeyValuePair<string, int>[] Map(System.Collections.Generic.KeyValuePair<string, string> record) {
            return base.Channel.Map(record);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.KeyValuePair<string, int>[]> MapAsync(System.Collections.Generic.KeyValuePair<string, string> record) {
            return base.Channel.MapAsync(record);
        }
        
        public string Reduce(string key, int[] values) {
            return base.Channel.Reduce(key, values);
        }
        
        public System.Threading.Tasks.Task<string> ReduceAsync(string key, int[] values) {
            return base.Channel.ReduceAsync(key, values);
        }
    }
}
