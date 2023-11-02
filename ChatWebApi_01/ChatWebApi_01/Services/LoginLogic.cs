using ChatWebApi_01.ApiDTO;

namespace ChatWebApi_01.Services
{
    public class LoginLogic
    {
        public bool LoginCheck(LoginDTO loginData)
        {  
            string checkUser = "user1";
            string loginPass = loginData.passWord;
            string checkPass = getPass(checkUser);
            LoginCheckDataDTO checkData = createLoginCheckData(loginPass, checkPass);
            bool result = passCheck(checkData);
            return result;
        }
        public string getPass(string checkUser)
        {
            
            string checkPass = "check1";
            return checkPass;

        }
        public bool passCheck(LoginCheckDataDTO data)
        {
            return data.passWord == data.checkPass;
        }
        public LoginCheckDataDTO createLoginCheckData(string loginPass, string checkPass)
        {
            return new LoginCheckDataDTO
            {
                passWord = loginPass,
                checkPass = checkPass
            };
        }

    }
}
