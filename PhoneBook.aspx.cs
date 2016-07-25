using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using System.Xml.Linq;
using System.Xml;

public partial class PhoneBook : System.Web.UI.Page
{
    // object to invoke the web serivce
    HttpClient client = new HttpClient();

    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected async void btnFind_Click(object sender, EventArgs e)
    {
        // clear any text in the result textfield
        txtResult.Text = string.Empty; 

        string personToFind = txtFindLastName.Text;
        Uri uri = new Uri("http://localhost:25955/Service1.svc/" + personToFind);

        string result = await client.GetStringAsync(uri);

        // Parse the returned xml
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(result);

        XmlNodeList node;

        node = xmlDoc.GetElementsByTagName("string");

        // Add query result to Result text box
        for (int i = 0; i < node.Count; i++)
        {
            txtResult.Text += node[i].InnerText + "\r\n";
        }
        
    }

    protected async void btnAddEntry_Click(object sender, EventArgs e)
    {
        // Get user input
        string firstName = txtFirstName.Text;
        string lastName = txtLastName.Text;
        string phoneNumber = txtPhoneNumber.Text;

        Uri uri = new Uri("http://localhost:25955/Service1.svc/" + lastName + "/" + firstName + "/" + phoneNumber);

        string result = string.Empty;
        // String 'result' should contain the text: "Entry added sucessfully"
        try
        {
            result = await client.GetStringAsync(uri);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(result);
            XmlNodeList node;

            node = xmlDoc.GetElementsByTagName("string");

            // clear any text in the result textfield
            txtResult.Text = string.Empty;
            txtResult.Text = node[0].InnerText;
        }
        catch (HttpRequestException ex)
        {
            txtResult.Text = string.Empty;
            txtResult.Text = "Something went wrong on the frontend.\nDetailed error message:\n" + ex.InnerException.ToString();
        }
    }
}