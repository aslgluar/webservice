<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="serviscek.aspx.cs" Inherits="tepeguvenlık.serviscek" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 424px">
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                <br />
                <br />
                <br />
                <asp:DataList ID="DataList1" runat="server">
                    <HeaderTemplate>

                        <table>
                            <tr>

                            <th style="width:150px" >Adi</th>
                            <th style="width:150px">Soyadi</th>
                            <th style="width:150px">dogumtarihi</th>
                            <th style="width:150px">sehir</th>

                            </tr>
                        </table>

                    </HeaderTemplate>

                </asp:DataList>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
