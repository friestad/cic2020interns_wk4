﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="comparison.aspx.cs" Inherits="Ibm.Br.Cic.Internship.Covid.Fe.statistics.comparison" %>

<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>IBM Code Blue - Statistics by Apify and Covid19Api</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous" />
    <link href="https://fonts.googleapis.com/css2?family=Open+Sans+Condensed:wght@300&display=swap" rel="stylesheet" />
    <link rel="shortcut icon" type="image/jpg" href="/codeblue.jpg" />
    <link rel="stylesheet" href="../css/main.css" />
</head>
<body>
    <header>
        <nav class="navbar navbar-default">
            <div class="container">
                <img src="../codeblue.jpg" alt="Code Blue" class="brand-logo" />
                <h1>Code Blue Against C19</h1>
            </div>
        </nav>
    </header>
    <div class="container">
        <div class="row">

            <div class="col">
                <div id="chartdiv"></div>
            </div>
        </div>
        <div class="row">
            <div class="col-6">
                <h5>API v2 (RED)</h5>
                <div id="tablediv1"></div>
            </div>
            <div class="col-6">
                <h5>API v1 (BLUE)</h5>
                <div id="tablediv2"></div>
            </div>"
        </div>"
    </div>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js" integrity="sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI" crossorigin="anonymous"></script>
    <script src="https://www.amcharts.com/lib/4/core.js"></script>
    <script src="https://www.amcharts.com/lib/4/maps.js"></script>
    <script src="https://www.amcharts.com/lib/4/geodata/worldLow.js"></script>
    <script src="https://www.amcharts.com/lib/4/themes/animated.js"></script>
    <script src="../js/comparison.js"></script>
</body>
</html>
