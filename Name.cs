Random random = new Random();
activationcode random.Next (1001, 9999).ToString();
String query = "insert into emaildetails (cname, emailaddress, status, activationcode) values ("TextBox1.Text + ","" 
String mycon = "Data Source=HP-PC\\SQLEXPRESS; Initial Catalog-SubscriberDatabase: Integrated Security=true"; 
SqlConnection con= new SqlConnection(mycon);
con.Open();
SqlCommand cmd = new SqlCommand();
cmd.CommandText = query;
cmd.Connection = con;
cmd.ExecuteNonQuery();
sendcode();
Response.Redirect("ActivateEmail.aspx?emailadd=" + TextBox2.Text);

SmtpClient smtp = new SmtpClient();
smtp.Host ="smtp.gmail.com";
smtp.Port= 587;
smtp.Credentials = new System.Net.NetworkCredential("salmansharma2014@gmail.com", "enter here your password");
smtp.EnableSsl = true;
MailMessage msg new MailMessage();
msg.Subject "Activation Code to Verify Email Address";
msg.Body "Dear "TextBox1.Text + ", Your Activation Code is "+ activationcode + "\n\n\nThanks & Regards\nHariti Study Hub Team";
string toaddress TextBox2.Text;
msg.To.Add(toaddress);
string fromaddress "Hariti Study Hub <salmansharma2014@gmail.com>";
msg. From new MailAddress(fromaddress);

try
{
  smtp.Send(msg);
}
catch
{
  throw;
}

Label3. Text ="Your Email is "+Request.QueryString["emailadd"].ToString() +", Kindly Check Your Mail Inbox For Activation Code":
protected void Button1_Click(object sender, EventArgs e)
{
    String mycon = "Data Source=Hb-PC\\SQLEXPRESS; Initial Catalog-SubscriberDatabase; Integrated Security=True"; String myquery = "Select from EmailDetails where emailaddress='" + Request.QueryString["emailadd"] + "'"; SqlConnection con= new SqlConnection (mycon);
    SqlCommand cmd = new SqlCommand();
    cmd.CommandText = myquery;
    cmd.Connection = con;
    SqlDataAdapter da = new SqlDataAdapter();
    da.SelectCommand = cmd;
    DataSet ds = new DataSet();
    da.Fill(ds);
    if (ds.Tables[0].Rows.Count > 0)
    String activationcode;
    activationcode= ds.Tables[0].Rows[0]["activationcode"].ToString();
    {

    if (activationcode == TextBox1.Text)
    {
      changestatus();
      Label4.Text = "Your Email Has Been Verified Successfully";
    }
    else
    {
      Label4. Text "You Have Entered Invalid Activation Code, Kindly Check Your Mail Inbox";
    }
}
  
  private void changestatus()

(

String mycon= "Data Source=HP-PC\\SQLEXPRESS; Initial Catalog-SubscriberDatabase; Integrated Security-True"; 
String updatedata= "Update emaildetails set status-'Verified' where emailaddress-+ Request.QueryString["emailadd"] + "*"; 
SqlConnection con= new SqlConnection (mycon);
con.Open();
SqlCommand cmd = new SqlCommand();
cmd.CommandText = updatedata;
cmd.Connection con;
cmd.ExecuteNonQuery();
