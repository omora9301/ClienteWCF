﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteWCF.ServiceReferenceUsuarios {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BE", Namespace="http://schemas.datacontract.org/2004/07/aaacesa.Business.WCFUsuarios.AppEntity")]
    [System.SerializableAttribute()]
    public partial class BE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EdadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string U_iduField;
        
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
        public int Edad {
            get {
                return this.EdadField;
            }
            set {
                if ((this.EdadField.Equals(value) != true)) {
                    this.EdadField = value;
                    this.RaisePropertyChanged("Edad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Materno {
            get {
                return this.MaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.MaternoField, value) != true)) {
                    this.MaternoField = value;
                    this.RaisePropertyChanged("Materno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Paterno {
            get {
                return this.PaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.PaternoField, value) != true)) {
                    this.PaternoField = value;
                    this.RaisePropertyChanged("Paterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string U_idu {
            get {
                return this.U_iduField;
            }
            set {
                if ((object.ReferenceEquals(this.U_iduField, value) != true)) {
                    this.U_iduField = value;
                    this.RaisePropertyChanged("U_idu");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceUsuarios.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ObtenerListaUs", ReplyAction="http://tempuri.org/IService/ObtenerListaUsResponse")]
        ClienteWCF.ServiceReferenceUsuarios.BE[] ObtenerListaUs(string idu, string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ObtenerListaUs", ReplyAction="http://tempuri.org/IService/ObtenerListaUsResponse")]
        System.Threading.Tasks.Task<ClienteWCF.ServiceReferenceUsuarios.BE[]> ObtenerListaUsAsync(string idu, string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AgregarUsuario", ReplyAction="http://tempuri.org/IService/AgregarUsuarioResponse")]
        string AgregarUsuario(string nombre, string paterno, string materno, int edad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AgregarUsuario", ReplyAction="http://tempuri.org/IService/AgregarUsuarioResponse")]
        System.Threading.Tasks.Task<string> AgregarUsuarioAsync(string nombre, string paterno, string materno, int edad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ActualizarUsu", ReplyAction="http://tempuri.org/IService/ActualizarUsuResponse")]
        string ActualizarUsu(string u_idu, string nombre, string paterno, string materno, int edad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ActualizarUsu", ReplyAction="http://tempuri.org/IService/ActualizarUsuResponse")]
        System.Threading.Tasks.Task<string> ActualizarUsuAsync(string u_idu, string nombre, string paterno, string materno, int edad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Eliminar", ReplyAction="http://tempuri.org/IService/EliminarResponse")]
        string Eliminar(string u_idu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Eliminar", ReplyAction="http://tempuri.org/IService/EliminarResponse")]
        System.Threading.Tasks.Task<string> EliminarAsync(string u_idu);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : ClienteWCF.ServiceReferenceUsuarios.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<ClienteWCF.ServiceReferenceUsuarios.IService>, ClienteWCF.ServiceReferenceUsuarios.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClienteWCF.ServiceReferenceUsuarios.BE[] ObtenerListaUs(string idu, string nombre) {
            return base.Channel.ObtenerListaUs(idu, nombre);
        }
        
        public System.Threading.Tasks.Task<ClienteWCF.ServiceReferenceUsuarios.BE[]> ObtenerListaUsAsync(string idu, string nombre) {
            return base.Channel.ObtenerListaUsAsync(idu, nombre);
        }
        
        public string AgregarUsuario(string nombre, string paterno, string materno, int edad) {
            return base.Channel.AgregarUsuario(nombre, paterno, materno, edad);
        }
        
        public System.Threading.Tasks.Task<string> AgregarUsuarioAsync(string nombre, string paterno, string materno, int edad) {
            return base.Channel.AgregarUsuarioAsync(nombre, paterno, materno, edad);
        }
        
        public string ActualizarUsu(string u_idu, string nombre, string paterno, string materno, int edad) {
            return base.Channel.ActualizarUsu(u_idu, nombre, paterno, materno, edad);
        }
        
        public System.Threading.Tasks.Task<string> ActualizarUsuAsync(string u_idu, string nombre, string paterno, string materno, int edad) {
            return base.Channel.ActualizarUsuAsync(u_idu, nombre, paterno, materno, edad);
        }
        
        public string Eliminar(string u_idu) {
            return base.Channel.Eliminar(u_idu);
        }
        
        public System.Threading.Tasks.Task<string> EliminarAsync(string u_idu) {
            return base.Channel.EliminarAsync(u_idu);
        }
    }
}