using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReviewYourRestaurants.Startup))]
namespace ReviewYourRestaurants
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
