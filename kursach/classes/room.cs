using kursach.classes;
using System;
using System.Collections.Generic;

public class Room
{
    private int width;
    private int length;
    private int height;
    private int usefulWallArea;
    private double volume;
    public List<Exhibit> ExhibitList { get; set; } = new List<Exhibit>();


    public Room(int width, int length, int height, int usefulWallArea)
    {
        Width = width;
        Length = length;
        Height = height;
        UsefulWallArea = usefulWallArea;
    }

    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0) throw new ArgumentException("Ширина не може бути від'ємною.");
            width = value;
        }
    }
    public int Length { 
        get { return length; }
        set { 
            if (value < 0) throw new ArgumentException("Довжина не може бути від'ємною.");
            length = value;
        }
    }
    public int Height { 
        get { return height; }
        set { 
            if (value < 0) throw new ArgumentException("Висота не може бути від'ємною.");
            height = value;
        }
    }

    public int UsefulWallArea { 
        get { return usefulWallArea; }
        set { 
            if (value > Width * Height * 2 + Length * Height * 2) throw new ArgumentException("Корисна площа стін не може перевищувати загальну площу стін.");
            usefulWallArea = value;
        }
    }
    public double Volume
    {
        get { return volume; }
        set
        {
            volume = Width * Length * Height;
        }
    }

    public bool CanAccommodate(double L, double W, double H)
    {
        if (volume >= L * W * H
         && (Width >= W) && (Length >= L) && (Height >= H))
        {
          volume -= L * W * H;
            return true;
        }
        return false;
    }
    
    public override string ToString()
    {
        return $"Кімната: ширина = {Width}, довжина = {Length}, висота = {Height}, корисна площа стін = {UsefulWallArea}";
}
  

}
 