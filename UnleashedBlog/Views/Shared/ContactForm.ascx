<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContactForm.ascx.cs" Inherits="UnleashedBlog.Views.Shared.ContactForm" %>

<%@ Import Namespace="System.Net.Mail" %>
<%@ Import Namespace= "System.Net" %>

<script runat="server" type="text/C#">
    public void btnSend_Click(object sender, EventArgs e){

        MailMessage message = new MailMessage();
        message.To.Add("");
        message.From = new MailAddress(txtEmail.Text);
        message.Subject = TextSubject.Text;
        message.Body = txtName.Text + Environment.NewLine + txtMessage.Value;

        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com";
        smtp.Port = 587;
        smtp.EnableSsl = true;
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        smtp.Credentials = new System.Net.NetworkCredential(", "");
        smtp.Send(message);
    }

    public void btnReset_Click(object sender, EventArgs e) {

        txtName.Text = "";
        txtMessage.Value = "";
        txtEmail.Text = "";
        TextSubject.Text = "";
 
    }

</script>
<asp:Panel runat= "server" style=" margin-bottom: 32px">

<asp:Label runat= "server">Name:</asp:Label> 
<asp:Textbox ID="txtName" runat= "server"></asp:Textbox>
<br />

<asp:RequiredFieldValidator runat="server" ErrorMessage="Please enter the information requested."
ControlToValidate="txtName"></asp:RequiredFieldValidator>

<asp:Label runat= "server">Email:</asp:Label> 
<asp:Textbox ID="txtEmail" runat= "server"></asp:Textbox>
<br />

<asp:RequiredFieldValidator runat="server" ErrorMessage="Please enter the information requested."
ControlToValidate="txtEmail"></asp:RequiredFieldValidator>

<asp:RegularExpressionValidator runat= "server" ErrorMessage= "Please enter a valid email address." ControlToValidate= "txtEmail" ValidationExpression= "\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>

<asp:Label runat= "server">Subject:</asp:Label> 
<asp:Textbox ID="TextSubject" runat= "server"></asp:Textbox>
<br />

<asp:RequiredFieldValidator runat="server" ErrorMessage="Please enter the information requested."
ControlToValidate="txtSubject"></asp:RequiredFieldValidator>

<asp:Label runat="server">Message:</asp:Label>
<textarea runat="server" id= "txtMessage" rows="7" cols="24"></textarea>
<br/>

<asp:RequiredFieldValidator runat="server" ErrorMessage="Please enter a message." ControlToValidate = "txtMessage">
</asp:RequiredFieldValidator>

<asp:Button runat="server" ID="btnSend" OnClick="btnSend_Click" Text="Send" />
<asp:Button runat="server" ID="btnReset" CausesValidation= "false" OnClick="btnReset_Click" Text="Reset" />

</asp:Panel>


