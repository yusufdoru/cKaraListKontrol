using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cKaraListKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {            
            if (btnBaslat.Text == "BAŞLAT") // Program ilk açıldığında "BAŞLAT" butonu aktiftir.
            {
                tmrZamanlayici.Interval = Int32.Parse(txtMS.Text); // Milisaniyeyi alıp ilk önce string'i int'e çevirdik yaptık. Daha sonra bunu Timer nesnesinin Interval özelliğine atadık.
                txtMS.Enabled = false; // int olarak milisaniye değeri alan text kutucuğunu erişime kapattık.
                txtUrl.Enabled = false; // txtURL ID'li text kutucuğunu erişime kapadık.                
                tmrZamanlayici.Enabled = true; // Zamanlayıcı Timer kontrolünü aktif ettik.                
                btnBaslat.Text = "DURDUR"; // BAŞLAT butonuna bastığımızda haliyle "DURDUR" yazısı set ediliyor.

                StartTest(); // ve burdaki işimiz "StartTest" metoduyla bitiyor.
            }
            else // DURDUR butuna tıklandığında
            {
                txtMS.Enabled = true; 
                tmrZamanlayici.Enabled = false; 
                txtUrl.Enabled = true;

                lblDurum.Text = "-TEST YAPILMADI-"; // Durumu başlangıçtaki haline getiriyoruz.
                lblDurum.ForeColor = Color.Black;

                btnBaslat.Text = "BAŞLAT";
            }
        }
        void StartTest()
        {
            wb.Url = new Uri("http://mxtoolbox.com/SuperTool.aspx?action=blacklist%3a" + txtUrl.Text + "&run=toolpage"); 
            // Kara liste kontrolünü mxtoolbox.com adresinden yapıyoruz. Site ajax kullanıyor.
        }

        private void web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) // mxtoolbox.com adresinin kaynak kodları yüklendiğinde.
        {
            tmrFullLoaded.Enabled = true; 
            // Burası "DocumentCompleted" olayı tetiklendiğinde kod blogu çalışıyor. Fakat sitemiz ajax ile çalıştığı için timer kontrolü ile istediğimiz değerin yüklenip yüklenmediğini kontrol etmeliyiz.
        }

        private void tmrFullLoaded_Tick(object sender, EventArgs e) // İlgili sitedeki ajax'ın başarıyla yüklenip yüklenmediğini anlamaya çalışıyoruz.
        {
            string innerHtml = IsAjaxLoaded(wb.Document.GetElementById("lblResult"));// "IsAjaxLoaded" metodu bana "#lblResult" içindeki veriyi döndürüyor. 

            if (!String.IsNullOrEmpty(innerHtml)) { // "innerHtml" null veya boş değilse
                CheckList(innerHtml); // Kara listede var yada yok kontrolü. innerHtml burada parametre olarak gönderiliyor.

                tmrFullLoaded.Enabled = false; // Amacımıza ulaştığımıza göre Timer kontrolünü devredışı bırakabiliriz.

            }

            
        }
        string IsAjaxLoaded(HtmlElement cTag)
        {
            cTag = wb.Document.GetElementById("lblResult"); // #lblResult idsini değişkene atıyoruz.
            if (cTag != null) // eğer "lblResult" varsa null değildir.
            {
                if (cTag.InnerHtml != null && cTag.InnerHtml.Contains("Reported by") == true)
                    return cTag.InnerHtml;  // Burada innerHtml null değilse ve innerhtml içinde "Reported by" kelimesi geçiyorsa raporlama bitmiştir deyip string olarak döndürüyoruz.
            }
            return null;
        }

        void CheckList(string innerHtml) //  Kara listede var veya yok kontrolü.
        {
            if (innerHtml.Contains("&nbsp;LISTED")) // Eğer innerHtml içinde LISTED kelimesi geçiyorsa mail sunucusu kara listededir.
            {
                lblDurum.Text = "KARA LİSTEDE !";
                lblDurum.ForeColor = Color.Red;
            }
            else // Üstteki şart sağlanmamışsa listede olmamasından başka seçenek yok gibi görünüyor.
            {
                lblDurum.Text = "LİSTEDE DEĞİL :)";
                lblDurum.ForeColor = Color.Green;
            }

        }
        private void tmrZamanlayici_Tick(object sender, EventArgs e) // txtMS ile belirttiğimiz milisaniyede bir tetiklenen olay.
        {
            StartTest(); // Üstteki kontrol aşamaları tekrarlanıyor.
        }

       
    }
}
