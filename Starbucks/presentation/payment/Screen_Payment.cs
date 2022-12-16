
using Newtonsoft.Json.Linq;
using SixLabors.ImageSharp.Memory;
using Starbucks.application.events;
using Starbucks.domain.admin;
using Starbucks.presentation.final;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;

namespace Starbucks.presentation.payment
{
    public partial class Screen_Payment : Form
    {
        int total;
        int amount = 1,orderID;
        JObject productJSON;
        string prodJsonString = 
            @"
{
""products"" : [
";
        string emailData =
            @"
                <html>
                <body>
<h2> E Bill </h2>
<table border=""1"">
<tr>
<th>Product</th>
<th>Price</th>
<th>Count</th>
<th>Size</th>
<th>Flavour</th>
</tr>
             ";
        public Screen_Payment()
        {
            InitializeComponent();
            baseContainer.Location = new Point((ClientSize.Width / 2) - (baseContainer.Width / 2), (ClientSize.Height / 2) - (baseContainer.Height / 2));
            
        }

        void getData()
        {
            AdminDbOP adminDbOP = new AdminDbOP();
            SqlDataReader cartDetails = adminDbOP.adminDataFetchQuery("select name,price,count,size,flavour,category from cart");
            while (cartDetails.Read())
            {
                emailData += 
                    $@"
<tr>
            <td> {cartDetails["name"]} </td>
<td> {cartDetails["price"]} </td>
<td> {cartDetails["count"]} </td>
<td> {cartDetails["size"]} </td>
<td> {cartDetails["flavour"]} </td>
</tr>
                    ";

                prodJsonString +=
                    $@"
{{
""name"": ""{cartDetails["name"]}"",
""price"": {cartDetails["price"]},
""count"": {cartDetails["count"]},
""size"": ""{cartDetails["size"]}"",
""flavour"": ""{cartDetails["flavour"]}"",
""category"": ""{cartDetails["category"]}""
}},
";
                total += int.Parse(cartDetails["price"].ToString()) * int.Parse(cartDetails["count"].ToString());
            }
            prodJsonString +=
                @"

]
}
";
            emailData += 
                $@"
</table>
<h5> Total Price: {total} </h5>
</body>
</html>
";
            productJSON = JObject.Parse(prodJsonString);
            cartDetails.Close();
        }

        void addSales()
        {
            Sales sales = new Sales();
            AdminDbOP dbOP = new AdminDbOP();
             orderID = makeOderID();
            foreach(var items in productJSON["products"])
            {
                sales.addSales(items["name"].ToString(), int.Parse(items["price"].ToString()), int.Parse(items["count"].ToString()), items["category"].ToString());
                dbOP.adminQuery($"insert into orders values({orderID},'{items["name"]}',{int.Parse(items["price"].ToString())},{int.Parse(items["count"].ToString())},'{items["size"]}','{items["flavour"]}')");
            }

        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            getData();
            addSales();
            makeQrCode(orderID.ToString(), true);
            Email email = new Email();
            email.send(emailData);
            Screen_final finalScreen = new Screen_final();
            finalScreen.Show();
            Hide();
        }

        private void Screen_Payment_Load(object sender, EventArgs e)
        {
           qrCodebx.Image = makeQrCode($"upi://pay?pn=Jeril%20Albi&pa=jerilalbi11@oksbi&am={amount}", false);
        }

        Image makeQrCode(string message,bool prodQr)
        {
            var writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = new QrCodeEncodingOptions
            {
                Height = 364,
                Width = 364,
                Margin = 0,
            };
            var qrcode = writer.Write(message);
            if (prodQr)
            {
                qrcode.Save("J:\\coding\\.net\\Starbucks\\Starbucks\\presentation\\images\\qrcode.png");
            }
            return qrcode;
        }

        int makeOderID() 
        {
            List<int> oderIds = new List<int>();
            Random random = new Random();
            int oderID = random.Next(1000,9999);
            AdminDbOP adminDbOP = new AdminDbOP();
            SqlDataReader readerID = adminDbOP.adminDataFetchQuery("select order_id from orders");
            while (readerID.Read())
            {
                oderIds.Add(int.Parse(readerID["order_id"].ToString()));
            }
            do
            {
                oderID = random.Next(1000, 9999);
            }while(oderIds.Contains(oderID));
            readerID.Close();
            return oderID; 
        }
    }
}
