#pragma checksum "C:\Users\mathe\OneDrive\Área de Trabalho\InstaDev\Views\EditarPerfil\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d0f52974ed4860cc09362bb1dbdd9acaccd6c2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EditarPerfil_Index), @"mvc.1.0.view", @"/Views/EditarPerfil/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\mathe\OneDrive\Área de Trabalho\InstaDev\Views\_ViewImports.cshtml"
using InstaDev;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mathe\OneDrive\Área de Trabalho\InstaDev\Views\_ViewImports.cshtml"
using InstaDev.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d0f52974ed4860cc09362bb1dbdd9acaccd6c2e", @"/Views/EditarPerfil/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e21b0f649ba389abf6f454a8c2b6a61dd9d6b1f5", @"/Views/_ViewImports.cshtml")]
    public class Views_EditarPerfil_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "link para excluir equipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "EditarPerfil", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Excluir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mathe\OneDrive\Área de Trabalho\InstaDev\Views\EditarPerfil\Index.cshtml"
  
    ViewData["Title"] = "EditarPerfil";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d0f52974ed4860cc09362bb1dbdd9acaccd6c2e4542", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"">
    <link href=""https://fonts.googleapis.com/css2?family=Lato:wght@400;700&display=swap"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.2/css/all.min.css"" integrity=""sha512-HK5fgLBL+xu6dm/Ii3z4xhlSUyZgTT9tuc/hSrtw6uzJOvgRr2a9jyxxT1ely+B+xFAmJKVSTbpM/CuL7qxO8w=="" crossorigin=""anonymous""/>
    <link rel=""stylesheet"" href=""EdicaoPerfil.css"">
    <title>EditarPerfil</title>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d0f52974ed4860cc09362bb1dbdd9acaccd6c2e6137", async() => {
                WriteLiteral(@"
    <!-- Início Header -->
    <header>
        <div class=""center"">    
    
            <div class=""logo-header"">
                <a href=""#""><img src=""img/Instadev.svg"" alt=""logo Instadev""></a>
            </div> <!-- logo da header -->
            
    
            <div class=""search"">
    
                <div class=""search-box"">
    
                    <i class=""fas fa-search""></i>
                    <input placeholder=""Pesquisar"" type=""text"" name=""busca"">
    
                </div><!-- search-box-->
                
            </div> <!-- search-->
            
    
            <div class=""notify"">
                
                <a href=""#""><img src=""img/Vector.svg""></a>
                <a href=""#""><img src=""img/plane 1.svg""></i></a>
                <a href=""#""><i class=""far fa-compass""></i></i></a>
                <a href=""#""><i class=""far fa-heart""></i></a>
    
                <div class=""img-miniatura""><img src=""img/IMG_20201028_173745_375 (4).jpg""  ></div>
    ");
                WriteLiteral(@"        </div><!--icones-->
    
        </div><!--center div de centralizar-->
    </header>
    <!-- Fim Header -->

    <main class=container>
        <section class=""content"">
            <div class=""barra-divisao""></div>
            <div class=""esquerdo"">
                <div class=""barra-esquerda""></div>
                <div class=""editar-perfil"">Editar Perfil</div>
            </div>
            <div class=""direito"">
                <div class=""foto-perfil"">
                    <img src=""img/thank-you 2.png"" alt=""Foto de perfil"" class=""img"">
                    <div class=""username"">Strilicherk</div>
                    <a href=""#"" class=""alterar-foto"">Alterar foto de perfil</a>
                </div>
                <div class=""nome"">
                    <h1>Nome</h1>
                    <input type=""text"">
                    <p>Ajude as pessoas a descobrir sua conta usando o nome pelo qual você é conhecido: seu nome completo, apelido ou nome comercial. <br>
                   ");
                WriteLiteral(@" <br>
                    Você pode alterar o seu nome apenas duas vezes a cada 14 dias.</p>
                </div>
                <div class=""nome-usuario"">
                    <h2>Nome de Usuário</h2>
                    <input type=""text"">
                    <p>Na maioria dos casos, você poderá alterar seu nome de usuário novamente para nascimento_tr por mais 14 dias.<br>
                        <br>
                    Informações pessoais <br> Forneça suas informações pessoais, mesmo se a conta for usada para uma empresa, um animal de estimação ou outra coisa. Elas não farão parte do seu perfil público.</p>
                </div>
                <div class=""email"">
                    <h3>Email</h3>
                    <input type=""email"">
                </div>
                <div class=""inferior"">
                    <button>Enviar</button>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d0f52974ed4860cc09362bb1dbdd9acaccd6c2e9495", async() => {
                    WriteLiteral("Desativar minha conta definitivamente");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </section>\r\n    </main>\r\n    <footer></footer>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591