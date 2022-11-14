using Starbucks.application.datas;
using Starbucks.domain.user;
using Starbucks.domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.DrawingCore.Imaging;

namespace Starbucks.application.events
{
    internal class Email
    {
        string fromMail = "jerilalbi11@gmail.com";
        string password = "dhdqtnbeuiafqesh";
        string text;
        MemoryStream stream;


        public void fetchData()
        {
            AddCart cart = new AddCart();
            SqlDataReader cartdata = cart.showCart();
            while (cartdata.Read())
            {
                text += $"Product: {cartdata["name"]},Size: {cartdata["size"]}, Flavour: {cartdata["flavour"]} ";
                text += Environment.NewLine;
            }
            cartdata.Close();
            Database.connection.Close();
        }

       public void send()
        {
            fetchData();
            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromMail);
                message.Subject = "Starbucks";
                message.To.Add(new MailAddress(data.emailId));
                message.Body = text;

                var smtp = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(fromMail, password),
                    EnableSsl = true
                };
                smtp.Send(message);
            }catch(Exception er)
            {
                MessageBox.Show(er.Message);
            } 
        }
    }
}
