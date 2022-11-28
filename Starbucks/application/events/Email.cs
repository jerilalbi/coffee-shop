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
using System.IO;
using System.DrawingCore.Imaging;
using System.Drawing;

namespace Starbucks.application.events
{
    internal class Email
    {
        string fromMail = "jerilalbi11@gmail.com";
        string password = "dhdqtnbeuiafqesh";
        string text;
        MemoryStream stream;
        System.Drawing.Image img;


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

       public void send(string emailData)
        {
            fetchData();
            MemoryStream ms = new MemoryStream();
           img = Starbucks.Properties.Resources.prod_frap;
            img.Save(ms, img.RawFormat);
            Attachment attachment = new Attachment("C:\\Users\\devje\\Downloads\\qrcode.png");
            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromMail);
                message.Subject = "Starbucks";
                message.To.Add(new MailAddress(data.emailId));
               // message.To.Add(new MailAddress("devjerilalbi@gmail.com"));

                message.Body = emailData;
               /* message.Body = String.Format(
            "<h3>Client:  StarBucks Bill</h3>" +
            @"<img height=""200"" width=""200"" src=""cid:{0}"" />", attachment.ContentId); */
                message.IsBodyHtml = true; 
                message.Attachments.Add(attachment);

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
