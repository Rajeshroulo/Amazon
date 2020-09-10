using Newtonsoft.Json;
using System.Configuration;
using System.IO;

namespace Amazon.Data
{
    public class UserData
    {
        public string email;
        public string password;
        public string json;
        public string bookspassword;
        public string devmail;
        public UserData()
        {
            using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["JSON"]))
            {
                json = reader.ReadToEnd();
            }

            dynamic array = JsonConvert.DeserializeObject(json);
            email = array["email"];
            password = array["amazon"];
        }
    }
}
