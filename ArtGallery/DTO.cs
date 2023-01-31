using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtGallery.Entities;

namespace ArtGallery
{
    #region Artist

    public class ArtistBasic

    {
        public int Artist_ID;
        public string Name;
        public string Last_Name;
        public string City;
        public string BirthDate;
        public string Country;
        public virtual IList<ArtworkBasic> Artworks { get; set; }
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

            Artworks = new List<ArtworkBasic>();
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
        public virtual IList<PhoneNumberBasic> C_PhoneNumbers { get; set; }

        public virtual IList<ArtworkBasic> Artworks { get; set; }
        public virtual IList<RentBasic> Rent { get; set; }

        public CustomerBasic() { 
            Rent=new List<RentBasic>();
            C_PhoneNumbers = new List<PhoneNumberBasic>();
            Artworks = new List<ArtworkBasic>();
        }
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

    #region PhoneNumber

    public class PhoneNumberBasic
    {

        public int Id;
        public string Phone;
        public CustomerBasic Customer_ID;
        public PhoneNumberBasic() { }
        public PhoneNumberBasic(int i,string p,CustomerBasic cid) {
            this.Id = i;
            this.Phone = p;
            this.Customer_ID = cid;
        }
    }
    public class PhoneNumberPregled
    {

        public int Id;
        public string Phone;
        public CustomerBasic Customer_ID;
        public PhoneNumberPregled() { }
        public PhoneNumberPregled(int i, string p, CustomerBasic cid)
        {
            this.Id = i;
            this.Phone = p;
            this.Customer_ID = cid;
        }
    }

    #endregion

    #region Exhibition

    public class ExhibitionBasic {
        public int Exhibition_ID;
        public DateTime Start_Date;
        public DateTime End_Date;
        public int Hall; 

        public virtual IList<ArtworkBasic> Artworks { get; set; }
        public ExhibitionBasic() {
            Artworks = new List<ArtworkBasic>();
        }
        public ExhibitionBasic(int eId, DateTime sDate, DateTime eDate,int h)
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
        public DateTime Start_Date;
        public DateTime End_Date;
        public int Hall;

        public ExhibitionPregled() { }
        public ExhibitionPregled(int eId, DateTime sDate, DateTime eDate, int h)
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
        public ArtworkBasic Artwork;
        public ShownPregled() { }
        public ShownPregled(int i, ExhibitionBasic eb, ArtworkBasic art)
        {
            this.Id = i;
            this.Exhibition = eb;
            this.Artwork = art;
        }


    }
    public class ShownBasic { 
        public int Id;
        public ExhibitionBasic Exhibition;
        public ArtworkBasic Artwork;
        public ShownBasic() { }
        public ShownBasic(int i, ExhibitionBasic eb, ArtworkBasic art)
        {
            this.Id = i;
            this.Exhibition = eb;
            this.Artwork = art;
        }


    }
    #endregion

    #region Rent
    public class RentPregled
    {
        public RentID Id;

        public int Rental_Price;
        public DateTime R_StartDate;
        public DateTime R_EndDate;

        public RentPregled()
        {

        }

        public RentPregled(RentID id,int price,DateTime sdate,DateTime edate)
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
        public DateTime R_StartDate;
        public DateTime R_EndDate;

        public RentBasic()
        {

        }

        public RentBasic(RentIDBasic id, int price, DateTime sdate, DateTime edate)
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
        public RentIDBasic(CustomerBasic c,ArtworkBasic a)
        {
            Customer = c;
            Artwork = a;
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

        public ArtworkBasic(int id,string title,string style,int year, string type, string drawn,string m,double w,double h,ArtistBasic art,CustomerBasic cu)
        {
            this.Customer=cu;
            this.Artist =art;
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
        public ArtworkBasic(int id, string title, string style, int year, string type, string drawn, string m, double w, double h, ArtistBasic art)
        {
            this.Artist = art;
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
        public ArtworkBasic(int id, string title, string style, int year, string type, string drawn, string m, double w, double h)
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
        public ArtworkPregled(int id, string title, string style, int year, string type, string drawn, string m, double w, double h,CustomerBasic cu)
        {
            this.Customer = cu;
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
