using Numbro;
using System;
using Xunit;

namespace Numbro.Tests {
    public class UnitTest1 {
        [Theory]
        [InlineData (0, "nul")] // nulo? https://en.wikibooks.org/wiki/Esperanto:_A_Complete_and_Comprehensive_Grammar/Numbers
        [InlineData (1, "unu")]
        [InlineData (2, "du")]
        [InlineData (3, "tri")]
        [InlineData (4, "kvar")]
        [InlineData (5, "kvin")]
        [InlineData (6, "ses")]
        [InlineData (7, "sep")]
        [InlineData (8, "ok")]
        [InlineData (9, "naŭ")] // naux?
        [InlineData (10, "dek")]
        [InlineData (11, "dek unu")]
        [InlineData (15, "dek kvin")]
        [InlineData (17, "dek sep")]
        [InlineData (20, "dudek")]
        [InlineData (25, "dudek kvin")]
        [InlineData (31, "tridek unu")]
        [InlineData (71, "sepdek unu")]
        [InlineData (122, "cent dudek du")]
        [InlineData (256, "ducent kvindek ses")]
        [InlineData (3501, "tri mil kvincent unu")]
        [InlineData (100, "cent")]
        [InlineData (1000, "mil")]
        [InlineData (100000, "cent mil")]
        [InlineData (1000000, "miliono")]
        [InlineData (10000000, "dek miliono")]
        [InlineData (100000000, "cent miliono")]
        [InlineData (1000000000, "miliardo")] // or biliono http://esperanto.org/stanford/numeroj/ vs https://eo.wikipedia.org/wiki/Miliardo
        //[InlineData (1000000000000, "duiliono")]
        [InlineData (111, "cent dek unu")]
        [InlineData (1111, "mil cent dek unu")]
        [InlineData (111111, "cent dek unu mil cent dek unu")]
        [InlineData (1111111, "miliono cent dek unu mil cent dek unu")]
        [InlineData (11111111, "dek unu miliono cent dek unu mil cent dek unu")]
        [InlineData (111111111, "cent dek unu miliono cent dek unu mil cent dek unu")]
        [InlineData (1111111111, "miliardo cent dek unu miliono cent dek unu mil cent dek unu")]
        [InlineData (123, "cent dudek tri")]
        [InlineData (1234, "mil ducent tridek kvar")]
        [InlineData (12345, "dek du mil tricent kvardek kvin")]
        [InlineData (123456, "cent dudek tri mil kvarcent kvindek ses")]
        [InlineData (1234567, "miliono ducent tridek kvar mil kvincent sesdek sep")]
        [InlineData (12345678, "dek du miliono tricent kvardek kvin mil sescent sepdek ok")]
        [InlineData (123456789, "cent dudek tri miliono kvarcent kvindek ses mil sepcent okdek naŭ")]
        [InlineData (1234567890, "miliardo ducent tridek kvar miliono kvincent sesdek sep mil okcent naŭdek")]
        [InlineData (1234567899, "miliardo ducent tridek kvar miliono kvincent sesdek sep mil okcent naŭdek naŭ")]
        [InlineData (223, "ducent dudek tri")]
        //[InlineData(2234, "deux mille deux cent trente-quatre")]
        //[InlineData(22345, "vingt-deux mille trois cent quarante-cinq")]
        //[InlineData(223456, "deux cent vingt-trois mille quatre cent cinquante-six")]
        //[InlineData(2234567, "deux millions deux cent trente-quatre mille cinq cent soixante-sept")]
        //[InlineData(22345678, "vingt-deux millions trois cent quarante-cinq mille six cent soixante-dix-huit")]
        //[InlineData(223456789, "deux cent vingt-trois millions quatre cent cinquante-six mille sept cent quatre-vingt-neuf")]
        //[InlineData(2147483646, "deux milliards cent quarante-sept millions quatre cent quatre-vingt-trois mille six cent quarante-six")]
        //[InlineData(1999, "mil naŭcent naŭdek naŭ")]
        [InlineData (2014, "du mil dek kvar")]
        [InlineData (2048, "du mil kvardek ok")]
        public void ToWords(int number, string expected) {
            Assert.Equal (expected, number.ToWords ());
        }
    }
}
