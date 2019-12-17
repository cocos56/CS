<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="01GetCheckCode.aspx.cs" Inherits="获取验证码._01GetCheckCode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>获取验证码</title>
    <script type="text/javascript">
        
    </script>
</head>

<body>
    <img src="CheckCode.ashx" onclick="this.src='CheckCode.ashx?id='+Math.random()" />
</body>
</html>
