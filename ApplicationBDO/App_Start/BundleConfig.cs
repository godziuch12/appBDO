using System.Web;
using System.Web.Optimization;

namespace ApplicationBDO
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/content/smartadmin").Include(
                                      "~/content/css/bootstrap.min.css",
                                      "~/content/css/font-awesome.min.css",
                                      "~/content/css/lockscreen.min.css",
                                      "~/content/css/smartadmin-production-plugins.min.css",
                                      "~/content/css/smartadmin-production.min.css",
                                      "~/content/css/smartadmin-skins.min.css",
                                      "~/content/css/bootstrap-datetimepicker.min.css",
                                      "~/content/css/eprzedszkolaczek.css"));


            bundles.Add(new ScriptBundle("~/scripts/smartadmin").Include(
                "~/scripts/libs/jquery-2.1.1.min.js",
                "~/scripts/libs/jquery-ui-1.10.3.min.js",
                "~/scripts/jquery.unobtrusive-ajax.min.js",
                "~/scripts/app.config.js",
                "~/scripts/plugin/jquery-touch/jquery.ui.touch-punch.min.js",
                "~/scripts/bootstrap/bootstrap.min.js",
                "~/scripts/notification/SmartNotification.min.js",
                "~/scripts/smartwidgets/jarvis.widget.min.js",
                "~/scripts/plugin/jquery-validate/jquery.validate.min.js",
                "~/scripts/plugin/masked-input/jquery.maskedinput.min.js",
                "~/scripts/plugin/select2/select2.min.js",
                "~/scripts/plugin/bootstrap-slider/bootstrap-slider.min.js",
                "~/scripts/plugin/bootstrap-progressbar/bootstrap-progressbar.min.js",
                "~/scripts/plugin/msie-fix/jquery.mb.browser.min.js",
                "~/scripts/plugin/fastclick/fastclick.min.js",
                "~/scripts/datetimepicker/moment.min.js",
                "~/scripts/datetimepicker/pl.js",
                "~/scripts/datetimepicker/bootstrap-datetimepicker.min.js",
                "~/scripts/plugin/bootstrap-duallistbox/jquery.bootstrap-duallistbox.min.js",
                "~/scripts/app.js"));

            bundles.Add(new ScriptBundle("~/scripts/datatables").Include(
                "~/scripts/plugin/datatables/jquery.dataTables.min.js",
                "~/scripts/plugin/datatables/dataTables.colVis.min.js",
                "~/scripts/plugin/datatables/dataTables.tableTools.min.js",
                "~/scripts/plugin/datatables/dataTables.bootstrap.min.js",
                "~/scripts/plugin/datatable-responsive/datatables.responsive.min.js"
            ));
        }
    }
}
