# Véletlen szavak, mondatok, bekezdések.
## Függvények:

### Beolvasás
- Kell egy Beolvasás ami beolvas egy listába egy angol és egy magyar szavakból álló txt fájlt ezt az alábbi módon:
~~~csharp
public static void BeolvasNeve()
{
    if (lang == "en")
    {
        ListaNeve = File.ReadAllLines("angoltxtneve.txt");
    }
    else if (lang == "hu")
    {
        ListaNeve = File.ReadAllLines("magyartxtneve.txt");
    }
}
~~~

### Véletlen szó
- RandomWord()
    - generál egy random szót.

- RandomWord(int ListCount, bool Distinct)
    - generál egy random szó listát, mi adjuk meg hogy hány szóból álljon. A Distinct nevű változótól függően a lista szavai ismétlődhetnek.

### Véletlen mondat
- RandomSentence(int WordCount)
    - generál egy random szavakból álló mondatot, mi adjuk meg hogy hány szóból álljon.

### Véletlen bekezdés
- RandomParagraph(int WordperSentence, int SentenceCount)
    - generál egy random mondatokból álló bekezdést, mi adjuk meg hogy hány mondatból álljon és hogy a mondatok hány szóból álljanak.