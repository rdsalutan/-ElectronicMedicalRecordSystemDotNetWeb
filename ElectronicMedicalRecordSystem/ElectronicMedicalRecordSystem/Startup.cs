using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ElectronicMedicalRecordSystem.Startup))]
namespace ElectronicMedicalRecordSystem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
