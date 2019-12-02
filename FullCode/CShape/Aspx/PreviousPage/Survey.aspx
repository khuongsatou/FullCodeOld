<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Survey.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            height: 46px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%; color: #0E0E6C">
                        <tr>
                            <td align="left" valign="top" colspan="2" style="background-color: Maroon; color: White;">
                                <span style="font-size: 18pt; font-family: Verdana; font-style: normal;">&nbsp;Help
                                    us to help you!</span>
                                <br />
                                Personal Info&nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td align="right" valign="top">
                                Name:</td>
                            <td>
                                <input id="txtName" type="text" name="txtName" runat="server" enableviewstate="true" />
                            </td>
                        </tr>
                        <tr>
                            <td align="right" valign="top" class="style1">
                                Gender:</td>
                            <td class="style1">
                                <input id="Radio1" name="optGender" type="radio" value="Female" runat="server" enableviewstate="true" />Female
                                <br />
                                <input id="Radio2" name="optGender" type="radio" value="Male" runat="server" enableviewstate="true" />Male
                            </td>
                        </tr>
                        <tr>
                            <td align="right" valign="top">
                                Mountain Bike Rider?</td>
                            <td>
                                <input id="chkMBR" checked="checked" name="chkMBR" type="checkbox" runat="server"
                                    enableviewstate="true" />
                            </td>
                        </tr>
                        <tr>
                            <td align="right" valign="top">
                                Road Rider?</td>
                            <td>
                                <input id="chkRR" checked="checked" name="chkRR" type="checkbox" runat="server" enableviewstate="true" />
                            </td>
                        </tr>
                        <tr>
                            <td align="right" valign="top">
                                Favorite Trails from&nbsp;<br />
                                around the world:</td>
                            <td>
                                <textarea id="txtTrails" cols="50" name="txtTrails" rows="3" runat="server" enableviewstate="true"></textarea>
                            </td>
                        </tr>
                    </table>
                    <hr />
                    <asp:Table ID="tblOuter" runat="server" ForeColor="#0E0E6C" Width="100%">
                        <asp:TableRow ID="outerR1" runat="server">
                            <asp:TableCell ID="outerR1C1" runat="server" ColumnSpan="2">
                                <asp:Panel ID="pnlActivity" runat="server" Width="100px">
                                    Recent and Planned Activity</asp:Panel>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="outerR2" runat="server">
                            <asp:TableCell ID="outerR2C1" runat="server" VerticalAlign="Middle" Width="1%" Wrap="False">Rides</asp:TableCell>
                            <asp:TableCell ID="outerR2C2" runat="server">
                                <asp:Table ID="tblInner" runat="server" GridLines="None" Width="100%">
                                    <asp:TableRow ID="innerR1" runat="server">
                                        <asp:TableCell ID="innerR1C1" runat="server" Wrap="false" Width="1%">
                                            <asp:Literal ID="itlLast" runat="server" Text="Last Trip>>>"></asp:Literal>
                                        </asp:TableCell>
                                        <asp:TableCell ID="innerR1C2" runat="server">
                                            <asp:Calendar ID="calLast" runat="server" TodayDayStyle-BackColor="Maroon"></asp:Calendar>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow ID="innerR2" runat="server">
                                        <asp:TableCell ID="innerR2C1" runat="server" Wrap="false" Width="1%">
                                            <asp:Literal ID="ltlNext" runat="server" Text="Next Trip>>>"></asp:Literal>
                                        </asp:TableCell>
                                        <asp:TableCell ID="innerR2C2" runat="server">
                                            <asp:Calendar ID="calNext" runat="server" TodayDayStyle-BackColor="Maroon"></asp:Calendar>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="outerR3" runat="server">
                            <asp:TableCell ID="outerR3C1" runat="server" HorizontalAlign="Left" VerticalAlign="Top"
                                Width="1%" Wrap="False">Your Ability:</asp:TableCell>
                            <asp:TableCell ID="outerR3C2" runat="server">
                                <asp:DropDownList ID="ddAbility" runat="server">
                                    <asp:ListItem Text="Beginner"></asp:ListItem>
                                    <asp:ListItem Text="Competent"></asp:ListItem>
                                    <asp:ListItem Text="Expert"></asp:ListItem>
                                </asp:DropDownList>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="outerR4" runat="server">
                            <asp:TableCell ID="outerR4C1" runat="server" HorizontalAlign="Left" VerticalAlign="Top"
                                Width="1%" Wrap="False">Your Experience:</asp:TableCell>
                            <asp:TableCell ID="outerR4C2" runat="server">
                                <asp:ListBox ID="lstExperience" runat="server">
                                    <asp:ListItem Text="Ridden only on the road"></asp:ListItem>
                                    <asp:ListItem Text="Ridden on some forest fire-breaks"></asp:ListItem>
                                    <asp:ListItem Text="Ridden singletrack trails"></asp:ListItem>
                                    <asp:ListItem Text="Ridden down mountains"></asp:ListItem>
                                    <asp:ListItem Text="Raced down mountains"></asp:ListItem>
                                    <asp:ListItem Text="Won races down mountains"></asp:ListItem>
                                </asp:ListBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="outerR5" runat="server">
                            <asp:TableCell ID="outerR5C1" runat="server" HorizontalAlign="Left" VerticalAlign="Top"
                                Width="1%" Wrap="False">Your Goals:</asp:TableCell>
                            <asp:TableCell ID="outerR5C2" runat="server">
                                <asp:CheckBoxList ID="chkGoals" runat="server">
                                    <asp:ListItem Text="To get more road-riding experience"></asp:ListItem>
                                    <asp:ListItem Text="To get more mountain-biking experience"></asp:ListItem>
                                    <asp:ListItem Text="To upgrade my bike"></asp:ListItem>
                                    <asp:ListItem Text="To get the latest accessories"></asp:ListItem>
                                </asp:CheckBoxList>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="outerR6" runat="server">
                            <asp:TableCell ID="outerR6C1" runat="server" HorizontalAlign="Left" VerticalAlign="Top"
                                Width="1%" Wrap="False">Contact:</asp:TableCell>
                            <asp:TableCell ID="outerR6C2" runat="server">
                                <asp:RadioButtonList ID="optMarketing" runat="server">
                                    <asp:ListItem Selected="True">Do not send me sales information</asp:ListItem>
                                    <asp:ListItem>Only send me sales information from Adventure Works</asp:ListItem>
                                    <asp:ListItem>Send me any sales information I might be interested in</asp:ListItem>
                                </asp:RadioButtonList>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="outerR7" runat="server">
                            <asp:TableCell ID="outerR7C1" runat="server" HorizontalAlign="Left" VerticalAlign="Top"
                                Width="1%" Wrap="False">Where do you normally ride?</asp:TableCell>
                            <asp:TableCell ID="outerR7C2" runat="server">
                                <asp:ImageMap ID="imgMap" OnClick="imgMap_Click" runat="server" ImageUrl="~/Images/BikeTheWorld.gif"
                                    HotSpotMode="PostBack">
                                    <asp:PolygonHotSpot Coordinates="0,0,150,0,75,60,75,100,0,75" HotSpotMode="PostBack"
                                        PostBackValue="USA" TabIndex="1" />
                                    <asp:PolygonHotSpot Coordinates="160,0,225,0,200,60,125,60,125,25" HotSpotMode="PostBack"
                                        PostBackValue="Europe" TabIndex="2" />
                                </asp:ImageMap>
                                <asp:HiddenField ID="hdnRegion" runat="server" />
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="outerR8" runat="server">
                            <asp:TableCell ID="outerR8C1" runat="server" HorizontalAlign="Left" VerticalAlign="Top"
                                Width="1%" Wrap="False"></asp:TableCell>
                            <asp:TableCell ID="outerR8C2" runat="server">
                                <asp:ImageButton ID="ImageButton1" runat="server" PostBackUrl="~/SurveyReceipts.aspx"  ImageUrl="~/images/Submit.GIF"/>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>    
    </div>
    </form>
</body>
</html>
