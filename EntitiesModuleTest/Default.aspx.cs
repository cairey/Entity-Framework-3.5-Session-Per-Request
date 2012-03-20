using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Library.Modules;
using EntitiesModuleWeb.Model;
using System.Text;

namespace EntitiesModule
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            DateTime date =  DateTime.Now.AddYears(-1);
            MediaFreedomTestEntities ctx = null;


            /* Get an instance that lives for the life time of the request per user */
            ctx = EntitiesManager.AsSingleton<MediaFreedomTestEntities>();
            GridView1.DataSource = ctx.AssetContentPackage.Where(x => x.CreatedDate > date);
            GridView1.DataBind();

            sb.Append("Singleton - Hash Code: ");
            sb.Append(ctx.GetHashCode());
            sb.Append("<br/>");


            /* Get a new instance of the Entity */
            using(ctx = EntitiesManager.AsNewInstance<MediaFreedomTestEntities>())
            {
                GridView2.DataSource = (from x in ctx.AssetContentPackage
                                        where x.CreatedDate > date
                                        select x);

                GridView2.DataBind();

                sb.Append("New Instance - Hash Code: ");
                sb.Append(ctx.GetHashCode());
                sb.Append("<br/>");
            }



            /* Get an instance that lives for the life time of the request per user */
            ctx = EntitiesManager.AsSingleton<MediaFreedomTestEntities>();
            GridView3.DataSource = (from x in ctx.AssetContentPackage
                                    where x.CreatedDate > date
                                    select x);

            GridView3.DataBind();



            sb.Append("Singleton - Hash Code: ");
            sb.Append(ctx.GetHashCode());
            sb.Append("<br/>");



            GridView4.DataSource = GetACPNotActive().Where(x => x.CreatedDate > date);
            GridView4.DataBind();



            Literal1.Text = sb.ToString();

            // Can check we have mutal exclusion
            System.Threading.Thread.Sleep(2000);
        }


        private IQueryable<AssetContentPackage> GetACPNotActive()
        {
            MediaFreedomTestEntities ctx = EntitiesManager.AsSingleton<MediaFreedomTestEntities>();

            return ctx.AssetContentPackage.Where(x => x.Active == false);
        }
    }

}
