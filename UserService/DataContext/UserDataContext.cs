using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.DataContext
{
    public class UserDataContext
    {
        private static Dictionary<int, User> userList;
        private static int userCount = 0;

        static UserDataContext()
        {
            userList = new Dictionary<int, User>();
            userList.Add(++userCount, new User() { UserId = userCount, Name="Ajay", Age=23, Email="ajay@gmail.com" });
            userList.Add(++userCount, new User() { UserId = userCount, Name = "Himanshu", Age = 20, Email = "himanshu@gmail.com" });
            userList.Add(++userCount, new User() { UserId = userCount, Name = "Sachin", Age = 22, Email = "sachin@gmail.com" });
            userList.Add(++userCount, new User() { UserId = userCount, Name = "Devesh", Age = 25, Email = "devesh@gmail.com" });
        }

        internal static User GetUserDetailsByUserId(int id)
        {
            return userList.Values.FirstOrDefault(user => user.UserId == id);
        }
    }
}
