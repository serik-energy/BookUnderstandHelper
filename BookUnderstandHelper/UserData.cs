using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookUnderstandHelper
{
    /// <summary>
    /// singleton, that contain all user data
    /// </summary>
    public class UserData
    {
        private UserData() { }

        static private UserData userData;
        /// <summary>
        /// get instance of <see cref="UserData"/>
        /// </summary>
        /// <returns>return <see cref="UserData.userData"/></returns>
        public static UserData getUserData()
        {
            return userData ?? (userData = new UserData());
        }

        #region some data collections
        public List<string> book { get; set; }
        public Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>>
            library
        { get; set; } =
            new Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>>();
        public Dictionary<string, Dictionary<string, Dictionary<string, ulong>>>
            myVocabulary
        { get; set; } =
            new Dictionary<string, Dictionary<string, Dictionary<string, ulong>>>();
        public Dictionary<string, Dictionary<string, Dictionary<string, ulong>>>
            users
        { get; set; } =
            new Dictionary<string, Dictionary<string, Dictionary<string, ulong>>>();
        #endregion

        public static bool ifContainLanguage(string lang, string user)
        {
            return getUserData().users[user].ContainsKey(lang);
        }

        public static bool ifContainUser(string user)
        {
            return getUserData().users.ContainsKey(user);
        }
    }
}
