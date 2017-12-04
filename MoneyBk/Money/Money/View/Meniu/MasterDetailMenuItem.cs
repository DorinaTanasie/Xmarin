using Money.View.DetailView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Money.View.Meniu
{

    public class MasterDetailMenuItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Color BackgroundColor { get; set; }
        public Type TargetType { get; set; }//the type is used for navigations purposes 
        public string IconSource { get; set; }

        public MasterDetailMenuItem(string Title, string Icon, Color color, Type target)//constructor is created to constract objects easy
        {
            this.Title = Title;
            this.IconSource = Icon;
            this.BackgroundColor = color;
            this.TargetType = target;
        }
        public MasterDetailMenuItem()
        {
            TargetType = typeof(InfoScreen1);
        }
    }
}