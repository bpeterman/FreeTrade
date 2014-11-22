using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FreeTradeWindowsForms.Models;

namespace FreeTradeWindowsForms.Controllers
{
    static class LoginController
    {
        public static User Login(string username, string password)
        {
            //Construct the filepath
            string filepath = Directory.GetCurrentDirectory() + "\\" + username + ".txt";
            // User already exists
            if (File.Exists(filepath))
            {
                System.Xml.Serialization.XmlSerializer reader =
                    new System.Xml.Serialization.XmlSerializer(typeof(User));
                System.IO.StreamReader file = new System.IO.StreamReader(filepath);
                User user = new User();
                user = (User)reader.Deserialize(file);
                file.Close();
                if (user.Password == password)
                    return user;
                else
                    return null;
            }
            else
            {
                // User not found
                return null;
            }
        }

        public static bool isUser(string username)
        {
            string filepath = Directory.GetCurrentDirectory() + "\\" + username + ".txt";
            if (File.Exists(filepath))
                return true;
            else return false;
        }

        public static User CreateNewUser(string username, string password, double startingCash)
        {
            //Construct the filepath
            string filepath = Directory.GetCurrentDirectory() + "\\" + username + ".txt";
            // User already exists
            if (File.Exists(filepath))
                return null;

            User user = new User(username, password, startingCash);
            Logout(user);
            return user;
        }

        public static void Logout(User user)
        {

            // The following is just test code

            //User user = new User("Ted", "Password", 5000.00);
            //user.Holdings.Add(new Holding("GOOG"));
            //DateTime newDate = new DateTime();
            //user.WatchList.Add(new Company("test", "GOOG", "Something", "Something", "Something", 50.00));
            //user.Transactions.Add(new Transaction("Test", "Test", 50.00, 50, DateTime.Now));

            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(User));

            //Construct the filepath
            string filepath = Directory.GetCurrentDirectory() + "\\" + user.Username + ".txt";

            // Clear the file
            if (File.Exists(filepath) )
            {
                File.WriteAllText(filepath, string.Empty);
            }
            System.IO.StreamWriter file = new System.IO.StreamWriter(
               filepath);
            writer.Serialize(file, user);
            file.Close();
        }
    }
}
