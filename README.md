# String Format for other Calenders
This class consists of four private dictionaries:    _weekDaysSolar_ and   _maunthSolar_,   _weekDaysLunar_ and   _maunthLunar_, which are definitions of the names of months and days of the week in the Hijri and Persian calendars. This class then has four Extension methods that, using a dictionary and taking a DateTime type, return long and short frames of a string:

```c#
.ToLongSolarDateString (this DateTime datetime);
.ToShortSolarDateString (this DateTime datetime); 
.ToLongLunarDateString (this DateTime datetime);
.ToShortLunarDateString (this DateTime datetime);
```
![String Format for other Calenders](/src/Screenshot%202022-05-28%20171031.png "String Format for other Calenders")
