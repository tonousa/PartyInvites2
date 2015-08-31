<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PartyInvites2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="PartyStyles.css" rel="stylesheet" />
</head>
<body>
    <form id="rsvpform" runat="server">
    <div>
        <h1>New Year's Eve at Jacqui's</h1>
        <p>We are going to have an exciting party and you'r invited!</p>
        <div><label>Your name: </label><input type="text" id="name" /></div>
        <div><label>Your email: </label><input type="text" id="email" /></div>
        <div><label>Your phone: </label><input type="text" id="phone" /></div>
    </div>
    <div>
        <label>Will you attend?</label>
        <select id="willattend">
            <option value="">Choose an option</option>
            <option value="true">Yes</option>
            <option value="false">No</option>
        </select>
    </div>
        <div>
            <button type="submit">Submit</button>
        </div>
    </form>
</body>
</html>
