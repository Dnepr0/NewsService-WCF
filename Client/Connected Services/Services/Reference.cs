﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.Services {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Article", Namespace="http://schemas.datacontract.org/2004/07/Server")]
    [System.SerializableAttribute()]
    public partial class Article : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] CategoriesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LinkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public string[] Categories {
            get {
                return this.CategoriesField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoriesField, value) != true)) {
                    this.CategoriesField = value;
                    this.RaisePropertyChanged("Categories");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Link {
            get {
                return this.LinkField;
            }
            set {
                if ((object.ReferenceEquals(this.LinkField, value) != true)) {
                    this.LinkField = value;
                    this.RaisePropertyChanged("Link");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Services.INewsService", CallbackContract=typeof(Client.Services.INewsServiceCallback))]
    public interface INewsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/Subscribe", ReplyAction="http://tempuri.org/INewsService/SubscribeResponse")]
        bool Subscribe(string category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/Subscribe", ReplyAction="http://tempuri.org/INewsService/SubscribeResponse")]
        System.Threading.Tasks.Task<bool> SubscribeAsync(string category);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INewsServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/INewsService/SendArticle")]
        void SendArticle(Client.Services.Article article);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INewsServiceChannel : Client.Services.INewsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NewsServiceClient : System.ServiceModel.DuplexClientBase<Client.Services.INewsService>, Client.Services.INewsService {
        
        public NewsServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public NewsServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public NewsServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public NewsServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public NewsServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public bool Subscribe(string category) {
            return base.Channel.Subscribe(category);
        }
        
        public System.Threading.Tasks.Task<bool> SubscribeAsync(string category) {
            return base.Channel.SubscribeAsync(category);
        }
    }
}
