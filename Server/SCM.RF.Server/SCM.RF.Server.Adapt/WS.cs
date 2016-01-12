using SCM.RF.Server.BizEntities.Sys;
namespace SCM.RF.Server.Adapt
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "IWebWarehouseServiceQYBServiceSoapBinding", Namespace = "http://warehouse.cxf.kcb.com/")]
    public partial class IWebWarehouseServiceQYBService : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private System.Threading.SendOrPostCallback getJhOutstockByIdOperationCompleted;

        private System.Threading.SendOrPostCallback receiveGoodsOperationCompleted;

        private System.Threading.SendOrPostCallback getSJGZRuleOperationCompleted;

        private System.Threading.SendOrPostCallback loginoutOperationCompleted;

        private System.Threading.SendOrPostCallback CheckBarocdeUnitOperationCompleted;

        private System.Threading.SendOrPostCallback saveMoveOperationCompleted;

        private System.Threading.SendOrPostCallback cancelReceiveOperationCompleted;

        private System.Threading.SendOrPostCallback getUnitOperationCompleted;

        private System.Threading.SendOrPostCallback cancelLocationOperationCompleted;

        private System.Threading.SendOrPostCallback confirmShelfTaskOperationCompleted;

        private System.Threading.SendOrPostCallback loginOperationCompleted;

        private System.Threading.SendOrPostCallback getTaskDByIdsOperationCompleted;

        private System.Threading.SendOrPostCallback getInstockreceOperationCompleted;

        private System.Threading.SendOrPostCallback getTaskdInfoOperationCompleted;

        private System.Threading.SendOrPostCallback checkSerialnumberOperationCompleted;

        private System.Threading.SendOrPostCallback getInstockDetailOperationCompleted;

        private System.Threading.SendOrPostCallback locationWhitemOperationCompleted;

        private System.Threading.SendOrPostCallback getTaskByIdOperationCompleted;

        private System.Threading.SendOrPostCallback completeTaskdOperationCompleted;

        private System.Threading.SendOrPostCallback checkInWhitemOperationCompleted;

        private System.Threading.SendOrPostCallback CheckReWhitemOperationCompleted;

        private System.Threading.SendOrPostCallback checkItemBarcodeOperationCompleted;

        private System.Threading.SendOrPostCallback getJhOutstockByDisOperationCompleted;

        private System.Threading.SendOrPostCallback updateInstockreceOperationCompleted;

        private System.Threading.SendOrPostCallback getStockinfoOperationCompleted;

        private System.Threading.SendOrPostCallback checkOutWhitemOperationCompleted;

        private bool useDefaultCredentialsSetExplicitly;

        /// <remarks/>
        public IWebWarehouseServiceQYBService()
        {
            this.Url = SystemInstance.SystemEntityInstance.wsurl; ;//global::SCM.RF.Server.Adapt.Properties.Settings.Default.SCM_RF_Server_Adapt_com_kucangbao_demo_IWebWarehouseServiceQYBService;
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
        public event getJhOutstockByIdCompletedEventHandler getJhOutstockByIdCompleted;

        /// <remarks/>
        public event receiveGoodsCompletedEventHandler receiveGoodsCompleted;

        /// <remarks/>
        public event getSJGZRuleCompletedEventHandler getSJGZRuleCompleted;

        /// <remarks/>
        public event loginoutCompletedEventHandler loginoutCompleted;

        /// <remarks/>
        public event CheckBarocdeUnitCompletedEventHandler CheckBarocdeUnitCompleted;

        /// <remarks/>
        public event saveMoveCompletedEventHandler saveMoveCompleted;

        /// <remarks/>
        public event cancelReceiveCompletedEventHandler cancelReceiveCompleted;

        /// <remarks/>
        public event getUnitCompletedEventHandler getUnitCompleted;

        /// <remarks/>
        public event cancelLocationCompletedEventHandler cancelLocationCompleted;

        /// <remarks/>
        public event confirmShelfTaskCompletedEventHandler confirmShelfTaskCompleted;

        /// <remarks/>
        public event loginCompletedEventHandler loginCompleted;

        /// <remarks/>
        public event getTaskDByIdsCompletedEventHandler getTaskDByIdsCompleted;

        /// <remarks/>
        public event getInstockreceCompletedEventHandler getInstockreceCompleted;

        /// <remarks/>
        public event getTaskdInfoCompletedEventHandler getTaskdInfoCompleted;

        /// <remarks/>
        public event checkSerialnumberCompletedEventHandler checkSerialnumberCompleted;

        /// <remarks/>
        public event getInstockDetailCompletedEventHandler getInstockDetailCompleted;

        /// <remarks/>
        public event locationWhitemCompletedEventHandler locationWhitemCompleted;

        /// <remarks/>
        public event getTaskByIdCompletedEventHandler getTaskByIdCompleted;

        /// <remarks/>
        public event completeTaskdCompletedEventHandler completeTaskdCompleted;

        /// <remarks/>
        public event checkInWhitemCompletedEventHandler checkInWhitemCompleted;

        /// <remarks/>
        public event CheckReWhitemCompletedEventHandler CheckReWhitemCompleted;

        /// <remarks/>
        public event checkItemBarcodeCompletedEventHandler checkItemBarcodeCompleted;

        /// <remarks/>
        public event getJhOutstockByDisCompletedEventHandler getJhOutstockByDisCompleted;

        /// <remarks/>
        public event updateInstockreceCompletedEventHandler updateInstockreceCompleted;

        /// <remarks/>
        public event getStockinfoCompletedEventHandler getStockinfoCompleted;

        /// <remarks/>
        public event checkOutWhitemCompletedEventHandler checkOutWhitemCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string getJhOutstockById([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("getJhOutstockById", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void getJhOutstockByIdAsync(string arg0)
        {
            this.getJhOutstockByIdAsync(arg0, null);
        }

        /// <remarks/>
        public void getJhOutstockByIdAsync(string arg0, object userState)
        {
            if ((this.getJhOutstockByIdOperationCompleted == null))
            {
                this.getJhOutstockByIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetJhOutstockByIdOperationCompleted);
            }
            this.InvokeAsync("getJhOutstockById", new object[] {
                        arg0}, this.getJhOutstockByIdOperationCompleted, userState);
        }

        private void OngetJhOutstockByIdOperationCompleted(object arg)
        {
            if ((this.getJhOutstockByIdCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getJhOutstockByIdCompleted(this, new getJhOutstockByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string receiveGoods([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("receiveGoods", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void receiveGoodsAsync(string arg0)
        {
            this.receiveGoodsAsync(arg0, null);
        }

        /// <remarks/>
        public void receiveGoodsAsync(string arg0, object userState)
        {
            if ((this.receiveGoodsOperationCompleted == null))
            {
                this.receiveGoodsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnreceiveGoodsOperationCompleted);
            }
            this.InvokeAsync("receiveGoods", new object[] {
                        arg0}, this.receiveGoodsOperationCompleted, userState);
        }

        private void OnreceiveGoodsOperationCompleted(object arg)
        {
            if ((this.receiveGoodsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.receiveGoodsCompleted(this, new receiveGoodsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string getSJGZRule([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("getSJGZRule", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void getSJGZRuleAsync(string arg0)
        {
            this.getSJGZRuleAsync(arg0, null);
        }

        /// <remarks/>
        public void getSJGZRuleAsync(string arg0, object userState)
        {
            if ((this.getSJGZRuleOperationCompleted == null))
            {
                this.getSJGZRuleOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetSJGZRuleOperationCompleted);
            }
            this.InvokeAsync("getSJGZRule", new object[] {
                        arg0}, this.getSJGZRuleOperationCompleted, userState);
        }

        private void OngetSJGZRuleOperationCompleted(object arg)
        {
            if ((this.getSJGZRuleCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getSJGZRuleCompleted(this, new getSJGZRuleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
        public string CheckBarocdeUnit([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("CheckBarocdeUnit", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void CheckBarocdeUnitAsync(string arg0)
        {
            this.CheckBarocdeUnitAsync(arg0, null);
        }

        /// <remarks/>
        public void CheckBarocdeUnitAsync(string arg0, object userState)
        {
            if ((this.CheckBarocdeUnitOperationCompleted == null))
            {
                this.CheckBarocdeUnitOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckBarocdeUnitOperationCompleted);
            }
            this.InvokeAsync("CheckBarocdeUnit", new object[] {
                        arg0}, this.CheckBarocdeUnitOperationCompleted, userState);
        }

        private void OnCheckBarocdeUnitOperationCompleted(object arg)
        {
            if ((this.CheckBarocdeUnitCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CheckBarocdeUnitCompleted(this, new CheckBarocdeUnitCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string saveMove([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("saveMove", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void saveMoveAsync(string arg0)
        {
            this.saveMoveAsync(arg0, null);
        }

        /// <remarks/>
        public void saveMoveAsync(string arg0, object userState)
        {
            if ((this.saveMoveOperationCompleted == null))
            {
                this.saveMoveOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsaveMoveOperationCompleted);
            }
            this.InvokeAsync("saveMove", new object[] {
                        arg0}, this.saveMoveOperationCompleted, userState);
        }

        private void OnsaveMoveOperationCompleted(object arg)
        {
            if ((this.saveMoveCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.saveMoveCompleted(this, new saveMoveCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cancelReceive([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("cancelReceive", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void cancelReceiveAsync(string arg0)
        {
            this.cancelReceiveAsync(arg0, null);
        }

        /// <remarks/>
        public void cancelReceiveAsync(string arg0, object userState)
        {
            if ((this.cancelReceiveOperationCompleted == null))
            {
                this.cancelReceiveOperationCompleted = new System.Threading.SendOrPostCallback(this.OncancelReceiveOperationCompleted);
            }
            this.InvokeAsync("cancelReceive", new object[] {
                        arg0}, this.cancelReceiveOperationCompleted, userState);
        }

        private void OncancelReceiveOperationCompleted(object arg)
        {
            if ((this.cancelReceiveCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.cancelReceiveCompleted(this, new cancelReceiveCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string getUnit([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("getUnit", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void getUnitAsync(string arg0)
        {
            this.getUnitAsync(arg0, null);
        }

        /// <remarks/>
        public void getUnitAsync(string arg0, object userState)
        {
            if ((this.getUnitOperationCompleted == null))
            {
                this.getUnitOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetUnitOperationCompleted);
            }
            this.InvokeAsync("getUnit", new object[] {
                        arg0}, this.getUnitOperationCompleted, userState);
        }

        private void OngetUnitOperationCompleted(object arg)
        {
            if ((this.getUnitCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getUnitCompleted(this, new getUnitCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cancelLocation([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("cancelLocation", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void cancelLocationAsync(string arg0)
        {
            this.cancelLocationAsync(arg0, null);
        }

        /// <remarks/>
        public void cancelLocationAsync(string arg0, object userState)
        {
            if ((this.cancelLocationOperationCompleted == null))
            {
                this.cancelLocationOperationCompleted = new System.Threading.SendOrPostCallback(this.OncancelLocationOperationCompleted);
            }
            this.InvokeAsync("cancelLocation", new object[] {
                        arg0}, this.cancelLocationOperationCompleted, userState);
        }

        private void OncancelLocationOperationCompleted(object arg)
        {
            if ((this.cancelLocationCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.cancelLocationCompleted(this, new cancelLocationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string confirmShelfTask([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("confirmShelfTask", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void confirmShelfTaskAsync(string arg0)
        {
            this.confirmShelfTaskAsync(arg0, null);
        }

        /// <remarks/>
        public void confirmShelfTaskAsync(string arg0, object userState)
        {
            if ((this.confirmShelfTaskOperationCompleted == null))
            {
                this.confirmShelfTaskOperationCompleted = new System.Threading.SendOrPostCallback(this.OnconfirmShelfTaskOperationCompleted);
            }
            this.InvokeAsync("confirmShelfTask", new object[] {
                        arg0}, this.confirmShelfTaskOperationCompleted, userState);
        }

        private void OnconfirmShelfTaskOperationCompleted(object arg)
        {
            if ((this.confirmShelfTaskCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.confirmShelfTaskCompleted(this, new confirmShelfTaskCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string getTaskDByIds([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("getTaskDByIds", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void getTaskDByIdsAsync(string arg0)
        {
            this.getTaskDByIdsAsync(arg0, null);
        }

        /// <remarks/>
        public void getTaskDByIdsAsync(string arg0, object userState)
        {
            if ((this.getTaskDByIdsOperationCompleted == null))
            {
                this.getTaskDByIdsOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetTaskDByIdsOperationCompleted);
            }
            this.InvokeAsync("getTaskDByIds", new object[] {
                        arg0}, this.getTaskDByIdsOperationCompleted, userState);
        }

        private void OngetTaskDByIdsOperationCompleted(object arg)
        {
            if ((this.getTaskDByIdsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getTaskDByIdsCompleted(this, new getTaskDByIdsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string getInstockrece([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("getInstockrece", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void getInstockreceAsync(string arg0)
        {
            this.getInstockreceAsync(arg0, null);
        }

        /// <remarks/>
        public void getInstockreceAsync(string arg0, object userState)
        {
            if ((this.getInstockreceOperationCompleted == null))
            {
                this.getInstockreceOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetInstockreceOperationCompleted);
            }
            this.InvokeAsync("getInstockrece", new object[] {
                        arg0}, this.getInstockreceOperationCompleted, userState);
        }

        private void OngetInstockreceOperationCompleted(object arg)
        {
            if ((this.getInstockreceCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getInstockreceCompleted(this, new getInstockreceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string getTaskdInfo([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("getTaskdInfo", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void getTaskdInfoAsync(string arg0)
        {
            this.getTaskdInfoAsync(arg0, null);
        }

        /// <remarks/>
        public void getTaskdInfoAsync(string arg0, object userState)
        {
            if ((this.getTaskdInfoOperationCompleted == null))
            {
                this.getTaskdInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetTaskdInfoOperationCompleted);
            }
            this.InvokeAsync("getTaskdInfo", new object[] {
                        arg0}, this.getTaskdInfoOperationCompleted, userState);
        }

        private void OngetTaskdInfoOperationCompleted(object arg)
        {
            if ((this.getTaskdInfoCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getTaskdInfoCompleted(this, new getTaskdInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string checkSerialnumber([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("checkSerialnumber", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void checkSerialnumberAsync(string arg0)
        {
            this.checkSerialnumberAsync(arg0, null);
        }

        /// <remarks/>
        public void checkSerialnumberAsync(string arg0, object userState)
        {
            if ((this.checkSerialnumberOperationCompleted == null))
            {
                this.checkSerialnumberOperationCompleted = new System.Threading.SendOrPostCallback(this.OncheckSerialnumberOperationCompleted);
            }
            this.InvokeAsync("checkSerialnumber", new object[] {
                        arg0}, this.checkSerialnumberOperationCompleted, userState);
        }

        private void OncheckSerialnumberOperationCompleted(object arg)
        {
            if ((this.checkSerialnumberCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.checkSerialnumberCompleted(this, new checkSerialnumberCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string getInstockDetail([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("getInstockDetail", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void getInstockDetailAsync(string arg0)
        {
            this.getInstockDetailAsync(arg0, null);
        }

        /// <remarks/>
        public void getInstockDetailAsync(string arg0, object userState)
        {
            if ((this.getInstockDetailOperationCompleted == null))
            {
                this.getInstockDetailOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetInstockDetailOperationCompleted);
            }
            this.InvokeAsync("getInstockDetail", new object[] {
                        arg0}, this.getInstockDetailOperationCompleted, userState);
        }

        private void OngetInstockDetailOperationCompleted(object arg)
        {
            if ((this.getInstockDetailCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getInstockDetailCompleted(this, new getInstockDetailCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string locationWhitem([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("locationWhitem", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void locationWhitemAsync(string arg0)
        {
            this.locationWhitemAsync(arg0, null);
        }

        /// <remarks/>
        public void locationWhitemAsync(string arg0, object userState)
        {
            if ((this.locationWhitemOperationCompleted == null))
            {
                this.locationWhitemOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlocationWhitemOperationCompleted);
            }
            this.InvokeAsync("locationWhitem", new object[] {
                        arg0}, this.locationWhitemOperationCompleted, userState);
        }

        private void OnlocationWhitemOperationCompleted(object arg)
        {
            if ((this.locationWhitemCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.locationWhitemCompleted(this, new locationWhitemCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string getTaskById([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("getTaskById", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void getTaskByIdAsync(string arg0)
        {
            this.getTaskByIdAsync(arg0, null);
        }

        /// <remarks/>
        public void getTaskByIdAsync(string arg0, object userState)
        {
            if ((this.getTaskByIdOperationCompleted == null))
            {
                this.getTaskByIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetTaskByIdOperationCompleted);
            }
            this.InvokeAsync("getTaskById", new object[] {
                        arg0}, this.getTaskByIdOperationCompleted, userState);
        }

        private void OngetTaskByIdOperationCompleted(object arg)
        {
            if ((this.getTaskByIdCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getTaskByIdCompleted(this, new getTaskByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string completeTaskd([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("completeTaskd", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void completeTaskdAsync(string arg0)
        {
            this.completeTaskdAsync(arg0, null);
        }

        /// <remarks/>
        public void completeTaskdAsync(string arg0, object userState)
        {
            if ((this.completeTaskdOperationCompleted == null))
            {
                this.completeTaskdOperationCompleted = new System.Threading.SendOrPostCallback(this.OncompleteTaskdOperationCompleted);
            }
            this.InvokeAsync("completeTaskd", new object[] {
                        arg0}, this.completeTaskdOperationCompleted, userState);
        }

        private void OncompleteTaskdOperationCompleted(object arg)
        {
            if ((this.completeTaskdCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.completeTaskdCompleted(this, new completeTaskdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string checkInWhitem([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("checkInWhitem", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void checkInWhitemAsync(string arg0)
        {
            this.checkInWhitemAsync(arg0, null);
        }

        /// <remarks/>
        public void checkInWhitemAsync(string arg0, object userState)
        {
            if ((this.checkInWhitemOperationCompleted == null))
            {
                this.checkInWhitemOperationCompleted = new System.Threading.SendOrPostCallback(this.OncheckInWhitemOperationCompleted);
            }
            this.InvokeAsync("checkInWhitem", new object[] {
                        arg0}, this.checkInWhitemOperationCompleted, userState);
        }

        private void OncheckInWhitemOperationCompleted(object arg)
        {
            if ((this.checkInWhitemCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.checkInWhitemCompleted(this, new checkInWhitemCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CheckReWhitem([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("CheckReWhitem", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void CheckReWhitemAsync(string arg0)
        {
            this.CheckReWhitemAsync(arg0, null);
        }

        /// <remarks/>
        public void CheckReWhitemAsync(string arg0, object userState)
        {
            if ((this.CheckReWhitemOperationCompleted == null))
            {
                this.CheckReWhitemOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckReWhitemOperationCompleted);
            }
            this.InvokeAsync("CheckReWhitem", new object[] {
                        arg0}, this.CheckReWhitemOperationCompleted, userState);
        }

        private void OnCheckReWhitemOperationCompleted(object arg)
        {
            if ((this.CheckReWhitemCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CheckReWhitemCompleted(this, new CheckReWhitemCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string checkItemBarcode([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("checkItemBarcode", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void checkItemBarcodeAsync(string arg0)
        {
            this.checkItemBarcodeAsync(arg0, null);
        }

        /// <remarks/>
        public void checkItemBarcodeAsync(string arg0, object userState)
        {
            if ((this.checkItemBarcodeOperationCompleted == null))
            {
                this.checkItemBarcodeOperationCompleted = new System.Threading.SendOrPostCallback(this.OncheckItemBarcodeOperationCompleted);
            }
            this.InvokeAsync("checkItemBarcode", new object[] {
                        arg0}, this.checkItemBarcodeOperationCompleted, userState);
        }

        private void OncheckItemBarcodeOperationCompleted(object arg)
        {
            if ((this.checkItemBarcodeCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.checkItemBarcodeCompleted(this, new checkItemBarcodeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string getJhOutstockByDis([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("getJhOutstockByDis", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void getJhOutstockByDisAsync(string arg0)
        {
            this.getJhOutstockByDisAsync(arg0, null);
        }

        /// <remarks/>
        public void getJhOutstockByDisAsync(string arg0, object userState)
        {
            if ((this.getJhOutstockByDisOperationCompleted == null))
            {
                this.getJhOutstockByDisOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetJhOutstockByDisOperationCompleted);
            }
            this.InvokeAsync("getJhOutstockByDis", new object[] {
                        arg0}, this.getJhOutstockByDisOperationCompleted, userState);
        }

        private void OngetJhOutstockByDisOperationCompleted(object arg)
        {
            if ((this.getJhOutstockByDisCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getJhOutstockByDisCompleted(this, new getJhOutstockByDisCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string updateInstockrece([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("updateInstockrece", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void updateInstockreceAsync(string arg0)
        {
            this.updateInstockreceAsync(arg0, null);
        }

        /// <remarks/>
        public void updateInstockreceAsync(string arg0, object userState)
        {
            if ((this.updateInstockreceOperationCompleted == null))
            {
                this.updateInstockreceOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdateInstockreceOperationCompleted);
            }
            this.InvokeAsync("updateInstockrece", new object[] {
                        arg0}, this.updateInstockreceOperationCompleted, userState);
        }

        private void OnupdateInstockreceOperationCompleted(object arg)
        {
            if ((this.updateInstockreceCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.updateInstockreceCompleted(this, new updateInstockreceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string getStockinfo([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("getStockinfo", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void getStockinfoAsync(string arg0)
        {
            this.getStockinfoAsync(arg0, null);
        }

        /// <remarks/>
        public void getStockinfoAsync(string arg0, object userState)
        {
            if ((this.getStockinfoOperationCompleted == null))
            {
                this.getStockinfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetStockinfoOperationCompleted);
            }
            this.InvokeAsync("getStockinfo", new object[] {
                        arg0}, this.getStockinfoOperationCompleted, userState);
        }

        private void OngetStockinfoOperationCompleted(object arg)
        {
            if ((this.getStockinfoCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getStockinfoCompleted(this, new getStockinfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://warehouse.cxf.kcb.com/", ResponseNamespace = "http://warehouse.cxf.kcb.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string checkOutWhitem([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0)
        {
            object[] results = this.Invoke("checkOutWhitem", new object[] {
                        arg0});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void checkOutWhitemAsync(string arg0)
        {
            this.checkOutWhitemAsync(arg0, null);
        }

        /// <remarks/>
        public void checkOutWhitemAsync(string arg0, object userState)
        {
            if ((this.checkOutWhitemOperationCompleted == null))
            {
                this.checkOutWhitemOperationCompleted = new System.Threading.SendOrPostCallback(this.OncheckOutWhitemOperationCompleted);
            }
            this.InvokeAsync("checkOutWhitem", new object[] {
                        arg0}, this.checkOutWhitemOperationCompleted, userState);
        }

        private void OncheckOutWhitemOperationCompleted(object arg)
        {
            if ((this.checkOutWhitemCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.checkOutWhitemCompleted(this, new checkOutWhitemCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void getJhOutstockByIdCompletedEventHandler(object sender, getJhOutstockByIdCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getJhOutstockByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal getJhOutstockByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    public delegate void receiveGoodsCompletedEventHandler(object sender, receiveGoodsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class receiveGoodsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal receiveGoodsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    public delegate void getSJGZRuleCompletedEventHandler(object sender, getSJGZRuleCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getSJGZRuleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal getSJGZRuleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    public delegate void CheckBarocdeUnitCompletedEventHandler(object sender, CheckBarocdeUnitCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckBarocdeUnitCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal CheckBarocdeUnitCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    public delegate void saveMoveCompletedEventHandler(object sender, saveMoveCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class saveMoveCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal saveMoveCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    public delegate void cancelReceiveCompletedEventHandler(object sender, cancelReceiveCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class cancelReceiveCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal cancelReceiveCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    public delegate void getUnitCompletedEventHandler(object sender, getUnitCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getUnitCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal getUnitCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    public delegate void cancelLocationCompletedEventHandler(object sender, cancelLocationCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class cancelLocationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal cancelLocationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    public delegate void confirmShelfTaskCompletedEventHandler(object sender, confirmShelfTaskCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class confirmShelfTaskCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal confirmShelfTaskCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void getTaskDByIdsCompletedEventHandler(object sender, getTaskDByIdsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getTaskDByIdsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal getTaskDByIdsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    public delegate void getInstockreceCompletedEventHandler(object sender, getInstockreceCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getInstockreceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal getInstockreceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    public delegate void getTaskdInfoCompletedEventHandler(object sender, getTaskdInfoCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getTaskdInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal getTaskdInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    public delegate void checkSerialnumberCompletedEventHandler(object sender, checkSerialnumberCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class checkSerialnumberCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal checkSerialnumberCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    public delegate void getInstockDetailCompletedEventHandler(object sender, getInstockDetailCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getInstockDetailCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal getInstockDetailCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    public delegate void locationWhitemCompletedEventHandler(object sender, locationWhitemCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class locationWhitemCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal locationWhitemCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    public delegate void getTaskByIdCompletedEventHandler(object sender, getTaskByIdCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getTaskByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal getTaskByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    public delegate void completeTaskdCompletedEventHandler(object sender, completeTaskdCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class completeTaskdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal completeTaskdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    public delegate void checkInWhitemCompletedEventHandler(object sender, checkInWhitemCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class checkInWhitemCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal checkInWhitemCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    public delegate void CheckReWhitemCompletedEventHandler(object sender, CheckReWhitemCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckReWhitemCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal CheckReWhitemCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    public delegate void checkItemBarcodeCompletedEventHandler(object sender, checkItemBarcodeCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class checkItemBarcodeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal checkItemBarcodeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    public delegate void getJhOutstockByDisCompletedEventHandler(object sender, getJhOutstockByDisCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getJhOutstockByDisCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal getJhOutstockByDisCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    public delegate void updateInstockreceCompletedEventHandler(object sender, updateInstockreceCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class updateInstockreceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal updateInstockreceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    public delegate void getStockinfoCompletedEventHandler(object sender, getStockinfoCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getStockinfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal getStockinfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    public delegate void checkOutWhitemCompletedEventHandler(object sender, checkOutWhitemCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class checkOutWhitemCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal checkOutWhitemCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
