using OOPAccessModifiers_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPAccessModifiers_2
{
    public  partial class Form1 : Form
    {

        /*
         
               Access Modifiers (Erişim Belirtecleri)

        public , internal, protected internal, protected, private
         
         public : Basında yazıldıgı yapının her yere erişiminin oldugunu belirtir (Proje icerisinden veya proje dısarısından fark etmez)

        internal : Basında yazıldıgı yapının sadece bulundugu proje icerisinde her yere erişiminin oldugunu belirtir

        private : Yazıldıgı yapının sadece kendi bulundugu yapı icerisinden erişilebilecegini belirtir (Baska hicbir yere , kendi projesi icerisinde bile cıkamaz)


         Local alanın icerisindeki yapılara erişim belirteci yazamazsınız....

        Biz erişim belirteci yazabilecegimiz bir yerde bir erişim belirteci yazmazsak C#, ilgili alanı kontrol eder ve ilgili alanda tanımladıgınız yapının o alanda alabilecegi en kısıtlayıcı erişim belirteci hangisiyse otomatik olarak verir...

        Global alanda bir yapının alabilecegi en kısıtlayıcı erişim belirteci private'tir...

        Namespace alanında direkt tanımlanan bir yapının (erişim belirteci yazılmadan tanımlanan bir yapının) public veya internal dısında bir erişim belirteci alamayacagını bilmelisiniz... Erişim belirteci minimum internal olabilir...Global alanda tanımlanabilecek erişim belirteci minimum private'tir...


        **Namespace alanında direkt tanımlanan hicbir yapının basına erişim belirteci olarak private,protected, protected internal yazamazsınız...Onlar sadece public veya internal alabilirler...En kapsayıcı belirteci public'tir...Ondan sonra internal gelir...Sonra protected internal ve sonra private...
        *
        *
        *
        *Yapı İkonları => 
        *
        *Lila renkli küp => Metot demektir
        *İngiliz anahtarı => Property
        *Turuncu geometrik şekiller => class
        *Mavi dikdörtgen prizması => GLobal degişken (field)
        *Parantezler icerisindeki dikdörtgen prizması => Local degişken (local variable)
        *
        *Erişim Belirtecleri İkonları => Yapı ikonlarının altında cıkan kücük ikonlar
        *
        *private => kilit şeklinde ikon
        *internal => kalp şeklinde ikon
        *protected/protected internal => yıldız
        *public : ikon cıkmaz (zaten local alanda erişim belirteci olamaz)
        *
        *
        *private erişim belirtecine sahip ogeler sadece iclerinde bulundukları yapı icerisinden erişilebilirler...Yapı dısından hicbir yerden erişilemezler...
        *
         
         
         */

        


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
