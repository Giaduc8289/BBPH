using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using GD.BBPH.BLL;
using GD.BBPH.DAL;
using GD.BBPH.DAL.EntityClasses;
using GD.BBPH.DAL.FactoryClasses;
using GD.BBPH.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using GD.BBPH.LIB;
using Janus.Data;
using Janus.Windows.GridEX;
using Janus.Windows.Common;
using GD.BBPH.APP.DANHMUC;

namespace GD.BBPH.APP.HETHONG
{
    public partial class FRM_ROLES_MENU : FRM_DMPARENT
    {
        private MenuroleManager _MenuroleManager = new MenuroleManager();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        //private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_ROLES = new DataTable();
        private BindingSource BS_ROLES = new BindingSource();
        private DataRow r_Insert = null;
        private GD.BBPH.CONTROL.JGridEX GRID_ROLES = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "";
        private string mnid;
        private TreeNode tlID;
        private TreeNode tlChild;
        private TreeNode tlChild1;
        private List<TreeNode> selectedNode;
        private void TEXTBOX_Only_Control(bool _isbool, GD.BBPH.CONTROL.TEXTBOX _Textbox)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(!_isbool, uiPanel1Container, new List<Control>(new Control[] { _Textbox }));
        }

        private void FORM_PROCESS()
        {
            using (System.Windows.Forms.Form f = new System.Windows.Forms.Form())
            using (PictureBox _PictureBox = new PictureBox())
            using (BackgroundWorker worker = new BackgroundWorker())
            {
                Image _image = Image.FromFile(LIB.PATH.BBPH_PATH + @"\IMG\waiting.xml");
                _PictureBox.Image = _image;
                _PictureBox.Width = _image.Width;
                _PictureBox.Height = _image.Height;
                worker.DoWork += delegate
                {
                    if (FUNCTION == "LOAD")
                    {
                        //TreeNode tn;
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_ROLES");
                        DT_ROLES = LIB.SESSION_START.DT_ROLE;


                    }
                };
                worker.RunWorkerCompleted += delegate
                {
                    f.Dispose();   // exit the modal dialog
                };
                f.Load += delegate
                {
                    worker.RunWorkerAsync();
                };
                Point a = new Point(10, 10);
                _PictureBox.Location = a;
                f.Controls.Add(_PictureBox);
                f.Text = "Chờ xử lý";
                f.ShowIcon = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.ShowInTaskbar = false;
                f.ControlBox = false;
                //f.BackColor = Color.Blue;
                f.MaximumSize = new System.Drawing.Size(_PictureBox.Width + 20, _PictureBox.Height + 20);
                f.MinimumSize = new System.Drawing.Size(_PictureBox.Width + 20, _PictureBox.Height + 20);
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog();
            };
        }
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            //  ErrorTrapper.ErrorHandler.HandleError(e.Exception);
        }
        public FRM_ROLES_MENU()
        {
            InitializeComponent();
            MenuroleManager _MenuroleManager = new MenuroleManager();
            DataTable dt111 = _MenuroleManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_ROLES.xml");
            // GD.BBPH.LIB.COMBO_COMM.SOURCE(false, cbb_NHOMQUYEN, txt_TENNHOMQUYEN, DT_ROLES, RolesFields.Rolesid.Name, RolesFields.Rolesname.Name);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_ROLES.xml", GRID_ROLES, uiPanel0Container);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_ROLES);
            BS_ROLES = new BindingSource();
            BS_ROLES.DataSource = Source_View;
            GRID_ROLES.DataSource = BS_ROLES;
            BS_ROLES.CurrentChanged += new EventHandler(BS_ROLES_CurrentChanged);
            BS_ROLES_CurrentChanged((new object()), (new EventArgs()));
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
        }

        void BS_ROLES_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_ROLES.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_ROLES.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[RolesFields.Rolesid.Name].ToString();
                    txt_MAHIEU.Text = _Rowview.Row[RolesFields.Rolesid.Name].ToString();
                    txt_TENHIEU.Text = _Rowview.Row[RolesFields.Rolesname.Name].ToString();
                    txt_TENRUTGON.Text = _Rowview.Row[RolesFields.Description.Name].ToString();
                    btn_LUULAI.Enabled = false;
                    TreeListRoles(MAHIEU_PK);
                }
                else { GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container)); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_ROLES_CurrentChanged"); }
        }

        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            try
            {
                MenuroleEntity _MenuroleEntity;
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                _MenuroleManager.DeleteByRolesid(MAHIEU_PK);
                string filterExpression = "";
                //  DataTable tab = new MenuroleManager().SelectByRolesidRDT(MAHIEU_PK);
                //foreach (TreeNode node in selectedNode)
                //{
                //    //filterExpression = "";
                //    //filterExpression = "[Menuid] ='" + node.Tag.ToString() + "'";
                //    //DataRow[] rows = tab.Select(filterExpression);
                //    //if (rows.Length > 0)
                //    //{ }
                //    //else
                //    //{
                //        _MenuroleEntity = new MenuroleEntity();
                //        _MenuroleEntity.Menuid = node.Tag.ToString();
                //        _MenuroleEntity.Rolesid = txt_MAHIEU.Text.Trim();
                //        _MenuroleManager.Insert(_MenuroleEntity);
                // //   }

                //}
                for (int i = 0; i < treeView1.Nodes.Count; i++)
                {

                    if (treeView1.Nodes[i].Checked == true)
                    {
                        _MenuroleEntity = new MenuroleEntity();
                        _MenuroleEntity.Menuid = treeView1.Nodes[i].Tag.ToString();
                        _MenuroleEntity.Rolesid = txt_MAHIEU.Text.Trim();
                        _MenuroleManager.Insert(_MenuroleEntity);
                    }
                    for (int j = 0; j < treeView1.Nodes[i].Nodes.Count; j++)
                    {
                        if (treeView1.Nodes[i].Nodes[j].Checked == true)
                        {
                            _MenuroleEntity = new MenuroleEntity();
                            _MenuroleEntity.Menuid = treeView1.Nodes[i].Nodes[j].Tag.ToString();
                            _MenuroleEntity.Rolesid = txt_MAHIEU.Text.Trim();
                            _MenuroleManager.Insert(_MenuroleEntity);
                        }
                        for (int k = 0; k < treeView1.Nodes[i].Nodes[j].Nodes.Count; k++)
                        {
                            if (treeView1.Nodes[i].Nodes[j].Nodes[k].Checked == true)
                            {
                                _MenuroleEntity = new MenuroleEntity();
                                _MenuroleEntity.Menuid = treeView1.Nodes[i].Nodes[j].Nodes[k].Tag.ToString();
                                _MenuroleEntity.Rolesid = txt_MAHIEU.Text.Trim();
                                _MenuroleManager.Insert(_MenuroleEntity);
                            }
                        }
                    }
                }


                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_ROLES.Enabled = true;
                btn_LUULAI.Enabled = false;
            }
            catch (Exception)
            {
                //  throw;
            }

        }

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            //GRID_ROLES.ColumnAutoResize = false;
            if (uiPanel0.Width > 820)
                GRID_ROLES.ColumnAutoResize = true;
            else
                GRID_ROLES.ColumnAutoResize = false;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_ROLES_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btn_LUULAI.Enabled)
            {
                DialogResult Dlog = MessageBox.Show("Dữ liệu đã được thay đổi! Bạn có muốn lưu lại không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (Dlog == DialogResult.Yes)
                {
                    btn_LUULAI_Click(new object(), new EventArgs());
                    return;
                }
                if (Dlog == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void FRM_ROLES_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //btn_LUULAI.Enabled = true;
        }

        // Updates all child tree nodes recursively.
        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            //TreeNode node = default(TreeNode);
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    // If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                    this.CheckAllChildNodes(node, nodeChecked);
                }
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }


        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            try
            {
                // The code only executes if the user caused the checked state to change.
                if (e.Node.Checked)
                {
                    if (selectedNode == null)
                    {
                        selectedNode = new List<TreeNode>();
                    }
                    selectedNode.Add(e.Node);
                }
                else
                {
                    if (selectedNode != null)
                        selectedNode.Remove(e.Node);
                }
                if (e.Action != TreeViewAction.Unknown)
                {
                    if (e.Node.Nodes.Count > 0)
                    {
                        this.CheckAllChildNodes(e.Node, e.Node.Checked);
                    }
                }
            }
            catch { }
            btn_LUULAI.Enabled = true;
        }

        public void TreeListRoles(string mahieu)
        {
            treeView1.Nodes.Clear();
            DataTable tabcheck = new MenuroleManager().SelectByRolesidRDT(mahieu);
            DataTable tab1 = new MenuManager().SelectByMenuparentRDT("").Select("Issudung='1'").CopyToDataTable();
            string filterExpression = "";
            string filterExpression1 = "";
            string filterExpression2 = "";
            foreach (DataRow dr in tab1.Rows)
            {
                tlID = new TreeNode();
                tlID.Text = dr["MenuName"].ToString();
                tlID.Tag = dr["MenuId"].ToString();
                if (tabcheck.Rows.Count > 0)
                {
                    filterExpression = "";
                    filterExpression = "[Menuid] ='" + dr["MenuId"].ToString() + "'";
                    DataRow[] rows = tabcheck.Select(filterExpression);
                    if (rows.Length > 0)
                    {
                        tlID.Checked = true;
                    }
                }
                treeView1.Nodes.Add(tlID);
                DataRow[] drArr1 = new MenuManager().SelectByMenuparentRDT(dr["Menuid"].ToString()).Select("Issudung='1'");
                DataTable tab2 = new DataTable();
                if (drArr1.Length > 0) tab2 = drArr1.CopyToDataTable();
                foreach (DataRow dr1 in tab2.Rows)
                {
                    if (dr1["MenuName"].Equals("Separator"))
                    { }
                    else
                    {
                        tlChild = new TreeNode();
                        tlChild.Text = dr1["MenuName"].ToString();
                        tlChild.Tag = dr1["MenuId"].ToString();
                        if (tabcheck.Rows.Count > 0)
                        {
                            filterExpression1 = "";
                            filterExpression1 = "[Menuid] ='" + dr1["MenuId"].ToString() + "'";
                            DataRow[] rows1 = tabcheck.Select(filterExpression1);
                            if (rows1.Length > 0)
                            {
                                tlChild.Checked = true;
                            }
                        }
                        tlID.Nodes.Add(tlChild);
                        DataRow[] drArr = new MenuManager().SelectByMenuparentRDT(dr1["Menuid"].ToString()).Select("Issudung='1'");
                        DataTable tab3 = new DataTable();
                        if (drArr.Length > 0) tab3 = drArr.CopyToDataTable();
                        foreach (DataRow dr2 in tab3.Rows)
                        {
                            if (dr2["MenuName"].Equals("Separator"))
                            { }
                            else
                            {
                                tlChild1 = new TreeNode();
                                tlChild1.Text = dr2["MenuName"].ToString();
                                tlChild1.Tag = dr2["MenuId"].ToString();
                                if (tabcheck.Rows.Count > 0)
                                {
                                    filterExpression2 = "";
                                    filterExpression2 = "[Menuid] ='" + dr2["MenuId"].ToString() + "'";
                                    DataRow[] rows2 = tabcheck.Select(filterExpression2);
                                    if (rows2.Length > 0)
                                    {
                                        tlChild1.Checked = true;
                                    }
                                }
                                tlChild.Nodes.Add(tlChild1);
                            }
                        }
                    }
                }
                tlID.Expand();
            }

        }

        private void treeView1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                // The code only executes if the user caused the checked state to change.
                if (e.Node.Checked)
                {
                    if (selectedNode == null)
                    {
                        selectedNode = new List<TreeNode>();
                    }
                    selectedNode.Add(e.Node);
                }
                else
                {
                    if (selectedNode != null)
                        selectedNode.Remove(e.Node);
                }
                if (e.Action != TreeViewAction.Unknown)
                {
                    if (e.Node.Nodes.Count > 0)
                    {
                        this.CheckAllChildNodes(e.Node, e.Node.Checked);
                    }
                }
            }
            catch { }
            btn_LUULAI.Enabled = true;
        }
    }
}
