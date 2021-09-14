### Written in Visual Basic, this command can easily be built to run on  Windows, Linux, or macOS.

## About:
This is a standalone command that will return the date of the next Easter holiday at the command prompt. It also accepts multiple 4-digit Year arguments to return the date for all of the specified years. Easter is a Christian holiday and can fall on any date between March 22 and April 25.

Please note that the dates returned are for the Gregorian calendar which was not used before October 1582. People would have celebrated Easter on the date returned converted to their Julian Calendar equivalent before 1583.

## Usage:                                                                                    
### EasterDate [####] [####]...

- EasterDate {returns the date of the next Easter}
- EasterDate 1953 {returns the date of Easter in 1953}
- EasterDate 1953 2000 2021 2022 4200 {returns the date of Easter for each argument passed}
 
Only years between 1 - 9999 will return dates, other arguments will return an error message.

### Holidays.dll has two relevant functions:

####	*  EasterDate.GetEasterDate() which returns the next date of Easter.
####	*  EasterDate.CalculateEasterDate(Year as Integer) which can return the date of Easter for the given Year.

##### To use Holidays.dll, add it to your project's references and use the Holidays namespace to access the EasterDate functions.

### More...
### Additional Information about Easter, the Gregorian Calendar, and calculatng the date.
The Easter date changes from year to year because the date has to be a Sunday (resurrection was on a Sunday), and the New Testament says the crucifixion took place during the Jewish holiday of Passover, which is celebrated for eight days following the first full moon of Spring. That means the date is linked to astronomical cycles making it difficult to calculate. The solar year is about 365.24 days long and a lunar month is currently about 29.53 days long; that means there are 12.37 lunar months per year. 

235 lunar months are very close to 19 solar years, and the church’s system for assigning a date to Easter exploited this coincidence. In A.D. 325 at the Council of Nicaea, church leaders decided that Easter should fall on the first Sunday after the first full moon occurring on, or after, the Spring equinox (a date in March when day and night have equal length).

At that time, the year was based on the Julian calendar with one leap year in every four. The dates of full moons were assumed to repeat every 19 Julian years; a bit of kludging the calendar made this period equal to 235 lunar months. The 19-year period was called the lunar cycle, and each year’s position in this cycle was indicated by its Golden Number, which ran from 1 to 19. The entire cycle of the Julian calendar would repeat every 76 years. After four lunar cycles of 19 years each, the pattern of leap years would repeat. 

The mathematical principle was that the length of a cycle is equal to the lowest common multiple of the lengths of its constituent sub-cycles (76 is the lowest common multiple of 19 and 4). Easter dates repeated in a 532-year cycle, because 532 is the lowest common multiple of 76 (the Julian calendar’s cycle) and 7 (the cycle of days in the week). Unfortunately, the system did not accurately account for the true lengths of the lunar month and solar year. As the centuries passed, the calendar started to slip relative to the seasons. 

In 1582, Pope Gregory XIII reformed the calendar by omitting the leap day in all years that are multiples of 100, except for years that are multiples of 400 to more align with the astrological cycles. To correct for the previous slippage, the “Gregorian” calendar for 1582 skipped the 10 days between October 4 and 15. The church’s new procedure for calculating the date of Easter assigned each year a number called the Epact, an integer between 0 and 29. This number reveals the phase of the moon on January 1 of each year, with 0 indicating a new moon and 15 a full moon. Every so often the cycle of Epacts must be revised to account for the fact that 235 lunar months do not exactly equal 19 solar years. The last such correction occurred in 1900, and the next will be needed in 2200.

Using the Golden Number and Epact for any given year, one can calculate the date of the first full moon of Spring. To determine the date of Easter (the first Sunday after the full moon) the church assigned each year a dominical letter, from A to G, indicating the date of that year’s first Sunday: A for January 1, B for January 2, and so on. Every leap year has two dominical letters, one for January and February and the other for the remaining months.

The system has its flaws. The church considers March 21 to be the perennial date of the vernal equinox, but the real astronomical equinox can occur as early as March 19 (as will happen in 2096). Also, the moon does not slavishly follow ecclesiastical conventions. In 1845 and 1923 the first full moon of spring occurred after Easter Sunday in the world’s easterly longitudes.

### Calculating the date 
In general, the date of Easter slips back by about eight days each year until it hops forward again. The pattern looks irregular but actually follows the arithmetical procedure. Under the rules of the Gregorian calendar, the cycle of Easter dates repeats exactly after 5.7 million years. Long before the first repeat, though, the rules will have slipped relative to astronomical realities because the lengths of the month and day are slowly changing, mainly because of tidal friction. Eventually, there will be more adjustments.

To determine the date of Easter, carry out the following 10:
Choose any year of the Gregorian calendar and call it x. 

### For this example: x = 2001 {Event Year}

1. Divide x by 19 to get a quotient (which we ignore) and a remainder A. This is the year’s position in the 19-year lunar cycle. (A + 1 is the year’s Golden Number.)
	- A = x MOD 19
2. Divide x by 100 to get a quotient B and a remainder C.
	- B = x \ 100
	- C = x Mod 100
3. Divide B by 4 to get a quotient D and a remainder E.
	- D = B \ 4
	- E = B Mod 4
4. Divide 8B + 13 by 25 to get a quotient G and a remainder (which we ignore).
	- G = ((8 * B) + 13
5. Divide 19A + B – D – G + 15 by 30 to get a quotient (which we ignore) and a remainder H.
(The year’s Epact is 23 – H when H is less than 24 and 53 – H otherwise.)
	- H = ((19 * A) + B - D - G + 15) Mod 30 
6. Divide A + 11H by 319 to get a quotient M and a remainder (which we ignore).
	- M = (A + (11 * H)) \ 319
7. Divide C by 4 to get a quotient J and a remainder K.
	- J = C \ 4
	- k = C Mod 4
8. Divide 2E + 2J – K – H + M + 32 by 7 to get a quotient (which we ignore) and a remainder L.
	- L = ((2 * E) + (2 * J) - K - H + M + 32) Mod 7
9. Divide H – M + L + 90 by 25 to get a quotient N and a remainder (which we ignore).
	- N = (H - M + L + 90) \ 25
10. Divide H – M + L + N + 19 by 32 to get a quotient (which we ignore) and a remainder P.
	- P = (H - M + L  + N + 19) Mod 32

Easter Sunday is the Pth day of the Nth month (N can be either 3 for March or 4 for April). 

### The above formmulas should return these values:

If x = 2001  {EventYear}

-  (1) A = 6 
-  (2) B = 20, C = 1 
-  (3) D = 5,  E = 0 
-  (4) G = 6 
-  (5) H = 18 
-  (6) M = 0 
-  (7) J = 0,  K = 1 
-  (8) L = 6
 
-  (9) N = 4  (Month)
- (10) P = 15 (Day)
 
#### So Easter 2001 is April 15

### Much of the additional information above is from:
	
- Algorithms Calendar Calculations: Easter Is a Quasicrystal
- Revealing the divine mathematics of a holiday
- MATHEMATICAL RECREATIONS by Ian Stewart
- Scientific American, March 2001
- http://www.whydomath.org/Reading_Room_Material/ian_stewart/2000_03.html
