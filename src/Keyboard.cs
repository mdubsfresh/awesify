﻿using System.Linq;

namespace Awesify
{
    class Keyboard
    {
        internal enum Style
        {
            Swing,
            Straight
        }

        public Keyboard(int bpm, Style style)
        {
            if (style == Style.Swing)
            {
                this.bpm = bpm;
                quarter = 1000*60/bpm;
                half = quarter*2;
                eighth = (int) 1.08*(quarter/2);
                sixteenth = eighth/2;
                dquarter = quarter + eighth;
                qtriplet = (int) (.82*quarter/3);
            }
            else if (style == Style.Straight)
            {
                this.bpm = bpm;
                quarter = 1000 * 60 / bpm;
                half = quarter * 2;
                eighth = (quarter / 2);
                sixteenth = eighth / 2;
                dquarter = quarter + eighth;
                qtriplet =  quarter / 3;
            }
        }

        public int[] GetKeyboard()
        {
            var v2 = typeof (Keyboard).GetFields()
                                    .Where(pi => pi.FieldType == typeof (double))
                                    .Select(pi => pi.GetValue(new Keyboard(10, Style.Swing)))
                                    .Cast<double>()
                                    .Select(d => (int) d)
                                    .OrderBy(d => d)
                                    .ToArray();
            return v2;
        }

        public int bpm = 120;
        public int quarter;
        public int half;
        public int eighth;
        public int sixteenth;
        public int dquarter;
        public int qtriplet;

        public static double C8 = 4186.01;
        public static double B7 = 3951.07;
        public static double ASharp7 = 3729.31;
        public static double A7 = 3520.0;
        public static double GSharp7 = 3322.44;
        public static double G7 = 3135.96;
        public static double FSharp7 = 2959.96;
        public static double F7 = 2793.83;
        public static double E7 = 2637.02;
        public static double DSharp7 = 2489.02;
        public static double D7 = 2349.32;
        public static double CSharp7 = 2217.46;
        public static double C7 = 2093.0;
        public static double B6 = 1975.53;
        public static double ASharp6 = 1864.66;
        public static double A6 = 1760.0;
        public static double GSharp6 = 1661.22;
        public static double G6 = 1567.98;
        public static double FSharp6 = 1479.98;
        public static double F6 = 1396.91;
        public static double E6 = 1318.51;
        public static double DSharp6 = 1244.51;
        public static double D6 = 1174.66;
        public static double CSharp6 = 1108.73;
        public static double C6 = 1046.5;
        public static double B5 = 987.767;
        public static double ASharp5 = 932.328;
        public static double A5 = 880.0;
        public static double GSharp5 = 830.609;
        public static double G5 = 783.991;
        public static double FSharp5 = 739.989;
        public static double F5 = 698.456;
        public static double E5 = 659.255;
        public static double DSharp5 = 622.254;
        public static double D5 = 587.33;
        public static double CSharp5 = 554.365;
        public static double C5 = 523.251;
        public static double B4 = 493.883;
        public static double ASharp4 = 466.164;
        public static double A4 = 440.0;
        public static double GSharp4 = 415.305;
        public static double G4 = 391.995;
        public static double FSharp4 = 369.994;
        public static double F4 = 349.228;
        public static double E4 = 329.628;
        public static double DSharp4 = 311.127;
        public static double D4 = 293.665;
        public static double CSharp4 = 277.183;
        public static double C4 = 261.626;
        public static double B3 = 246.942;
        public static double ASharp3 = 233.082;
        public static double A3 = 220.0;
        public static double GSharp3 = 207.652;
        public static double G3 = 195.998;
        public static double FSharp3 = 184.997;
        public static double F3 = 174.614;
        public static double E3 = 164.814;
        public static double DSharp3 = 155.563;
        public static double D3 = 146.832;
        public static double CSharp3 = 138.591;
        public static double C3 = 130.813;
        public static double B2 = 123.471;
        public static double ASharp2 = 116.541;
        public static double A2 = 110.0;
        public static double GSharp2 = 103.826;
        public static double G2 = 97.9989;
        public static double FSharp2 = 92.4986;
        public static double F2 = 87.3071;
        public static double E2 = 82.4069;
        public static double DSharp2 = 77.7817;
        public static double D2 = 73.4162;
        public static double CSharp2 = 69.2957;
        public static double C2 = 65.4064;
        public static double B1 = 61.7354;
        public static double ASharp1 = 58.2705;
        public static double A1 = 55.0;
        public static double GSharp1 = 51.9131;
        public static double G1 = 48.9994;
        public static double FSharp1 = 46.2493;
        public static double F1 = 43.6535;
        public static double E1 = 41.2034;
        public static double DSharp1 = 38.8909;
        public static double D1 = 36.7081;
        public static double CSharp1 = 34.6478;
        public static double C1 = 32.7032;
        public static double B0 = 30.8677;
        public static double ASharp0 = 29.1352;
        public static double A0 = 27.5;
    }
}
