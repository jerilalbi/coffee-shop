
using IronBarCode;
using Starbucks.application.datas;
using Starbucks.application.events;
using Starbucks.domain;
using Starbucks.domain.admin;
using Starbucks.domain.user;
using Starbucks.infrastructure.components;
using Starbucks.presentation.final;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.QrCode.Internal;

namespace Starbucks.presentation.payment
{
    public partial class Screen_Payment : Form
    {
        int total;
        int amount = 1;
        string prodJson = 
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
            SqlDataReader cartDetails = adminDbOP.adminDataFetchQuery("select name,price,count,size,flavour from cart");
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

                prodJson +=
                    $@"
{{
""name"": ""{cartDetails["name"]}"",
""price"": {cartDetails["price"]},
""count"": {cartDetails["count"]},
""size"": ""{cartDetails["size"]}"",
""flavour"": ""{cartDetails["flavour"]}"",
}},
";
                total += int.Parse(cartDetails["price"].ToString()) * int.Parse(cartDetails["count"].ToString());
            }
            prodJson +=
                @"
{}
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
            Console.WriteLine(prodJson);
            cartDetails.Close();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            getData();
            makeQrCode(prodJson, true);
            Email email = new Email();
            email.send(emailData);
            Screen_final finalScreen = new Screen_final();
            finalScreen.Show();
            Hide();
        }

        private void Screen_Payment_Load(object sender, EventArgs e)
        {
            qrCodebx.Image = makeQrCode($"upi://pay?pn=Jeril%20Albi&pa=jerilalbi11@oksbi&am={amount}",false);
        }

        Image makeQrCode(string message,bool prodQr)
        {
            var qrcode = QRCodeWriter.CreateQrCodeWithLogo(message, "J:\\coding\\.net\\cafe management media\\starbucks_logo.png", 364);
            if (prodQr)
            {
                qrcode.SaveAsPng("C:\\Users\\devje\\Downloads\\qrcode.png");
            }
            return qrcode.Image;
        }
    }
}
