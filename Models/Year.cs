using System.Collections.Generic;
using System;

namespace Year.Models
{
  public class Year
  {
    private string _Year;
    private static List<Year> _Year = new List<Year> {};

    public Year (string Year)
    {
      _Year = Year;
    }
    public string GetYear()
    {
      return _Year;
    }
    public void SetYear(string newYear)
    {
      _Year = newYear;
    }
    public static List<Year> GetAll()
    {
      return _Year;
    }
    public void Save()
    {
      _Year.Add(this);
    }
    public static void ClearAll()
    {
      _Year.Clear();
    }

  }
}
