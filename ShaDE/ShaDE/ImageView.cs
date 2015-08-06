using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TakeOne.WindowSuite;

namespace ShaDE
{
    public partial class ImageView : ToolForm
    {
        public ImageView()
        {
            InitializeComponent();
        }
        public void SetImage(string Title, Bitmap ViewImage)
        {
            this.Text = Title;
            this.Title = Title;
            this.View.BackgroundImage = ViewImage;
        }
    }
}
