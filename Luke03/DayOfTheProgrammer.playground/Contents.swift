import UIKit

/*Programmererenes dag feires hvert år på den 256. dagen (eller 2^8. dagen om du vil) i året. Hvor mange ganger fra og med år 1 til og med år 2015 har dette forekommet på en fredag om en antar at 1. januar år 1 var en fredag i, samt at dagens skuddårsregler og kalendersystem har vært gjeldende i hele perioden?

Hint: Skuddår er forøvrig et år som er delelig på 4 og ikke 100 med mindre det er delelig på 400

OBS: Er blitt gjort oppmerksom på et avvik i oppgaven. Svaret som er lagt inn på oppgaven later til å anta at den første dagen i året er den "nulte" dagen i året.*/

let dayOfProgrammers = 256
var weekDay = 4

func daysInYear(year:Int)->Int{
    
    let isLeapYear = (year % 400) == 0 || (year % 4) == 0 && (year % 100) != 0
    
    return isLeapYear ? 366 : 365
}

var counter = 0

for year in 1...2015{
    for day in 0...daysInYear(year)-1{
        weekDay = (weekDay + 1) % 7
        if day == dayOfProgrammers-1 && weekDay == 4{
            counter++
        }
    }
}


