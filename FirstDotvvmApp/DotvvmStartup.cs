﻿	using DotVVM.Framework.Configuration;
using DotVVM.Framework.ResourceManagement;
using DotVVM.Framework.Routing;

namespace FirstDotvvmApp
{
    public class DotvvmStartup : IDotvvmStartup
    {
        // For more information about this class, visit https://dotvvm.com/docs/tutorials/basics-project-structure
        public void Configure(DotvvmConfiguration config, string applicationPath)
        {
            ConfigureRoutes(config, applicationPath);
            ConfigureControls(config, applicationPath);
            ConfigureResources(config, applicationPath);
        }

        private void ConfigureRoutes(DotvvmConfiguration config, string applicationPath)
        {
            config.RouteTable.Add("Default", "", "Views/default.dothtml");
            config.RouteTable.AutoDiscoverRoutes(new DefaultRouteStrategy(config));    
        }

        private void ConfigureControls(DotvvmConfiguration config, string applicationPath)
        {
            // register code-only controls and markup controls
        }

        private void ConfigureResources(DotvvmConfiguration config, string applicationPath)
        {
            // register custom resources and adjust paths to the built-in resources
            config.Resources.Register("bootstrap-css", new StylesheetResource
            {
                Location = new UrlResourceLocation("~/lib/bootstrap/dist/css/bootstrap.min.css")
            });
            config.Resources.Register("bootstrap-theme", new StylesheetResource
            {
                Location = new UrlResourceLocation("~/lib/bootstrap/dist/css/bootstrap-theme.min.css"),
                Dependencies = new[] { "bootstrap-css" }
            });
            config.Resources.Register("bootstrap", new ScriptResource
            {
                Location = new UrlResourceLocation("~/lib/bootstrap/dist/js/bootstrap.min.js"),
                Dependencies = new[] { "bootstrap-css" , "jquery" }
            });
            config.Resources.Register("jquery", new ScriptResource
            {
                Location = new UrlResourceLocation("~/lib/jquery/dist/jquery.min.js")
            });
        }
    }
}