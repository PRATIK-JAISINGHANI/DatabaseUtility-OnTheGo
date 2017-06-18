using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Net.Http;
using System.Json;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DatabaseUtility_OnTheGo
{
    [Activity(Label = "ScriptGeneratorActivity")]
    public class ScriptGeneratorActivity : Activity
    {
        #region Constructor

        public ScriptGeneratorActivity()
        {
        }

        #endregion

        #region Declarations

        string baseURL = "http://3689-20485.el-alt.com/";

        string connectEndPoint = "API/SQL/Connect";
        string executeEndPoint = "API/SQL/Execute";
        string disconnectEndPoint = "API/SQL/Disconnect";

        #endregion

        #region Protected Methods
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.ScriptGenerator);

            Button connect = FindViewById<Button>(Resource.Id.connectButton);
            connect.Click += Connect_Click;
        }
        #endregion

        #region Helper Methods
        private HttpClient GetClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new System.Uri(baseURL);
            return client;
        }

        private bool ConnectToServer()
        {
            var result = false;

            // For Script Generator Activties
            EditText serverName = FindViewById<EditText>(Resource.Id.serverText);
            EditText username = FindViewById<EditText>(Resource.Id.usernameText);
            EditText password = FindViewById<EditText>(Resource.Id.passwordText);
            EditText databaseName = FindViewById<EditText>(Resource.Id.databasenameText);

            JObject jObject = new JObject();
            jObject.Add("ServerName", serverName.Text);
            jObject.Add("Username", username.Text);
            jObject.Add("Password", password.Text);
            jObject.Add("DatabaseName", databaseName.Text);
            //
            return result;
        }

        #endregion

        #region Events
        private void Connect_Click(object sender, System.EventArgs e)
        {
            ConnectToServer();
        }
        #endregion
    }
}