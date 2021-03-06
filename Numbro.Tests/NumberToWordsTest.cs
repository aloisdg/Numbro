﻿using Numbro;
using System;
using Xunit;

namespace Numbro.Tests {
    public class NumberToWordsTest {
        [Theory]
        [InlineData (-42, "minus kvardek du")]
        [InlineData (-1, "minus unu")]
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
        [InlineData (3501, "trimil kvincent unu")]
        [InlineData (100, "cent")]
        [InlineData (1000, "mil")]
        [InlineData (10000, "dek mil")]
        [InlineData (100000, "cent mil")]
        [InlineData (1000000, "miliono")]
        [InlineData (10000000, "dek miliono")]
        [InlineData (100000000, "cent miliono")]
        [InlineData (1000000000, "miliardo")] // or biliono http://esperanto.org/stanford/numeroj/ vs https://eo.wikipedia.org/wiki/Miliardo
        //[InlineData (1000000000000, "duiliono")]
        [InlineData (110, "cent dek")]
        [InlineData (1100, "mil cent")]
        [InlineData (11000, "dek unu mil")]
        [InlineData (111, "cent dek unu")]
        [InlineData (1111, "mil cent dek unu")]
        [InlineData (111111, "cent dek unu mil cent dek unu")]
        [InlineData (1111111, "miliono cent dek unu mil cent dek unu")]
        [InlineData (11111111, "dek unu miliono cent dek unu mil cent dek unu")]
        [InlineData (111111111, "cent dek unu miliono cent dek unu mil cent dek unu")]
        [InlineData (1111111111, "miliardo cent dek unu miliono cent dek unu mil cent dek unu")]
        [InlineData (123, "cent dudek tri")]
        [InlineData (1234, "mil ducent tridek kvar")]
        [InlineData (12345, "dek dumil tricent kvardek kvin")]
        [InlineData (123456, "cent dudek trimil kvarcent kvindek ses")]
        [InlineData (1234567, "miliono ducent tridek kvarmil kvincent sesdek sep")]
        [InlineData (12345678, "dek du miliono tricent kvardek kvinmil sescent sepdek ok")]
        [InlineData (123456789, "cent dudek tri miliono kvarcent kvindek sesmil sepcent okdek naŭ")]
        [InlineData (1234567890, "miliardo ducent tridek kvar miliono kvincent sesdek sepmil okcent naŭdek")]
        [InlineData (1234567899, "miliardo ducent tridek kvar miliono kvincent sesdek sepmil okcent naŭdek naŭ")]
        [InlineData (223, "ducent dudek tri")]
        //[InlineData(2234, "deux mille deux cent trente-quatre")]
        //[InlineData(22345, "vingt-deux mille trois cent quarante-cinq")]
        //[InlineData(223456, "deux cent vingt-trois mille quatre cent cinquante-six")]
        //[InlineData(2234567, "deux millions deux cent trente-quatre mille cinq cent soixante-sept")]
        //[InlineData(22345678, "vingt-deux millions trois cent quarante-cinq mille six cent soixante-dix-huit")]
        //[InlineData(223456789, "deux cent vingt-trois millions quatre cent cinquante-six mille sept cent quatre-vingt-neuf")]
        //[InlineData(2147483646, "deux milliards cent quarante-sept millions quatre cent quatre-vingt-trois mille six cent quarante-six")]
        [InlineData (1999, "mil naŭcent naŭdek naŭ")]
        [InlineData (2014, "dumil dek kvar")]
        [InlineData (2048, "dumil kvardek ok")]
        [InlineData (31786, "tridek unu mil sepcent okdek ses")]
        [InlineData (30786, "tridek mil sepcent okdek ses")]
        public void ToWords(int number, string expected) {
            Assert.Equal (expected, number.ToWords ());
        }

        [Theory]
        [InlineData (0, "nula")]
        [InlineData (1, "unua")]
        [InlineData (2, "dua")]
        [InlineData (3, "tria")]
        [InlineData (4, "kvara")]
        [InlineData (5, "kvina")]
        [InlineData (6, "sesa")]
        [InlineData (7, "sepa")]
        [InlineData (8, "oka")]
        [InlineData (9, "naŭa")]
        [InlineData (10, "deka")]
        //[InlineData(11, "onzième")]
        //[InlineData(12, "douzième")]
        //[InlineData(13, "treizième")]
        //[InlineData(14, "quatorzième")]
        //[InlineData(15, "quinzième")]
        //[InlineData(16, "seizième")]
        //[InlineData(17, "dix-septième")]
        //[InlineData(18, "dix-huitième")]
        //[InlineData(19, "dix-neuvième")]
        //[InlineData(20, "vingtième")]
        //[InlineData(21, "vingt et unième")]
        //[InlineData(22, "vingt-deuxième")]
        //[InlineData(30, "trentième")]
        //[InlineData(40, "quarantième")]
        //[InlineData(50, "cinquantième")]
        //[InlineData(60, "soixantième")]
        //[InlineData(70, "soixante-dixième")]
        //[InlineData(80, "quatre-vingtième")]
        //[InlineData(90, "quatre-vingt-dixième")]
        //[InlineData(95, "quatre-vingt-quinzième")]
        //[InlineData(96, "quatre-vingt-seizième")]
        [InlineData (100, "centa")]
        [InlineData (120, "cent dudeka")]
        [InlineData (121, "cent dudek unua")]
        [InlineData (1000, "mila")]
        [InlineData (1001, "mil unua")]
        [InlineData (1021, "mil dudek unua")]
        [InlineData (3000, "trimila")]
        [InlineData (10000, "dek mila")]
        [InlineData (10121, "dek mil cent dudek unua")]
        [InlineData (100000, "cent mila")]
        [InlineData (1000000, "milionoa")]
        [InlineData (1000000000, "miliardoa")]
        public void ToOrdinalWords(int number, string words) {
            Assert.Equal (words, number.ToOrdinalWords ());
        }
    }
}
