using System.Web;
using System.Web.Optimization;

namespace OTDAV.WEB
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour le développement et l'apprentissage. Puis, une fois
            // prêt pour la production, utilisez l'outil de génération à l'adresse https://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Scripts/js").Include(
                "~/Scripts/js/vendor/jquery-3.3.1.min.js",
                "~/Scripts/js/popper.min.js",
                "~/Scripts/js/bootstrap.min.js",
                "~/Scripts/js/slider/jquery.nivo.slider.pack.js",
                "~/Scripts/js/slider/nivo-active.js",
                "~/Scripts/js/plugins.js",
                "~/Scripts/js/main.js"
               
                ));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/css/bootstrap.min.css",
                "~/Content/css/plugins.css",
                "~/Content/css/shortcode.css",
                "~/Content/css/style.css",
                "~/Content/css/responsive.css",
                "~/Content/css/custom.css",
                "~/Content/css/style-customizer.css"
                
                
                
               
               
                
                ));
            bundles.Add(new ScriptBundle("~/temp/modernizr").Include(
                "~/Scripts/js/vendor/modernizr-2.8.3.min.js"));
           
        }
    }
}
