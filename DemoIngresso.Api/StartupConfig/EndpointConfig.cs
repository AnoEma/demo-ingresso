using DemoIngresso.Api.Endpoints;

namespace DemoIngresso.Api.StartupConfig
{
    public static class EndpointConfig
    {
        public static void AddDemoIngressoEndpoint(this WebApplication app)
        {
            UsuarioEndpointConfig.AddEndpoint(app);
        }
    }
}
