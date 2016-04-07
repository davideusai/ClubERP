using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.Provisioning
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataDirectory = "I:\\alnilam\\GitHub\\ClubERP\\CMN\\data\\";
            string stateFileName = "State.xml";
            string roleFileName = "Role.xml";
            string skypperRankFileName = "SkypperRank.xml";
            string sailingModeFileName = "SailingMode.xml";
            string paymentModeFileName = "PaymentMode.xml";
            string boatFileName = "Boat.xml";
            string portFileName = "Port.xml";
            string userFileName = "User.xml";
            string sailFileName = "Sail.xml";
            
            string fileToProcess = "";

            fileToProcess = dataDirectory + stateFileName;
            Tools.FileProcess.ProcessState(fileToProcess);

            fileToProcess = dataDirectory + roleFileName;
            Tools.FileProcess.ProcessRole(fileToProcess);

            fileToProcess = dataDirectory + skypperRankFileName;
            Tools.FileProcess.ProcessSkypperRank(fileToProcess);

            fileToProcess = dataDirectory + sailingModeFileName;
            Tools.FileProcess.ProcessSailingMode(fileToProcess);

            fileToProcess = dataDirectory + paymentModeFileName;
            Tools.FileProcess.ProcessPaymentMode(fileToProcess);

            fileToProcess = dataDirectory + portFileName;
            Tools.FileProcess.ProcessPort(fileToProcess);

            fileToProcess = dataDirectory + boatFileName;
            Tools.FileProcess.ProcessBoat(fileToProcess);

            fileToProcess = dataDirectory + userFileName;
            Tools.FileProcess.ProcessUser(fileToProcess);

            //fileToProcess = dataDirectory + sailFileName;
            //Tools.FileProcess.ProcessSail(fileToProcess);
        }
    }
}
