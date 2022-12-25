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
        #region Artist
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

                s.SaveOrUpdate(o);

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
        public static void addExhibition(ExhibitionBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ArtGallery.Entities.Exhibition o = new ArtGallery.Entities.Exhibition();

                o.Hall = p.Hall;
                o.Start_Date = p.Start_Date;
                o.End_Date = p.End_Date;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
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

        public static void addArtwork(ArtworkBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ArtGallery.Entities.Artwork o = new ArtGallery.Entities.Artwork();

                o.Drawn_on = p.Drawn_on;
                o.Height = p.Height;
                o.Material = p.Material;
                o.Price = p.Price;
                o.Style = p.Style;
                o.Title = p.Title;
                o.Type = p.Type;
                o.Weight = p.Weight;
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
        #endregion
    }
}
