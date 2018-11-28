#pragma checksum "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Areas\Manager\Views\Issues\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfe73ebc9234d65d2eee0e83f753977d75aa6bf3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Views_Issues_Index), @"mvc.1.0.view", @"/Areas/Manager/Views/Issues/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manager/Views/Issues/Index.cshtml", typeof(AspNetCore.Areas_Manager_Views_Issues_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Areas\Manager\Views\_ViewImports.cshtml"
using UrbanSolution.Services.Models;

#line default
#line hidden
#line 1 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Areas\Manager\Views\Issues\Index.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#line 2 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Areas\Manager\Views\Issues\Index.cshtml"
using UrbanSolution.Web.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfe73ebc9234d65d2eee0e83f753977d75aa6bf3", @"/Areas/Manager/Views/Issues/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a08b03058efd3ee7f12bb1eacf17cea0d04a4a61", @"/Areas/Manager/Views/_ViewImports.cshtml")]
    public class Areas_Manager_Views_Issues_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UrbanIssuesListingServiceModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Areas\Manager\Views\Issues\Index.cshtml"
  
    ViewData["Title"] = "Not approved issues";
    var apiKey = Configuration.GetSection("Google:MapsApiKey").Value;

#line default
#line hidden
            BeginContext(300, 39, true);
            WriteLiteral("\r\n<div row class=\"text-info\">\r\n    <h2>");
            EndContext();
            BeginContext(340, 22, false);
#line 11 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Areas\Manager\Views\Issues\Index.cshtml"
   Write(this.ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(362, 55, true);
            WriteLiteral("</h2>\r\n</div>\r\n\r\n<div class=\"row issues-listing\">\r\n    ");
            EndContext();
            BeginContext(418, 55, false);
#line 15 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Areas\Manager\Views\Issues\Index.cshtml"
Write(await Html.PartialAsync("_IssuesListingPartial", Model));

#line default
#line hidden
            EndContext();
            BeginContext(473, 88, true);
            WriteLiteral("\r\n</div>\r\n\r\n<br />\r\n\r\n\r\n<div class=\"slick-issues row issues-listing\" id=\"wrapper\">\r\n    ");
            EndContext();
            BeginContext(562, 55, false);
#line 22 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Areas\Manager\Views\Issues\Index.cshtml"
Write(await Html.PartialAsync("_IssuesListingPartial", Model));

#line default
#line hidden
            EndContext();
            BeginContext(617, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(744, 113, true);
            WriteLiteral("\r\n<br />\r\n\r\n<div class=\"form-group col-lg-12\">\r\n    <div id=\"map\" style=\"height: 500px;\">\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(880, 475, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('.slick-issues').slick({
                infinite: true,
                slidesToShow: 3,
                slidesToScroll: 3,
                dots: false,
                arrows: true,
                autoplay: true,
                autoplaySpeed: 700
            });
        });
    </script>

    <script>
        var map;

        function initMap() {
            var myLatLng = { lat: ");
                EndContext();
                BeginContext(1357, 30, false);
#line 54 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Areas\Manager\Views\Issues\Index.cshtml"
                              Write(WebConstants.MapCenterLatitude);

#line default
#line hidden
                EndContext();
                BeginContext(1388, 7, true);
                WriteLiteral(", lng: ");
                EndContext();
                BeginContext(1397, 31, false);
#line 54 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Areas\Manager\Views\Issues\Index.cshtml"
                                                                      Write(WebConstants.MapCenterLongitude);

#line default
#line hidden
                EndContext();
                BeginContext(1429, 175, true);
                WriteLiteral(" };\r\n            var mapOptions = { zoom: 12.8, center: myLatLng }\r\n            map = new google.maps.Map(document.getElementById(\'map\'), mapOptions);\r\n\r\n\r\n            $.get(\"");
                EndContext();
                BeginContext(1605, 50, false);
#line 59 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Areas\Manager\Views\Issues\Index.cshtml"
              Write(Url.Action("GetIssuesInfoBoxDetails", "IssuesApi"));

#line default
#line hidden
                EndContext();
                BeginContext(1655, 2053, true);
                WriteLiteral(@""",
                function(data, status) {
                    console.log(data);
                    var marker = [];
                    var contentString = [];
                    var infowindow = [];
                    for (var i = 0; i < data.length; i++) {
                        marker[i] = new google.maps.Marker({
                            position: { lat: parseFloat(data[i].latitude), lng: parseFloat(data[i].longitude) },
                            map: map
                        });
                        contentString[i] = '<div id=""content"">' +
                            '<div id=""siteNotice"">' +
                            '</div>' +
                            '<h1 id=""firstHeading"" class=""firstHeading"">' +
                            data[i].name +
                            '</h1>' +
                            '<div id=""bodyContent"">' +
                            '<p>' + data[i].description + '</p>' +
                            '<a href=""/issue/details/'+ data[i]");
                WriteLiteral(@".id +'""><h3 id=""content"">View Details</h3></a>' +
                            '</div>' +
                            '</div>';

                        infowindow[i] = new google.maps.InfoWindow({
                            content: contentString[i]
                        });
                        var markerValue = marker[i];

                        google.maps.event.addListener(markerValue, 'mouseover', (function(currentMarker, i) {
                            return function() {
                                infowindow[i].open(map, marker[i]);
                            }
                        })(marker[i], i));

                        google.maps.event.addListener(markerValue, 'mouseclick', (function (currentMarker, i) {
                            return function () {
                                infowindow[i].close();
                            }
                        })(marker[i], i));
                    }
                });
        }


    </script>

    <s");
                WriteLiteral("cript");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3708, "\"", 3784, 3);
                WriteAttributeValue("", 3714, "https://maps.googleapis.com/maps/api/js?key=", 3714, 44, true);
#line 105 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Areas\Manager\Views\Issues\Index.cshtml"
WriteAttributeValue("", 3758, apiKey, 3758, 9, false);

#line default
#line hidden
                WriteAttributeValue("", 3767, "&callback=initMap", 3767, 17, true);
                EndWriteAttribute();
                BeginContext(3785, 45, true);
                WriteLiteral("\r\n            async defer>\r\n    </script>\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(3833, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UrbanIssuesListingServiceModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
