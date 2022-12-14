using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Collections;
using System.Globalization;
using NumberFormats = System.Globalization.CultureInfo;
namespace GD.BBPH.CONTROL
{
    public partial class TEXTBOXNUMBER : TextBox
    {

        #region "Declarations"
        private static bool _isKEYPRESS = false;
        public static string chuoithapphan = ",";
        public static string sperator = ".";
        public static string soambaocao = "-";
        private int giatrithapphan = 0;
        private string mRegularExpression="";
        private bool isSoNguyen = false;
        private string zero = "";
        public static string NUMBER_FORMAR = "#.##0";
        public static string NUMBER_FORMAR_PERCENT = "#.##0,0";
        #endregion
        #region "Properties"
        public string Zero 
        {
            get 
            {
                zero = "";
                for (int i = 0; i < giatrithapphan; i++)
                {
                    zero += "0";
                }
                return zero; 
            }            
        }
        public bool IsSoNguyen
        {
            get
            {
                return isSoNguyen;
            }
            set
            {
                isSoNguyen = value;
            }
        }
        public int Giatrithapphan
        {
            get
            {
                return giatrithapphan;
            }
            set
            {
                giatrithapphan = value;
            }
        }
        public string Regular_Expression
        {
            get
            {
                return mRegularExpression;
            }
            set
            {
                mRegularExpression = value;
            }
        }
        #endregion
        #region "Constructor"

        public TEXTBOXNUMBER()
        {
            InitializeComponent();
        }
        [DllImport("User32.dll")]
        public extern static IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("User32.dll")]
        public extern static int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("user32")]
        private static extern bool HideCaret(IntPtr hWnd);
        #region Declarations
        private int m_BorderWidth = 1;
        private int m_FixedSingleLineWidth = 1;
        private Color m_BorderColor = Color.Red;
        private Color m_FixedSingleLineColor = Color.CadetBlue;

        private bool doRedraw = false;
        private bool hideCaret = false;
        private bool first = true;
        private bool doPaint = false;

        #endregion Declarations
        private void PaintBorderRect(IntPtr hWnd, int width, Color color, object borderLineColor)
        {
            if (width == 0) return;                             // Without this test there may be artifacts

            IntPtr hDC = GetWindowDC(hWnd);
            using (Graphics g = Graphics.FromHdc(hDC))
            {
                using (Pen p = new Pen(color, width))
                {
                    p.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    // 2634 -- Start
                    // There is a bug when drawing a line of width 1 so we have to special case it and adjust
                    // the height and width down 1 to circumvent it:
                    int adjustment = (width == 1 ? 1 : 0);
                    g.DrawRectangle(p, new Rectangle(0, 0, Width - adjustment, Height - adjustment));
                    // 2634 -- End

                    // Draw the border line if a color is specified and there is room:
                    if (borderLineColor != null && width >= m_FixedSingleLineWidth && m_FixedSingleLineWidth > 0)   // 2635
                    {
                        p.Color = (Color)borderLineColor;
                        p.Width = m_FixedSingleLineWidth;
                        int offset = width - m_FixedSingleLineWidth;    // Overlay the inner border edge with the border line
                        // 2634 -- Start
                        // There is a bug when drawing a line of width 1 so we have to special case it and adjust
                        // the height and width down 1 to circumvent it:
                        adjustment = (m_FixedSingleLineWidth == 1 ? 1 : 0);
                        g.DrawRectangle(p, new Rectangle(offset, offset, Width - offset - offset - adjustment,
                                                         Height - offset - offset - adjustment));
                        // 2634 -- End
                    }
                }
            }
            ReleaseDC(hWnd, hDC);
        }
        #endregion
        #region "Methods"

        protected override void OnPaint(PaintEventArgs pe)
        {
            // TODO: Add custom paint code here

            // Calling the base class OnPaint
            base.OnPaint(pe);
        }
        // This method intercepts the Enter Key signal before the containing Form does
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message m, System.Windows.Forms.Keys k)
        {
            // detect the pushing of Enter Key
            if (m.Msg == 256 && k == System.Windows.Forms.Keys.Enter)
            {
                // Execute an alternative action: here we tabulate in order to focus on the next control in the formular
                System.Windows.Forms.SendKeys.Send("\t");
                // return true to stop any further interpretation of this key action                 
                return true;
            }
            else if (k == System.Windows.Forms.Keys.PageUp || k == System.Windows.Forms.Keys.Up)
            {
                // Execute an alternative action: here we tabulate in order to focus on the next control in the formular
                System.Windows.Forms.SendKeys.Send("+{TAB}");
                // return true to stop any further interpretation of this key action

                return true;
            }
            else if (k == System.Windows.Forms.Keys.PageDown || k == System.Windows.Forms.Keys.Down)
            {
                // Execute an alternative action: here we tabulate in order to focus on the next control in the formular
                System.Windows.Forms.SendKeys.Send("{TAB}");
                // return true to stop any further interpretation of this key action

                return true;
            }
            else if (k == (Keys)new KeysConverter().ConvertFromString("Ctrl+V"))
            {
                this.Text = Clipboard.GetDataObject().GetData(DataFormats.Text).ToString();
            }
            // if not pushing Enter Key, then process the signal as usual
            return base.ProcessCmdKey(ref m, k);
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!this.Enabled || this.ReadOnly) { base.OnKeyPress(e); return; }            
            _isKEYPRESS = true;
            if (SelectionStart == 0 && SelectionLength == this.Text.Length)
            {
                this.Text = "";                
            }
            if (isSoNguyen)
            {
                if (!Char.IsDigit(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                {
                    if (e.KeyChar.Equals('-'))
                    { e.Handled = false; }
                    else
                    { e.Handled = true; }
                }
                if (e.KeyChar.Equals((char)Keys.Back))
                {
                    e.Handled = false;
                }                
                if (e.KeyChar.Equals('-'))
                {
                    e.Handled = false;
                    this.SelectionStart = 0;
                    if (this.Text.Contains("-"))
                    {
                        this.Text = this.Text.Replace("-", "");
                        e.Handled = true;
                    }
                }
                else
                {
                    this.SelectionStart = this.Text.Length;
                }                
            }
            else
            {
                if ((!char.IsDigit(e.KeyChar)) && !Char.IsNumber(e.KeyChar))
                {
                    if (e.KeyChar.Equals('-'))
                    {
                        e.Handled = false;
                        if (e.KeyChar.Equals('-'))
                        {
                            this.SelectionStart = 0;
                        }
                        if (this.Text.Contains("-"))
                        {
                            this.Text = this.Text.Replace("-", "");
                            e.Handled = true;
                        }
                    }
                    else if (!this.Text.Contains(chuoithapphan) && e.KeyChar.ToString().Equals(chuoithapphan))
                    {
                        e.Handled = false;
                    }
                    else if (this.Text.Contains(chuoithapphan)&&e.KeyChar.ToString().Equals(chuoithapphan))
                    {
                        e.Handled = true;
                    }
                    else if (e.KeyChar.ToString().Equals(sperator)) { e.Handled = true; }
                    else { e.Handled = true; }
                }
                if (e.KeyChar.Equals((char)Keys.Back))
                {
                    e.Handled = false;
                }
            }
            base.OnKeyPress(e);
        }
        protected override void OnTextChanged(EventArgs e)
        {            
            if (this.Tag != null && this.Tag.ToString() == "0") return;
            String _text = "";
            if (!isSoNguyen)
            {
                if (this.Text.Equals("-0") || this.Text.Equals("-" + chuoithapphan) || this.Text.Equals(chuoithapphan))//this.Text.Equals("0") || 
                {
                    _text = "";
                    this.Text = _text;
                }
            }
            else 
            {
                if (this.Text.Equals("-0") || this.Text.Equals("-" + chuoithapphan) || this.Text.Equals(chuoithapphan)) //this.Text.Equals("0") || 
                {
                    _text = "";
                    this.Text = _text;
                }
            }
            string strText = "";
            string strTextLast = "";
            for (int i = 0; i < this.Text.Length; i++)
            {
                strText += this.Text.Substring(i, 1).ToString();
                if (this.Text.Substring(i, 1).ToString().Equals(chuoithapphan))
                {
                    strTextLast = this.Text.Substring(i, this.Text.Length - i);                    
                    break;
                }
            }
            if (sperator.Equals(" ") && !chuoithapphan.Equals(",")) 
            {
                if (strText.Contains(",")) { strText = strText.Replace(",", ""); }
                if (strText.Contains("'")) { strText = strText.Replace("'", ""); }
                if (strText.Contains("_")) { strText = strText.Replace("_", ""); }
            }
            if (sperator.Equals(","))
            {
                if (strText.Contains(" ")) { strText = strText.Replace(" ", ""); }
                if (strText.Contains("'")) { strText = strText.Replace("'", ""); }
                if (strText.Contains("_")) { strText = strText.Replace("_", ""); }
            }
            strText = strText.Replace(sperator, "");
            strText = strText.Replace(chuoithapphan, "");
            string str = "";
            String str1 = "";
            if (strText.Length > 3)
            {
                for (int i = strText.Length; i >= 0; i--)
                {
                    if (i >= 1)
                    {
                        str += strText.Substring(i - 1, 1);
                        if (str.Replace("" + sperator + "", "").ToString().Length % 3 == 0)
                        {
                            str = str + "" + sperator + "";
                        }
                    }
                }
                if (str.Contains("-") || str.Contains(chuoithapphan))
                {
                    string _str = str.Replace("-", "");
                    _str = _str.Replace(chuoithapphan, "");
                    if (_str.Replace("" + sperator + "", "").Length % 3 == 0)
                    {
                        str = str.Remove(str.Length - 2, 1);
                    }
                    else if (_str.Replace("" + sperator + "", "").Length % 3 == 2)
                    {
                        str = str.Remove(str.Length - 1, 1);
                    }
                }
                else
                {
                    if (str.Replace("" + sperator + "", "").Length % 3 == 0)
                    {
                        str = str.Remove(str.Length - 1, 1);
                    }
                }
                for (int j = str.Length; j >= 1; j--)
                {
                    if (j >= 1)
                    {
                        str1 += str.Substring(j - 1, 1);
                    }
                }
                this.Text = str1 + strTextLast;
                this.SelectionStart = this.Text.Length;
            }
            else
            {
                _text = this.Text;
                this.Text = _text.Replace("" + sperator + "", "");
                this.SelectionStart = this.Text.Length;
            }
            ////////////NEW
            if (!_isKEYPRESS)
            {
                if (this.Text.EndsWith(chuoithapphan)) { this.Text = this.Text.Remove(this.Text.Length - 1, 1); }
                if (this.Text.Contains(chuoithapphan))
                {
                    int sauthapphan = this.Text.Split(char.Parse(chuoithapphan))[1].Length;
                    if (giatrithapphan == 0)
                    {
                        try
                        {
                            int i = sauthapphan + 1;
                            this.Text = this.Text.Remove(this.Text.Length - i, i);
                        }
                        catch { }
                    }
                    else if (sauthapphan > giatrithapphan)
                    {
                        //string s = this.Text.Split(char.Parse(chuoithapphan))[1];
                        this.Text = this.Text.Remove(this.Text.Length - (sauthapphan - giatrithapphan), (sauthapphan - giatrithapphan));                        
                    }                    
                }
                else//(!this.Text.Contains(chuoithapphan))
                {
                    try
                    {
                        if (decimal.Parse(this.Text.Replace(sperator, "")) > 0)
                        {
                            if (giatrithapphan > 0)
                            {
                                this.Text = this.Text + chuoithapphan + this.Zero;
                            }
                        }
                    }
                    catch { }
                }
            }
            ///////////
            base.OnTextChanged(e);
        }
        public bool ValidateControl()
        {            
            string TextToValidate;
            Regex expression;

            try
            {
                TextToValidate = this.Text;
                expression = new Regex(Regular_Expression);
            }
            catch
            {
                return false;
            }

            // test text with expression
            if (expression.IsMatch(TextToValidate))
            {
                return true;
            }
            else
            {
                // no match
                return false;
            }
        }

        #endregion
        #region bannertext

        #region NativeMethods

        private const uint ECM_FIRST = 0x1500;
        private const uint EM_SETCUEBANNER = ECM_FIRST + 1;
        private const uint WM_SETFONT = 0x30;

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, UInt32 msg, IntPtr wParam, string lParam);
        public Color FixedSingleLineColor
        {
            get { return m_FixedSingleLineColor; }
            set
            {
                m_FixedSingleLineColor = value;
                Redraw();
            }
        }
        private void Redraw()
        {
            // Make sure there is no recursion while recreating the handle:
            if (!this.RecreatingHandle) doRedraw = true;        // doRedraw = !this.RecreatingHandle;

            #region DEBUG redrawCount++
#if DEBUG
            //redrawCount++;
            //Debug.WriteLine("****** Redraw()");
#endif
            #endregion DEBUG redrawCount++
        }
        #endregion

        private string _bannerText;
        private Font _bannerFont;

        /// <summary>
        /// The banner text associated with the control.
        /// </summary>
        [Description("The banner text associated with the control.")]
        [Category("Appearance")]
        public string BannerText
        {
            get { return _bannerText; }
            set
            {
                _bannerText = value;

                // If supported set the value as banner text.
                if (IsSupported)
                    SendMessage(this.Handle, EM_SETCUEBANNER, IntPtr.Zero, value);
            }
        }
        /// <summary>
        /// The banner font used to display the banner text in the control.
        /// </summary>
        [Description("The banner font used to display the banner text in the control.")]
        [Category("Appearance")]
        public Font BannerFont
        {
            get
            {
                if (_bannerFont == null && this.Parent != null)
                    return this.Parent.Font;

                return _bannerFont;
            }
            set { _bannerFont = value; }
        }

        #region Overridden Members        
        //protected override void OnLostFocus(EventArgs e)
        //{
        //    base.OnLostFocus(e);
        //    if (!isSoNguyen)
        //    {
        //        if (!this.ReadOnly)
        //        {
        //            try
        //            {
        //                if (decimal.Parse(this.Text.Replace(sperator, "")) == 0)
        //                {
        //                    this.Text = chuoithapphan + this.Zero;
        //                }
        //            }
        //            catch { this.Text = chuoithapphan + this.Zero; }
        //            try
        //            {
        //                if (decimal.Parse(this.Text.Replace(sperator, "")) > 0)
        //                {
        //                    for (int i = 0; i < this.Text.Length; i++)
        //                    {
        //                        if (this.Text.StartsWith("0"))
        //                        {
        //                            this.Text = this.Text.Remove(0, 1);
        //                        }
        //                        else { break; }
        //                    }
        //                }
        //            }
        //            catch { }
        //            if (this.Text.EndsWith(chuoithapphan) && giatrithapphan > 0)
        //            {
        //                this.Text = this.Text + this.Zero;//+chuoithapphan
        //            }
        //            else if (Text.EndsWith(chuoithapphan) && giatrithapphan <= 0)
        //            {
        //                this.Text = this.Text.Remove(this.Text.Length - 1, 1);
        //            }
        //            if (this.Text.Contains(chuoithapphan))
        //            {
        //                string phan_thapphan = this.Text.Split(char.Parse(chuoithapphan))[1];
        //                if (phan_thapphan.Length > giatrithapphan)
        //                {
        //                    this.Text = this.Text.Replace(this.Text.Split(char.Parse(chuoithapphan))[1], this.Text.Split(char.Parse(chuoithapphan))[1].Substring(0, giatrithapphan));
        //                }
        //                else if (phan_thapphan.Length < giatrithapphan)
        //                {
        //                    string o = "";
        //                    for (int i = 0; i < giatrithapphan - phan_thapphan.Length; i++)
        //                    {
        //                        o = o + "0";
        //                    }
        //                    this.Text = this.Text + o;
        //                }
        //            }
        //            if (!this.Text.Contains(chuoithapphan) && giatrithapphan > 0)
        //            {
        //                this.Text = this.Text + chuoithapphan + this.Zero;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        if (!this.ReadOnly)
        //        {
        //            try
        //            {
        //                if (decimal.Parse(this.Text.Replace(sperator, "")) == 0)
        //                {
        //                    this.Text = "0";
        //                }
        //            }
        //            catch { this.Text = "0"; }
        //            try
        //            {
        //                if (decimal.Parse(this.Text.Replace(sperator, "")) > 0)
        //                {
        //                    for (int i = 0; i < this.Text.Length; i++)
        //                    {
        //                        if (this.Text.StartsWith("0"))
        //                        {
        //                            this.Text = this.Text.Remove(0, 1);
        //                        }
        //                        else { break; }
        //                    }
        //                }
        //            }
        //            catch { }
        //        }
        //    }
        //    base.OnLostFocus(e);
        //    // Notify the text box to change the font to the banner font.
        //    if (this.Text.Length == 0 && IsSupported)
        //    {
        //        SendMessage(this.Handle, WM_SETFONT, _bannerFont.ToHfont(), null);
        //    }
        //    PaintBorderRect(this.Handle, m_BorderWidth, Color.LightSteelBlue,
        //           (BorderStyle == BorderStyle.FixedSingle) ? (object)FixedSingleLineColor : null);
        //}
        //protected override void OnLeave(EventArgs e)
        //{
        //    base.OnLeave(e);

        //    // Notify the text box to change the font back.
        //    if (IsSupported)
        //        SendMessage(this.Handle, WM_SETFONT, base.Font.ToHfont(), null);
        //    PaintBorderRect(this.Handle, m_BorderWidth, Color.LightSteelBlue,
        //           (BorderStyle == BorderStyle.FixedSingle) ? (object)FixedSingleLineColor : null);
        //}
        //protected override void OnMouseHover(EventArgs e)
        //{
        //    base.OnMouseHover(e);
        //    // Notify the text box to change the font to the banner font.
        //    PaintBorderRect(this.Handle, m_BorderWidth, Color.Red,
        //           (BorderStyle == BorderStyle.FixedSingle) ? (object)FixedSingleLineColor : null);
        //}
        //protected override void OnMouseLeave(EventArgs e)
        //{
        //    base.OnMouseLeave(e);
        //    // Notify the text box to change the font to the banner font.
        //    PaintBorderRect(this.Handle, m_BorderWidth, Color.LightBlue,
        //           (BorderStyle == BorderStyle.FixedSingle) ? (object)FixedSingleLineColor : null);
        //}
        /// <summary>
        /// Invoked each time the focus is gotten.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            if (!isSoNguyen)
            {
                if (!this.ReadOnly)
                {
                    if (this.Text.Equals(chuoithapphan + this.Zero))
                    {
                        this.Text = "";
                    }
                    else
                    {
                        try { if (decimal.Parse(this.Text.Replace(sperator, "")) <= 0) { this.Text = ""; } }
                        catch { this.Text = ""; }
                    }
                }
            }
            else
            {
                if (!this.ReadOnly)
                {
                    try { if (decimal.Parse(this.Text.Replace(sperator,"")) <= 0) { this.Text = ""; } }
                    catch { this.Text = ""; }
                }
            }
            // Notify the text box to change the font back.
            if (IsSupported)
                SendMessage(this.Handle, WM_SETFONT, base.Font.ToHfont(), null);
            PaintBorderRect(this.Handle, m_BorderWidth, Color.Red,
                   (BorderStyle == BorderStyle.FixedSingle) ? (object)FixedSingleLineColor : null);
        }


        #endregion

        /// <summary>
        /// Returns whether the OS supports banner texts. It is fine if the application
        /// runs on XP or higher.
        /// </summary>
        private bool IsSupported
        {
            get
            {
                Version v = Environment.OSVersion.Version;
                return ((v.Major == 5 && v.Minor == 1) || v.Major > 5);
            }
        }

        #endregion endbannertext
    }
}
