# String Format for other Calenders
This library allows you to receive format strings from ```PersianCalendar``` and ```HijriCalendar``` and use them in your software.

![String Format for other Calenders](/src/Screenshot%202022-05-28%20171031.png "String Format for other Calenders")

##Instalation
for instal this library, download project and add to projects refrence (in .net framework) or dependencies (in .net core)  
##Use
This library contains two files, SolatSTD and LunarSTD. The SolarSTD file contains datetime extension methods related to the use of Persian calendar strings format:  

- `ToSolarFullTextFormat` for سه شنبه، 14 تیر سال 1401 ه.ش
- `ToSolarFullFormat` for سه شنبه، 14 تیر سال 1401
- `ToSolarMinTextFormat` for سه شنبه، 14 تیر 1401
- `ToSolarNoWeekFormat` for ا 14 تیر 1401 
- `ToSolarShortFormat` for 14/04.1401 ه.ش

For the Hijri calendar as above:  

- ToLunarFullTextFormat
- ToLunarFullFormat
- ToLunarNoWeekFormat
- ToLunarShortFormat
- ToLunarMinTextFormat
