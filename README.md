2. feladat 40 pont
XIX. Bükk Hegyikerékpár Maraton1
A Bükk Hegyikerékpár Maraton egyike a TOP Maraton versenysorozat négy versenyének.
A 2019-es versenyt augusztus 4-én öt versenytávon rendezték meg Felsőtárkányban. Ebben a
feladatban a célba érkező versenyzők adataival2

kell feladatokat megoldania. Megoldásában

vegye figyelembe a következőket:
• A képernyőre írást igénylő feladatok eredményének megjelenítése előtt írja a képernyőre a
feladat sorszámát (például: 4. feladat)!
• Az egyes feladatokban a kiírásokat a minta szerint készítse el!
• Az ékezetmentes kiírások is elfogadottak.
• Az azonosítókat kis- és nagybetűkkel is kezdheti.
• A program megírásakor az állományban lévő adatok helyes szerkezetét nem kell
ellenőriznie, feltételezheti, hogy a rendelkezésre álló adatok a leírtaknak megfelelnek.
• A megoldását úgy készítse el, hogy az azonos szerkezetű, de tetszőleges bemeneti adatok
mellett is helyes eredményt adjon.
Az UTF-8 kódolású bukkm2019.txt forrásállomány tartalmazza soronként a versenyzők
adatait, melyeket pontosvesszővel választottuk el:

• Rajtszám: A versenyző rajtszáma, az első karakter kódolja a versenytávot
• Kategória: A versenyzők nem és életkor szerinti kategóriája
• Név: A versenyző neve
• Egyesület: A versenyzőt indító sportegyesület neve. Üres, ha a versenyzőt nem
egyesület indította
• Idő: Az elért időeredmény [óra:perc:másodperc]
1. Készítsen konzolos alkalmazást a következő feladatok megoldására, melynek projektjét
BukkMaraton2019 néven mentse el!
2. A forráskódjában tegye elérhetővé a java.txt vagy a csharp.txt állományból a
Versenytav osztályt definiáló kódrészletet!
3. Olvassa be a bukkm2019.txt állományban lévő adatokat, és tárolja el egy olyan
adatszerkezetben, ami a további feladatok megoldására alkalmas! Az állományban
legfeljebb 1000 sor lehet. Ha a versenytávok tárolása mellett dönt, akkor felhasználhatja az
előző feladatban elérhetővé tett osztályt is. Ügyeljen rá, hogy az állomány első sora a
mezőneveket tartalmazza!

1 Forrás: https://www.mozgasvilag.hu/kerekpar/esemenynaptar/xix-bukk-hegyikerekpar-maraton
2
Forrás: http://www.temposport.hu/download/2019_bukkmaraton_eredmeny.xlsx

A feladat a következő oldalon folytatódik.

Informatikai ismeretek
középszint

2211 gyakorlati vizsga 8 / 16 2022. október 21.
Név: ........................................................... osztály:......
4. Határozza meg és írja ki a képernyőre, hogy a versenyzők milyen arányban nem teljesítették
a versenyt! Ismerjük, hogy a versenyen összesen 691 fő indult el. A célba érkezők számát
a forrásállomány adatsorainak a száma határozza meg.
5. Számolja meg és írja a képernyőre a rövidtávú versenyen elindult női versenyzők számát!
A megoldásához használja fel a 2. feladatban elérhetővé tett Versenytav osztály
példányait! Feltételezheti, hogy a kategóriaadatok női versenyzők esetében „n”, férfi
versenyzők esetében „f” karakterre végződnek.
6. Döntse el, hogy volt-e olyan versenyző, aki több mint hat órát töltött a versenypályán!
A keresést ne folytassa, ha a választ meg tudja adni! Az eldöntés eredményét jelenítse meg
a képernyőn („Volt ilyen versenyző” vagy „Nem volt ilyen versenyző”)!
7. Keresse meg a rövidtávú verseny felnőtt férfi kategóriájának győztesét! Megoldásában
feltételezheti, hogy a kategóriában volt célba érkező, és a rövidtávú versenyzők rajtszáma
„R” karakterrel kezdődik, vagy használhatja a Versenytav osztályt. Továbbá
feltételezheti, hogy a kategória neve „ff”, és nem alakult ki az élen holtverseny. A győztes
adatait írja a képernyőre! A vezetőnullák kiírása az időeredményben tetszőleges. Ha a
versenyzőt nem egyesület indította, akkor az egyesület adathoz ne írjon ki semmit!
8. Készítsen statisztikát kategóriák szerint a célba érkező férfi versenyzők számáról!
A statisztikát írja a képernyőre! A kategóriák sorrendje tetszőleges a kiírásnál.
9. Készítsen grafikus alkalmazást, melynek a projektjét BukkMaraton2019GUI néven
mentse el, melynek segítségével egy-egy versenyző átlagsebességét számolhatja ki!
A grafikus alkalmazásban a következő feladatokat végezze el:
a. Alakítsa ki a felhasználói felületet a következő minta szerint! Állítsa be az alkalmazás
címsorában megjelenő „Bükk Maraton 2019” feliratot! A legördülő listában rendre a
következő elemek szerepeljenek: „Mini - 16km”, „Rövid - 38km”, „Pedelec - 54km”,
„Közép - 57km”, „Hosszú - 94km”! Induláskor a „Közép - 57km” listaelem legyen
kiválasztva, a beviteli mező alapértelmezett értéke „1:00:00” legyen!

b. A „Számol” parancsgombra kattintva határozza meg és jelenítse meg két tizedesjegyre
kerekítve az átlagsebesség értékét km/óra és m/s mértékegységben kifejezve!
(1 km = 1000 m, 1 óra = 3600 s)
