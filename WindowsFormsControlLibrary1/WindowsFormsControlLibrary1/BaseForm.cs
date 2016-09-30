using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class BaseForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private Color favoriteColor;
        protected String ChildShape;

        public EventHandler Accept;

        

        public BaseForm()
        {
            InitializeComponent();
        }


        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }
        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if(dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void OpenColorDialog(object sender, EventArgs e)
        {
            ColorDialog.Color = this.BackColor;
            ColorDialog.ShowDialog();
            favoriteColor = ColorDialog.Color;
            BackColor = favoriteColor;
            if (Accept != null) Accept(this, EventArgs.Empty);
        }

        private void CloseDialog(object sender, EventArgs e)
        {
            Close();
        }

        public Color FavoriteColor()
        {
            return favoriteColor;
        }
        public String Shape()
        {
            return ChildShape;
        }

        private void BaseForm_Activated(object sender, EventArgs e)
        {
            if (Accept != null) Accept(this, EventArgs.Empty);
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
