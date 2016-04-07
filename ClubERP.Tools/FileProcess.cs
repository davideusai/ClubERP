using System;
using System.IO;
using System.Text;
using System.Xml;

namespace ClubERP.Tools
{
    public class FileProcess
    {
        public static void ProcessState(string fileName)
        {
            StreamReader source;
            XmlDocument document;
            XmlNodeList entries;
            source = new StreamReader(fileName, Encoding.GetEncoding(1252));
            document = new XmlDocument();
            document.Load(source);
            entries = document.GetElementsByTagName("state");
            foreach (XmlElement entry in entries)
            {
                DAO.State state = new DAO.State();

                state.Id = entry.GetElementsByTagName("id")[0].InnerText;
                state.Name = entry.GetElementsByTagName("name")[0].InnerText;
                state.Description = entry.GetElementsByTagName("description")[0].InnerText;
                state.Family = entry.GetElementsByTagName("family")[0].InnerText;
                state.TimeStamp = Convert.ToDateTime(entry.GetElementsByTagName("timeStamp")[0].InnerText);
                ORM.State.Save(state);
            }
        }
        public static void ProcessRole(string fileName)
        {
            StreamReader source;
            XmlDocument document;
            XmlNodeList entries;
            source = new StreamReader(fileName, Encoding.GetEncoding(1252));
            document = new XmlDocument();
            document.Load(source);
            entries = document.GetElementsByTagName("role");
            foreach (XmlElement entry in entries)
            {
                DAO.Role role = new DAO.Role();
                role.Id = entry.GetElementsByTagName("id")[0].InnerText;
                role.Name = entry.GetElementsByTagName("name")[0].InnerText;
                role.Description = entry.GetElementsByTagName("description")[0].InnerText;
                role.State.Id = entry.GetElementsByTagName("stateId")[0].InnerText;
                role.TimeStamp = Convert.ToDateTime(entry.GetElementsByTagName("timeStamp")[0].InnerText);
                ORM.Role.Save(role);
            }
        }
        public static void ProcessSkypperRank(string fileName)
        {
            StreamReader source;
            XmlDocument document;
            XmlNodeList entries;
            source = new StreamReader(fileName, Encoding.GetEncoding(1252));
            document = new XmlDocument();
            document.Load(source);
            entries = document.GetElementsByTagName("rank");
            foreach (XmlElement entry in entries)
            {
                DAO.SkypperRank rank = new DAO.SkypperRank();
                rank.Id = entry.GetElementsByTagName("id")[0].InnerText;
                rank.Name = entry.GetElementsByTagName("name")[0].InnerText;
                rank.Description = entry.GetElementsByTagName("description")[0].InnerText;
                rank.Position = Convert.ToInt16(entry.GetElementsByTagName("position")[0].InnerText);
                rank.State.Id = entry.GetElementsByTagName("stateId")[0].InnerText;
                rank.TimeStamp = Convert.ToDateTime(entry.GetElementsByTagName("timeStamp")[0].InnerText);
                ORM.SkypperRank.Save(rank);
            }
        }
        public static void ProcessBoat(string fileName)
        {
            StreamReader source;
            XmlDocument document;
            XmlNodeList entries;
            source = new StreamReader(fileName, Encoding.GetEncoding(1252));
            document = new XmlDocument();
            document.Load(source);
            entries = document.GetElementsByTagName("boat");
            foreach (XmlElement entry in entries)
            {
                DAO.Boat boat = new DAO.Boat();
                boat.Id = entry.GetElementsByTagName("id")[0].InnerText;
                boat.Name = entry.GetElementsByTagName("name")[0].InnerText;
                boat.Description = entry.GetElementsByTagName("description")[0].InnerText;
                boat.DateBuild = Convert.ToDateTime(entry.GetElementsByTagName("dateBuild")[0].InnerText);
                boat.DateEntryClub = Convert.ToDateTime(entry.GetElementsByTagName("dateEntryClub")[0].InnerText);
                boat.CrewMax = Convert.ToInt16(entry.GetElementsByTagName("crewMax")[0].InnerText);
                boat.Photo = entry.GetElementsByTagName("photo")[0].InnerText;
                boat.MinSkypperRank.Id = entry.GetElementsByTagName("minSkypperRankId")[0].InnerText;
                boat.State.Id = entry.GetElementsByTagName("stateId")[0].InnerText;
                boat.TimeStamp = Convert.ToDateTime(entry.GetElementsByTagName("timeStamp")[0].InnerText);
                ORM.Boat.Save(boat);
            }
        }   
        public static void ProcessSailingMode(string fileName)
        {
            StreamReader source;
            XmlDocument document;
            XmlNodeList entries;
            source = new StreamReader(fileName, Encoding.GetEncoding(1252));
            document = new XmlDocument();
            document.Load(source);
            entries = document.GetElementsByTagName("mode");
            foreach (XmlElement entry in entries)
            {
                DAO.SailingMode mode = new DAO.SailingMode();
                mode.Id = entry.GetElementsByTagName("id")[0].InnerText;
                mode.Name = entry.GetElementsByTagName("name")[0].InnerText;
                mode.Description = entry.GetElementsByTagName("description")[0].InnerText;
                mode.State.Id = entry.GetElementsByTagName("stateId")[0].InnerText;
                mode.TimeStamp = Convert.ToDateTime(entry.GetElementsByTagName("timeStamp")[0].InnerText);
                ORM.SailingMode.Save(mode);
            }
        }
        public static void ProcessPaymentMode(string fileName)
        {
            StreamReader source;
            XmlDocument document;
            XmlNodeList entries;
            source = new StreamReader(fileName, Encoding.GetEncoding(1252));
            document = new XmlDocument();
            document.Load(source);
            entries = document.GetElementsByTagName("mode");
            foreach (XmlElement entry in entries)
            {
                DAO.PaymentMode mode = new DAO.PaymentMode();
                mode.Id = entry.GetElementsByTagName("id")[0].InnerText;
                mode.Name = entry.GetElementsByTagName("name")[0].InnerText;
                mode.Description = entry.GetElementsByTagName("description")[0].InnerText;
                mode.State.Id = entry.GetElementsByTagName("stateId")[0].InnerText;
                mode.TimeStamp = Convert.ToDateTime(entry.GetElementsByTagName("timeStamp")[0].InnerText);
                ORM.PaymentMode.Save(mode);
            }
        }
        public static void ProcessPort(string fileName)
        {
            StreamReader source;
            XmlDocument document;
            XmlNodeList entries;
            source = new StreamReader(fileName, Encoding.GetEncoding(1252));
            document = new XmlDocument();
            document.Load(source);
            entries = document.GetElementsByTagName("port");
            foreach (XmlElement entry in entries)
            {
                DAO.Port port = new DAO.Port();
                port.Id = entry.GetElementsByTagName("id")[0].InnerText;
                port.Name = entry.GetElementsByTagName("name")[0].InnerText;
                port.Description = entry.GetElementsByTagName("description")[0].InnerText;
                port.Photo = entry.GetElementsByTagName("photo")[0].InnerText;
                port.Url = entry.GetElementsByTagName("url")[0].InnerText;
                port.Latitude = Convert.ToDecimal(entry.GetElementsByTagName("latitude")[0].InnerText.Replace(".", ","));
                port.Longitude = Convert.ToDecimal(entry.GetElementsByTagName("longitude")[0].InnerText.Replace(".", ","));
                port.City = entry.GetElementsByTagName("city")[0].InnerText;
                port.State.Id = entry.GetElementsByTagName("stateId")[0].InnerText;
                port.TimeStamp = Convert.ToDateTime(entry.GetElementsByTagName("timeStamp")[0].InnerText);
                ORM.Port.Save(port);
            }
        }
        public static void ProcessUser(string fileName)
        {
            StreamReader source;
            XmlDocument document;
            XmlNodeList entries;
            source = new StreamReader(fileName, Encoding.GetEncoding(1252));
            document = new XmlDocument();
            document.Load(source);
            entries = document.GetElementsByTagName("user");
            foreach (XmlElement entry in entries)
            {
                DAO.User user = new DAO.User();
                user.UserName = entry.GetElementsByTagName("userName").Item(0).InnerText;
                user.FirstName = entry.GetElementsByTagName("firstName").Item(0).InnerText;
                user.LastName = entry.GetElementsByTagName("lastName").Item(0).InnerText;
                user.eMail = entry.GetElementsByTagName("adressMail").Item(0).InnerText;
                user.PhoneNumber = entry.GetElementsByTagName("phoneNumber").Item(0).InnerText;
                user.SkypperRank.Id = entry.GetElementsByTagName("skypperRankId").Item(0).InnerText;
                user.IdentityId = entry.GetElementsByTagName("identityId").Item(0).InnerText;
                user.State.Id = entry.GetElementsByTagName("stateId").Item(0).InnerText;
                user.TimeStamp = Convert.ToDateTime(entry.GetElementsByTagName("timeStamp").Item(0).InnerText);
                ORM.User.Save(user);
            }
        }

        public static void ProcessSail(string fileName)
        {
            StreamReader source;
            XmlDocument document;
            XmlNodeList entries;
            source = new StreamReader(fileName, Encoding.GetEncoding(1252));
            document = new XmlDocument();
            document.Load(source);
            entries = document.GetElementsByTagName("sail");
            foreach (XmlElement entry in entries)
            {
                DAO.Sail sail = new DAO.Sail();
                sail.ArrivalDate = Convert.ToDateTime(entry.GetElementsByTagName("arrivalDate").Item(0).InnerText);
                sail.DepartureDate = Convert.ToDateTime(entry.GetElementsByTagName("departureDate").Item(0).InnerText);
                sail.ArrivalPort.Id = entry.GetElementsByTagName("arrivalPortId").Item(0).InnerText;
                sail.DeparturePort.Id = entry.GetElementsByTagName("departurePortId").Item(0).InnerText;
                sail.Boat.Id = entry.GetElementsByTagName("boatId").Item(0).InnerText;
                sail.SailingMode.Id = entry.GetElementsByTagName("sailingModeId").Item(0).InnerText;
                sail.Price = Convert.ToDecimal(entry.GetElementsByTagName("price").Item(0).InnerText);
                sail.Commentary = entry.GetElementsByTagName("commentary").Item(0).InnerText;
                sail.State.Id = entry.GetElementsByTagName("stateId").Item(0).InnerText;
                sail.TimeStamp = Convert.ToDateTime(entry.GetElementsByTagName("timeStamp").Item(0).InnerText);
                ORM.Sail.Save(sail);
            }
        }



    }
}