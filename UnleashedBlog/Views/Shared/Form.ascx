<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Form.ascx.cs" Inherits="UnleashedBlog.Views.Shared.Form" %>

<%@ Import Namespace="System.Net.Mail" %>
<%@ Import Namespace= "System.Net" %>

<script runat="server" type="text/C#">
    public void btnSend_Click(object sender, EventArgs e){

        MailMessage message = new MailMessage();
        message.To.Add("dacute1x3@gmail.com");
        message.From = new MailAddress(txtEmail.Text);
        message.Subject = TextSubject.Text;
        message.Body = txtName.Text + Environment.NewLine + txtMessage.Value;

        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com";
        smtp.Port = 587;
        smtp.EnableSsl = true;
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        smtp.Credentials = new System.Net.NetworkCredential("dacute1x3@gmail.com", "babyface");
        smtp.Send(message);
    }

    public void btnReset_Click(object sender, EventArgs e) {

        txtName.Text = "";
        txtMessage.Value = "";
        txtEmail.Text = "";
        TextSubject.Text = "";
 
    }

</script>
<asp:Panel ID="Panel1" runat= "server" style=" margin-bottom: 32px">

<asp:Label ID="Label1" runat= "server">Name:</asp:Label> 
<asp:Textbox ID="txtName" runat= "server"></asp:Textbox>
<br />

<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter the information requested."
ControlToValidate="txtName"></asp:RequiredFieldValidator>

<asp:Label ID="Label2" runat= "server">Email:</asp:Label> 
<asp:Textbox ID="txtEmail" runat= "server"></asp:Textbox>
<br />

<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter the information requested."
ControlToValidate="txtEmail"></asp:RequiredFieldValidator>

<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat= "server" ErrorMessage= "Please enter a valid email address." ControlToValidate= "txtEmail" ValidationExpression= "\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>

<asp:Label ID="Label3" runat= "server">Subject:</asp:Label> 
<asp:Textbox ID="TextSubject" runat= "server"></asp:Textbox>
<br />

<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please enter the information requested."
ControlToValidate="txtSubject"></asp:RequiredFieldValidator>

<asp:Label ID="Label4" runat="server">Message:</asp:Label>
<textarea runat="server" id= "txtMessage" rows="7" cols="24"></textarea>
<br/>

<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please enter a message." ControlToValidate = "txtMessage">
</asp:RequiredFieldValidator>

<asp:Button runat="server" ID="btnSend" OnClick="btnSend_Click" Text="Send" />
<asp:Button runat="server" ID="btnReset" CausesValidation= "false" OnClick="btnReset_Click" Text="Reset" />

</asp:Panel>


