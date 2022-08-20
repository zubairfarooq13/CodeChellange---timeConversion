

///* Given a time in -hour AM/PM format, convert it to military (24-hour) time.

//Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
//- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock. */

string s = "01:01:00AM";

string hour = s.Split(':').First();
bool isAM = s.Contains("AM");

string updatedTime = s.Substring(2).Replace("AM", "").Replace("PM", "").Replace('"', ' ').Trim();

string NewHour = "00";

if (isAM && hour == "12")
{
    NewHour = "00";
}
else if (!isAM && hour != "12")
{
    int upHour = 12 + int.Parse(hour);
    NewHour = upHour.ToString();
}
else
{
    NewHour = hour;
}

updatedTime = NewHour.ToString() + updatedTime;

Console.WriteLine(updatedTime);

