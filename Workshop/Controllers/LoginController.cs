using Forum.App.UserInterface;
using Forum.App.Views;

namespace Forum.App.Controllers
{
    using Forum.App.Controllers.Contracts;
    using Forum.App.UserInterface.Contracts;

    public class LogInController : IController, IReadUserInfoController
    {
        public string Username { get; private set; }
        public string Password { get; set; }
        public bool Error { get; set; }

        private enum Command
        {
            ReadUsername, ReadPassword, LogIn, Back
        }

        private void ResetLogin()
        {
            this.Error = false;
            this.Username = string.Empty;
            this.Password = string.Empty;
        }

        public LogInController()
        {
            this.ResetLogin();
        }

        public MenuState ExecuteCommand(int index)
        {
            throw new System.NotImplementedException();
        }

        public IView GetView(string userName)
        {
            return new LogInView(this.Error, this.Username, this.Password.Length);
        }

        public void ReadPassword()
        {
            this.Password = ForumViewEngine.ReadRow();
            ForumViewEngine.HideCursor();
        }

        public void ReadUsername()
        {
            this.Username = ForumViewEngine.ReadRow();
            ForumViewEngine.HideCursor();
        }
    }
}
