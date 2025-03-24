namespace MeetingApp.Models{

    public static class Repository{

        static Repository(){

            _users.Add(new UserInfo(){Id = 1 , Name = "Ali" ,Surname = "Yaldırak", Phone = "5551234567" , Email = "a@mail.com" , WillAttend = true});
            _users.Add(new UserInfo(){Id = 2 , Name = "Murat" , Surname = "Yaldırak" ,Phone = "5552346781" , Email = "b@mail.com" , WillAttend = false});
        }
        private static List<UserInfo> _users = new();

        public static List<UserInfo> Users{
            get{
                return _users;
            }
        }

        public static void CreateUser(UserInfo user){

            user.Id = Users.Count + 1;
            _users.Add(user);
        }
        public static UserInfo GetById(int id){
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}