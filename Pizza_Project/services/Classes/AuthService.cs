using Pizza_Project.services.interfaces;

namespace Pizza_Project.services.classes
{
    public class AuthService : IAuthService
    {
        private bool _authStatus = false;
        
        public void UpdateAuthStatus(bool status)
        {
            this._authStatus = status;
        }

        public bool GetAuthStatus()
        {
            return this._authStatus;
        }
    }
}