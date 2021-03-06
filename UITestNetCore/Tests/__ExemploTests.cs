﻿using UITestNetCore.Bases;
using UITestNetCore.Flows;
using UITestNetCore.Helpers;
using UITestNetCore.Pages;
using NUnit.Framework;

namespace UITestNetCore.Tests
{
    [TestFixture]
    public class __ExemploTests : TestBase
    {

        #region Pages and Flows Objects       
       

        #endregion

        [Test]
        public void ExemploTeste()
        {
            __ExemploPage exemploPage = new __ExemploPage();

            exemploPage.EscreverTxtPesquisar("Teste");
            exemploPage.ClicarBtnPesquisar();

            //Assert.IsTrue(true);
        }
		
		[Test, Category("teste_com_categoria")]
        public void ExemploTeste2()
        {
            __ExemploPage exemploPage = new __ExemploPage();

            exemploPage.EscreverTxtPesquisar("Teste Com Categoria");
            exemploPage.ClicarBtnPesquisar();

            //Assert.IsTrue(true);
        }
    }
}
