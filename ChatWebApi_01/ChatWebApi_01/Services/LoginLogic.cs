using ChatWebApi_01.ApiDTO;

namespace ChatWebApi_01.Services
{
    public class LoginLogic
    {
        public bool LoginCheck(LoginDTO loginData)
        {  
            string checkUser = "user1";
            string checkPass = getPass(checkUser);
            if(loginData.passWord != checkPass) 
            {
                return false; 
            }
            else
            {
                return true;
            }
        }
        public string getPass(string checkUser)
        {
            
            string checkPass = "check1";
            return checkPass;

        }
    }
}
