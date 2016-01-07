using System;
using SCM.RF.Client.BizEntities.HandOver;
using SCM.RF.Client.BizProcess.HandOver;
using SCM.RF.Client.Tool.Controls.Common;

namespace SCM.RF.Client.Tool.Controls.HandOver
{
    /// <summary>
    /// 目录
    /// </summary>
    public partial class UCHandOver1 : UCBasicControl
    {
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="rf"></param>
        public UCHandOver1(RF rf)
            : base(rf)
        {
            InitializeComponent();
        }

        #region 重载 override

        public override void Init()
        {
            base.SetTitle("交接方案");
        }

        public override void Proc(EnMessageType type)
        {
            if (type == EnMessageType.A)
            {
                this.btnCancel.Focus();
            }
            else if (type == EnMessageType.B)
            {
                base.Exit();
            }
        }

        #endregion

        #region PUBLIC FUNCTION

        public void LoadData()
        {
            this.listScheme.Items.Clear();

            SchemeViewEntity result = new SchemeBP().GetEntity(new SchemeViewEntity(), base.RemoteServer);

            if (result != null)
            {
                if (result.Success)
                {
                    LoadData(result);
                }
                else
                {
                    base.ShowMessage(result.Message, false, EnMessageType.A, false);
                }
            }
            else
            {
                base.ShowMessage("错误，重新登录！", false, EnMessageType.B, false);
            }
        }

        #endregion

        #region PRIVATE FUNCTION

        private void LoadData(SchemeViewEntity entity)
        {
            SchemeItemViewEntity[] array = entity.ItemList;

            //SchemeItemViewEntity itemEntity = new SchemeItemViewEntity();
            //itemEntity.SysNo = 0;
            //itemEntity.Name = "==请选择方案==";
            //this.listScheme.Items.Insert(0, itemEntity);

            //for (int i = 1; i <= array.Length; i++)
            //{
            //    SchemeItemViewEntity item = new SchemeItemViewEntity();
            //    item.SysNo = array[i - 1].SysNo;
            //    item.Name = array[i - 1].Name;
            //    this.listScheme.Items.Insert(i, item);
            //}

            this.listScheme.DataSource = array;
            this.listScheme.DisplayMember = "Name";
            this.listScheme.ValueMember = "SysNo";

            this.listScheme.SelectedIndex = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="old">old</param>
        private void LoadData(HOViewEntity entity, bool old)
        {
            HOViewEntity result = new HOBP().GetEntity(entity, base.RemoteServer);

            if (result != null)
            {
                if (result.Success)
                {
                    if (old)
                    {
                        //第二级页面
                        this.RF.ShowHandOver3(result);
                    }
                    else
                    {
                        //第二级页面
                        this.RF.ShowHandOver2(result);
                    }
                }
                else
                {
                    base.ShowMessage(result.Message, false, EnMessageType.A, false);
                }
            }
            else
            {
                base.ShowMessage("错误，重新登录！", false, EnMessageType.B, false);
            }
        }

        #endregion

        #region CLICK

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.btnCancel.Enabled = false;
            base.Cancel();
            this.btnCancel.Enabled = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SchemeItemViewEntity item = (SchemeItemViewEntity)this.listScheme.SelectedItem;

            if (item == null)
            {
                base.ShowMessage("请选择交接方案！", false, EnMessageType.A, false);

                return;
            }
            else
            {
                int schemesysno = item.SysNo;

                if (schemesysno > 0)
                {
                    HOViewEntity entity = new HOViewEntity();

                    entity.InUser = base.UserViewEntity.UserName;

                    entity.SchemeSysNo = schemesysno;

                    this.LoadData(entity, false);
                }
                else
                {
                    base.ShowMessage("请选择交接方案！", false, EnMessageType.A, false);

                    return;
                }
            }
        }

        private void btnOld_Click(object sender, EventArgs e)
        {
            SchemeItemViewEntity item = (SchemeItemViewEntity)this.listScheme.SelectedItem;

            if (item == null)
            {
                base.ShowMessage("请选择交接方案！", false, EnMessageType.A, false);

                return;
            }
            else
            {
                int schemesysno = item.SysNo;

                if (schemesysno > 0)
                {
                    HOViewEntity entity = new HOViewEntity();

                    entity.InUser = base.UserViewEntity.UserName;

                    entity.SchemeSysNo = schemesysno;

                    this.LoadData(entity, true);
                }
                else
                {
                    base.ShowMessage("请选择交接方案！", false, EnMessageType.A, false);

                    return;
                }
            }
        }

        #endregion

        #region 供快捷键调用 本级页面

        /// <summary>
        /// 退出快捷键
        /// </summary>
        public void HookExit()
        {
            btnCancel_Click(null, null);
        }

        public void HookStart()
        {
            btnStart_Click(null, null);
        }

        public void HookOld()
        {
            btnOld_Click(null, null);
        }

        #endregion
    }
}
