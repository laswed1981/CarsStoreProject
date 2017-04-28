<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-1"></div>
                <div class="col-md-10">
                    <h1>Welcome To Cars Store  ( <small>We Have Toyota &  Honda </small> )</h1>
                    <hr />
                    <div class="row">
                        <div class="col-md-12">
                           

                             <div class="form-group">
                                <label>Brand Type</label>
                                <asp:DropDownList ID="ddlOperations1" runat="server" CssClass="dropdown form-control" OnSelectedIndexChanged="ddlOperations1_TextChanged" AutoPostBack="true">                                 
                                </asp:DropDownList>
                            </div>


                            <div class="form-group">
                                <label> Model</label>
                                <asp:DropDownList ID="ddlOperations2" runat="server" CssClass="dropdown form-control" OnSelectedIndexChanged="ddlOperations2_SelectedIndexChanged"  AutoPostBack="true" >                               
                                </asp:DropDownList>
                            </div>

                             <div class="form-group">
                                <label>Price </label>
                                <asp:TextBox ID="txtPrice" Enabled="false" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>

                               <div class="form-group">
                                <label>Qty </label>
                                <asp:TextBox ID="txtQty"  runat="server" CssClass="form-control"></asp:TextBox>
                            </div>



                            <div class="form-group">
                                <asp:Button ID="btnbill" runat="server" Text="Bill" CssClass="btn btn-primary" OnClick="btnbill_Click" />
                                <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn" />
                            </div>
                            <div class="form-group">
                                <label>Total </label>
                                <asp:TextBox ID="txtTotal" Enabled="false" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-1"></div>
            </div>
        </div>
    </form>
</body>
</html>
