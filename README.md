# Frequency-Analysis
Basit şifreleme algoritmalarına yönelik frekans analizi saldırısı.

------------



- **[YOUTUBE](https://www.youtube.com/channel/UCltJlvbcFATfBm0qHttpZNg?view_as=subscriber "YOUTUBE") **kanalında verilen eğitime katkıda bulunması amacıyla hazırlanmıştır.
- **VISUAL STUDIO 2015** editörü kullanılarak hazırlanan uygulama görsel bir arayüze sahiptir.


------------
<br>

#### Vikipedi, özgür ansiklopedi


ROT13 bir Sezar şifresi , bir ikame şifresi türüdür. ROT13'te, alfabe 13 adımda döndürülür.
Tek harflerin ayrı ayrı ikame edilmesi - basit ikame - ikamesini temsil etmek için alfabeyi bir sırayla yazarak gösterilebilir. Buna bir ikame alfabesi denir . Cipher alfabesi kaydırılabilir veya tersine çevrilebilir ( sırasıyla Sezar ve Atbash şifrelerini oluşturabilir ) veya daha karmaşık bir şekilde karıştırılabilir, bu durumda buna karışık bir alfabe veya bozuk alfabesi adı verilir . Geleneksel olarak, karışık alfabeler ilk önce bir anahtar sözcük yazarak, tekrarlanan harfleri kaldırarak ve sonra sıradaki sırayla alfabedeki kalan tüm harfleri yazarak oluşturulabilir.

Bu sistemi kullanarak, " **zebralar** " anahtar kelimesi bize aşağıdaki alfabeleri verir:

Düz metin alfabesi:	**ABCDEFGHIJKLMNOPQRSTUVWXYZ**
Şifreli alfabe:**	ZEBRASCDFGHIJKLMNOPQTUVWXY**
Bir mesaj

    bir kerede kaçmak. keşfettik!

için şifreler

    SIAA ZQ LKBA. VA ZOA RFPBLUAOAR!
Geleneksel olarak, şifreli metin, noktalama işaretlerini ve boşlukları atlayarak, sabit uzunlukta bloklar halinde yazılır; Bu, aktarım hatalarından kaçınmaya ve sözcük metnini düz metinden gizlemeye yardımcı olmak için yapılır . Bu bloklara "gruplar" denir ve bazen bir "grup sayısı" (yani, grup sayısı) ek bir kontrol olarak verilir. İletilerin telegraf tarafından iletildiği tarihlerden kalma beş harfli gruplar gelenekseldir :

    SIAAZ QLKBA VAZOA RFPBL UAOAR
Mesajın uzunluğu beş ile bölünemezse, sonunda " **boş** " ile doldurulabilir . Bunlar açıkça saçma sapan şifreli herhangi bir karakter olabilir, böylece alıcı kolayca onları tespit edebilir ve atabilir.

Şifreli metin alfabesi bazen düz metin alfabesinden farklıdır; örneğin, pigpen şifrede , şifreli metin bir kılavuzdan türetilen bir dizi sembolden oluşur.


------------
### [Meyta - Kriptoloji 3 - Yerine Koyma Şifrelemesi](https://www.youtube.com/watch?v=nZwcoATMVdo "Kriptoloji 2 - Sezar Şifreleme")
![Meyta - Kriptoloji 2 - Sezar Şifreleme](https://github.com/serdaraltin/Substitution-Cipher/blob/master/Yerine%20Koyma/bin/Debug/On-Izleme.jpg)

------------

**Tasarım - Form1.Designer.cs**

![Form1](https://github.com/serdaraltin/Substitution-Cipher/blob/master/Yerine%20Koyma/bin/Debug/ScreenShot.PNG)

------------



**Kod - Form1.cs**

```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yerine_Koyma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_anahtarolustur_Click(object sender, EventArgs e)
        {
            tx_anahtar.Text = "";
            while(tx_anahtar.TextLength < 26)
            {
                Random rastgele = new Random();
                char harf = (char)rastgele.Next(97, 123); //harf elde etme

                if (!(tx_anahtar.Text.Contains(harf)))
                {
                    tx_anahtar.Text += harf;
                }

            }
        }

        private void btn_sifrele_Click(object sender, EventArgs e)
        {
            tx_sirelimesaj.Text = "";
            for (int i = 0; i< tx_acikmesaj.TextLength; i++)
            {
                int yerine_koyma = tx_acikmesaj.Text[i] - 97;
                char sirelenen_harf = tx_anahtar.Text[yerine_koyma];
                tx_sirelimesaj.Text += sirelenen_harf;
            }
        }
    }
}
```

**Powered By DeadSound**
