using Marvel.Services.Character.Enum;
using MarvelBackend.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestMarvelApi
{
    [TestClass]
    public class CharacterTest
    {
        [TestMethod]
        public void ValidarInput()
        {
            var charController = new CharactersController();
            var name = "";
            var limit = 50;
            var offset = 0;
            var result = charController.Get(name,
                                            null,
                                            DateTime.MinValue,
                                            null,
                                            null,
                                            null,
                                            null,
                                            ResultOrder.Modified,
                                            50,
                                            0);
            Assert.AreEqual(result.Value.Limit, limit);
            Assert.AreEqual(result.Value.Offset, offset);


        }
    }
}
