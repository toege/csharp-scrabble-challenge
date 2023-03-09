using csharp_scrabble_challenge.Main;
using NUnit.Framework;

namespace csharp_scrabble_challenge_exemplar.Test
{
    [TestFixture]
    public class ScrabbleTest
    {        
        [Test]
        public void shouldGive0ForSpace()
        {
            Scrabble scrabble = new Scrabble(" ");
            Assert.AreEqual(0, scrabble.score());
        }

        [Test]
        public void shouldGive0ForEmptyWords()
        {
            Scrabble scrabble = new Scrabble("");
            Assert.AreEqual(0, scrabble.score());
        }

        [Test]
        public void shouldGive0ForWhiteSpace()
        {
            Scrabble scrabble = new Scrabble("\n\r\t\b\f");
            Assert.AreEqual(0, scrabble.score());
        }

        [Test]
        public void shouldScore1ForA()
        {
            Scrabble scrabble = new Scrabble("a");
            Assert.AreEqual(1, scrabble.score());
        }

        [Test]
        public void shouldScore4ForF()
        {
            Scrabble scrabble = new Scrabble("f");
            Assert.AreEqual(4, scrabble.score());
        }

        [Test]
        public void shouldScore6ForStreet()
        {
            Scrabble scrabble = new Scrabble("street");
            Assert.AreEqual(6, scrabble.score());
        }

        [Test]
        public void shouldScore22ForQuirky()
        {
            Scrabble scrabble = new Scrabble("quirky");
            Assert.AreEqual(22, scrabble.score());
        }

        [Test]
        public void shouldScore41ForCaseInsensitiveWord()
        {
            Scrabble scrabble = new Scrabble("OXyPHEnBUTaZoNE");
            Assert.AreEqual(41, scrabble.score());
        }

    }
}