using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable()]
    public class Book
    {


        [XmlIgnore]
        public DateTime PublishDate { get; set; }

        [XmlIgnore]
        public DateTime RegistrationDate { get; set; }



        [XmlElement("isbn")]
        public string Isbn { get; set; }

        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlElement("author")]
        public string Author { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("genre")]
        public Genre Genre { get; set; }

        [XmlElement("publisher")]
        public string Publisher { get; set; }

        [XmlElement("publish_date")]
        public string PublishDateStr
        {
            get { return this.PublishDate.ToString("yyyy-MM-dd"); }
            set { this.PublishDate = DateTime.Parse(value); }
        }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("registration_date")]
        public string RegistrationDateStr
        {
            get { return this.RegistrationDate.ToString("yyyy-MM-dd"); }
            set { this.RegistrationDate = DateTime.Parse(value); }
        }

    }

    [Serializable()]
    [XmlRoot("catalog", Namespace = "http://library.by/catalog")]
    public class Catalog
    {
        [XmlIgnore]
        public DateTime Date { get; set; }

        private List<Book> _books;

        [XmlElement("book")]
        public List<Book> Books
        {
            get { return _books; }
            set { _books = value; }
        }

        [XmlAttribute("date")]
        public string DateString
        {
            get { return this.Date.ToString("yyyy-MM-dd"); }
            set { this.Date = DateTime.Parse(value); }
        }

    }

    public enum Genre
    {
        [XmlEnum(Name="Computer")]
        Computer,
        [XmlEnum(Name = "Science Fiction")]
        ScienceFiction,
        [XmlEnum(Name = "Horror")]
        Horror,
        [XmlEnum(Name = "Romance")]
        Romance,
        [XmlEnum(Name = "Fantasy")]
        Fantasy
    }
}
