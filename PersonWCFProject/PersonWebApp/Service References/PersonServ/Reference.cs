﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonWebApp.PersonServ {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PersonServ.IPersonService")]
    public interface IPersonService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPersonLongServ", ReplyAction="http://tempuri.org/IPersonService/GetPersonLongServResponse")]
        PersonEntities.PersonLongEntity[] GetPersonLongServ(int age);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPersonLongServ", ReplyAction="http://tempuri.org/IPersonService/GetPersonLongServResponse")]
        System.Threading.Tasks.Task<PersonEntities.PersonLongEntity[]> GetPersonLongServAsync(int age);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPersonShortServ", ReplyAction="http://tempuri.org/IPersonService/GetPersonShortServResponse")]
        PersonEntities.PersonShortEntity[] GetPersonShortServ(int age);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPersonShortServ", ReplyAction="http://tempuri.org/IPersonService/GetPersonShortServResponse")]
        System.Threading.Tasks.Task<PersonEntities.PersonShortEntity[]> GetPersonShortServAsync(int age);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/SaveToPersonShortServ", ReplyAction="http://tempuri.org/IPersonService/SaveToPersonShortServResponse")]
        void SaveToPersonShortServ(PersonEntities.PersonShortEntity[] lst);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/SaveToPersonShortServ", ReplyAction="http://tempuri.org/IPersonService/SaveToPersonShortServResponse")]
        System.Threading.Tasks.Task SaveToPersonShortServAsync(PersonEntities.PersonShortEntity[] lst);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/ShowDates", ReplyAction="http://tempuri.org/IPersonService/ShowDatesResponse")]
        string ShowDates();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/ShowDates", ReplyAction="http://tempuri.org/IPersonService/ShowDatesResponse")]
        System.Threading.Tasks.Task<string> ShowDatesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPersonServiceChannel : PersonWebApp.PersonServ.IPersonService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonServiceClient : System.ServiceModel.ClientBase<PersonWebApp.PersonServ.IPersonService>, PersonWebApp.PersonServ.IPersonService {
        
        public PersonServiceClient() {
        }
        
        public PersonServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PersonEntities.PersonLongEntity[] GetPersonLongServ(int age) {
            return base.Channel.GetPersonLongServ(age);
        }
        
        public System.Threading.Tasks.Task<PersonEntities.PersonLongEntity[]> GetPersonLongServAsync(int age) {
            return base.Channel.GetPersonLongServAsync(age);
        }
        
        public PersonEntities.PersonShortEntity[] GetPersonShortServ(int age) {
            return base.Channel.GetPersonShortServ(age);
        }
        
        public System.Threading.Tasks.Task<PersonEntities.PersonShortEntity[]> GetPersonShortServAsync(int age) {
            return base.Channel.GetPersonShortServAsync(age);
        }
        
        public void SaveToPersonShortServ(PersonEntities.PersonShortEntity[] lst) {
            base.Channel.SaveToPersonShortServ(lst);
        }
        
        public System.Threading.Tasks.Task SaveToPersonShortServAsync(PersonEntities.PersonShortEntity[] lst) {
            return base.Channel.SaveToPersonShortServAsync(lst);
        }
        
        public string ShowDates() {
            return base.Channel.ShowDates();
        }
        
        public System.Threading.Tasks.Task<string> ShowDatesAsync() {
            return base.Channel.ShowDatesAsync();
        }
    }
}