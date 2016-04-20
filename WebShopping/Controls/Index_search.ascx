<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Index_search.ascx.cs" Inherits="WebShopping.Controls.Index_search" %>
<style>
    ._search_div {
        width: 600px;
        height: 45px;
        margin: 5px auto;
        border:3px solid #FF6537;
    }

        ._search_div input {
            width: 490px;
            height: 37px;
            padding: 3px 6px;
            font: 14px/35px Helvetica, Verdana, sans-serif;
            float: left;
        }
        ._search_div a {
            border: 1px solid #FF6537;
            width: 82px;
            display: block;
            height: 38px;
            font: 18px/35px Helvetica, Verdana, sans-serif;
            float: left;
            padding: 3px 6px;
            text-align:center;
           color:white;
           background-color:#FF6537;
        }
</style>
<div class="_search_div">
    <input type="text"   placeholder="家用电器火爆销售" /><a>搜索</a>

</div>
