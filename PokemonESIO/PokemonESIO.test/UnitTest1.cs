using System;
using NUnit.Framework;
using PokemonESIO;

namespace PokemonESIO.test
{
    [TestFixture]
    public class SinglePokemonServicesTest
    {
        singlePokemon SinglePokemon = new singlePokemon();

        public SinglePokemonServicesTest()
        {
            SinglePokemon.GetSinglePokemon("scyther");
        }
        
        [Test]
        public void Status200()
        {
            Assert.AreEqual("100", SinglePokemon.PokemonSingleResponseContent["base_experience"].ToString());
        }

        [Test]
        public void SinglePokemonId()
        {
            Assert.AreEqual("123", SinglePokemon.PokemonSingleResponseContent["id"].ToString());
        }

        [Test]
        public void SinglePokemonWeight()
        {
            Assert.AreEqual("560", SinglePokemon.PokemonSingleResponseContent["weight"].ToString());
        }

        [Test]
        public void SinglePokemonName()
        {
            Assert.AreEqual("scyther", SinglePokemon.PokemonSingleResponseContent["name"].ToString());
        }


        [Test]
        public void SinglePokemonAbility1()
        {
            Assert.AreEqual("steadfast", SinglePokemon.PokemonSingleResponseContent["abilities"][0]["ability"]["name"].ToString());
        }
    }
}
