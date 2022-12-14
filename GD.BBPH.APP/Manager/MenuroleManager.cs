
/*
'===============================================================================
'  GD.BBPH.BL.MenuroleManager
'===============================================================================
*/

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using GD.BBPH.BLL;
using GD.BBPH.DAL;
using GD.BBPH.DAL.EntityClasses;
using GD.BBPH.DAL.FactoryClasses;
using GD.BBPH.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace GD.BBPH.BLL
{
    public class MenuroleManager : MenuroleManagerBase
    {
        /// <summary>
        /// Purpose: Class constructor.
        /// </summary>
        public MenuroleManager()
        {
            // Nothing for now.
        }

        public static string _CURRENTACTION = "";
        public static string _CURRENTFROMNAME = "";
        public static EntityCollection _CurrentCollection = null;
        public static MenuroleEntity Return_Current_Menurole(string FROMNAME)
        {
            if (_CurrentCollection == null || _CurrentCollection.Items.Count == 0) return null;
            for (int i = 0; i < _CurrentCollection.Items.Count; i++)
            {
                MenuroleEntity _MenuroleEntity = (MenuroleEntity)_CurrentCollection[i];
                return _MenuroleEntity;
            }
            return null;
        }
        public EntityCollection SelectBy_Rolesid_Madonvi(string Rolesid, string Madonvi)
        {
            EntityCollection _MenuroleCollection = new EntityCollection(new MenuroleEntityFactory());
            RelationPredicateBucket filter = new RelationPredicateBucket();
            IPredicateExpression _PredicateExpression = new PredicateExpression();
            _PredicateExpression.Add(MenuroleFields.Rolesid == Rolesid);
            filter.PredicateExpression.Add(_PredicateExpression);
            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchEntityCollection(_MenuroleCollection, filter, 0, null);
            }
            return _MenuroleCollection;
        }
        //Validate TextBox
        public static bool Validating_TextBox(params GD.BBPH.CONTROL.TEXTBOX[] listControl)
        {
            for (int i = 0; i < listControl.Length; i++)
            {
                if (listControl[i].GetType() == typeof(TextBox) || listControl[i].GetType().BaseType == typeof(TextBox))
                {
                    if (string.IsNullOrEmpty(listControl[i].Text))
                    {
                        MessageBox.Show("Dữ liệu không được trống !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        listControl[i].Focus();
                        return false;
                    }
                }
            }
            return true;
        }

        // them button IN
        public static void set_Enable_controls_TAM_THUC(string ACTION, MenuroleEntity _MenuroleEntity, ref GD.BBPH.CONTROL.BUTTON btn_THEMMOI, ref GD.BBPH.CONTROL.BUTTON btn_SUA, ref GD.BBPH.CONTROL.BUTTON btn_LUULAI_TAM, ref GD.BBPH.CONTROL.BUTTON btn_LUULAI_THUC, ref GD.BBPH.CONTROL.BUTTON btn_XOA, ref GD.BBPH.CONTROL.BUTTON btn_KHOIPHUC, ref GD.BBPH.CONTROL.SPLITBUTTON btn_IN)
        {
            btn_LUULAI_TAM.Visible = true; btn_LUULAI_TAM.Text = "&Lưu lại";
            btn_LUULAI_THUC.Visible = false;
            if (GD.BBPH.LIB.STATIC_PARAM.DUYETCHUNGTU_VALUE.ToString().Equals("1"))// sử dụng duyệt chứng từ kế toán
            {
                btn_LUULAI_TAM.Visible = true; btn_LUULAI_TAM.Text = "&Lưu tạm";
                btn_LUULAI_THUC.Visible = true; btn_LUULAI_THUC.Text = "Lư&u thực";
            }

            if (_MenuroleEntity == null && GD.BBPH.APP.LIB.USERS._RolesEntity.Rolesname.ToUpper().Equals(RolesManager.ROLE_ADMINISTRATOR) == false)
            {
                btn_THEMMOI.Enabled = btn_SUA.Enabled = btn_XOA.Enabled = btn_LUULAI_TAM.Enabled = btn_LUULAI_THUC.Enabled = false; return;
            }

            _CURRENTACTION = ACTION;
            if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD)
            {
                btn_IN.Enabled = true;
                btn_THEMMOI.Enabled = true;
                btn_SUA.Enabled = true;
                btn_XOA.Enabled = true;
                btn_LUULAI_TAM.Enabled = false;
                btn_KHOIPHUC.Enabled = false;
            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI)
            {
                btn_IN.Enabled = true;
                btn_THEMMOI.Enabled = false;
                btn_SUA.Enabled = false;
                btn_KHOIPHUC.Enabled = true;
                btn_XOA.Enabled = false;
                btn_LUULAI_TAM.Enabled = true;
            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT)
            {

                btn_IN.Enabled = true;
                btn_SUA.Enabled = true;
                btn_XOA.Enabled = true;
                btn_LUULAI_TAM.Enabled = true;
                btn_LUULAI_TAM.Enabled = false;
                btn_KHOIPHUC.Enabled = false;
                btn_THEMMOI.Enabled = true;
            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LUU_TAM)
            {
                btn_IN.Enabled = true;
                btn_SUA.Enabled = true;
                btn_XOA.Enabled = true;
                btn_THEMMOI.Enabled = true;
                btn_LUULAI_TAM.Enabled = false;
                btn_KHOIPHUC.Enabled = false;
                btn_LUULAI_THUC.Enabled = true;
            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LUU_THUC)
            {
                btn_IN.Enabled = true;
                btn_SUA.Enabled = false;
                btn_XOA.Enabled = false;
                btn_THEMMOI.Enabled = true;
                btn_LUULAI_TAM.Enabled = false;
                btn_KHOIPHUC.Enabled = false;
                btn_LUULAI_THUC.Enabled = false;
                DataTable Logtable = new DataTable("Logtable");

            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE)
            {
                btn_IN.Enabled = true;
                btn_SUA.Enabled = true;
                btn_XOA.Enabled = true;
                btn_LUULAI_TAM.Enabled = true;
                btn_LUULAI_TAM.Enabled = false;
                btn_KHOIPHUC.Enabled = false;
                DataTable Logtable = new DataTable("Logtable");
            }
        }

        public static void set_Enable_controls_TAM_THUC(DataRow R_INSERT, string ACTION, MenuroleEntity _MenuroleEntity, ref GD.BBPH.CONTROL.BUTTON btn_THEMMOI, ref GD.BBPH.CONTROL.BUTTON btn_SUA, ref GD.BBPH.CONTROL.BUTTON btn_LUULAI_TAM, ref GD.BBPH.CONTROL.BUTTON btn_LUULAI_THUC, ref GD.BBPH.CONTROL.BUTTON btn_XOA, ref GD.BBPH.CONTROL.BUTTON btn_KHOIPHUC, ref GD.BBPH.CONTROL.SPLITBUTTON btn_IN)
        {
            btn_LUULAI_TAM.Visible = true; btn_LUULAI_TAM.Text = "Lưu lại";
            btn_LUULAI_THUC.Visible = false;
            if (GD.BBPH.LIB.STATIC_PARAM.DUYETCHUNGTU_VALUE.ToString().Equals("1"))// sử dụng duyệt chứng từ kế toán
            {
                btn_LUULAI_TAM.Visible = true; btn_LUULAI_TAM.Text = "Lưu tạm";
                btn_LUULAI_THUC.Visible = true; btn_LUULAI_THUC.Text = "Lưu thực";
            }

            if (_MenuroleEntity == null && GD.BBPH.APP.LIB.USERS._RolesEntity.Rolesname.ToUpper().Equals(RolesManager.ROLE_ADMINISTRATOR) == false)
            {
                btn_THEMMOI.Enabled = btn_SUA.Enabled = btn_XOA.Enabled = btn_LUULAI_TAM.Enabled = btn_LUULAI_THUC.Enabled = false; return;
            }

            _CURRENTACTION = ACTION;
            if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD)
            {
                btn_IN.Enabled = true;
                btn_THEMMOI.Enabled = true;
                btn_SUA.Enabled = true;
                btn_XOA.Enabled = true;
                btn_LUULAI_TAM.Enabled = false;
                btn_KHOIPHUC.Enabled = false;
            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI)
            {
                btn_IN.Enabled = true;
                btn_THEMMOI.Enabled = false;
                btn_SUA.Enabled = false;
                btn_KHOIPHUC.Enabled = true;
                btn_XOA.Enabled = false;
                btn_LUULAI_TAM.Enabled = true;
            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT)
            {
                btn_IN.Enabled = true;
                btn_SUA.Enabled = true;
                btn_XOA.Enabled = true;
                btn_LUULAI_TAM.Enabled = true;
                btn_LUULAI_TAM.Enabled = false;
                btn_KHOIPHUC.Enabled = false;
                btn_THEMMOI.Enabled = true;
                DataTable Logtable = new DataTable("Logtable");
                if (R_INSERT != null)
                {
                    Logtable = R_INSERT.Table.Clone();
                    Logtable.ImportRow(R_INSERT);
                }
            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LUU_TAM)
            {
                btn_IN.Enabled = true;
                btn_SUA.Enabled = true;
                btn_XOA.Enabled = true;
                btn_THEMMOI.Enabled = true;
                btn_LUULAI_TAM.Enabled = false;
                btn_KHOIPHUC.Enabled = false;
                btn_LUULAI_THUC.Enabled = true;
            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LUU_THUC)
            {
                btn_IN.Enabled = true;
                btn_SUA.Enabled = false;
                btn_XOA.Enabled = false;
                btn_THEMMOI.Enabled = true;
                btn_LUULAI_TAM.Enabled = false;
                btn_KHOIPHUC.Enabled = false;
                btn_LUULAI_THUC.Enabled = false;
                DataTable Logtable = new DataTable("Logtable");
                if (R_INSERT != null)
                {
                    Logtable = R_INSERT.Table.Clone();
                    Logtable.ImportRow(R_INSERT);
                }

            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE)
            {
                btn_IN.Enabled = true;
                btn_SUA.Enabled = true;
                btn_XOA.Enabled = true;
                btn_LUULAI_TAM.Enabled = true;
                btn_LUULAI_TAM.Enabled = false;
                btn_KHOIPHUC.Enabled = false;
                DataTable Logtable = new DataTable("Logtable");
                if (R_INSERT != null)
                {
                    Logtable = R_INSERT.Table.Clone();
                    Logtable.ImportRow(R_INSERT);
                }
            }
            if (btn_LUULAI_THUC.Visible) { btn_IN.Enabled = btn_LUULAI_THUC.Enabled; }

        }

        public static void set_Enable_controls(DataRow R_INSERT, string ACTION, MenuroleEntity _MenuroleEntity, ref GD.BBPH.CONTROL.BUTTON btn_THEMMOI, ref GD.BBPH.CONTROL.BUTTON btn_SUA, ref GD.BBPH.CONTROL.BUTTON btn_LUULAI, ref GD.BBPH.CONTROL.BUTTON btn_XOA, ref GD.BBPH.CONTROL.BUTTON btn_KHOIPHUC, ref GD.BBPH.CONTROL.BUTTON btn_IN)
        {
            if (_MenuroleEntity == null)
            {
                btn_THEMMOI.Enabled = btn_SUA.Enabled = btn_XOA.Enabled = btn_LUULAI.Enabled = btn_IN.Enabled = false; return;
            }
            _CURRENTACTION = ACTION;
            if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD)
            {
                btn_IN.Enabled = true;
                btn_THEMMOI.Enabled = true;
                btn_SUA.Enabled = true;
                btn_XOA.Enabled = true;
                btn_LUULAI.Enabled = false;
                btn_KHOIPHUC.Enabled = false;
            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI)
            {
                btn_IN.Enabled = true;
                btn_THEMMOI.Enabled = false;
                btn_SUA.Enabled = false;
                btn_KHOIPHUC.Enabled = true;
                btn_XOA.Enabled = false;
                btn_LUULAI.Enabled = true;
            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT)
            {
                btn_IN.Enabled = true;
                btn_SUA.Enabled = true;
                btn_XOA.Enabled = true;
                btn_LUULAI.Enabled = true;
                btn_LUULAI.Enabled = false;
                btn_KHOIPHUC.Enabled = false;
                btn_THEMMOI.Enabled = true;
                DataTable Logtable = new DataTable("Logtable");
                if (R_INSERT != null)
                {
                    Logtable = R_INSERT.Table.Clone();
                    Logtable.ImportRow(R_INSERT);
                }
            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE)
            {
                btn_IN.Enabled = true;
                btn_SUA.Enabled = true;
                btn_XOA.Enabled = true;
                btn_LUULAI.Enabled = true;
                btn_THEMMOI.Enabled = true;
                btn_LUULAI.Enabled = false;
                btn_KHOIPHUC.Enabled = false;
                DataTable Logtable = new DataTable("Logtable");
                if (R_INSERT != null)
                {
                    Logtable = R_INSERT.Table.Clone();
                    Logtable.ImportRow(R_INSERT);
                }
            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE)
            {
                btn_IN.Enabled = true;
                btn_SUA.Enabled = true;
                btn_XOA.Enabled = true;
                btn_LUULAI.Enabled = true;
                btn_LUULAI.Enabled = false;
                btn_KHOIPHUC.Enabled = false;
                DataTable Logtable = new DataTable("Logtable");
                if (R_INSERT != null)
                {
                    Logtable = R_INSERT.Table.Clone();
                    Logtable.ImportRow(R_INSERT);
                }
            }
        }

        public static void set_Enable_controls(string ACTION, MenuroleEntity _MenuroleEntity, ref GD.BBPH.CONTROL.BUTTON btn_THEMMOI, ref GD.BBPH.CONTROL.BUTTON btn_SUA, ref GD.BBPH.CONTROL.BUTTON btn_LUULAI, ref GD.BBPH.CONTROL.BUTTON btn_XOA, ref GD.BBPH.CONTROL.BUTTON btn_KHOIPHUC, ref GD.BBPH.CONTROL.BUTTON btn_IN)
        {
            if (_MenuroleEntity == null)
            {
                btn_THEMMOI.Enabled = btn_SUA.Enabled = btn_XOA.Enabled = btn_LUULAI.Enabled = btn_IN.Enabled = false; return;
            }
            _CURRENTACTION = ACTION;
            if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD)
            {
                btn_THEMMOI.Enabled = true;
                btn_SUA.Enabled = true;
                btn_XOA.Enabled = true;
                btn_IN.Enabled = true;
                btn_KHOIPHUC.Enabled = false;
                btn_LUULAI.Enabled = false;
            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI)
            {
                btn_THEMMOI.Enabled = false;
                btn_SUA.Enabled = false;
                btn_XOA.Enabled = false;
                btn_IN.Enabled = true;
                btn_LUULAI.Enabled = true;
                btn_KHOIPHUC.Enabled = true;
            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT)
            {
                btn_IN.Enabled = true;
                btn_SUA.Enabled = true;
                btn_XOA.Enabled = true;
                btn_LUULAI.Enabled = true;
                btn_THEMMOI.Enabled = true;
                btn_KHOIPHUC.Enabled = false;
                btn_LUULAI.Enabled = false;
            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA)
            {
                btn_IN.Enabled = true;
                btn_SUA.Enabled = false;
                btn_THEMMOI.Enabled = false;
                btn_LUULAI.Enabled = true;
                btn_XOA.Enabled = false;
                btn_KHOIPHUC.Enabled = true;
                btn_LUULAI.Enabled = true;
            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE)
            {
                btn_IN.Enabled = true;
                btn_SUA.Enabled = true;
                btn_XOA.Enabled = true;
                btn_THEMMOI.Enabled = true;
                btn_LUULAI.Enabled = false;
                btn_KHOIPHUC.Enabled = false;
            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL)
            {
                btn_IN.Enabled = true;
                btn_THEMMOI.Enabled = true;
                btn_SUA.Enabled = true;
                btn_XOA.Enabled = true;
                btn_LUULAI.Enabled = false;
                btn_LUULAI.Enabled = false;
                btn_KHOIPHUC.Enabled = false;
            }
        }

        public static void set_Enable_controls(string ACTION, MenuroleEntity _MenuroleEntity, ref GD.BBPH.CONTROL.BUTTON btn_THEMMOI, ref GD.BBPH.CONTROL.BUTTON btn_SUA, ref GD.BBPH.CONTROL.BUTTON btn_LUULAI, ref GD.BBPH.CONTROL.BUTTON btn_XOA, ref GD.BBPH.CONTROL.BUTTON btn_KHOIPHUC)
        {

            //if (_MenuroleEntity == null && GD.BBPH.APP.LIB.USERS._RolesEntity.Rolesname.ToUpper().Equals(RolesManager.ROLE_ADMINISTRATOR) == false)
            //{
            //    btn_THEMMOI.Enabled = btn_SUA.Enabled = btn_XOA.Enabled = btn_LUULAI.Enabled = false; return;
            //}
            _CURRENTACTION = ACTION;
           


            if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD)
            {
                btn_THEMMOI.Enabled = true;
                btn_SUA.Enabled = true;
                btn_XOA.Enabled = true;
                btn_KHOIPHUC.Enabled = false;
                btn_LUULAI.Enabled = false;
                return;
            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI)
            {
                btn_THEMMOI.Enabled = false;
                btn_SUA.Enabled = false;
                btn_XOA.Enabled = false;
                btn_LUULAI.Enabled = true;
                btn_KHOIPHUC.Enabled = true;
                return;
            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT)
            {
                btn_SUA.Enabled = true;
                btn_XOA.Enabled = true;
                btn_LUULAI.Enabled = true;
                btn_THEMMOI.Enabled = true;
                btn_KHOIPHUC.Enabled = false;
                btn_LUULAI.Enabled = false;
                return;
            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA)
            {
                btn_SUA.Enabled = false;
                btn_THEMMOI.Enabled = false;
                btn_LUULAI.Enabled = true;
                btn_XOA.Enabled = false;
                btn_KHOIPHUC.Enabled = true;
                btn_LUULAI.Enabled = true;
                return;
            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE)
            {
                btn_SUA.Enabled = true;
                btn_XOA.Enabled = true;
                btn_THEMMOI.Enabled = true;
                btn_LUULAI.Enabled = false;
                btn_KHOIPHUC.Enabled = false;
                return;
            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL)
            {
                btn_THEMMOI.Enabled = true;
                btn_SUA.Enabled = true;
                btn_XOA.Enabled = true;
                btn_LUULAI.Enabled = false;
                btn_LUULAI.Enabled = false;
                btn_KHOIPHUC.Enabled = false;
                return;
            }
        }

        public static void set_Enable_controls(DataRow R_INSERT, string ACTION, MenuroleEntity _MenuroleEntity, ref GD.BBPH.CONTROL.BUTTON btn_THEMMOI, ref GD.BBPH.CONTROL.BUTTON btn_SUA, ref GD.BBPH.CONTROL.BUTTON btn_LUULAI, ref GD.BBPH.CONTROL.BUTTON btn_XOA, ref GD.BBPH.CONTROL.BUTTON btn_KHOIPHUC)
        {

            //if (_MenuroleEntity == null && GD.BBPH.APP.LIB.USERS._RolesEntity.Rolesname.ToUpper().Equals(RolesManager.ROLE_ADMINISTRATOR) == false)
            //{
            //    btn_THEMMOI.Enabled = btn_SUA.Enabled = btn_XOA.Enabled = btn_LUULAI.Enabled = false; return;
            //}
            _CURRENTACTION = ACTION;
            if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD)
            {
                btn_THEMMOI.Enabled = true;
                btn_SUA.Enabled = true;
                btn_XOA.Enabled = true;
                btn_LUULAI.Enabled = false;
                btn_KHOIPHUC.Enabled = false;
                return;
            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI)
            {
                btn_THEMMOI.Enabled = false;
                btn_SUA.Enabled = false;
                btn_KHOIPHUC.Enabled = true;
                btn_XOA.Enabled = false;
                btn_LUULAI.Enabled = true;
                return;
            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT)
            {
                btn_SUA.Enabled = true;
                btn_XOA.Enabled = true;
                btn_LUULAI.Enabled = true;
                btn_LUULAI.Enabled = false;
                btn_KHOIPHUC.Enabled = false;
                btn_THEMMOI.Enabled = true;
                DataTable Logtable = new DataTable("Logtable");
                if (R_INSERT != null)
                {
                    Logtable = R_INSERT.Table.Clone();
                    Logtable.ImportRow(R_INSERT);
                }
                return;
            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE)
            {
                btn_SUA.Enabled = true;
                btn_XOA.Enabled = true;
                btn_LUULAI.Enabled = true;
                btn_THEMMOI.Enabled = true;
                btn_LUULAI.Enabled = false;
                btn_KHOIPHUC.Enabled = false;
                DataTable Logtable = new DataTable("Logtable");
                if (R_INSERT != null)
                {
                    Logtable = R_INSERT.Table.Clone();
                    Logtable.ImportRow(R_INSERT);
                }
                return;
            }
            else if (_CURRENTACTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE)
            {
                btn_SUA.Enabled = true;
                btn_XOA.Enabled = true;
                btn_LUULAI.Enabled = true;
                btn_LUULAI.Enabled = false;
                btn_KHOIPHUC.Enabled = false;
                DataTable Logtable = new DataTable("Logtable");
                if (R_INSERT != null)
                {
                    Logtable = R_INSERT.Table.Clone();
                    Logtable.ImportRow(R_INSERT);
                }

                return;
            }
        }

        public static string ConvertDataTableToXML(DataTable dtData)
        {
            if (dtData == null || dtData.Rows.Count == 0) return "";
            DataSet dsData = new DataSet();
            StringBuilder sbSQL;
            StringWriter swSQL;
            string XMLformat;
            try
            {
                sbSQL = new StringBuilder();
                swSQL = new StringWriter(sbSQL);
                dsData.Merge(dtData, true, MissingSchemaAction.AddWithKey);
                dsData.Tables[0].TableName = "Logtable";
                foreach (DataColumn col in dsData.Tables[0].Columns)
                {
                    col.ColumnMapping = MappingType.Attribute;
                }
                dsData.WriteXml(swSQL, XmlWriteMode.WriteSchema);
                XMLformat = sbSQL.ToString();
                return XMLformat;
            }
            catch (Exception sysException)
            {
                throw sysException;
            }
        }

    }
}
