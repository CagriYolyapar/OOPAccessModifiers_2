using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPAccessModifiers_2.Models;

namespace IkinciProje
{

    //Eger bir Proje baska bir proje icerisindeki bir yapıyı kullanmak istiyorsa ilk önce o yapıyı barındıran projeyi referans almalıdır... Ama tabii ki sadece bu ilgili class'ı kullanmaya yetmez.Aynı zamanda ilgili class'ın erişilebilir olması (Mesela baska projelerde kullanılabilmesi icin public olması gereklidir)...Eger class internal olursa sadece kendi projesinden erişilebilir...
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Personel p = new Personel();
        }
    }
}
