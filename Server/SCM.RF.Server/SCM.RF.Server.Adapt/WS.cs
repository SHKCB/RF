using SCM.RF.Server.BizEntities.Sys;

namespace SCM.RF.Server.Adapt
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "IWebWarehouseServiceServiceSoapBinding", Namespace = "http://warehouse.cxf.kcb.com/")]
    public partial class IWebWarehouseServiceService : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private System.Threading.SendOrPostCallback uploadPickgoodsInfoOperationCompleted;

        private System.Threading.SendOrPostCallback loginoutOperationCompleted;

        private System.Threading.SendOrPostCallback getPickorderGoodsOperationCompleted;

        private System.Threading.SendOrPostCallback getClientAddtoshelfListOperationCompleted;

        private System.Threading.SendOrPostCallback wavePickFinishOperationCompleted;

        private System.Threading.SendOrPostCallback getShiftTaskOrderOperationCompleted;

        private System.Threading.SendOrPostCallback getStockGoodsListOperationCompleted;

        private System.Threading.SendOrPostCallback uploadAddToShellInfoOperationCompleted;

        private System.Threading.SendOrPostCallback confirmGoodsShiftOperationCompleted;

        private System.Threading.SendOrPostCallback getClientAddtoshelfListDetailOperationCompleted;

        private System.Threading.SendOrPostCallback getInstockOfCheckOperationCompleted;

        private System.Threading.SendOrPostCallback getGoodsOnStockListOperationCompleted;

        private System.Threading.SendOrPostCallback getInstockdOfCheckOperationCompleted;

        private System.Threading.SendOrPostCallback uploadInstockdOfCheckOperationCompleted;

        private System.Threading.SendOrPostCallback finishInstockOfCheckOperationCompleted;

        private System.Threading.SendOrPostCallback loginOperationCompleted;

        private bool useDefaultCredentialsSetExplicitly;

        /// <remarks/>
        public IWebWarehouseServiceService()
        {
            this.Url = SystemInstance.SystemEntityInstance.wsurl; //global::SCM.RF.Server.Adapt.Properties.Settings.Default.SCM_RF_Server_Adapt_WebService_IWebWarehouseServiceService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true))
            {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else
            {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        public new string Url
        {
            get
            {
                return base.Url;
            }
            set
            {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true)
                            && (this.useDefaultCredentialsSetExplicitly == false))
                            && (this.IsLocalFileSystemWebService(value) == false)))
                {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }

        public new bool UseDefaultCredentials
        {
            get
            {
                return base.UseDefaultCredentials;
            }
            set
            {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        /// <remarks/>
        public event uploadPickgoodsInfoCompletedEventHandler uploadPickgoodsInfoCompleted;

        /// <remarks/>
        public event loginoutCompletedEventHandler loginoutCompleted;

        /// <remarks/>
        public event getPickorderGoodsCompletedEventHandler getPickorderGoodsCompleted;

        /// <remarks/>
        public event getClientAddtoshelfListCompletedEventHandler getClientAddtoshelfListCompleted;

        /// <remarks/>
        public event wavePickFinishCompletedEventHandler wavePickFinishCompleted;

        /// <remarks/>
        public event getShiftTaskOrderCompletedEventHandler getShiftTaskOrderCompleted;

        /// <remarks/>
        public event getStockGoodsListCompletedEventHandler getStockGoodsListCompleted;

        /// <remarks/>
        public event uploadAddToShellInfoCompletedEventHandler uploadAddToShellInfoCompleted;

        /// <remarks/>
        public event confirmGoodsShiftCompletedEventHandler confirmGoodsShiftCompleted;

        /// <remarks/>
        public event getClientAddtoshelfListDetailCompletedEventHandler getClientAddtoshelfListDetailCompleted;

        /// <remarks/>
        public event getInstockOfCheckCompletedEventHandler getInstockOfCheckCompleted;

        /// <remarks/>
        public event getGoodsOnStockListCompletedEventHandler getGoodsOnStockListCompleted;

        /// <remarks/>
        public event getInstockdOfCheckCompletedEventHandler getInstockdOfCheckCompleted;

        /// <remarks/>
        public event uploadInstockdOfCheckCompletedEventHandler uploadInstockdOfCheckCompleted;

        /// <remarks/>
        public event finishInstockOfCheckCompletedEventHandler finishInstockOfCheckCompleted;

        /// <remarks/>
        public event loginCompletedEventHandler loginCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string uploadPickgoodsInfo([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("uploadPickgoodsInfo", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void uploadPickgoodsInfoAsync(string arg0)
        {
            this.uploadPickgoodsInfoAsync(arg0, null);
        }

        /// <remarks/>
        public void uploadPickgoodsInfoAsync(string arg0, object userState)
        {
            if ((this.uploadPickgoodsInfoOperationCompleted == null))
            {
                this.uploadPickgoodsInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnuploadPickgoodsInfoOperationCompleted);
            }
            this.InvokeAsync("uploadPickgoodsInfo", new object[] {
                        arg0}, this.uploadPickgoodsInfoOperationCompleted, userState);
        }

        private void OnuploadPickgoodsInfoOperationCompleted(object arg)
        {
            if ((this.uploadPickgoodsInfoCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.uploadPickgoodsInfoCompleted(this, new uploadPickgoodsInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string loginout([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("loginout", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void loginoutAsync(string arg0)
        {
            this.loginoutAsync(arg0, null);
        }

        /// <remarks/>
        public void loginoutAsync(string arg0, object userState)
        {
            if ((this.loginoutOperationCompleted == null))
            {
                this.loginoutOperationCompleted = new System.Threading.SendOrPostCallback(this.OnloginoutOperationCompleted);
            }
            this.InvokeAsync("loginout", new object[] {
                        arg0}, this.loginoutOperationCompleted, userState);
        }

        private void OnloginoutOperationCompleted(object arg)
        {
            if ((this.loginoutCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.loginoutCompleted(this, new loginoutCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string getPickorderGoods([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("getPickorderGoods", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void getPickorderGoodsAsync(string arg0)
        {
            this.getPickorderGoodsAsync(arg0, null);
        }

        /// <remarks/>
        public void getPickorderGoodsAsync(string arg0, object userState)
        {
            if ((this.getPickorderGoodsOperationCompleted == null))
            {
                this.getPickorderGoodsOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetPickorderGoodsOperationCompleted);
            }
            this.InvokeAsync("getPickorderGoods", new object[] {
                        arg0}, this.getPickorderGoodsOperationCompleted, userState);
        }

        private void OngetPickorderGoodsOperationCompleted(object arg)
        {
            if ((this.getPickorderGoodsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getPickorderGoodsCompleted(this, new getPickorderGoodsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string getClientAddtoshelfList([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("getClientAddtoshelfList", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void getClientAddtoshelfListAsync(string arg0)
        {
            this.getClientAddtoshelfListAsync(arg0, null);
        }

        /// <remarks/>
        public void getClientAddtoshelfListAsync(string arg0, object userState)
        {
            if ((this.getClientAddtoshelfListOperationCompleted == null))
            {
                this.getClientAddtoshelfListOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetClientAddtoshelfListOperationCompleted);
            }
            this.InvokeAsync("getClientAddtoshelfList", new object[] {
                        arg0}, this.getClientAddtoshelfListOperationCompleted, userState);
        }

        private void OngetClientAddtoshelfListOperationCompleted(object arg)
        {
            if ((this.getClientAddtoshelfListCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getClientAddtoshelfListCompleted(this, new getClientAddtoshelfListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string wavePickFinish([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("wavePickFinish", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void wavePickFinishAsync(string arg0)
        {
            this.wavePickFinishAsync(arg0, null);
        }

        /// <remarks/>
        public void wavePickFinishAsync(string arg0, object userState)
        {
            if ((this.wavePickFinishOperationCompleted == null))
            {
                this.wavePickFinishOperationCompleted = new System.Threading.SendOrPostCallback(this.OnwavePickFinishOperationCompleted);
            }
            this.InvokeAsync("wavePickFinish", new object[] {
                        arg0}, this.wavePickFinishOperationCompleted, userState);
        }

        private void OnwavePickFinishOperationCompleted(object arg)
        {
            if ((this.wavePickFinishCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.wavePickFinishCompleted(this, new wavePickFinishCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string getShiftTaskOrder([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("getShiftTaskOrder", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void getShiftTaskOrderAsync(string arg0)
        {
            this.getShiftTaskOrderAsync(arg0, null);
        }

        /// <remarks/>
        public void getShiftTaskOrderAsync(string arg0, object userState)
        {
            if ((this.getShiftTaskOrderOperationCompleted == null))
            {
                this.getShiftTaskOrderOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetShiftTaskOrderOperationCompleted);
            }
            this.InvokeAsync("getShiftTaskOrder", new object[] {
                        arg0}, this.getShiftTaskOrderOperationCompleted, userState);
        }

        private void OngetShiftTaskOrderOperationCompleted(object arg)
        {
            if ((this.getShiftTaskOrderCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getShiftTaskOrderCompleted(this, new getShiftTaskOrderCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string getStockGoodsList([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("getStockGoodsList", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void getStockGoodsListAsync(string arg0)
        {
            this.getStockGoodsListAsync(arg0, null);
        }

        /// <remarks/>
        public void getStockGoodsListAsync(string arg0, object userState)
        {
            if ((this.getStockGoodsListOperationCompleted == null))
            {
                this.getStockGoodsListOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetStockGoodsListOperationCompleted);
            }
            this.InvokeAsync("getStockGoodsList", new object[] {
                        arg0}, this.getStockGoodsListOperationCompleted, userState);
        }

        private void OngetStockGoodsListOperationCompleted(object arg)
        {
            if ((this.getStockGoodsListCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getStockGoodsListCompleted(this, new getStockGoodsListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string uploadAddToShellInfo([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("uploadAddToShellInfo", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void uploadAddToShellInfoAsync(string arg0)
        {
            this.uploadAddToShellInfoAsync(arg0, null);
        }

        /// <remarks/>
        public void uploadAddToShellInfoAsync(string arg0, object userState)
        {
            if ((this.uploadAddToShellInfoOperationCompleted == null))
            {
                this.uploadAddToShellInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnuploadAddToShellInfoOperationCompleted);
            }
            this.InvokeAsync("uploadAddToShellInfo", new object[] {
                        arg0}, this.uploadAddToShellInfoOperationCompleted, userState);
        }

        private void OnuploadAddToShellInfoOperationCompleted(object arg)
        {
            if ((this.uploadAddToShellInfoCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.uploadAddToShellInfoCompleted(this, new uploadAddToShellInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string confirmGoodsShift([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("confirmGoodsShift", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void confirmGoodsShiftAsync(string arg0)
        {
            this.confirmGoodsShiftAsync(arg0, null);
        }

        /// <remarks/>
        public void confirmGoodsShiftAsync(string arg0, object userState)
        {
            if ((this.confirmGoodsShiftOperationCompleted == null))
            {
                this.confirmGoodsShiftOperationCompleted = new System.Threading.SendOrPostCallback(this.OnconfirmGoodsShiftOperationCompleted);
            }
            this.InvokeAsync("confirmGoodsShift", new object[] {
                        arg0}, this.confirmGoodsShiftOperationCompleted, userState);
        }

        private void OnconfirmGoodsShiftOperationCompleted(object arg)
        {
            if ((this.confirmGoodsShiftCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.confirmGoodsShiftCompleted(this, new confirmGoodsShiftCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string getClientAddtoshelfListDetail([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("getClientAddtoshelfListDetail", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void getClientAddtoshelfListDetailAsync(string arg0)
        {
            this.getClientAddtoshelfListDetailAsync(arg0, null);
        }

        /// <remarks/>
        public void getClientAddtoshelfListDetailAsync(string arg0, object userState)
        {
            if ((this.getClientAddtoshelfListDetailOperationCompleted == null))
            {
                this.getClientAddtoshelfListDetailOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetClientAddtoshelfListDetailOperationCompleted);
            }
            this.InvokeAsync("getClientAddtoshelfListDetail", new object[] {
                        arg0}, this.getClientAddtoshelfListDetailOperationCompleted, userState);
        }

        private void OngetClientAddtoshelfListDetailOperationCompleted(object arg)
        {
            if ((this.getClientAddtoshelfListDetailCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getClientAddtoshelfListDetailCompleted(this, new getClientAddtoshelfListDetailCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string getInstockOfCheck([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("getInstockOfCheck", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void getInstockOfCheckAsync(string arg0)
        {
            this.getInstockOfCheckAsync(arg0, null);
        }

        /// <remarks/>
        public void getInstockOfCheckAsync(string arg0, object userState)
        {
            if ((this.getInstockOfCheckOperationCompleted == null))
            {
                this.getInstockOfCheckOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetInstockOfCheckOperationCompleted);
            }
            this.InvokeAsync("getInstockOfCheck", new object[] {
                        arg0}, this.getInstockOfCheckOperationCompleted, userState);
        }

        private void OngetInstockOfCheckOperationCompleted(object arg)
        {
            if ((this.getInstockOfCheckCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getInstockOfCheckCompleted(this, new getInstockOfCheckCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string getGoodsOnStockList([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("getGoodsOnStockList", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void getGoodsOnStockListAsync(string arg0)
        {
            this.getGoodsOnStockListAsync(arg0, null);
        }

        /// <remarks/>
        public void getGoodsOnStockListAsync(string arg0, object userState)
        {
            if ((this.getGoodsOnStockListOperationCompleted == null))
            {
                this.getGoodsOnStockListOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetGoodsOnStockListOperationCompleted);
            }
            this.InvokeAsync("getGoodsOnStockList", new object[] {
                        arg0}, this.getGoodsOnStockListOperationCompleted, userState);
        }

        private void OngetGoodsOnStockListOperationCompleted(object arg)
        {
            if ((this.getGoodsOnStockListCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getGoodsOnStockListCompleted(this, new getGoodsOnStockListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string getInstockdOfCheck([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("getInstockdOfCheck", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void getInstockdOfCheckAsync(string arg0)
        {
            this.getInstockdOfCheckAsync(arg0, null);
        }

        /// <remarks/>
        public void getInstockdOfCheckAsync(string arg0, object userState)
        {
            if ((this.getInstockdOfCheckOperationCompleted == null))
            {
                this.getInstockdOfCheckOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetInstockdOfCheckOperationCompleted);
            }
            this.InvokeAsync("getInstockdOfCheck", new object[] {
                        arg0}, this.getInstockdOfCheckOperationCompleted, userState);
        }

        private void OngetInstockdOfCheckOperationCompleted(object arg)
        {
            if ((this.getInstockdOfCheckCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getInstockdOfCheckCompleted(this, new getInstockdOfCheckCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string uploadInstockdOfCheck([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("uploadInstockdOfCheck", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void uploadInstockdOfCheckAsync(string arg0)
        {
            this.uploadInstockdOfCheckAsync(arg0, null);
        }

        /// <remarks/>
        public void uploadInstockdOfCheckAsync(string arg0, object userState)
        {
            if ((this.uploadInstockdOfCheckOperationCompleted == null))
            {
                this.uploadInstockdOfCheckOperationCompleted = new System.Threading.SendOrPostCallback(this.OnuploadInstockdOfCheckOperationCompleted);
            }
            this.InvokeAsync("uploadInstockdOfCheck", new object[] {
                        arg0}, this.uploadInstockdOfCheckOperationCompleted, userState);
        }

        private void OnuploadInstockdOfCheckOperationCompleted(object arg)
        {
            if ((this.uploadInstockdOfCheckCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.uploadInstockdOfCheckCompleted(this, new uploadInstockdOfCheckCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string finishInstockOfCheck([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("finishInstockOfCheck", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void finishInstockOfCheckAsync(string arg0)
        {
            this.finishInstockOfCheckAsync(arg0, null);
        }

        /// <remarks/>
        public void finishInstockOfCheckAsync(string arg0, object userState)
        {
            if ((this.finishInstockOfCheckOperationCompleted == null))
            {
                this.finishInstockOfCheckOperationCompleted = new System.Threading.SendOrPostCallback(this.OnfinishInstockOfCheckOperationCompleted);
            }
            this.InvokeAsync("finishInstockOfCheck", new object[] {
                        arg0}, this.finishInstockOfCheckOperationCompleted, userState);
        }

        private void OnfinishInstockOfCheckOperationCompleted(object arg)
        {
            if ((this.finishInstockOfCheckCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.finishInstockOfCheckCompleted(this, new finishInstockOfCheckCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string login([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("login", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void loginAsync(string arg0)
        {
            this.loginAsync(arg0, null);
        }

        /// <remarks/>
        public void loginAsync(string arg0, object userState)
        {
            if ((this.loginOperationCompleted == null))
            {
                this.loginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnloginOperationCompleted);
            }
            this.InvokeAsync("login", new object[] {
                        arg0}, this.loginOperationCompleted, userState);
        }

        private void OnloginOperationCompleted(object arg)
        {
            if ((this.loginCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.loginCompleted(this, new loginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }

        private bool IsLocalFileSystemWebService(string url)
        {
            if (((url == null)
                        || (url == string.Empty)))
            {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024)
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0)))
            {
                return true;
            }
            return false;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void uploadPickgoodsInfoCompletedEventHandler(object sender, uploadPickgoodsInfoCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class uploadPickgoodsInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal uploadPickgoodsInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void loginoutCompletedEventHandler(object sender, loginoutCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class loginoutCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal loginoutCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void getPickorderGoodsCompletedEventHandler(object sender, getPickorderGoodsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getPickorderGoodsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal getPickorderGoodsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void getClientAddtoshelfListCompletedEventHandler(object sender, getClientAddtoshelfListCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getClientAddtoshelfListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal getClientAddtoshelfListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void wavePickFinishCompletedEventHandler(object sender, wavePickFinishCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class wavePickFinishCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal wavePickFinishCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void getShiftTaskOrderCompletedEventHandler(object sender, getShiftTaskOrderCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getShiftTaskOrderCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal getShiftTaskOrderCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void getStockGoodsListCompletedEventHandler(object sender, getStockGoodsListCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getStockGoodsListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal getStockGoodsListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void uploadAddToShellInfoCompletedEventHandler(object sender, uploadAddToShellInfoCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class uploadAddToShellInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal uploadAddToShellInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void confirmGoodsShiftCompletedEventHandler(object sender, confirmGoodsShiftCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class confirmGoodsShiftCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal confirmGoodsShiftCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void getClientAddtoshelfListDetailCompletedEventHandler(object sender, getClientAddtoshelfListDetailCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getClientAddtoshelfListDetailCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal getClientAddtoshelfListDetailCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void getInstockOfCheckCompletedEventHandler(object sender, getInstockOfCheckCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getInstockOfCheckCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal getInstockOfCheckCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void getGoodsOnStockListCompletedEventHandler(object sender, getGoodsOnStockListCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getGoodsOnStockListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal getGoodsOnStockListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void getInstockdOfCheckCompletedEventHandler(object sender, getInstockdOfCheckCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getInstockdOfCheckCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal getInstockdOfCheckCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void uploadInstockdOfCheckCompletedEventHandler(object sender, uploadInstockdOfCheckCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class uploadInstockdOfCheckCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal uploadInstockdOfCheckCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void finishInstockOfCheckCompletedEventHandler(object sender, finishInstockOfCheckCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class finishInstockOfCheckCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal finishInstockOfCheckCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void loginCompletedEventHandler(object sender, loginCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class loginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal loginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}
