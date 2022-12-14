using System;
using System.Collections.Generic;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Configuration;
namespace GitHub.FavLanguages
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Method to check Favourite Language for a given username 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Validateuser(object sender, EventArgs e)
        {
            var serviceClient = new ServiceClient();
            lblError.Text = serviceClient.GetUserFavoriteLanguage(txtUsername.Text);
        }

    }
}