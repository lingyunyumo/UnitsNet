﻿// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using UnitsNet.Units;
using Xunit;

namespace UnitsNet.Tests
{
    public class BaseUnitsTests
    {
        [Fact]
        public void ConstructorSetsUnitsProperly()
        {
            var baseUnits = new BaseUnits(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela);

            Assert.Equal(LengthUnit.Meter, baseUnits.Length);
            Assert.Equal(MassUnit.Kilogram, baseUnits.Mass);
            Assert.Equal(DurationUnit.Second, baseUnits.Time);
            Assert.Equal(ElectricCurrentUnit.Ampere, baseUnits.Current);
            Assert.Equal(TemperatureUnit.Kelvin, baseUnits.Temperature);
            Assert.Equal(AmountOfSubstanceUnit.Mole, baseUnits.Amount);
            Assert.Equal(LuminousIntensityUnit.Candela, baseUnits.LuminousIntensity);
        }

        [Fact]
        public void EqualsObjectIsImplementedCorrectly()
        {
            var baseUnits1 = new BaseUnits(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela);

            var baseUnits2 = new BaseUnits(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela);

            var baseUnits3 = new BaseUnits(LengthUnit.Foot, MassUnit.Pound, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.DegreeFahrenheit, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela);

            Assert.True(baseUnits1.Equals((object)baseUnits2));
            Assert.False(baseUnits1.Equals((object)baseUnits3));

            Assert.False(baseUnits1.Equals("Some object."));
            Assert.False(baseUnits1.Equals((IFormatProvider)null));
        }

        [Fact]
        public void EqualsBaseUnitsIsImplementedCorrectly()
        {
            var baseUnits1 = new BaseUnits(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela);

            var baseUnits2 = new BaseUnits(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela);

            var baseUnits3 = new BaseUnits(LengthUnit.Foot, MassUnit.Pound, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.DegreeFahrenheit, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela);

            Assert.True(baseUnits1.Equals(baseUnits2));
            Assert.True(baseUnits2.Equals(baseUnits1));

            Assert.False(baseUnits1.Equals(baseUnits3));
            Assert.False(baseUnits3.Equals(baseUnits1));

            Assert.False(baseUnits1.Equals(null));
        }

        [Fact]
        public void EqualityOperatorIsImplementedCorrectly()
        {
            var baseUnits1 = new BaseUnits(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela);

            var baseUnits2 = new BaseUnits(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela);

            var baseUnits3 = new BaseUnits(LengthUnit.Foot, MassUnit.Pound, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.DegreeFahrenheit, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela);

            Assert.True(baseUnits1 == baseUnits2);
            Assert.True(baseUnits2 == baseUnits1);

            Assert.False(baseUnits1 == baseUnits3);
            Assert.False(baseUnits3 == baseUnits1);

            Assert.False(baseUnits1 == null);
            Assert.False(null == baseUnits1);

            BaseUnits nullBaseUnits1 = null;
            BaseUnits nullBaseUnits2 = null;

            Assert.True(nullBaseUnits1 == nullBaseUnits2);
        }

        [Fact]
        public void InequalityOperatorIsImplementedCorrectly()
        {
            var baseUnits1 = new BaseUnits(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela);

            var baseUnits2 = new BaseUnits(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela);

            var baseUnits3 = new BaseUnits(LengthUnit.Foot, MassUnit.Pound, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.DegreeFahrenheit, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela);

            Assert.False(baseUnits1 != baseUnits2);
            Assert.False(baseUnits2 != baseUnits1);

            Assert.True(baseUnits1 != baseUnits3);
            Assert.True(baseUnits3 != baseUnits1);

            Assert.True(baseUnits1 != null);
            Assert.True(null != baseUnits1);

            BaseUnits nullBaseUnits1 = null;
            BaseUnits nullBaseUnits2 = null;

            Assert.False(nullBaseUnits1 != nullBaseUnits2);
        }

        [Fact]
        public void ToStringGivesExpectedResult()
        {
            var baseUnits1 = new BaseUnits(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela);

            Assert.Equal("[Length]: m, [Mass]: kg, [Time]: s, [Current]: A, [Temperature]: K, [Amount]: mol, [LuminousIntensity]: cd", baseUnits1.ToString());
        }
    }
}
