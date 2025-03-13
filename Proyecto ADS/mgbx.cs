using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_ADS
{
    internal class mgbx : GroupBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            // Configurar la fuente y el pincel
            Font font = this.Font;
            Brush textBrush = new SolidBrush(this.ForeColor);

            // Medir el texto del título
            SizeF textSize = e.Graphics.MeasureString(this.Text, font);

            // Dibujar el título sin el borde
            e.Graphics.DrawString(this.Text, font, textBrush, 10, 0);
        }
    }
}
