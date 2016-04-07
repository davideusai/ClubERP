using System;
using System.Collections.Generic;

namespace ClubERP.DevTests
{
    class Program
    {
        static void Main(string[] args)
        {
            // ** State ** //
            //List<DAO.State> stateList = new List<DAO.State>();
            //BLL.State objLoader = new BLL.State();
            //stateList = objLoader.List();
            //DAO.State state = new DAO.State();
            //state = objLoader.Detail("active");

            // ** Role ** //
            //List<DAO.Role> roleList = new List<DAO.Role>();
            //roleList = ORM.Role.List();
            //DAO.Role role = new DAO.Role();
            //role = ORM.Role.Detail("CDB");

            // ** Skypper Rank ** //
            //List<DAO.SkypperRank> rankList = new List<DAO.SkypperRank>();
            //BLL.SkypperRank objLoader = new BLL.SkypperRank();
            //rankList = objLoader.List();
            //DAO.SkypperRank rank = new DAO.SkypperRank();
            //rank = objLoader.Detail("COT");

            // ** Sailing Mode ** //
            //List<DAO.SailingMode> modeList = new List<DAO.SailingMode>();
            //BLL.SailingMode objLoader = new BLL.SailingMode();
            //modeList = objLoader.List();
            //DAO.SailingMode mode = new DAO.SailingMode();
            //mode = objLoader.Detail("fo");

            // ** Payment Mode ** //
            //List<DAO.PaymentMode> modeList = new List<DAO.PaymentMode>();
            //modeList = ORM.PaymentMode.List();
            //DAO.PaymentMode mode = new DAO.PaymentMode();
            //mode = ORM.PaymentMode.Detail("PP");





            // ** Boat ** //
            //List<DAO.Boat> boatList = new List<DAO.Boat>();
            //BLL.Boat objLoader = new BLL.Boat();
            //boatList = objLoader.List();
            //DAO.Boat boat = new DAO.Boat();
            //boat = objLoader.Load("nnd2");

            // ** Port ** //
            //List<DAO.Port> portList = new List<DAO.Port>();
            //portList = ORM.Port.List();
            //DAO.Port port = new DAO.Port();
            //port = ORM.Port.Detail("CROUESTY");

            // ** User ** //
            //List<DAO.User> userList = new List<DAO.User>();
            //userList = ORM.User.List();
            //DAO.User user = new DAO.User();
            //user = ORM.User.Detail(13);

            // ** Sail ** //
            //List<DAO.Sail> sailList = new List<DAO.Sail>();
            //sailList = ORM.Sail.List();
            DAO.Crew crew = new DAO.Crew();
            //crew.User.Id = 1;
            //crew.Role.Id = "CDB";
            //crew.State.Id = "A";
            //crew.TimeStamp = DateTime.Now;
            //ORM.Sail.AddCrew(1, crew);
            //List<DAO.Crew> crewList = new List<DAO.Crew>();
            //crewList = ORM.Sail.CrewList(1);
            //sailList = ORM.Sail.Search("KNLKR3");
            crew = ORM.Crew.Detail(1);
        }
    }
}
