#pragma checksum "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50dd0379704d6561fbdec2b83eb6996f33c94105"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_SearchResult), @"mvc.1.0.view", @"/Views/Search/SearchResult.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Search/SearchResult.cshtml", typeof(AspNetCore.Views_Search_SearchResult))]
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
#line 1 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\_ViewImports.cshtml"
using TransportServicesApp;

#line default
#line hidden
#line 2 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\_ViewImports.cshtml"
using TransportServicesApp.Models;

#line default
#line hidden
#line 3 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\_ViewImports.cshtml"
using TransportServicesApp.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50dd0379704d6561fbdec2b83eb6996f33c94105", @"/Views/Search/SearchResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90866365b0e2ba9c5feea6355549a46a744b22ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_SearchResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SearchResultViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdvertDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
  
    ViewData["Title"] = "Ogłoszenia";

#line default
#line hidden
            BeginContext(91, 71, true);
            WriteLiteral("\r\n<h1 style=\"text-align: center\">Dostępne Ogłoszenia</h1>\r\n<hr />\r\n\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
 if (Model.Any())
{
    foreach (var advert in Model)
    {

#line default
#line hidden
            BeginContext(226, 45, true);
            WriteLiteral("        <div class=\"card mb-3\">\r\n            ");
            EndContext();
            BeginContext(271, 1270, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50dd0379704d6561fbdec2b83eb6996f33c941055170", async() => {
                BeginContext(357, 225, true);
                WriteLiteral("\r\n                <div class=\"card-header\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-8\">\r\n                            <p>\r\n                                <span class=\"text-black-50\">");
                EndContext();
                BeginContext(583, 17, false);
#line 21 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                                                       Write(advert.AdvertType);

#line default
#line hidden
                EndContext();
                BeginContext(600, 151, true);
                WriteLiteral("</span>\r\n                                <span style=\"color: black\"> transportu z </span>\r\n                                <span class=\"text-black-50\">");
                EndContext();
                BeginContext(752, 15, false);
#line 23 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                                                       Write(advert.CityFrom);

#line default
#line hidden
                EndContext();
                BeginContext(767, 141, true);
                WriteLiteral("</span>\r\n                                <span style=\"color: black\"> do </span>\r\n                                <span class=\"text-black-50\">");
                EndContext();
                BeginContext(909, 13, false);
#line 25 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                                                       Write(advert.CityTo);

#line default
#line hidden
                EndContext();
                BeginContext(922, 74, true);
                WriteLiteral("</span>\r\n                            </p>\r\n                            <p>");
                EndContext();
                BeginContext(997, 13, false);
#line 27 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                          Write(advert.Expire);

#line default
#line hidden
                EndContext();
                BeginContext(1010, 97, true);
                WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"col-md-4 text-right\">\r\n");
                EndContext();
#line 30 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                              
                                var imgSrc = String.Format("data:image/gif;base64,{0}", advert.UserImage);
                            

#line default
#line hidden
                BeginContext(1278, 55, true);
                WriteLiteral("                            <span style=\"color: black\">");
                EndContext();
                BeginContext(1334, 15, false);
#line 33 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                                                  Write(advert.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(1349, 41, true);
                WriteLiteral("</span>\r\n                            <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1390, "\"", 1403, 1);
#line 34 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
WriteAttributeValue("", 1396, imgSrc, 1396, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1404, 133, true);
                WriteLiteral(" style=\"height:80px; width:80px\" />\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-advertId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 16 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                                                                          WriteLiteral(advert.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["advertId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-advertId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["advertId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1541, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 39 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
             if (advert.AdvertType == "Prośba")
            {

#line default
#line hidden
            BeginContext(1607, 191, true);
            WriteLiteral("                <div class=\"card-body\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-3\">\r\n                            <label>Rodzaj Transportu:</label>\r\n");
            EndContext();
#line 45 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                             if (advert.AdvertOption == 1)
                            {

#line default
#line hidden
            BeginContext(1889, 84, true);
            WriteLiteral("                                <h6 class=\"text-black-50\">Przejazd Pasażerski</h6>\r\n");
            EndContext();
#line 48 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                            }
                            else if (advert.AdvertOption == 2)
                            {

#line default
#line hidden
            BeginContext(2099, 79, true);
            WriteLiteral("                                <h6 class=\"text-black-50\">Przewóz Towaru</h6>\r\n");
            EndContext();
#line 52 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2274, 80, true);
            WriteLiteral("                                <h6 class=\"text-black-50\">Niezdefiniowany</h6>\r\n");
            EndContext();
#line 56 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                            }

#line default
#line hidden
            BeginContext(2385, 32, true);
            WriteLiteral("                        </div>\r\n");
            EndContext();
#line 58 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                         if (advert.AdvertOption == 1 || advert.AdvertOption == 0)
                        {

#line default
#line hidden
            BeginContext(2528, 175, true);
            WriteLiteral("                            <div class=\"col-md-3\">\r\n                                <label>Ilość Pasażerów:</label>\r\n                                <h6 class=\"text-black-50\">");
            EndContext();
            BeginContext(2704, 23, false);
#line 62 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                                                     Write(advert.PassengerAmmount);

#line default
#line hidden
            EndContext();
            BeginContext(2727, 160, true);
            WriteLiteral("</h6>\r\n                            </div>\r\n                            <div class=\"col-md-3\">\r\n                                <label>Dodatkowy Bagaż:</label>\r\n");
            EndContext();
#line 66 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                                 if (advert.AdditionalBaggage)
                                {

#line default
#line hidden
            BeginContext(2986, 72, true);
            WriteLiteral("                                    <h6 class=\"text-black-50\">Tak</h6>\r\n");
            EndContext();
#line 69 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3166, 72, true);
            WriteLiteral("                                    <h6 class=\"text-black-50\">Nie</h6>\r\n");
            EndContext();
#line 73 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                                }

#line default
#line hidden
            BeginContext(3273, 36, true);
            WriteLiteral("                            </div>\r\n");
            EndContext();
#line 75 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                        }

#line default
#line hidden
            BeginContext(3336, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 76 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                         if (advert.AdvertOption == 2 || advert.AdvertOption == 0)
                        {

#line default
#line hidden
            BeginContext(3447, 168, true);
            WriteLiteral("                            <div class=\"col-md-3\">\r\n                                <label>Rozmiary:</label>\r\n                                <h6 class=\"text-black-50\">");
            EndContext();
            BeginContext(3616, 11, false);
#line 80 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                                                     Write(advert.Size);

#line default
#line hidden
            EndContext();
            BeginContext(3627, 207, true);
            WriteLiteral("</h6>\r\n                            </div>\r\n                            <div class=\"col-md-3\">\r\n                                <label>Waga:</label>\r\n                                <h6 class=\"text-black-50\">");
            EndContext();
            BeginContext(3835, 13, false);
#line 84 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                                                     Write(advert.Weight);

#line default
#line hidden
            EndContext();
            BeginContext(3848, 163, true);
            WriteLiteral(" Kg</h6>\r\n                            </div>\r\n                            <div class=\"col-md-3\">\r\n                                <label>Towar delikatny:</label>\r\n");
            EndContext();
#line 88 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                                 if (advert.IsFragile)
                                {

#line default
#line hidden
            BeginContext(4102, 72, true);
            WriteLiteral("                                    <h6 class=\"text-black-50\">Tak</h6>\r\n");
            EndContext();
#line 91 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(4282, 72, true);
            WriteLiteral("                                    <h6 class=\"text-black-50\">Nie</h6>\r\n");
            EndContext();
#line 95 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                                }

#line default
#line hidden
            BeginContext(4389, 36, true);
            WriteLiteral("                            </div>\r\n");
            EndContext();
#line 97 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                        }

#line default
#line hidden
            BeginContext(4452, 52, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n");
            EndContext();
#line 100 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
            }

#line default
#line hidden
            BeginContext(4519, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 101 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
             if (advert.AdvertType == "Oferta")
            {

#line default
#line hidden
            BeginContext(4583, 191, true);
            WriteLiteral("                <div class=\"card-body\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-3\">\r\n                            <label>Rodzaj Transportu:</label>\r\n");
            EndContext();
#line 107 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                             if (advert.AdvertOption == 1)
                            {

#line default
#line hidden
            BeginContext(4865, 84, true);
            WriteLiteral("                                <h6 class=\"text-black-50\">Przejazd Pasażerski</h6>\r\n");
            EndContext();
#line 110 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                            }
                            else if (advert.AdvertOption == 2)
                            {

#line default
#line hidden
            BeginContext(5075, 79, true);
            WriteLiteral("                                <h6 class=\"text-black-50\">Przewóz Towaru</h6>\r\n");
            EndContext();
#line 114 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(5250, 80, true);
            WriteLiteral("                                <h6 class=\"text-black-50\">Niezdefiniowany</h6>\r\n");
            EndContext();
#line 118 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                            }

#line default
#line hidden
            BeginContext(5361, 32, true);
            WriteLiteral("                        </div>\r\n");
            EndContext();
#line 120 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                         if (advert.AdvertOption == 1 || advert.AdvertOption == 0)
                        {

#line default
#line hidden
            BeginContext(5504, 175, true);
            WriteLiteral("                            <div class=\"col-md-3\">\r\n                                <label>Limit Pasażerów:</label>\r\n                                <h6 class=\"text-black-50\">");
            EndContext();
            BeginContext(5680, 21, false);
#line 124 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                                                     Write(advert.PassengerLimit);

#line default
#line hidden
            EndContext();
            BeginContext(5701, 171, true);
            WriteLiteral("</h6>\r\n                            </div>\r\n                            <div class=\"col-md-3\">\r\n                                <label>Miejsce Na Dodatkowy Bagaż:</label>\r\n");
            EndContext();
#line 128 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                                 if (advert.AdditionalBaggage == true)
                                {

#line default
#line hidden
            BeginContext(5979, 72, true);
            WriteLiteral("                                    <h6 class=\"text-black-50\">Tak</h6>\r\n");
            EndContext();
#line 131 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(6159, 72, true);
            WriteLiteral("                                    <h6 class=\"text-black-50\">Nie</h6>\r\n");
            EndContext();
#line 135 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                                }

#line default
#line hidden
            BeginContext(6266, 36, true);
            WriteLiteral("                            </div>\r\n");
            EndContext();
#line 137 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                        }

#line default
#line hidden
            BeginContext(6329, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 138 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                         if (advert.AdvertOption == 1)
                        {

#line default
#line hidden
            BeginContext(6412, 174, true);
            WriteLiteral("                            <div class=\"col-md-3\">\r\n                                <label>Zajęte miejsca:</label>\r\n                                <h6 class=\"text-black-50\">");
            EndContext();
            BeginContext(6587, 17, false);
#line 142 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                                                     Write(advert.SeatsTaken);

#line default
#line hidden
            EndContext();
            BeginContext(6604, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(6608, 21, false);
#line 142 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                                                                          Write(advert.PassengerLimit);

#line default
#line hidden
            EndContext();
            BeginContext(6629, 43, true);
            WriteLiteral("</h6>\r\n                            </div>\r\n");
            EndContext();
#line 144 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                        }

#line default
#line hidden
            BeginContext(6699, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 145 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                         if (advert.AdvertOption == 2 || advert.AdvertOption == 0)
                        {

#line default
#line hidden
            BeginContext(6810, 173, true);
            WriteLiteral("                            <div class=\"col-md-3\">\r\n                                <label>Max. Rozmiary:</label>\r\n                                <h6 class=\"text-black-50\">");
            EndContext();
            BeginContext(6984, 14, false);
#line 149 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                                                     Write(advert.MaxSize);

#line default
#line hidden
            EndContext();
            BeginContext(6998, 212, true);
            WriteLiteral("</h6>\r\n                            </div>\r\n                            <div class=\"col-md-3\">\r\n                                <label>Max. Waga:</label>\r\n                                <h6 class=\"text-black-50\">");
            EndContext();
            BeginContext(7211, 16, false);
#line 153 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                                                     Write(advert.MaxWeight);

#line default
#line hidden
            EndContext();
            BeginContext(7227, 151, true);
            WriteLiteral("</h6>\r\n                            </div>\r\n                            <div class=\"col-md-3\">\r\n                                <label>Status:</label>\r\n");
            EndContext();
#line 157 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                                 if (advert.IsOccupied)
                                {

#line default
#line hidden
            BeginContext(7470, 82, true);
            WriteLiteral("                                    <h6 class=\"text-black-50\">Zarezerwowana</h6>\r\n");
            EndContext();
#line 160 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(7660, 77, true);
            WriteLiteral("                                    <h6 class=\"text-black-50\">Dostępna</h6>\r\n");
            EndContext();
#line 164 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                                }

#line default
#line hidden
            BeginContext(7772, 36, true);
            WriteLiteral("                            </div>\r\n");
            EndContext();
#line 166 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
                        }

#line default
#line hidden
            BeginContext(7835, 52, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n");
            EndContext();
#line 169 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
            }


            

#line default
#line hidden
            BeginContext(8922, 16, true);
            WriteLiteral("        </div>\r\n");
            EndContext();
#line 191 "C:\Users\Wojas\Desktop\Inzynierka\inzynierka_New\TransportServicesApp\TransportServicesApp\Views\Search\SearchResult.cshtml"
    }
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SearchResultViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
