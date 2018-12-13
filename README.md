# Frequency-Analysis
Basit şifreleme algoritmalarına yönelik frekans analizi saldırısı.

------------



- [YOUTUBE](https://www.youtube.com/channel/UCltJlvbcFATfBm0qHttpZNg?view_as=subscriber "YOUTUBE") kanalında verilen eğitime katkıda bulunması amacıyla hazırlanmıştır.
- **VISUAL STUDIO 2015** editörü kullanılarak hazırlanan uygulama görsel bir arayüze sahiptir.
------------

### Yazan: Şadi Evren ŞEKER

Şifrelenmiş bir metine saldırı yöntemlerinden birisi de frekans analizi yapmaktır. Bu yöntemde, metinde bulunan harf sıklıklarına göre bir frekans tablosu oluşuturulur. Bu tablo orjinal mesajın gönderildiği frekans sıklıkları ile karşılaştırılır ve karakteristik bazı harfler tahmin edilebilir.

Örneğin ingilizce’de **e** harfi diğer harflere nazaran daha sık kullanılmaktadır. Bu durumda şifrelenmiş metinde en çok geçen harf muhtemelen **e** harfidir denilebilir.

Aşağıdaki resimde inigilizce dilindeki harflerin frekansları verilmiştir.
[![Analiz](https://github.com/serdaraltin/Frequency-Analysis/blob/master/Frekans%20Analizi/bin/Debug/frekans_analiz1.jpg)



------------
### [Meyta - Kriptoloji 6 - Kriptoanaliz / Frekans Analizi(Frequency Analysis)](https://www.youtube.com/watch?v=WyBOdy9glYw "Meyta - Kriptoloji 6 - Kriptoanaliz / Frekans Analizi(Frequency Analysis)")
![Meyta - Kriptoloji 6 - Kriptoanaliz / Frekans Analizi(Frequency Analysis)](https://github.com/serdaraltin/Frequency-Analysis/blob/master/Frekans%20Analizi/bin/Debug/On-Izleme.jpg)

------------

**Tasarım - Form1.Designer.cs**

![Form1](https://github.com/serdaraltin/Frequency-Analysis/blob/master/Frekans%20Analizi/bin/Debug/Program.PNG)

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

namespace Frekans_Analizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_analizet_Click(object sender, EventArgs e)
        {
            int[] alfabe = new int[26];
            //0,0,0,0,0,0,0...
            //a,b,c,d,e,f,g...
            prgb_durum.Maximum = tx_analizmetin.TextLength;
            for (int i = 0; i < tx_analizmetin.TextLength; i++)
            {
                if(tx_analizmetin.Text[i] > 96 && tx_analizmetin.Text[i] < 123) // örnek : a = 97 - 97 = 0
                {
                    alfabe[tx_analizmetin.Text[i] - 97] += 1; // 
                }
                prgb_durum.Value += 1;
            }

            for(int a = 0; a < alfabe.Length; a++)
            {
                char harf = (char)(a + 97);
                lstb_analizsonucu.Items.Add(harf.ToString() + " = " + alfabe[a].ToString());
            }

        }
    }
}

```

**Powered By DeadSound**
