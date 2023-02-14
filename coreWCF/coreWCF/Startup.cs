using CoreWCF;
using CoreWCF.Configuration;
using CoreWCF.Description;
using CoreWCfDemoServer;

namespace CoreWcf.Samples.Http
{
    public class BasicHttpBindingStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Add WSDL support
            services.AddServiceModelServices().AddServiceModelMetadata();
            services.AddSingleton<IServiceBehavior, UseRequestHeadersForMetadataAddressBehavior>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseServiceModel(builder =>
            {
                builder.AddService<EchoService>(serviceOptions => { })
                // Add a BasicHttpBinding at a specific endpoint
                .AddServiceEndpoint<EchoService, IEchoService>(new BasicHttpBinding(), "/EchoService/basichttp")
                // Add a WSHttpBinding with Transport Security for TLS
                .AddServiceEndpoint<EchoService, IEchoService>(new WSHttpBinding(SecurityMode.Transport), "/EchoService/WSHttps");

                var serviceMetadataBehavior = app.ApplicationServices.GetRequiredService<CoreWCF.Description.ServiceMetadataBehavior>();
                serviceMetadataBehavior.HttpGetEnabled = true;
            });
        }
    }
}