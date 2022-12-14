using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;


namespace GD.BBPH.CONTROL
{    
    public enum format_date
    {
        ddMMyyyy, MMddyyyy,
    }
    public partial class TEXTBOXDATE : ComboBox
    {        
        #region "Declarations"
        private format_date _setFormat;
        private MonCalendar cal = new MonCalendar();        
        private DateTime _Value;
        #endregion

        #region "Properties"   
        public DateTime Value
        {
            get
            {
                if (_setFormat == format_date.ddMMyyyy)
                {
                    if (string.IsNullOrEmpty(this.Text))
                    {
                        this.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
                    }
                    int day = int.Parse(this.Text.Split('/')[0].ToString());
                    int month = int.Parse(this.Text.Split('/')[1].ToString());
                    int year = int.Parse(this.Text.Split('/')[2].ToString());
                    _Value = new DateTime(year, month, day);                    
                }
                else
                {
                    if (string.IsNullOrEmpty(this.Text))
                    {
                        this.Text = DateTime.Today.Month.ToString() + "/" + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Year.ToString();
                    }
                    int day = int.Parse(this.Text.Split('/')[1].ToString());
                    int month = int.Parse(this.Text.Split('/')[0].ToString());
                    int year = int.Parse(this.Text.Split('/')[2].ToString());
                    _Value = new DateTime(year, month, day);                    
                }
                return _Value;
            }
            set 
            { 
                _Value = value;
                SetDateTime(value);
            }
        }
        public format_date SetFormat
        {
            get { return _setFormat; }
            set { _setFormat = value; }
        }
        #endregion

        #region "Constructor"
        public TEXTBOXDATE()
        {
            InitializeComponent();
            cal.Visible = false;
        }
        #region Declarations
        [DllImport("User32.dll")]
        public extern static IntPtr GetWindowDC(IntPtr hWnd);
        [DllImport("User32.dll")]
        public extern static int ReleaseDC(IntPtr hWnd, IntPtr hDC);
        [DllImport("user32")]
        private static extern bool HideCaret(IntPtr hWnd);        
        private int m_BorderWidth = 1;
        private int m_FixedSingleLineWidth = 1;
        private Color m_BorderColor = Color.Red;
        private Color m_FixedSingleLineColor = Color.CadetBlue;        
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
        private bool doRedraw = false;
        #endregion Declarations
        #endregion

        #region "Methods"
        public DateTime GetDateTime()
        {
            if (_setFormat == format_date.ddMMyyyy)
            {
                int day = int.Parse(this.Text.Split('/')[0].ToString());
                int month = int.Parse(this.Text.Split('/')[1].ToString());
                int year = int.Parse(this.Text.Split('/')[2].ToString());
                return new DateTime(year, month, day);
            }
            else
            {
                int day = int.Parse(this.Text.Split('/')[1].ToString());
                int month = int.Parse(this.Text.Split('/')[0].ToString());
                int year = int.Parse(this.Text.Split('/')[2].ToString());
                return new DateTime(year, month, day);
            }
        }
        public void SetDateTime(DateTime _datetime)
        {
            if (_setFormat == format_date.ddMMyyyy)
            {
                string day = _datetime.Day.ToString();
                string month = _datetime.Month.ToString();
                string year = _datetime.Year.ToString();
                this.Text = day + "/" + month + "/" + year;
                if (day.Length == 1)
                {
                    if (month.Length == 1)
                    {
                        day = "0" + day;
                        month = "0" + month;
                        this.Text = day + "/" + month + "/" + year;
                    }
                    else
                    {
                        day = "0" + day;
                        this.Text = day + "/" + month + "/" + year;
                    }
                }
                if (month.Length == 1)
                {
                    if (day.Length == 1)
                    {
                        day = "0" + day;
                        month = "0" + month;
                        this.Text = day + "/" + month + "/" + year;
                    }
                    else
                    {
                        month = "0" + month;
                        this.Text = day + "/" + month + "/" + year;
                    }
                }                
            }
            else
            {
                string day = _datetime.Day.ToString();
                string month = _datetime.Month.ToString();
                string year = _datetime.Year.ToString();
                this.Text = month + "/" + day + "/" + year;
                if (day.Length == 1)
                {
                    if (month.Length == 1)
                    {
                        day = "0" + day;
                        month = "0" + month;
                        this.Text = month + "/" + day + "/" + year;
                    }
                    else
                    {
                        day = "0" + day;
                        this.Text = month + "/" + day + "/" + year;
                    }
                }
                if (month.Length == 1)
                {
                    if (day.Length == 1)
                    {
                        day = "0" + day;
                        month = "0" + month;
                        this.Text = month + "/" + day + "/" + year;
                    }
                    else
                    {
                        month = "0" + month;
                        this.Text = month + "/" + day + "/" + year;
                    }
                }                
            }
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            // TODO: Add custom paint code here

            // Calling the base class OnPaint
            base.OnPaint(pe);
        }
        protected override void OnClick(EventArgs e)
        {

            string s = this.Text.Split('/')[2].ToString();
            if (s.Length != 2 && s.Length != 4)
            {
                this.Focus();
                SelectionStart = 6;
                SelectionLength = this.Text.Length;
            }
            if (_setFormat == format_date.ddMMyyyy)
            {
                string day = this.Text.Split('/')[0].ToString();
                string month = this.Text.Split('/')[1].ToString();
                string year = this.Text.Split('/')[2].ToString();
                #region ddMMyyy
                if (year.Length == 2 && int.Parse(year) > 50)
                {
                    string s1 = this.Text.Remove(6, year.Length);
                    this.Text = s1 + "19" + year;
                }
                if (year.Length == 2 && int.Parse(year) < 50)
                {
                    string s1 = this.Text.Remove(6, year.Length);
                    this.Text = s1 + "20" + year;
                }
                if (year.Length == 4 && int.Parse(year) > 9999)
                {
                    string s1 = this.Text.Remove(6, year.Length);
                    this.Text = s1 + "9999";
                }
                if (year.Length == 4 && int.Parse(year) < 1)
                {
                    string s1 = this.Text.Remove(6, year.Length);
                    this.Text = s1 + "0001";
                }
                if (day.ToString().Length == 1)
                {
                    if (month.ToString().Length == 1)
                    {
                        this.Text = "0" + day + "/0" + month + "/" + year;
                    }
                    else
                    {
                        this.Text = "0" + day + "/" + month + "/" + year;
                    }
                }
                if (month.ToString().Length == 1)
                {
                    if (day.ToString().Length == 1)
                    {
                        this.Text = "0" + day + "/0" + month + "/" + year;
                    }
                    else
                    {
                        this.Text = day + "/0" + month + "/" + year;
                    }
                }
                #endregion
            }
            else
            {
                string day = this.Text.Split('/')[1].ToString();
                string month = this.Text.Split('/')[0].ToString();
                string year = this.Text.Split('/')[2].ToString();
                #region MMddyyyy
                if (year.Length == 2 && int.Parse(year) > 50)
                {
                    this.Text = month + "/" + day + "/" + "19" + year;
                }
                if (year.Length == 2 && int.Parse(year) < 50)
                {
                    this.Text = month + "/" + day + "/" + "20" + year;
                }
                if (year.Length == 4 && int.Parse(year) > 9999)
                {
                    this.Text = month + "/" + day + "/" + "9999";
                }
                if (year.Length == 4 && int.Parse(year) < 1)
                {
                    this.Text = month + "/" + day + "/" + "0001";
                }
                if (day.ToString().Length == 1)
                {
                    if (month.ToString().Length == 1)
                    {
                        this.Text = "/0" + month + "0" + day + "/" + year;
                    }
                    else
                    {
                        this.Text = month + "/0" + day + "/" + year;
                    }
                }
                if (month.ToString().Length == 1)
                {
                    if (day.ToString().Length == 1)
                    {
                        this.Text = "0" + month + "/0" + day + "/" + year;
                    }
                    else
                    {
                        this.Text = "0" + month + "/" + day + "/" + year;
                    }
                }
                #endregion
            }
            if (this.SelectionStart < 3)
            {
                this.SelectionStart = 0;
                this.SelectionLength = 2;
            }
            if (this.SelectionStart < 6 && this.SelectionStart >= 3)
            {
                this.SelectionStart = 3;
                this.SelectionLength = 2;
            }
            if (this.SelectionStart > 5)
            {
                this.SelectionStart = 6;
                this.SelectionLength = 4;
            }
            base.OnClick(e);
        }
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message m, System.Windows.Forms.Keys k)
        {
            #region enter key
            if (m.Msg == 256 && k == System.Windows.Forms.Keys.Enter)
            {
                cal.Hide();
                if (_setFormat == format_date.ddMMyyyy)
                {
                    string day = this.Text.Split('/')[0].ToString();
                    string month = this.Text.Split('/')[1].ToString();
                    string year = this.Text.Split('/')[2].ToString();
                    if (int.Parse(year) == 0)
                    {
                        string s1 = this.Text.Remove(6, year.Length);                        
                        year = "0001";
                        this.Text = s1 + year;
                    }
                    if (year.Length == 1)
                    {
                        string s1 = this.Text.Remove(6, year.Length);
                        this.Text = s1 + "000" + year;
                    }
                    if (DateTime.DaysInMonth(int.Parse(year), int.Parse(month)) < int.Parse(day))
                    {
                        MessageBox.Show("Ngày tháng không đúng !\n Bạn hãy nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
                        this.Focus();
                    }
                }
                else
                {
                    string day = this.Text.Split('/')[1].ToString();
                    string month = this.Text.Split('/')[0].ToString();
                    string year = this.Text.Split('/')[2].ToString();
                    if (int.Parse(year) == 0)
                    {
                        string s1 = this.Text.Remove(6, year.Length);
                        this.Text = s1 + "0001";
                        year = "0001";
                    }
                    if (year.Length == 1)
                    {
                        string s1 = this.Text.Remove(6, year.Length);
                        this.Text = s1 + "000" + year;
                    }
                    if (DateTime.DaysInMonth(int.Parse(year), int.Parse(month)) < int.Parse(day))
                    {
                        MessageBox.Show("Ngày tháng không đúng !\n Bạn hãy nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Text = DateTime.Today.Month.ToString() + "/" + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Year.ToString();
                        this.Focus();
                    }
                }
                System.Windows.Forms.SendKeys.Send("\t");
                return true;
            }
            #endregion
            if (k == System.Windows.Forms.Keys.Back || k == System.Windows.Forms.Keys.Delete)
            { return true; }
            if (k == Keys.Up || k == Keys.Down || k == Keys.Left || k == Keys.Right)
            {
                if (_setFormat == format_date.ddMMyyyy)
                {
                    #region 3
                    if (this.SelectionStart < 3)
                    {
                        this.SelectionStart = 0;
                        this.SelectionLength = 2;
                        if (k == System.Windows.Forms.Keys.Left)
                        {
                            string s = this.Text.Substring(0, 2);
                            if (s.Contains("/"))
                            {
                                string s1 = s.Remove(1, 1);
                                if (int.Parse(s1) > 0)
                                {
                                    this.Text = "0" + s1 + "/" + this.Text.Remove(0, 2).ToString();
                                }
                                else
                                {
                                    this.Text = "01/" + this.Text.Remove(0, 2).ToString();
                                }
                            }
                            else if (int.Parse(s) == 0)
                            {
                                string s1 = this.Text.Remove(0, 2);
                                this.Text = "01" + s1;
                            }
                            System.Windows.Forms.SendKeys.Send("+{TAB}");
                        }
                        if (k == System.Windows.Forms.Keys.Right)
                        {
                            string s = this.Text.Substring(0, 2);
                            if (s.Contains("/"))
                            {
                                string s1 = s.Remove(1, 1);
                                if (int.Parse(s1) > 0)
                                {
                                    this.Text = "0" + s1 + "/" + this.Text.Remove(0, 2).ToString();
                                }
                                else
                                {
                                    this.Text = "01/" + this.Text.Remove(0, 2).ToString();
                                }
                            }
                            else if (int.Parse(s) == 0)
                            {
                                string s1 = this.Text.Remove(0, 2);
                                this.Text = "01" + s1;
                            }
                            this.SelectionStart = 3;
                            this.SelectionLength = 2;
                        }
                        if (k == System.Windows.Forms.Keys.Up)
                        {
                            string s = this.Text.Substring(0, 2);
                            if (s.Contains("/"))
                            {
                                string s1 = s.Remove(1, 1);
                                if (int.Parse(s1) > 0)
                                {
                                    s = "0" + s1;
                                    this.Text = "0" + s1 + "/" + this.Text.Remove(0, 2).ToString();
                                }
                                else
                                {
                                    s = "01";
                                    this.Text = "01/" + this.Text.Remove(0, 2).ToString();
                                }
                            }
                            else if (int.Parse(s) == 0)
                            {
                                s = "01";
                                string s1 = this.Text.Remove(0, 2);
                                this.Text = "01" + s1;
                            }
                            this.Text = this.Text.Remove(0, 2);
                            if (int.Parse(s) > 30)
                            {
                                s = "00";
                            }
                            int i = int.Parse(s) + 1;
                            if (i > 9)
                            {
                                this.Text = i.ToString() + this.Text;
                                this.SelectionStart = 0;
                                this.SelectionLength = 2;
                            }
                            if (i <= 9)
                            {
                                this.Text = "0" + i.ToString() + this.Text;
                                this.SelectionStart = 0;
                                this.SelectionLength = 2;
                            }
                        }
                        if (k == System.Windows.Forms.Keys.Down)
                        {
                            string s = this.Text.Substring(0, 2);
                            if (s.Contains("/"))
                            {
                                string s1 = s.Remove(1, 1);
                                if (int.Parse(s1) > 0)
                                {
                                    s = "0" + s1;
                                    this.Text = "0" + s1 + "/" + this.Text.Remove(0, 2).ToString();
                                }
                                else
                                {
                                    s = "01";
                                    this.Text = "01/" + this.Text.Remove(0, 2).ToString();
                                }
                            }
                            else if (int.Parse(s) == 0)
                            {
                                s = "01";
                                string s1 = this.Text.Remove(0, 2);
                                this.Text = "01" + s1;
                            }
                            if (int.Parse(s) == 1)
                            {
                                s = "32";
                            }
                            int i = int.Parse(s) - 1;
                            this.Text = this.Text.Remove(0, 2);
                            if (i > 9)
                            {
                                this.Text = i.ToString() + this.Text;
                                this.SelectionStart = 0;
                                this.SelectionLength = 2;
                            }
                            if (i <= 9)
                            {
                                this.Text = "0" + i.ToString() + this.Text;
                                this.SelectionStart = 0;
                                this.SelectionLength = 2;
                            }
                        }
                        return true;
                    }
                    #endregion
                    #region 3<.<6
                    if (this.SelectionStart < 6 && this.SelectionStart >= 3)
                    {
                        this.SelectionStart = 3;
                        this.SelectionLength = 2;
                        if (SelectionStart == 3)
                        {
                            string a1 = this.Text.Substring(0, 3);
                            string a3 = this.Text.Remove(0, 4);
                            string a2 = this.Text.Substring(3, 1);
                            if (int.Parse(a2) == 0)
                            {
                                a2 = "1";
                            }
                            if (this.Text.Substring(3, 2).Contains("/"))
                            {
                                if (k == Keys.Right)
                                {
                                    this.Text = a1 + "0" + a2 + a3;
                                }
                                if (k == Keys.Left)
                                {
                                    this.Text = a1 + "0" + a2 + a3;
                                }
                            }
                            else if (int.Parse(this.Text.Substring(3, 2)) == 0)
                            {
                                string a4 = a3.Remove(0, 1);
                                this.Text = a1 + "01" + a4;
                            }
                        }
                        if (k == System.Windows.Forms.Keys.Right)
                        {
                            this.SelectionStart = 6;
                            this.SelectionLength = 4;
                        }
                        if (k == System.Windows.Forms.Keys.Left)
                        {
                            this.SelectionStart = 0;
                            this.SelectionLength = 2;
                        }
                        string s = this.Text.Substring(this.SelectionStart, 2);
                        string s1 = this.Text.Substring(0, 2);
                        string s2 = this.Text.Split('/')[2].ToString();
                        if (k == System.Windows.Forms.Keys.Up)
                        {
                            this.Text = "";
                            if (s.Contains("/"))
                            {
                                string s3 = s.Remove(1, 1);
                                if (int.Parse(s3) > 0)
                                {
                                    this.Text = s1 + "/0" + s3 + "/" + s2;
                                }
                                else
                                {
                                    this.Text = s1 + "/01" + "/" + s2;
                                }
                            }
                            else if (int.Parse(s) == 0)
                            {
                                this.Text = s1 + "/01" + "/" + s2;
                            }
                            if (int.Parse(s) == 12)
                            {
                                s = "00";
                            }
                            int i = int.Parse(s) + 1;
                            if (i > 9)
                            {
                                this.Text = s1 + "/" + i.ToString() + "/" + s2;
                                this.SelectionStart = 3;
                                this.SelectionLength = 2;
                            }
                            if (i <= 9)
                            {
                                this.Text = this.Text = s1 + "/0" + i.ToString() + "/" + s2;
                                this.SelectionStart = 3;
                                this.SelectionLength = 2;
                            }
                        }
                        if (k == System.Windows.Forms.Keys.Down)
                        {
                            this.Text = "";
                            if (s.Contains("/"))
                            {
                                string s3 = s.Remove(1, 1);
                                if (int.Parse(s3) > 0)
                                {
                                    s = "0" + s3;
                                    this.Text = s1 + "/0" + s3 + "/" + s2;
                                }
                                else
                                {
                                    s = "01";
                                    this.Text = s1 + "/01" + "/" + s2;
                                }
                            }
                            else if (int.Parse(s) == 0)
                            {
                                s = "01";
                                this.Text = s1 + "/01" + "/" + s2;
                            }
                            if (int.Parse(s) == 1)
                            {
                                s = "13";
                            }
                            int i = int.Parse(s) - 1;
                            if (i > 9)
                            {
                                this.Text = this.Text = s1 + "/" + i.ToString() + "/" + s2;
                                this.SelectionStart = 3;
                                this.SelectionLength = 2;
                            }
                            if (i <= 9)
                            {
                                this.Text = this.Text = s1 + "/0" + i.ToString() + "/" + s2;
                                this.SelectionStart = 3;
                                this.SelectionLength = 2;
                            }
                        }
                        return true;
                    }
                    #endregion
                    #region > 5
                    if (this.SelectionStart > 5)
                    {
                        this.SelectionStart = 6;
                        this.SelectionLength = 4;
                        string s = this.Text.Remove(0, 6);
                        string s1 = this.Text.Substring(0, 2);
                        string s2 = this.Text.Substring(3, 2);
                        if (k == System.Windows.Forms.Keys.Right)
                        {
                            if (s.Length == 1)
                            {
                                string s3 = this.Text.Remove(6, s.Length);
                                this.Text = s3 + "000" + s;
                            }
                            if (s.Length == 3)
                            {
                                string s3 = this.Text.Remove(6, s.Length);
                                this.Text = s3 + "0" + s;
                            }
                            if (s.Length == 2 && int.Parse(s) > 50)
                            {
                                string s3 = this.Text.Remove(6, s.Length);
                                this.Text = s3 + "19" + s;
                            }
                            if (s.Length == 2 && int.Parse(s) < 50)
                            {
                                string s3 = this.Text.Remove(6, s.Length);
                                this.Text = s3 + "20" + s;
                            }
                            if (s.Length == 4 && int.Parse(s) > 9999)
                            {
                                string s3 = this.Text.Remove(6, s.Length);
                                this.Text = s3 + "9999";
                            }
                            if (s.Length == 4 && int.Parse(s) < 1)
                            {
                                string s3 = this.Text.Remove(6, s.Length);
                                this.Text = s3 + "0001";
                            }
                            System.Windows.Forms.SendKeys.Send("\t");
                        }
                        if (k == System.Windows.Forms.Keys.Left)
                        {
                            if (s.Length == 1)
                            {
                                string s3 = this.Text.Remove(6, s.Length);
                                this.Text = s3 + "000" + s;
                            }
                            if (s.Length == 3)
                            {
                                string s3 = this.Text.Remove(6, s.Length);
                                this.Text = s3 + "0" + s;
                            }
                            if (s.Length == 2 && int.Parse(s) > 50)
                            {
                                string s3 = this.Text.Remove(6, s.Length);
                                this.Text = s3 + "19" + s;
                            }
                            if (s.Length == 2 && int.Parse(s) < 50)
                            {
                                string s3 = this.Text.Remove(6, s.Length);
                                this.Text = s3 + "20" + s;
                            }
                            if (s.Length == 4 && int.Parse(s) > 9999)
                            {
                                string s3 = this.Text.Remove(6, s.Length);
                                this.Text = s3 + "9999";
                            }
                            if (s.Length == 4 && int.Parse(s) < 1)
                            {
                                string s3 = this.Text.Remove(6, s.Length);
                                this.Text = s3 + "0001";
                            }
                            this.SelectionStart = 3;
                            this.SelectionLength = 2;
                        }
                        if (k == System.Windows.Forms.Keys.Up)
                        {
                            this.Text = "";
                            if (int.Parse(s) == 9999)
                            {
                                s = "0000";
                            }
                            int i = int.Parse(s) + 1;
                            if (i.ToString().Length == 1)
                            {
                                this.Text = s1 + "/" + s2 + "/000" + i.ToString();
                            }
                            if (i.ToString().Length == 2)
                            {
                                this.Text = s1 + "/" + s2 + "/00" + i.ToString();
                            }
                            if (i.ToString().Length == 3)
                            {
                                this.Text = s1 + "/" + s2 + "/0" + i.ToString();
                            }
                            if (i.ToString().Length == 4)
                            {
                                this.Text = s1 + "/" + s2 + "/" + i.ToString();
                            }
                            this.SelectionStart = 6;
                            this.SelectionLength = 4;
                        }
                        if (k == System.Windows.Forms.Keys.Down)
                        {
                            this.Text = "";
                            if (int.Parse(s) == 1)
                            {
                                s = "10000";
                            }
                            int i = int.Parse(s) - 1;
                            if (i.ToString().Length == 1)
                            {
                                this.Text = s1 + "/" + s2 + "/000" + i.ToString();
                            }
                            if (i.ToString().Length == 2)
                            {
                                this.Text = s1 + "/" + s2 + "/00" + i.ToString();
                            }
                            if (i.ToString().Length == 3)
                            {
                                this.Text = s1 + "/" + s2 + "/0" + i.ToString();
                            }
                            if (i.ToString().Length == 4)
                            {
                                this.Text = s1 + "/" + s2 + "/" + i.ToString();
                            }
                            this.SelectionStart = 6;
                            this.SelectionLength = 4;
                        }
                        return true;
                    }
                    #endregion
                }
                else
                {
                    #region 3
                    if (this.SelectionStart < 3)
                    {
                        this.SelectionStart = 0;
                        this.SelectionLength = 2;
                        if (k == System.Windows.Forms.Keys.Left)
                        {
                            string s = this.Text.Substring(0, 2);
                            if (s.Contains("/"))
                            {
                                string s1 = s.Remove(1, 1);
                                if (int.Parse(s1) > 0)
                                {
                                    this.Text = "0" + s1 + "/" + this.Text.Remove(0, 2).ToString();
                                }
                                else
                                {
                                    this.Text = "01/" + this.Text.Remove(0, 2).ToString();
                                }
                            }
                            else if (int.Parse(s) == 0)
                            {
                                string s1 = this.Text.Remove(0, 2);
                                this.Text = "01" + s1;
                            }
                            System.Windows.Forms.SendKeys.Send("+{TAB}");
                        }
                        if (k == System.Windows.Forms.Keys.Right)
                        {
                            string s = this.Text.Substring(0, 2);
                            if (s.Contains("/"))
                            {
                                string s1 = s.Remove(1, 1);
                                if (int.Parse(s1) > 0)
                                {
                                    this.Text = "0" + s1 + "/" + this.Text.Remove(0, 2).ToString();
                                }
                                else
                                {
                                    this.Text = "01/" + this.Text.Remove(0, 2).ToString();
                                }
                            }
                            else if (int.Parse(s) == 0)
                            {
                                string s1 = this.Text.Remove(0, 2);
                                this.Text = "01" + s1;
                            }
                            this.SelectionStart = 3;
                            this.SelectionLength = 2;
                        }
                        if (k == System.Windows.Forms.Keys.Up)
                        {
                            string s = this.Text.Substring(0, 2);
                            if (s.Contains("/"))
                            {
                                string s1 = s.Remove(1, 1);
                                if (int.Parse(s1) > 0)
                                {
                                    s = "0" + s1;
                                    this.Text = "0" + s1 + "/" + this.Text.Remove(0, 2).ToString();
                                }
                                else
                                {
                                    s = "01";
                                    this.Text = "01/" + this.Text.Remove(0, 2).ToString();
                                }
                            }
                            else if (int.Parse(s) == 0)
                            {
                                s = "01";
                                string s1 = this.Text.Remove(0, 2);
                                this.Text = "01" + s1;
                            }
                            this.Text = this.Text.Remove(0, 2);
                            if (int.Parse(s) > 11)
                            {
                                s = "00";
                            }
                            int i = int.Parse(s) + 1;
                            if (i > 9)
                            {
                                this.Text = i.ToString() + this.Text;
                                this.SelectionStart = 0;
                                this.SelectionLength = 2;
                            }
                            if (i <= 9)
                            {
                                this.Text = "0" + i.ToString() + this.Text;
                                this.SelectionStart = 0;
                                this.SelectionLength = 2;
                            }
                        }
                        if (k == System.Windows.Forms.Keys.Down)
                        {
                            string s = this.Text.Substring(0, 2);                            
                            if (s.Contains("/"))
                            {
                                string s1 = s.Remove(1, 1);
                                if (int.Parse(s1) > 0)
                                {
                                    s = "0" + s1;
                                    this.Text = "0" + s1 + "/" + this.Text.Remove(0, 2).ToString();
                                }
                                else
                                {
                                    s = "01";
                                    this.Text = "01/" + this.Text.Remove(0, 2).ToString();
                                }
                            }
                            else if (int.Parse(s) == 0)
                            {
                                s = "01";
                                string s1 = this.Text.Remove(0, 2);
                                this.Text = "01" + s1;
                            }
                            if (int.Parse(s) == 1)
                            {
                                s = "13";
                            }
                            int i = int.Parse(s) - 1;
                            this.Text = this.Text.Remove(0, 2);
                            if (i > 9)
                            {
                                this.Text = i.ToString() + this.Text;
                                this.SelectionStart = 0;
                                this.SelectionLength = 2;
                            }
                            if (i <= 9)
                            {
                                this.Text = "0" + i.ToString() + this.Text;
                                this.SelectionStart = 0;
                                this.SelectionLength = 2;
                            }
                        }
                        return true;
                    }
                    #endregion
                    #region 3<.<6
                    if (this.SelectionStart < 6 && this.SelectionStart >= 3)
                    {
                        this.SelectionStart = 3;
                        this.SelectionLength = 2;
                        if (SelectionStart == 3)
                        {
                            string a1 = this.Text.Substring(0, 3);
                            string a3 = this.Text.Remove(0, 4);
                            string a2 = this.Text.Substring(3, 1);
                            if (int.Parse(a2) == 0)
                            {
                                a2 = "1";
                            }
                            if (this.Text.Substring(3, 2).Contains("/"))
                            {
                                if (k == Keys.Right)
                                {
                                    this.Text = a1 + "0" + a2 + a3;
                                }
                                if (k == Keys.Left)
                                {
                                    this.Text = a1 + "0" + a2 + a3;
                                }
                            }
                            else if (int.Parse(this.Text.Substring(3, 2)) == 0)
                            {
                                string a4 = a3.Remove(0, 1);
                                this.Text = a1 + "01" + a4;
                            }
                        }
                        if (k == System.Windows.Forms.Keys.Right)
                        {
                            this.SelectionStart = 6;
                            this.SelectionLength = 4;
                        }
                        if (k == System.Windows.Forms.Keys.Left)
                        {
                            this.SelectionStart = 0;
                            this.SelectionLength = 2;
                        }
                        string s = this.Text.Substring(this.SelectionStart, 2);
                        string s1 = this.Text.Substring(0, 2);
                        string s2 = this.Text.Split('/')[2].ToString();
                        if (k == System.Windows.Forms.Keys.Up)
                        {
                            this.Text = "";
                            if (s.Contains("/"))
                            {
                                string s3 = s.Remove(1, 1);
                                if (int.Parse(s3) > 0)
                                {
                                    s = "0" + s3;
                                    this.Text = s1 + "/0" + s3 + "/" + s2;
                                }
                                else
                                {
                                    s = "01";
                                    this.Text = s1 + "/01" + "/" + s2;
                                }
                            }
                            else if (int.Parse(s) == 0)
                            {
                                s = "01";
                                this.Text = s1 + "/01" + "/" + s2;
                            }
                            if (int.Parse(s) == 31)
                            {
                                s = "00";
                            }
                            int i = int.Parse(s) + 1;
                            if (i > 9)
                            {
                                this.Text = s1 + "/" + i.ToString() + "/" + s2;
                                this.SelectionStart = 3;
                                this.SelectionLength = 2;
                            }
                            if (i <= 9)
                            {
                                this.Text = this.Text = s1 + "/0" + i.ToString() + "/" + s2;
                                this.SelectionStart = 3;
                                this.SelectionLength = 2;
                            }
                        }
                        if (k == System.Windows.Forms.Keys.Down)
                        {
                            this.Text = "";
                            if (s.Contains("/"))
                            {
                                string s3 = s.Remove(1, 1);
                                if (int.Parse(s3) > 0)
                                {
                                    s = "0" + s3;
                                    this.Text = s1 + "/0" + s3 + "/" + s2;
                                }
                                else
                                {
                                    s = "01";
                                    this.Text = s1 + "/01" + "/" + s2;
                                }
                            }
                            else if (int.Parse(s) == 0)
                            {
                                s = "01";
                                this.Text = s1 + "/01" + "/" + s2;
                            }
                            if (int.Parse(s) == 1)
                            {
                                s = "32";
                            }
                            int i = int.Parse(s) - 1;
                            if (i > 9)
                            {
                                this.Text = this.Text = s1 + "/" + i.ToString() + "/" + s2;
                                this.SelectionStart = 3;
                                this.SelectionLength = 2;
                            }
                            if (i <= 9)
                            {
                                this.Text = this.Text = s1 + "/0" + i.ToString() + "/" + s2;
                                this.SelectionStart = 3;
                                this.SelectionLength = 2;
                            }
                        }
                        return true;
                    }
                    #endregion
                    #region > 5
                    if (this.SelectionStart > 5)
                    {
                        this.SelectionStart = 6;
                        this.SelectionLength = 4;
                        string s = this.Text.Remove(0, 6);
                        string s1 = this.Text.Substring(0, 2);
                        string s2 = this.Text.Substring(3, 2);
                        if (k == System.Windows.Forms.Keys.Right)
                        {
                            if (s.Length == 1)
                            {
                                string s3 = this.Text.Remove(6, s.Length);
                                this.Text = s3 + "000" + s;
                            }
                            if (s.Length == 3)
                            {
                                string s3 = this.Text.Remove(6, s.Length);
                                this.Text = s3 + "0" + s;
                            }
                            if (s.Length == 2 && int.Parse(s) > 50)
                            {
                                string s3 = this.Text.Remove(6, s.Length);
                                this.Text = s3 + "19" + s;
                            }
                            if (s.Length == 2 && int.Parse(s) < 50)
                            {
                                string s3 = this.Text.Remove(6, s.Length);
                                this.Text = s3 + "20" + s;
                            }
                            if (s.Length == 4 && int.Parse(s) > 9999)
                            {
                                string s3 = this.Text.Remove(6, s.Length);
                                this.Text = s3 + "9999";
                            }
                            if (s.Length == 4 && int.Parse(s) < 1)
                            {
                                string s3 = this.Text.Remove(6, s.Length);
                                this.Text = s3 + "0001";
                            }
                            System.Windows.Forms.SendKeys.Send("\t");
                        }
                        if (k == System.Windows.Forms.Keys.Left)
                        {
                            if (s.Length == 1)
                            {
                                string s3 = this.Text.Remove(6, s.Length);
                                this.Text = s3 + "000" + s;
                            }
                            if (s.Length == 3)
                            {
                                string s3 = this.Text.Remove(6, s.Length);
                                this.Text = s3 + "0" + s;
                            }
                            if (s.Length == 2 && int.Parse(s) > 50)
                            {
                                string s3 = this.Text.Remove(6, s.Length);
                                this.Text = s3 + "19" + s;
                            }
                            if (s.Length == 2 && int.Parse(s) < 50)
                            {
                                string s3 = this.Text.Remove(6, s.Length);
                                this.Text = s3 + "20" + s;
                            }
                            if (s.Length == 4 && int.Parse(s) > 9999)
                            {
                                string s3 = this.Text.Remove(6, s.Length);
                                this.Text = s3 + "9999";
                            }
                            if (s.Length == 4 && int.Parse(s) < 1)
                            {
                                string s3 = this.Text.Remove(6, s.Length);
                                this.Text = s3 + "0001";
                            }
                            this.SelectionStart = 3;
                            this.SelectionLength = 2;
                        }
                        if (k == System.Windows.Forms.Keys.Up)
                        {
                            this.Text = "";
                            if (int.Parse(s) == 2050)
                            {
                                s = "1989";
                            }
                            int i = int.Parse(s) + 1;
                            this.Text = s1 + "/" + s2 + "/" + i.ToString();
                            this.SelectionStart = 6;
                            this.SelectionLength = 4;
                        }
                        if (k == System.Windows.Forms.Keys.Down)
                        {
                            this.Text = "";
                            if (int.Parse(s) == 1990)
                            {
                                s = "2051";
                            }
                            int i = int.Parse(s) - 1;
                            this.Text = this.Text = s1 + "/" + s2 + "/" + i.ToString();
                            this.SelectionStart = 6;
                            this.SelectionLength = 4;
                        }
                        return true;
                    }
                    #endregion
                }
            }
            return base.ProcessCmdKey(ref m, k);
        }
        protected override void InitLayout()
        {
            base.InitLayout();
            SetDateTime(_Value);              
        }        
        #region MonthCalendar_Event
        private void Show_Month_Calendar()
        {
            if (!cal.Visible)
            {
                cal.DateSelected += new DateRangeEventHandler(cal_DateSelected);
                cal.DateChanged += new DateRangeEventHandler(cal_DateChanged);
                cal.LostFocus += new EventHandler(cal_LostFocus);
                cal.KeyDown += new KeyEventHandler(cal_KeyDown);                
                cal.Location = new Point(this.Bounds.X,
                   this.Bounds.Y + this.Bounds.Height);
                this.Parent.Controls.Add(cal);
                cal.BringToFront();
                cal.Refresh();
                cal.Show();
                cal.Focus();
            }
            else
            {
                cal.Visible = false;
            }
        }

        void cal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MonCalendar _cal = (MonCalendar)sender;
                SetDateTime(_cal.SelectionStart);
                this.Focus();
                _cal.Visible = false;
            }            
        }

        void cal_LostFocus(object sender, EventArgs e)
        {
            if (!this.Focused && !cal.Focused)
            {
                cal.Visible = false;
            }
        }

        public delegate void MonCalendar_Event(object sender, DateRangeEventArgs e);
        public event MonCalendar_Event DateSelected_Changed;

        void cal_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (DateSelected_Changed != null && sender!=null)
            {                
                DateSelected_Changed(sender, e);
            }
        }

        void cal_DateSelected(object sender, DateRangeEventArgs e)
        {            
            MonthCalendar _cal = (MonthCalendar)sender;            
            SetDateTime(_cal.SelectionStart);
            this.Focus();
            _cal.Visible = false;
        }
        #endregion
        protected override void OnTextChanged(EventArgs e)
        {            
            if (this.SelectionStart == 2)
            {
                if (int.Parse(this.Text.Split('/')[0]) == 0)
                {
                    this.Text = "01/" + this.Text.Split('/')[1] + "/" + this.Text.Split('/')[2];
                }
                SelectionStart = 3;
                SelectionLength = 2;
            }
            if (this.SelectionStart == 5)
            {
                if (int.Parse(this.Text.Split('/')[1]) == 0)
                {
                    this.Text = this.Text.Split('/')[0] + "/01/" + this.Text.Split('/')[2];
                }
                SelectionStart = 6;
                SelectionLength = 4;
            }
            base.OnTextChanged(e);
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            { e.Handled = true; }
            if (e.KeyChar.Equals((char)Keys.Back) || e.KeyChar.Equals((char)Keys.Delete))
            { e.Handled = true; }
            if (_setFormat == format_date.ddMMyyyy)
            {
                #region ddMMyyyy
                if (this.SelectionStart == 0)
                {
                    if (e.KeyChar >= (char)Keys.D4 || e.KeyChar >= (char)Keys.NumPad4)
                        e.Handled = true;
                }
                if (this.SelectionStart == 1)
                {
                    if (int.Parse(this.Text.Substring(0, 1)) == 3)
                    {
                        if (e.KeyChar > (char)Keys.D1 || e.KeyChar > (char)Keys.NumPad1)
                            e.Handled = true;
                    }
                }
                if (this.SelectionStart == 4)
                {
                    if (int.Parse(this.Text.Substring(3, 1)) == 1)
                    {
                        if (e.KeyChar > (char)Keys.D2 || e.KeyChar > (char)Keys.NumPad2)
                            e.Handled = true;
                    }
                    if (int.Parse(this.Text.Substring(3, 1)) > 1)
                    {
                        string s = this.Text.Substring(3, 1);
                        string s1 = this.Text.Substring(0, 2);
                        string s2 = this.Text.Substring(5, 4);
                        this.Text = this.Text = s1 + "/0" + s + "/" + s2;
                        SelectionStart = 6;
                        SelectionLength = 4;
                    }
                }
                if (this.SelectionStart == 10)
                {
                    e.Handled = true;
                }
                #endregion
            }
            else
            {
                #region MMddyyy
                if (this.SelectionStart == 3)
                {
                    if (e.KeyChar >= (char)Keys.D4 || e.KeyChar >= (char)Keys.NumPad4)
                        e.Handled = true;
                }
                if (this.SelectionStart == 4)
                {

                    if (int.Parse(this.Text.Substring(3, 1)) == 3)
                    {
                        if (e.KeyChar > (char)Keys.D1 || e.KeyChar > (char)Keys.NumPad1)
                            e.Handled = true;
                    }
                }
                if (this.SelectionStart == 1)
                {
                    if (int.Parse(this.Text.Substring(0, 1)) == 1)
                    {
                        if (e.KeyChar > (char)Keys.D2 || e.KeyChar > (char)Keys.NumPad2)
                            e.Handled = true;
                    }
                    if (int.Parse(this.Text.Substring(0, 1)) > 1)
                    {
                        string day = this.Text.Substring(3, 2);
                        string month = this.Text.Substring(0, 1);
                        string year = this.Text.Substring(5, 4);
                        this.Text = this.Text = "0" + month + "/" + day + "/" + year;
                        SelectionStart = 3;
                        SelectionLength = 2;
                    }
                }
                if (this.SelectionStart == 10)
                {
                    e.Handled = true;
                }
                #endregion
            }
            base.OnKeyPress(e);
        }
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            if (this.Text != "")
            {
                string s = this.Text.Split('/')[2].ToString();
                if (s.Length != 2 && s.Length != 4)
                {
                    this.Focus();
                    SelectionStart = 6;
                    SelectionLength = this.Text.Length;
                }
                if (_setFormat == format_date.ddMMyyyy)
                {
                    string day = this.Text.Split('/')[0].ToString();
                    string month = this.Text.Split('/')[1].ToString();
                    string year = this.Text.Split('/')[2].ToString();
                    #region ddMMyyy
                    if (int.Parse(year) == 0)
                    {
                        string s1 = this.Text.Remove(6, year.Length);
                        this.Text = s1 + "0001";
                    }
                    if (year.Length == 2 && int.Parse(year) > 50)
                    {
                        string s1 = this.Text.Remove(6, year.Length);
                        this.Text = s1 + "19" + year;
                    }
                    if (year.Length == 2 && int.Parse(year) < 50)
                    {
                        string s1 = this.Text.Remove(6, year.Length);
                        this.Text = s1 + "20" + year;
                    }
                    if (year.Length == 4 && int.Parse(year) > 9999)
                    {
                        string s1 = this.Text.Remove(6, year.Length);
                        this.Text = s1 + "9999";
                    }
                    if (year.Length == 4 && int.Parse(year) < 1)
                    {
                        string s1 = this.Text.Remove(6, year.Length);
                        this.Text = s1 + "0001";
                    }
                    if (day.ToString().Length == 1)
                    {
                        if (month.ToString().Length == 1)
                        {
                            this.Text = "0" + day + "/0" + month + "/" + year;
                        }
                        else
                        {
                            this.Text = "0" + day + "/" + month + "/" + year;
                        }
                    }
                    if (month.ToString().Length == 1)
                    {
                        if (day.ToString().Length == 1)
                        {
                            this.Text = "0" + day + "/0" + month + "/" + year;
                        }
                        else
                        {
                            this.Text = day + "/0" + month + "/" + year;
                        }
                    }
                    if (DateTime.DaysInMonth(int.Parse(year), int.Parse(month)) < int.Parse(day))
                    {
                        this.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
                        this.Focus();
                    }
                    #endregion
                }
                else
                {
                    string day = this.Text.Split('/')[1].ToString();
                    string month = this.Text.Split('/')[0].ToString();
                    string year = this.Text.Split('/')[2].ToString();
                    #region MMddyyyy
                    if (int.Parse(year) == 0)
                    {
                        string s1 = this.Text.Remove(6, year.Length);
                        this.Text = s1 + "0001";
                    }
                    if (year.Length == 2 && int.Parse(year) > 50)
                    {
                        this.Text = month + "/" + day + "/" + "19" + year;
                    }
                    if (year.Length == 2 && int.Parse(year) < 50)
                    {
                        this.Text = month + "/" + day + "/" + "20" + year;
                    }
                    if (year.Length == 4 && int.Parse(year) > 9999)
                    {
                        this.Text = month + "/" + day + "/" + "9999";
                    }
                    if (year.Length == 4 && int.Parse(year) < 1)
                    {
                        this.Text = month + "/" + day + "/" + "0001";
                    }
                    if (day.ToString().Length == 1)
                    {
                        if (month.ToString().Length == 1)
                        {
                            this.Text = "/0" + month + "0" + day + "/" + year;
                        }
                        else
                        {
                            this.Text = month + "/0" + day + "/" + year;
                        }
                    }
                    if (month.ToString().Length == 1)
                    {
                        if (day.ToString().Length == 1)
                        {
                            this.Text = "0" + month + "/0" + day + "/" + year;
                        }
                        else
                        {
                            this.Text = "0" + month + "/" + day + "/" + year;
                        }
                    }
                    //if (DateTime.DaysInMonth(int.Parse(year), int.Parse(month)) < int.Parse(day))
                    //{
                    //    this.Text = DateTime.Today.Month.ToString() + "/" + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Year.ToString();
                    //    this.Focus();
                    //}
                    #endregion
                }
                // Notify the text box to change the font to the banner font.
                if (this.Text.Length == 0 && IsSupported)
                {
                    SendMessage(this.Handle, WM_SETFONT, _bannerFont.ToHfont(), null);
                }
            }
          
        }
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e); 
            if (_setFormat == format_date.ddMMyyyy)
            {
                if (string.IsNullOrEmpty(this.Text))
                {                
                    this.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
                }                
                string day = this.Text.Split('/')[0].ToString();
                string month = this.Text.Split('/')[1].ToString();
                string year = this.Text.Split('/')[2].ToString();
                if (day.ToString().Length == 1)
                {
                    if (month.ToString().Length == 1)
                    {
                        this.Text = "0" + day + "/0" + month + "/" + year;
                    }
                    else
                    {
                        this.Text = "0" + day + "/" + month + "/" + year;
                    }
                }
                if (month.ToString().Length == 1)
                {
                    if (day.ToString().Length == 1)
                    {
                        this.Text = "0" + day + "/0" + month + "/" + year;
                    }
                    else
                    {
                        this.Text = day + "/0" + month + "/" + year;
                    }
                }                
            }
            else
            {
                if (string.IsNullOrEmpty(this.Text))
                {
                    this.Text = DateTime.Today.Month.ToString() + "/" + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Year.ToString();
                }                
                string day = this.Text.Split('/')[1].ToString();
                string month = this.Text.Split('/')[0].ToString();
                string year = this.Text.Split('/')[2].ToString();
                if (day.ToString().Length == 1)
                {
                    if (month.ToString().Length == 1)
                    {
                        this.Text = "0" + month + "/0" + day + "/" + year;
                    }
                    else
                    {
                        this.Text = month + "/0" + day + "/" + year;
                    }
                }
                if (month.ToString().Length == 1)
                {
                    if (day.ToString().Length == 1)
                    {
                        this.Text = "0" + month + "/0" + day + "/" + year;
                    }
                    else
                    {
                        this.Text = "0" + month + "/" + day + "/" + year;
                    }
                }                
            }            
            SelectionStart = 0;
            SelectionLength = 2;
            // Notify the text box to change the font back.
            if (IsSupported)
                SendMessage(this.Handle, WM_SETFONT, base.Font.ToHfont(), null);            
        }
        protected override void OnDropDown(EventArgs e)
        {            
            this.DropDownHeight = 1;
            this.DropDownWidth = 1;
            Show_Month_Calendar();            
            base.OnDropDown(e);
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
