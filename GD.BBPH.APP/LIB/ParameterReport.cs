using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using GD.BBPH.BLL;
using GD.BBPH.DAL.HelperClasses;

namespace GD.BBPH.APP.LIB
{
    public class ParameterReport
    {
         public static void ShowMessage_Error( string messge)
        {
            MessageBox.Show(messge, "Phần mềm BBPH 2020", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
