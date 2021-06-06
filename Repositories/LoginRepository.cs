﻿using MP140.Interfaces;

namespace MP140.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private static LoginRepository instance = null;
        private LoginRepository() { }
        public static LoginRepository SingleInstance
        {
            get
            {
                if(instance == null)
                {
                    instance = new LoginRepository();
                }
                return instance;
            }
        }

        public bool CheckUserLoggedIn(string username, string password)
        {
            throw new System.NotImplementedException();
        }
    }
}