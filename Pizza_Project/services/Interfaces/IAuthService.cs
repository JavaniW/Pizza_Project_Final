namespace Pizza_Project.services.interfaces
{
    public interface IAuthService
    {
        public void UpdateAuthStatus(bool status);
        public bool GetAuthStatus();
    }
}