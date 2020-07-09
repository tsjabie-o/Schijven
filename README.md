# Schijven
Opdracht voor studie


Elk door een klant bestelde steunblok heeft een bepaalde hoogte, die wordt bereikt door
op 1 zo groot mogelijk standaardblok een aantal schijfjes van hoogte 1 te lijmen. Er
is een catalogus met standaardblokken beschikbaar, geordend op grootte, waarin je allereerst
moet zoeken naar het geschikte blok. Vervolgens bepaal je hoeveel schijfjes daar nog bovenop
moeten worden gelijmd. Een testcase bestaat uit de opdrachten van een aantal klanten,
en je moet per testcase het minimale aantal schijfjes geven, dat nodig is om alle
bestelde steunblokken in de testcase te kunnen produceren. Als de catalogus bijvoorbeeld
standaardblokken van hoogte 2, 13, 18 en 23 vermeldt, kan DAKIBOT voor een besteld
steunblok van hoogte 21 het standaardblok van 23 niet gebruiken, want dat is te groot. Een
standaardblok van 13 met daar bovenop 8 schijfjes zou kunnen, maar we kunnen een nog
groter standaardblok van 18 kiezen, waarop we namelijk slechts 3 schijfjes hoeven te lijmen.

De invoer heeft op de eerste regel een getal n ≤ 9 999 999, het aantal verschillende verkrijgbare
standaardblokken. Dan volgen n regels met een getal, elk maximaal 999 999 999, de hoogte van
een standaardblok; deze lijst van standaardblokken is op hoogte gesorteerd. De regel daarna
bevat een getal m ≤ 9 999 999, het aantal steunblokken dat je moet afhandelen.
Dan volgen m regels met elk een getal, maximaal 1 999 999 999, de hoogte van het gewenste
1
steunblok. Al deze getallen zijn geheel en niet negatief. Na elk getal kan een spatie staan
en andere dingen (zoals in het voorbeeld hieronder, dat een van de testcases is), die moet je
dan negeren. De uitvoer heeft 1 regel met 1 getal, namelijk het totaal aantal schijfjes dat
je nodig hebt.
