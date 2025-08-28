using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        ProgramSorting(TypeSorting.Time);
        Console.WriteLine("------");
        ProgramSorting(TypeSorting.Name);
        Console.WriteLine("------");
        ProgramSorting(TypeSorting.NameAndTime);
    }

    // List Data 
    public static List<DataSorting> datas = new List<DataSorting>()
    {
        new DataSorting("Chicago", new TimeSpan(9, 0, 0)),
        new DataSorting("Chicago", new TimeSpan(9, 3, 13)),
        new DataSorting("Phoenix", new TimeSpan(9, 0, 3)),
        new DataSorting("Houston", new TimeSpan(9, 1, 10)),
        new DataSorting("Houston", new TimeSpan(9, 0, 13)),
        new DataSorting("Seattle", new TimeSpan(9, 10, 11)),
        new DataSorting("Chicago", new TimeSpan(9, 19, 32)),
        new DataSorting("Chicago", new TimeSpan(9, 21, 5)),
        new DataSorting("Seattle", new TimeSpan(9, 10, 25)),
        new DataSorting("Phoenix", new TimeSpan(9, 14, 25)),
        new DataSorting("Seattle", new TimeSpan(9, 36, 14)),
        new DataSorting("Chicago", new TimeSpan(9, 0, 59)),
        new DataSorting("Seattle", new TimeSpan(9, 22, 43)),
        new DataSorting("Chicago", new TimeSpan(9, 19, 46)),
        new DataSorting("Chicago", new TimeSpan(9, 25, 52)),
        new DataSorting("Seattle", new TimeSpan(9, 22, 54)),
        new DataSorting("Phoenix", new TimeSpan(9, 37, 44)),
        new DataSorting("Chicago", new TimeSpan(9, 35, 21)),
    };

    public static void ProgramSorting(TypeSorting type = TypeSorting.Time)
    {
        IEnumerable<DataSorting> sortedDatas = datas;

        switch (type)
        {
            case TypeSorting.Name:
                sortedDatas = datas.OrderBy(d => d.LocationName);
                break;
            case TypeSorting.Time:
                sortedDatas = datas.OrderBy(d => d.Time);
                break;
            case TypeSorting.NameAndTime:
                sortedDatas = datas
                    .OrderBy(d => d.LocationName)
                    .ThenBy(d => d.Time);
                break;
        }

        foreach (var data in sortedDatas)
        {
            Console.WriteLine($"{data.LocationName} {data.Time}");
        }
    }
}

public class DataSorting
{
    public string LocationName { get; set; }
    public TimeSpan Time { get; set; }

    public DataSorting(string location, TimeSpan time)
    {
        LocationName = location;
        Time = time;
    }
}

public enum TypeSorting
{
    Name,
    Time,
    NameAndTime
}
