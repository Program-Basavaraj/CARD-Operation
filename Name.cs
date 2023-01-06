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
