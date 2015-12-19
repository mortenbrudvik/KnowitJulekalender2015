import std.stdio;
import std.net.curl;
import std.regex;
import std.string;

/*
Hver innbygger i Ruritania har en unik ID. IDen er en streng bygd opp etter følgende regler:

* Id strengen må begynne med 0-3 små bokstaver (fra a-z).
* Rett etter bokstavene må det følge 2-8 tall. Tallene har verdi fra og med 0 til og med 9
* Rett etter tallene må det følge en streng med minst 3 store bokstaver (fra A-Z)
 */
void main()
{
  auto regex = r"^[a-z]{0,3}[0-9]{2,8}[A-Z]{3,}$";
  auto content = get("http://pastebin.com/raw.php?i=F8z0JWqa");
  auto counter = 0;
  foreach(line; content.splitLines()){
    if ( matchFirst(line,regex))
      counter++;
  }
  writeln(counter);
}
