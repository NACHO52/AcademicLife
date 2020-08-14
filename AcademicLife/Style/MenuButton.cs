using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AcademicLife.Style
{
    public class MenuButton : Control
    {
        private Color CurrentBackColor;
        private Color CurrentForeColor;
        private Color OnHoverBackColor
        {
            get
            {
                return ColorPalette.LightGreyGhost;
            }
            set
            {
                this.OnHoverBackColor = value;
                Invalidate();
            }
        }
        private Color OnHoverForeColor
        {
            get
            {
                return ColorPalette.GreenArrow;
            }
            set
            {
                this.OnHoverForeColor = value;
                Invalidate();
            }
        }



        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.FillRectangle(new SolidBrush(CurrentBackColor), 0, 0, Width, Height);
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(pevent.Graphics, Text, Font, new Point(Width + 3, Height / 2), ColorPalette.WhiteLetter, flags);
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            CurrentBackColor = OnHoverBackColor; 
            CurrentForeColor = OnHoverForeColor;
            Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            CurrentBackColor = BackColor;
            CurrentForeColor = ForeColor;
            Invalidate();
        }
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            CurrentBackColor = ColorPalette.LightGreyGhost;
            Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            CurrentBackColor = BackColor;
            Invalidate();
        }
    }
}
