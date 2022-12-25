using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtGallery.Entities;

namespace ArtGallery
{
    #region Radnik

    public class ArtistBasic

    {
        public int Artist_ID;
        public string Name;
        public string Last_Name;
        public string City;
        public string BirthDate;
        public string Country;
        public ArtistBasic(int artistId, string name, string lname,string c,string b,string con)
        {
            this.Artist_ID = artistId;
            this.Name = name;
            this.Last_Name = lname;
            this.City = c;
            this.Country = con;
            this.BirthDate = b;
        }
        public ArtistBasic()
        {

        }
    }

    public class ArtistPregled

    {
        public int Artist_ID;
        public string Name;
        public string Last_Name;
        public string City;
        public string BirthDate;
        public string Country;
        public ArtistPregled(int artistId, string name, string lname, string c, string b, string con)
        {
            this.Artist_ID = artistId;
            this.Name = name;
            this.Last_Name = lname;
            this.City = c;
            this.Country = con;
            this.BirthDate = b;
        }
        public ArtistPregled()
        {

        }
    }
    #endregion

    #region Customer

    public class CustomerBasic
    {
        public int Customer_ID;
        public string CustomerName;
        public string CustomerLastName;
        public string CustomerEmail;
        public string CustomerAddress;

        public CustomerBasic() { }
        public CustomerBasic(int cId,string cName,string cLName,string cEmail, string cAddress)
        {
            this.Customer_ID = cId;
            this.CustomerName = cName;
            this.CustomerLastName = cLName;
            this.CustomerEmail = cEmail;
            this.CustomerAddress = cAddress;
        }
    }
    public class CustomerPregled
    {
        public int Customer_ID;
        public string CustomerName;
        public string CustomerLastName;
        public string CustomerEmail;
        public string CustomerAddress;

        public CustomerPregled() { }
        public CustomerPregled(int cId, string cName, string cLName, string cEmail, string cAddress)
        {
            this.Customer_ID = cId;
            this.CustomerName = cName;
            this.CustomerLastName = cLName;
            this.CustomerEmail = cEmail;
            this.CustomerAddress = cAddress;
        }
    }


    #endregion

    #region Exhibition

    public class ExhibitionBasic {
        public int Exhibition_ID;
        public string Start_Date;
        public string End_Date;
        public int Hall;

        public ExhibitionBasic() { }
        public ExhibitionBasic(int eId,string sDate,string eDate,int h)
        {
            this.Exhibition_ID = eId;
            this.Start_Date = sDate;
            this.End_Date = eDate;
            this.Hall = h;
        }
    }
    public class ExhibitionPregled
    {
        public int Exhibition_ID;
        public string Start_Date;
        public string End_Date;
        public int Hall;

        public ExhibitionPregled() { }
        public ExhibitionPregled(int eId, string sDate, string eDate, int h)
        {
            this.Exhibition_ID = eId;
            this.Start_Date = sDate;
            this.End_Date = eDate;
            this.Hall = h;
        }
    }

    #endregion

    #region Shown

    public class ShownPregled
    {
        public int Id;
        public ExhibitionBasic Exhibition;
      //  public ArtworkBasic Artwork;
      public ShownPregled() { }
      public ShownPregled(int i, ExhibitionBasic eb)
        {
            this.Id = i;
            this.Exhibition = eb;
        }


    }
    public class ShownBasic { 
        public int Id;
        public ExhibitionBasic Exhibition;
        //  public ArtworkBasic Artwork;
        public ShownBasic() { }
        public ShownBasic(int i, ExhibitionBasic eb)
        {
            this.Id = i;
            this.Exhibition = eb;
        }


    }
    #endregion

    #region Rent
    public class RentPregled
    {
        public RentID Id;

        public int Rental_Price;
        public string R_StartDate;
        public string R_EndDate;

        public RentPregled()
        {

        }

        public RentPregled(RentID id,int price,string sdate,string edate)
        {
            this.Rental_Price = price;
            this.Id = id;
            this.R_StartDate = sdate;
            this.R_EndDate = edate;
        }
    }
    public class RentBasic
    {
        public RentIDBasic Id;

        public int Rental_Price;
        public string R_StartDate;
        public string R_EndDate;

        public RentBasic()
        {

        }

        public RentBasic(RentIDBasic id, int price, string sdate, string edate)
        {
            this.Rental_Price = price;
            this.Id = id;
            this.R_StartDate = sdate;
            this.R_EndDate = edate;
        }
    }

    public class RentIDBasic
    {
        public CustomerBasic Customer { get; set; }
        public ArtworkBasic Artwork { get; set; }
        public RentIDBasic()
        {

        }
    }
    #endregion

    #region Artwork
    public class ArtworkBasic
    {
        public int Artwork_ID { get; set; }
        public string Title { get; set; }
        public string Style { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public string Drawn_on { get; set; }
        public string Material { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int Price { get; set; }
        public virtual IList<ExhibitionBasic> Exhibitions { get; set; }
        public ArtistBasic Artist { get; set; }
        public CustomerBasic Customer { get; set; }
        public virtual IList<RentBasic> Rent { get; set; }

        public ArtworkBasic()
        {
            Exhibitions = new List<ExhibitionBasic>();
            Rent = new List<RentBasic>();
        }

        public ArtworkBasic(int id,string title,string style,int year, string type, string drawn,string m,double w,double h)
        {
            this.Artwork_ID = id;
            this.Title = title;
            this.Style = style;
            this.Year = year;
            this.Type = type;
            this.Drawn_on = drawn;
            this.Material = m;
            this.Weight = w;
            this.Height = h;

        }
    }
    public class ArtworkPregled
    {
        public int Artwork_ID { get; set; }
        public string Title { get; set; }
        public string Style { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public string Drawn_on { get; set; }
        public string Material { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int Price { get; set; }
        public ArtistBasic Artist { get; set; }
        public CustomerBasic Customer { get; set; }

        public ArtworkPregled()
        { }

        public ArtworkPregled(int id, string title, string style, int year, string type, string drawn, string m, double w, double h)
        {
            this.Artwork_ID = id;
            this.Title = title;
            this.Style = style;
            this.Year = year;
            this.Type = type;
            this.Drawn_on = drawn;
            this.Material = m;
            this.Weight = w;
            this.Height = h;

        }
    }
    #endregion
}
