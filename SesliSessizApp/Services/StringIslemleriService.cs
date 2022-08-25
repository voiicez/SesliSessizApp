namespace SesliSessizApp.Services
{
    internal class StringIslemleriService
    {
        string[] _sesliler = new string[8]
        {
            "a","e","ı","i","o","ö","u","ü"
        };
        public string SesliSessizHarfBul(string kelime, bool sesliMi)
        {
            //1. başla
            //2. Kullanıcıdan kelime alınır.
            //3. Kullanıcıdan sesli/sessiz alınır.
            //4. Kelime üzerinde dönülür
            //5. Sesli dizisi oluşturulur.
            //6. kelimenin döngüdeki karakteri sesliler içinde ise ,SesliMi=true ise
            //7. sonuç string'ine sesli harf eklenir.
            //8. Ankara
            string sonuc = "";
            bool sesliHarfMi;

            if (sesliMi)
            {
                foreach (char kelimeHarf in kelime)
                {
                    foreach (string sesliHarf in _sesliler)
                    {
                        if (kelimeHarf.ToString().ToLower() == sesliHarf)
                        {
                            if (!sonuc.Contains(kelimeHarf.ToString()))
                                sonuc = sonuc + kelimeHarf;
                            break;
                        }
                    }
                }
            }
            else
            {


                for (int i = 0; i < kelime.Length; i++)
                {
                    sesliHarfMi = false;
                    for (int j = 0; j < _sesliler.Length; j++)
                    {
                        if (kelime[i].ToString() == _sesliler[j])
                        {
                            sesliHarfMi = true;
                            break;
                        }
                    }
                    if (!sesliHarfMi)
                    {
                        if (!sonuc.Contains(kelime[i].ToString().ToLower()))
                        {
                            sonuc += kelime[i];
                        }
                    }
                }
                
            }
            return sonuc;

        }
        //bEhlül Şahin -> Behlül Şahin
        public string IlkHarfleriBuyut(string cumle)
        {
            string sonuc = "";
            if (string.IsNullOrWhiteSpace(cumle))
            {
                sonuc = "Lütfen minumum bir kelime içeren bir cümle giriniz. ";
                return sonuc;
            }
            string[] kelimeler = cumle.Split(' ');
            foreach (string kelime in kelimeler)
            {
                sonuc += kelime.Substring(0, 1).ToUpper();//B
                sonuc += kelime.Substring(1).ToLower();//Behlül
                sonuc += " ";
            }
            
            return sonuc.Trim();

        }
    }
}

