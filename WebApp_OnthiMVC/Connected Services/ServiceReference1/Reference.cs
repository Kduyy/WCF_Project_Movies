//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp_OnthiMVC.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfOnThi")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Movie", Namespace="http://schemas.datacontract.org/2004/07/WcfOnThi")]
    [System.SerializableAttribute()]
    public partial class Movie : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal BoxOfficeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApp_OnthiMVC.ServiceReference1.Genre GenreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GenreIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MovieIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ReleaseDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RunningTimeField;
        
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
        public decimal BoxOffice {
            get {
                return this.BoxOfficeField;
            }
            set {
                if ((this.BoxOfficeField.Equals(value) != true)) {
                    this.BoxOfficeField = value;
                    this.RaisePropertyChanged("BoxOffice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebApp_OnthiMVC.ServiceReference1.Genre Genre {
            get {
                return this.GenreField;
            }
            set {
                if ((object.ReferenceEquals(this.GenreField, value) != true)) {
                    this.GenreField = value;
                    this.RaisePropertyChanged("Genre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int GenreId {
            get {
                return this.GenreIdField;
            }
            set {
                if ((this.GenreIdField.Equals(value) != true)) {
                    this.GenreIdField = value;
                    this.RaisePropertyChanged("GenreId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MovieId {
            get {
                return this.MovieIdField;
            }
            set {
                if ((this.MovieIdField.Equals(value) != true)) {
                    this.MovieIdField = value;
                    this.RaisePropertyChanged("MovieId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ReleaseDate {
            get {
                return this.ReleaseDateField;
            }
            set {
                if ((this.ReleaseDateField.Equals(value) != true)) {
                    this.ReleaseDateField = value;
                    this.RaisePropertyChanged("ReleaseDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RunningTime {
            get {
                return this.RunningTimeField;
            }
            set {
                if ((this.RunningTimeField.Equals(value) != true)) {
                    this.RunningTimeField = value;
                    this.RaisePropertyChanged("RunningTime");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Genre", Namespace="http://schemas.datacontract.org/2004/07/WcfOnThi")]
    [System.SerializableAttribute()]
    public partial class Genre : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GenreIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenreNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApp_OnthiMVC.ServiceReference1.Movie[] MoviesField;
        
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
        public int GenreId {
            get {
                return this.GenreIdField;
            }
            set {
                if ((this.GenreIdField.Equals(value) != true)) {
                    this.GenreIdField = value;
                    this.RaisePropertyChanged("GenreId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GenreName {
            get {
                return this.GenreNameField;
            }
            set {
                if ((object.ReferenceEquals(this.GenreNameField, value) != true)) {
                    this.GenreNameField = value;
                    this.RaisePropertyChanged("GenreName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebApp_OnthiMVC.ServiceReference1.Movie[] Movies {
            get {
                return this.MoviesField;
            }
            set {
                if ((object.ReferenceEquals(this.MoviesField, value) != true)) {
                    this.MoviesField = value;
                    this.RaisePropertyChanged("Movies");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        WebApp_OnthiMVC.ServiceReference1.CompositeType GetDataUsingDataContract(WebApp_OnthiMVC.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WebApp_OnthiMVC.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(WebApp_OnthiMVC.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAll", ReplyAction="http://tempuri.org/IService1/getAllResponse")]
        WebApp_OnthiMVC.ServiceReference1.Movie[] getAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAll", ReplyAction="http://tempuri.org/IService1/getAllResponse")]
        System.Threading.Tasks.Task<WebApp_OnthiMVC.ServiceReference1.Movie[]> getAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Search", ReplyAction="http://tempuri.org/IService1/SearchResponse")]
        WebApp_OnthiMVC.ServiceReference1.Movie[] Search([System.ServiceModel.MessageParameterAttribute(Name="Search")] string Search1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Search", ReplyAction="http://tempuri.org/IService1/SearchResponse")]
        System.Threading.Tasks.Task<WebApp_OnthiMVC.ServiceReference1.Movie[]> SearchAsync(string Search);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetbyId", ReplyAction="http://tempuri.org/IService1/GetbyIdResponse")]
        WebApp_OnthiMVC.ServiceReference1.Movie GetbyId(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetbyId", ReplyAction="http://tempuri.org/IService1/GetbyIdResponse")]
        System.Threading.Tasks.Task<WebApp_OnthiMVC.ServiceReference1.Movie> GetbyIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Add", ReplyAction="http://tempuri.org/IService1/AddResponse")]
        void Add(WebApp_OnthiMVC.ServiceReference1.Movie m);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Add", ReplyAction="http://tempuri.org/IService1/AddResponse")]
        System.Threading.Tasks.Task AddAsync(WebApp_OnthiMVC.ServiceReference1.Movie m);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Edit", ReplyAction="http://tempuri.org/IService1/EditResponse")]
        void Edit(WebApp_OnthiMVC.ServiceReference1.Movie m);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Edit", ReplyAction="http://tempuri.org/IService1/EditResponse")]
        System.Threading.Tasks.Task EditAsync(WebApp_OnthiMVC.ServiceReference1.Movie m);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete", ReplyAction="http://tempuri.org/IService1/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete", ReplyAction="http://tempuri.org/IService1/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebApp_OnthiMVC.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebApp_OnthiMVC.ServiceReference1.IService1>, WebApp_OnthiMVC.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WebApp_OnthiMVC.ServiceReference1.CompositeType GetDataUsingDataContract(WebApp_OnthiMVC.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WebApp_OnthiMVC.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(WebApp_OnthiMVC.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public WebApp_OnthiMVC.ServiceReference1.Movie[] getAll() {
            return base.Channel.getAll();
        }
        
        public System.Threading.Tasks.Task<WebApp_OnthiMVC.ServiceReference1.Movie[]> getAllAsync() {
            return base.Channel.getAllAsync();
        }
        
        public WebApp_OnthiMVC.ServiceReference1.Movie[] Search(string Search1) {
            return base.Channel.Search(Search1);
        }
        
        public System.Threading.Tasks.Task<WebApp_OnthiMVC.ServiceReference1.Movie[]> SearchAsync(string Search) {
            return base.Channel.SearchAsync(Search);
        }
        
        public WebApp_OnthiMVC.ServiceReference1.Movie GetbyId(int id) {
            return base.Channel.GetbyId(id);
        }
        
        public System.Threading.Tasks.Task<WebApp_OnthiMVC.ServiceReference1.Movie> GetbyIdAsync(int id) {
            return base.Channel.GetbyIdAsync(id);
        }
        
        public void Add(WebApp_OnthiMVC.ServiceReference1.Movie m) {
            base.Channel.Add(m);
        }
        
        public System.Threading.Tasks.Task AddAsync(WebApp_OnthiMVC.ServiceReference1.Movie m) {
            return base.Channel.AddAsync(m);
        }
        
        public void Edit(WebApp_OnthiMVC.ServiceReference1.Movie m) {
            base.Channel.Edit(m);
        }
        
        public System.Threading.Tasks.Task EditAsync(WebApp_OnthiMVC.ServiceReference1.Movie m) {
            return base.Channel.EditAsync(m);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
    }
}
