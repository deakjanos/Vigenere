Vigenere
========

Visual Basic 2008 Form App

Már a XVI. században komoly titkosítási módszereket találtak ki az üzenetek elrejtésére. A század egyik legjobb kriptográfusának Blaise de Vigenère-nek a módszerét olvashatja a következőkben.
A kódoláshoz egy táblázatot és egy ún. kulcsszót használt.

Feladatok
Készítsen programot a következő feladatok megoldására!

    Kérjen be a felhasználótól egy maximum 255 karakternyi, nem üres szöveget! A továbbiakban ez a nyílt szöveg.
    Alakítsa át a nyílt szöveget, hogy a későbbi kódolás feltételeinek megfeleljen! A kódolás feltételei: A magyar ékezetes karakterek helyett ékezetmenteseket kell használni. (Például á helyett a; ő helyett o stb.) A nyílt szövegben az átalakítás után csak az angol ábécé betűi szerepelhetnek. A nyílt szöveg az átalakítás után legyen csupa nagybetűs.
    Írja ki a képernyőre az átalakított nyílt szöveget!
    Kérjen be a felhasználótól egy maximum 5 karakteres, nem üres kulcsszót! A kulcsszó a kódolás feltételeinek megfelelő legyen! (Sem átalakítás, sem ellenőrzés nem kell!) Alakítsa át a kulcsszót csupa nagybetűssé!
    A kódolás első lépéseként fűzze össze a kulcsszót egymás után annyiszor, hogy az így kapott karaktersorozat (továbbiakban kulcsszöveg) hossza legyen egyenlő a kódolandó szöveg hosszával! Írja ki a képernyőre az így kapott kulcsszöveget!
    A kódolás második lépéseként a következőket hajtsa végre! Vegye az átalakított nyílt szöveg első karakterét, és keresse meg a vtabla.dat fájlból beolvasott táblázat első oszlopában! Ezután vegye a kulcsszöveg első karakterét, és keresse meg a táblázat első sorában! Az így kiválasztott sor és oszlop metszéspontjában lévő karakter lesz a kódolt szöveg első karaktere. Ezt ismételje a kódolandó szöveg többi karakterével is!
    Írja ki a képernyőre és a kodolt.dat fájlba a kapott kódolt szöveget! 

