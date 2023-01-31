using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;
using ArtGallery.Entities;
using NHibernate;
using System.Windows.Forms;
namespace ArtGallery
{
    public class DTOManager
    {
        public static int h;
        #region Artist

        public static List<ArtistPregled> getArtistFromFilter(bool f,string finding)
        {
            List<ArtistPregled> artistsFind = new List<ArtistPregled>();
            IEnumerable<ArtGallery.Entities.Artist> artists;
            try
            {
                ISession s = DataLayer.GetSession();

                if (f) { artists= from o in s.Query<ArtGallery.Entities.Artist>()
                                                                             where o.Last_Name==finding
                                                                   select o; }
                else
                {
                     artists = from o in s.Query<ArtGallery.Entities.Artist>()
                                                                        where o.Name == finding
                                                                        select o;
                }

                foreach (ArtGallery.Entities.Artist p in artists)
                {
                    artistsFind.Add(new ArtistPregled(p.Artist_ID, p.Name, p.Last_Name, p.City, p.BirthDate, p.Country));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
            return artistsFind; 

        }
            public static List<ArtistPregled> getArtists()
             {
            List<ArtistPregled> artists = new List<ArtistPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ArtGallery.Entities.Artist> allOfArtist = from o in s.Query<ArtGallery.Entities.Artist>()
                                                                      select o;

                foreach (ArtGallery.Entities.Artist p in allOfArtist)
                {
                    artists.Add(new ArtistPregled(p.Artist_ID, p.Name, p.Last_Name, p.City, p.BirthDate, p.Country));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return artists;
             }

        public static void addArtist(ArtistBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ArtGallery.Entities.Artist o = new ArtGallery.Entities.Artist();

                o.Name = p.Name;
                o.Last_Name = p.Last_Name;
                o.BirthDate = p.BirthDate;
                o.City = p.City;
                o.Country = p.Country;

                h=(int)s.Save(o);

                s.Flush();
                
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static ArtistBasic updateArtist(ArtistBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ArtGallery.Entities.Artist o = new ArtGallery.Entities.Artist();

                o.Name = p.Name;
                o.Last_Name = p.Last_Name;
                o.BirthDate = p.BirthDate;
                o.City = p.City;
                o.Country = p.Country;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return p;
        }

        public static ArtistBasic getArtist(int id)
        {
            ArtistBasic pb = new ArtistBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                ArtGallery.Entities.Artist o = s.Load<ArtGallery.Entities.Artist>(id);
                pb = new ArtistBasic(o.Artist_ID, o.Name, o.Last_Name, o.City, o.BirthDate, o.Country);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static void deleteArtist(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ArtGallery.Entities.Artist o = s.Load<ArtGallery.Entities.Artist>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        #endregion

        #region Exhibition
        public static List<ExhibitionPregled> getExhibitions()
        {
            List<ExhibitionPregled> exhib = new List<ExhibitionPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ArtGallery.Entities.Exhibition> allOfExhibition = from o in s.Query<ArtGallery.Entities.Exhibition>()
                                                                              select o;

                foreach (ArtGallery.Entities.Exhibition p in allOfExhibition)
                {
                    exhib.Add(new ExhibitionPregled(p.Exhibition_ID, p.Start_Date, p.End_Date, p.Hall));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return exhib;
        }
        public static int addExhibition(ExhibitionBasic p)
        {
            int k=0;
            try
            {
                ISession s = DataLayer.GetSession();

                ArtGallery.Entities.Exhibition o = new ArtGallery.Entities.Exhibition();

                o.Hall = p.Hall;
                o.Start_Date = p.Start_Date;
                o.End_Date = p.End_Date;

              k=Int32.Parse( s.Save(o).ToString());

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
            return k;
        }

        public static ExhibitionBasic updateExhibition(ExhibitionBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ArtGallery.Entities.Exhibition o = new ArtGallery.Entities.Exhibition();

                o.Hall = p.Hall;
                o.Start_Date = p.Start_Date;
                o.End_Date = p.End_Date;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return p;
        }
        public static ExhibitionBasic getExhibition(int id)
        {
            ExhibitionBasic pb = new ExhibitionBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                ArtGallery.Entities.Exhibition o = s.Load<ArtGallery.Entities.Exhibition>(id);
                pb = new ExhibitionBasic(o.Exhibition_ID, o.Start_Date, o.End_Date, o.Hall);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static void deleteExhibition(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ArtGallery.Entities.Exhibition o = s.Load<ArtGallery.Entities.Exhibition>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        #endregion

        #region Customer
        public static List<CustomerPregled> getCustomerFromFilter(string filter, string finding)
        {
            List<CustomerPregled> customersFind = new List<CustomerPregled>();
            IEnumerable<ArtGallery.Entities.Customer> customers=null;
            try
            {
                ISession s = DataLayer.GetSession();

                switch (filter)
                {
                    case "Name":
                        customers = from o in s.Query<ArtGallery.Entities.Customer>()
                                  where o.CustomerName == finding
                                  select o;
                        break;
                    case "Last Name":
                        customers=from o in s.Query<ArtGallery.Entities.Customer>()
                                  where o.CustomerLastName == finding
                                  select o;
                        break;
                    case "Email":
                        customers = from o in s.Query<ArtGallery.Entities.Customer>()
                                    where o.CustomerEmail == finding
                                    select o;
                        break;
                    case "Address":
                        customers = from o in s.Query<ArtGallery.Entities.Customer>()
                                    where o.CustomerAddress== finding
                                    select o;
                        break;
                }
                

                foreach (ArtGallery.Entities.Customer p in customers)
                {
                    customersFind.Add(new CustomerPregled(p.Customer_ID, p.CustomerName, p.CustomerLastName, p.CustomerEmail, p.CustomerAddress));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
            return customersFind;

        }
        public static List<CustomerPregled> getCustomers()
        {
            List<CustomerPregled> exhib = new List<CustomerPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ArtGallery.Entities.Customer> allOfCustomer = from o in s.Query<ArtGallery.Entities.Customer>()
                                                                              select o;

                foreach (ArtGallery.Entities.Customer p in allOfCustomer)
                {
                    exhib.Add(new CustomerPregled(p.Customer_ID,p.CustomerName,p.CustomerLastName,p.CustomerEmail,p.CustomerAddress));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return exhib;
        }
        public static void addCustomer(CustomerBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ArtGallery.Entities.Customer o = new ArtGallery.Entities.Customer();

                o.CustomerName = p.CustomerName;
                o.CustomerLastName = p.CustomerLastName;
                o.CustomerEmail = p.CustomerEmail;
                o.CustomerAddress = p.CustomerAddress;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static CustomerBasic updateCustomer(CustomerBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ArtGallery.Entities.Customer o = new ArtGallery.Entities.Customer();

                o.CustomerName = p.CustomerName;
                o.CustomerLastName = p.CustomerLastName;
                o.CustomerEmail = p.CustomerEmail;
                o.CustomerAddress = p.CustomerAddress;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return p;
        }
        public static CustomerBasic getCustomer(int id)
        {
            CustomerBasic pb = new CustomerBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                ArtGallery.Entities.Customer o = s.Load<ArtGallery.Entities.Customer>(id);
                pb = new CustomerBasic(o.Customer_ID, o.CustomerName, o.CustomerLastName, o.CustomerEmail, o.CustomerAddress);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static void deleteCustomer(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ArtGallery.Entities.Customer o = s.Load<ArtGallery.Entities.Customer>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        #endregion

        #region Artworks
        public static void SaveArtworkForArtist(ArtworkBasic p,bool x)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ArtGallery.Entities.Artwork o = new ArtGallery.Entities.Artwork();

                if (x)
                {
                    o.Drawn_on = p.Drawn_on;
                }
                else
                {
                    o.Height = p.Height;
                    o.Material = p.Material;
                    o.Weight = p.Weight;
                }
                o.Price = p.Price;
                o.Style = p.Style;
                o.Title = p.Title;
                o.Type = p.Type;
                o.Year = p.Year;

                ArtGallery.Entities.Artist r = s.Load<ArtGallery.Entities.Artist>(p.Artist.Artist_ID);
                o.Artist = r;


                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static List<ArtworkPregled> getArtworksFromExhibition(int EID)
        {
            List<ArtworkPregled> artworks = new List<ArtworkPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ArtGallery.Entities.Shown> allOfShown = from o in s.Query<ArtGallery.Entities.Shown>()
                                                                        where o.Exhibition.Exhibition_ID==EID
                                                                        select o;

                foreach (ArtGallery.Entities.Shown p in allOfShown)
                {
                    Artwork k = s.Load<ArtGallery.Entities.Artwork>(p.Artwork.Artwork_ID);
                    artworks.Add(new ArtworkPregled(k.Artwork_ID, k.Title, k.Style, k.Year,k.Type, k.Drawn_on, k.Material,k.Weight,k.Height));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return artworks;
        }
        public static void SaveArtworkandArtist(ArtworkBasic p,ArtistBasic k,bool x)
        {
            ISession s = DataLayer.GetSession();

            ArtGallery.Entities.Artwork o = new ArtGallery.Entities.Artwork();

            if (x)
            {
                o.Drawn_on = p.Drawn_on;
            }
            else
            {
                o.Height = p.Height;
                o.Material = p.Material;
                o.Weight = p.Weight;
            }
            o.Price = p.Price;
            o.Style = p.Style;
            o.Title = p.Title;
            o.Type = p.Type;
            o.Year = p.Year;


            addArtist(k);
            ArtGallery.Entities.Artist r = s.Load<ArtGallery.Entities.Artist>(h);
            o.Artist = r;


            s.Save(o);

            s.Flush();

            s.Close();
        }
        public static List<ArtworkPregled> getArtworksFromArtist(int AID)
        {
            List<ArtworkPregled> artworks = new List<ArtworkPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ArtGallery.Entities.Artwork> allOfArtwork = from o in s.Query<ArtGallery.Entities.Artwork>()
                                                                        where o.Artist.Artist_ID==AID
                                                                        select o;

                foreach (ArtGallery.Entities.Artwork p in allOfArtwork)
                {
                    artworks.Add(new ArtworkPregled(p.Artwork_ID, p.Title, p.Style, p.Year, p.Type, p.Drawn_on, p.Material, p.Weight, p.Height));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return artworks;
        }
        public static List<ArtworkPregled> getArtworksOverlap2(DateTime s1, DateTime e1)
        {
            List<ArtworkPregled> artworks = new List<ArtworkPregled>();
            try
            {

                ISession s = DataLayer.GetSession();
                ISQLQuery q = s.CreateSQLQuery("select o.* from artwork o where o.artwork_id not in"
                    +"(select s.artwork_id from shown s inner join exhibition e on e.exhibition_id = s.exhibition_id where (e.Start_Date <= :e1 and  e.END_DATE >= :s1))"); ;

                /*IQuery q = s.CreateQuery("select o from Artwork o inner join Rent k  "+" on o.Artwork_ID = k.Artwork_ID"
                        + " and not(DATE(k.R_StartDate) <= :e1 and k.R_EndDate >= :s1 )" );*/
                q.SetParameter("e1", e1.Date);
                q.SetParameter("s1", s1.Date);
                q.AddEntity(typeof(Artwork));
                IList<Artwork> allOfArtwork = q.List<Artwork>();

                foreach (Artwork p in allOfArtwork)
                {
                    artworks.Add(new ArtworkPregled(p.Artwork_ID, p.Title, p.Style, p.Year, p.Type, p.Drawn_on, p.Material, p.Weight, p.Height));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return artworks;
        }
        public static List<ArtworkPregled> getArtworksOverlap(DateTime s1,DateTime e1)
        {
            List<ArtworkPregled> artworks = new List<ArtworkPregled>();
            try
            {

                ISession s = DataLayer.GetSession();
                ISQLQuery q = s.CreateSQLQuery("select o.* from Artwork o, Rent r minus select o.* from Artwork o inner JOIN Rent r on o.Artwork_ID = r.Artwork_ID and (r.R_StartDate <= :e1 and r.R_ENDDATE >= :s1)  ");;
               
                /*IQuery q = s.CreateQuery("select o from Artwork o inner join Rent k  "+" on o.Artwork_ID = k.Artwork_ID"
                        + " and not(DATE(k.R_StartDate) <= :e1 and k.R_EndDate >= :s1 )" );*/ 
                q.SetParameter("e1", e1.Date);
                q.SetParameter("s1",s1.Date);
                q.AddEntity(typeof(Artwork));
                IList<Artwork> allOfArtwork = q.List<Artwork>();

                foreach (Artwork p in allOfArtwork)
                {
                    artworks.Add(new ArtworkPregled(p.Artwork_ID, p.Title, p.Style, p.Year, p.Type, p.Drawn_on, p.Material, p.Weight, p.Height));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return artworks;
        }
        public static List<ArtworkBasic> getArtworksFromCustomer(int CID)
        {
            List<ArtworkBasic> artworks = new List<ArtworkBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ArtGallery.Entities.Artwork> allOfArtwork = from o in s.Query<ArtGallery.Entities.Artwork>()
                                                                        where o.Customer.Customer_ID==CID
                                                                        select o;

                foreach (ArtGallery.Entities.Artwork p in allOfArtwork)
                {
                    artworks.Add(new ArtworkBasic(p.Artwork_ID, p.Title, p.Style, p.Year, p.Type, p.Drawn_on, p.Material, p.Weight, p.Height));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return artworks;
        }
        public static List<ArtworkPregled> getArtworks()
        {
            List<ArtworkPregled> artworks = new List<ArtworkPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ArtGallery.Entities.Artwork> allOfArtwork = from o in s.Query<ArtGallery.Entities.Artwork>()
                                                                      select o;

                foreach (ArtGallery.Entities.Artwork p in allOfArtwork)
                {
                    artworks.Add(new ArtworkPregled(p.Artwork_ID, p.Title,p.Style, p.Year,  p.Type, p.Drawn_on,p.Material,p.Weight,p.Height));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return artworks;
        }
        public static ArtworkBasic getArtwork(int id)
        {
            ArtworkBasic pb = new ArtworkBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                ArtGallery.Entities.Artwork o = s.Load<ArtGallery.Entities.Artwork>(id);
                pb = new ArtworkBasic(o.Artwork_ID, o.Title, o.Style, o.Year, o.Type, o.Drawn_on, o.Material, o.Weight, o.Height);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static List<ArtworkPregled> getPaintings()
        {
            List<ArtworkPregled> artworks = new List<ArtworkPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ArtGallery.Entities.Artwork> allOfArtwork = from o in s.Query<ArtGallery.Entities.Artwork>()
                                                                        where o.Type == "painting"
                                                                        select o;

                foreach (ArtGallery.Entities.Artwork p in allOfArtwork)
                {
                    artworks.Add(new ArtworkPregled(p.Artwork_ID, p.Title, p.Style, p.Year, p.Type, p.Drawn_on, p.Material, p.Weight, p.Height));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return artworks;
        }

        public static List<ArtworkPregled> getSculptures()
        {
            List<ArtworkPregled> artworks = new List<ArtworkPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ArtGallery.Entities.Artwork> allOfArtwork = from o in s.Query<ArtGallery.Entities.Artwork>()
                                                                        where o.Type == "sculpture"
                                                                        select o;

                foreach (ArtGallery.Entities.Artwork p in allOfArtwork)
                {
                    artworks.Add(new ArtworkPregled(p.Artwork_ID, p.Title, p.Style, p.Year, p.Type, p.Drawn_on, p.Material, p.Weight, p.Height));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return artworks;
        }

        public static void addArtwork(ArtworkBasic p,bool x)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ArtGallery.Entities.Artwork o = new ArtGallery.Entities.Artwork();
                if (x)
                {
                    o.Drawn_on = p.Drawn_on;
                }
                else
                {
                    o.Height = p.Height;
                    o.Material = p.Material;
                    o.Weight = p.Weight;
                }
                o.Price = p.Price;
                o.Style = p.Style;
                o.Title = p.Title;
                o.Type = p.Type;
                o.Year = p.Year;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void deleteArtwork(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ArtGallery.Entities.Artwork o = s.Load<ArtGallery.Entities.Artwork>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        #endregion

        #region Rent

        public static void addRent(RentBasic rent)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Rent r = new Rent();
                r.Id = new RentID();
                r.Id.Artwork = s.Load<ArtGallery.Entities.Artwork>(rent.Id.Artwork.Artwork_ID);
                r.Id.Customer = s.Load<Customer>(rent.Id.Customer.Customer_ID);
                r.R_StartDate = rent.R_StartDate;
                r.R_EndDate = rent.R_EndDate;

                s.SaveOrUpdate(r);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }

        public static List<RentBasic> getRentWithCID(int CID)
        {
            List<RentBasic> rent = new List<RentBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Rent> allOfRent = from o in s.Query<Rent>()
                                         where o.Id.Customer.Customer_ID==CID
                                         select o;

                foreach (Rent p in allOfRent)
                {
                    ArtworkBasic art = DTOManager.getArtwork(p.Id.Artwork.Artwork_ID);
                    CustomerBasic cu = DTOManager.getCustomer(CID);
                    rent.Add(new RentBasic(new RentIDBasic(cu, art), p.Rental_Price, p.R_StartDate, p.R_EndDate));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return rent;
        }
        #endregion

        #region Shown 

        public static void addShown(ShownBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ArtGallery.Entities.Shown a = new ArtGallery.Entities.Shown();

                a.Artwork = s.Load<Artwork>(p.Artwork.Artwork_ID);
                a.Exhibition = s.Load<Exhibition>(p.Exhibition.Exhibition_ID);

                s.Save(a);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        public static List<ShownBasic> getArtworksFromEx(int EID)
        {
            List<ShownBasic> shown = new List<ShownBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Shown> proizvodi = from o in s.Query<ArtGallery.Entities.Shown>()
                                                   where o.Exhibition.Exhibition_ID == EID
                                                   select o;

                foreach (Shown p in proizvodi)
                {
                    ArtworkBasic proizvod = DTOManager.getArtwork(p.Artwork.Artwork_ID);
                    ExhibitionBasic odeljenje = DTOManager.getExhibition(p.Exhibition.Exhibition_ID);
                    shown.Add(new ShownBasic(p.Id, odeljenje,proizvod));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
            return shown;
        }

        #endregion
    }
}
