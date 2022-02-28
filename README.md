# Micanje dijaktirikâ iz imena datotekâ
Program datotekama u zadanom direktoriju mijenja ime tako da dijakritike (č,ž,š,đ) zamijenjuje latiniziranim znakovima (c, z, s, d)

##Kratki opis
Svatko tko je radio s datotekama koje u nazivu koriste hrvatske znakove zna koliko mu problema mogu stvarati upravo dijakritci, posebice ako radite s Linuxom. 
Napravio sam stoga ovaj mali programčić koji preimenuje sve datoteke u zadanom direktoriju, neovisno o njihovu formatu. 

Osim dijakritikâ, program razmake (bjeline) zamijenjuje s podvlakama (eng. *underscore*, *_*).

##Korištenje
Sve što trebate napraviti je:
1. skinuti program i otvoriti ga u nekom editoru
2. u 13. retku datoteke Program.cs izmijeniti putanju
`DirectoryInfo d = new DirectoryInfo(@"D:\nazivi");`
3. pokrenuti program


