// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
using __CallingConvention = global::System.Runtime.InteropServices.CallingConvention;
using __IntPtr = global::System.IntPtr;

#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS9084 // Struct member returns 'this' or other instance members by reference

namespace SDL3Sharp
{
    /// <summary>The SDL keyboard scancode representation.</summary>
    /// <remarks>
    /// <para>An SDL scancode is the physical representation of a key on the keyboard,</para>
    /// <para>independent of language and keyboard mapping.</para>
    /// <para>Values of this type are used to represent keyboard keys, among other places</para>
    /// <para>in the</para>
    /// </remarks>
    public enum Scancode
    {
        ScancodeUnknown = 0,
        ScancodeA = 4,
        ScancodeB = 5,
        ScancodeC = 6,
        ScancodeD = 7,
        ScancodeE = 8,
        ScancodeF = 9,
        ScancodeG = 10,
        ScancodeH = 11,
        ScancodeI = 12,
        ScancodeJ = 13,
        ScancodeK = 14,
        ScancodeL = 15,
        ScancodeM = 16,
        ScancodeN = 17,
        ScancodeO = 18,
        ScancodeP = 19,
        ScancodeQ = 20,
        ScancodeR = 21,
        ScancodeS = 22,
        ScancodeT = 23,
        ScancodeU = 24,
        ScancodeV = 25,
        ScancodeW = 26,
        ScancodeX = 27,
        ScancodeY = 28,
        ScancodeZ = 29,
        Scancode1 = 30,
        Scancode2 = 31,
        Scancode3 = 32,
        Scancode4 = 33,
        Scancode5 = 34,
        Scancode6 = 35,
        Scancode7 = 36,
        Scancode8 = 37,
        Scancode9 = 38,
        Scancode0 = 39,
        ScancodeReturn = 40,
        ScancodeEscape = 41,
        ScancodeBackspace = 42,
        ScancodeTab = 43,
        ScancodeSpace = 44,
        ScancodeMinus = 45,
        ScancodeEquals = 46,
        ScancodeLeftbracket = 47,
        ScancodeRightbracket = 48,
        /// <summary>
        /// <para>Located at the lower left of the return</para>
        /// <para>key on ISO keyboards and at the right end</para>
        /// <para>of the QWERTY row on ANSI keyboards.</para>
        /// <para>Produces REVERSE SOLIDUS (backslash) and</para>
        /// <para>VERTICAL LINE in a US layout, REVERSE</para>
        /// <para>SOLIDUS and VERTICAL LINE in a UK Mac</para>
        /// <para>layout, NUMBER SIGN and TILDE in a UK</para>
        /// <para>Windows layout, DOLLAR SIGN and POUND SIGN</para>
        /// <para>in a Swiss German layout, NUMBER SIGN and</para>
        /// <para>APOSTROPHE in a German layout, GRAVE</para>
        /// <para>ACCENT and POUND SIGN in a French Mac</para>
        /// <para>layout, and ASTERISK and MICRO SIGN in a</para>
        /// <para>French Windows layout.</para>
        /// </summary>
        ScancodeBackslash = 49,
        /// <summary>
        /// <para>ISO USB keyboards actually use this code</para>
        /// <para>instead of 49 for the same key, but all</para>
        /// <para>OSes I've seen treat the two codes</para>
        /// <para>identically. So, as an implementor, unless</para>
        /// <para>your keyboard generates both of those</para>
        /// <para>codes and your OS treats them differently,</para>
        /// <para>you should generate SDL_SCANCODE_BACKSLASH</para>
        /// <para>instead of this code. As a user, you</para>
        /// <para>should not rely on this code because SDL</para>
        /// <para>will never generate it with most (all?)</para>
        /// <para>keyboards.</para>
        /// </summary>
        ScancodeNonushash = 50,
        ScancodeSemicolon = 51,
        ScancodeApostrophe = 52,
        /// <summary>
        /// <para>Located in the top left corner (on both ANSI</para>
        /// <para>and ISO keyboards). Produces GRAVE ACCENT and</para>
        /// <para>TILDE in a US Windows layout and in US and UK</para>
        /// <para>Mac layouts on ANSI keyboards, GRAVE ACCENT</para>
        /// <para>and NOT SIGN in a UK Windows layout, SECTION</para>
        /// <para>SIGN and PLUS-MINUS SIGN in US and UK Mac</para>
        /// <para>layouts on ISO keyboards, SECTION SIGN and</para>
        /// <para>DEGREE SIGN in a Swiss German layout (Mac:</para>
        /// <para>only on ISO keyboards), CIRCUMFLEX ACCENT and</para>
        /// <para>DEGREE SIGN in a German layout (Mac: only on</para>
        /// <para>ISO keyboards), SUPERSCRIPT TWO and TILDE in a</para>
        /// <para>French Windows layout, COMMERCIAL AT and</para>
        /// <para>NUMBER SIGN in a French Mac layout on ISO</para>
        /// <para>keyboards, and LESS-THAN SIGN and GREATER-THAN</para>
        /// <para>SIGN in a Swiss German, German, or French Mac</para>
        /// <para>layout on ANSI keyboards.</para>
        /// </summary>
        ScancodeGrave = 53,
        ScancodeComma = 54,
        ScancodePeriod = 55,
        ScancodeSlash = 56,
        ScancodeCapslock = 57,
        ScancodeF1 = 58,
        ScancodeF2 = 59,
        ScancodeF3 = 60,
        ScancodeF4 = 61,
        ScancodeF5 = 62,
        ScancodeF6 = 63,
        ScancodeF7 = 64,
        ScancodeF8 = 65,
        ScancodeF9 = 66,
        ScancodeF10 = 67,
        ScancodeF11 = 68,
        ScancodeF12 = 69,
        ScancodePrintscreen = 70,
        ScancodeScrolllock = 71,
        ScancodePause = 72,
        /// <summary>
        /// <para>insert on PC, help on some Mac keyboards (but</para>
        /// <para>does send code 73, not 117)</para>
        /// </summary>
        ScancodeInsert = 73,
        ScancodeHome = 74,
        ScancodePageup = 75,
        ScancodeDelete = 76,
        ScancodeEnd = 77,
        ScancodePagedown = 78,
        ScancodeRight = 79,
        ScancodeLeft = 80,
        ScancodeDown = 81,
        ScancodeUp = 82,
        /// <summary>num lock on PC, clear on Mac keyboards</summary>
        ScancodeNumlockclear = 83,
        ScancodeKpDivide = 84,
        ScancodeKpMultiply = 85,
        ScancodeKpMinus = 86,
        ScancodeKpPlus = 87,
        ScancodeKpEnter = 88,
        ScancodeKp1 = 89,
        ScancodeKp2 = 90,
        ScancodeKp3 = 91,
        ScancodeKp4 = 92,
        ScancodeKp5 = 93,
        ScancodeKp6 = 94,
        ScancodeKp7 = 95,
        ScancodeKp8 = 96,
        ScancodeKp9 = 97,
        ScancodeKp0 = 98,
        ScancodeKpPeriod = 99,
        /// <summary>
        /// <para>This is the additional key that ISO</para>
        /// <para>keyboards have over ANSI ones,</para>
        /// <para>located between left shift and Y.</para>
        /// <para>Produces GRAVE ACCENT and TILDE in a</para>
        /// <para>US or UK Mac layout, REVERSE SOLIDUS</para>
        /// <para>(backslash) and VERTICAL LINE in a</para>
        /// <para>US or UK Windows layout, and</para>
        /// <para>LESS-THAN SIGN and GREATER-THAN SIGN</para>
        /// <para>in a Swiss German, German, or French</para>
        /// <para>layout.</para>
        /// </summary>
        ScancodeNonusbackslash = 100,
        /// <summary>windows contextual menu, compose</summary>
        ScancodeApplication = 101,
        /// <summary>
        /// <para>The USB document says this is a status flag,</para>
        /// <para>not a physical key - but some Mac keyboards</para>
        /// <para>do have a power key.</para>
        /// </summary>
        ScancodePower = 102,
        ScancodeKpEquals = 103,
        ScancodeF13 = 104,
        ScancodeF14 = 105,
        ScancodeF15 = 106,
        ScancodeF16 = 107,
        ScancodeF17 = 108,
        ScancodeF18 = 109,
        ScancodeF19 = 110,
        ScancodeF20 = 111,
        ScancodeF21 = 112,
        ScancodeF22 = 113,
        ScancodeF23 = 114,
        ScancodeF24 = 115,
        ScancodeExecute = 116,
        /// <summary>AL Integrated Help Center</summary>
        ScancodeHelp = 117,
        /// <summary>Menu (show menu)</summary>
        ScancodeMenu = 118,
        ScancodeSelect = 119,
        /// <summary>AC Stop</summary>
        ScancodeStop = 120,
        /// <summary>AC Redo/Repeat</summary>
        ScancodeAgain = 121,
        /// <summary>AC Undo</summary>
        ScancodeUndo = 122,
        /// <summary>AC Cut</summary>
        ScancodeCut = 123,
        /// <summary>AC Copy</summary>
        ScancodeCopy = 124,
        /// <summary>AC Paste</summary>
        ScancodePaste = 125,
        /// <summary>AC Find</summary>
        ScancodeFind = 126,
        ScancodeMute = 127,
        ScancodeVolumeup = 128,
        ScancodeVolumedown = 129,
        ScancodeKpComma = 133,
        ScancodeKpEqualsas400 = 134,
        /// <summary>
        /// <para>used on Asian keyboards, see</para>
        /// <para>footnotes in USB doc</para>
        /// </summary>
        ScancodeInternational1 = 135,
        ScancodeInternational2 = 136,
        /// <summary>Yen</summary>
        ScancodeInternational3 = 137,
        ScancodeInternational4 = 138,
        ScancodeInternational5 = 139,
        ScancodeInternational6 = 140,
        ScancodeInternational7 = 141,
        ScancodeInternational8 = 142,
        ScancodeInternational9 = 143,
        /// <summary>Hangul/English toggle</summary>
        ScancodeLang1 = 144,
        /// <summary>Hanja conversion</summary>
        ScancodeLang2 = 145,
        /// <summary>Katakana</summary>
        ScancodeLang3 = 146,
        /// <summary>Hiragana</summary>
        ScancodeLang4 = 147,
        /// <summary>Zenkaku/Hankaku</summary>
        ScancodeLang5 = 148,
        /// <summary>reserved</summary>
        ScancodeLang6 = 149,
        /// <summary>reserved</summary>
        ScancodeLang7 = 150,
        /// <summary>reserved</summary>
        ScancodeLang8 = 151,
        /// <summary>reserved</summary>
        ScancodeLang9 = 152,
        /// <summary>Erase-Eaze</summary>
        ScancodeAlterase = 153,
        ScancodeSysreq = 154,
        /// <summary>AC Cancel</summary>
        ScancodeCancel = 155,
        ScancodeClear = 156,
        ScancodePrior = 157,
        ScancodeReturn2 = 158,
        ScancodeSeparator = 159,
        ScancodeOut = 160,
        ScancodeOper = 161,
        ScancodeClearagain = 162,
        ScancodeCrsel = 163,
        ScancodeExsel = 164,
        ScancodeKp00 = 176,
        ScancodeKp000 = 177,
        ScancodeThousandsseparator = 178,
        ScancodeDecimalseparator = 179,
        ScancodeCurrencyunit = 180,
        ScancodeCurrencysubunit = 181,
        ScancodeKpLeftparen = 182,
        ScancodeKpRightparen = 183,
        ScancodeKpLeftbrace = 184,
        ScancodeKpRightbrace = 185,
        ScancodeKpTab = 186,
        ScancodeKpBackspace = 187,
        ScancodeKpA = 188,
        ScancodeKpB = 189,
        ScancodeKpC = 190,
        ScancodeKpD = 191,
        ScancodeKpE = 192,
        ScancodeKpF = 193,
        ScancodeKpXor = 194,
        ScancodeKpPower = 195,
        ScancodeKpPercent = 196,
        ScancodeKpLess = 197,
        ScancodeKpGreater = 198,
        ScancodeKpAmpersand = 199,
        ScancodeKpDblampersand = 200,
        ScancodeKpVerticalbar = 201,
        ScancodeKpDblverticalbar = 202,
        ScancodeKpColon = 203,
        ScancodeKpHash = 204,
        ScancodeKpSpace = 205,
        ScancodeKpAt = 206,
        ScancodeKpExclam = 207,
        ScancodeKpMemstore = 208,
        ScancodeKpMemrecall = 209,
        ScancodeKpMemclear = 210,
        ScancodeKpMemadd = 211,
        ScancodeKpMemsubtract = 212,
        ScancodeKpMemmultiply = 213,
        ScancodeKpMemdivide = 214,
        ScancodeKpPlusminus = 215,
        ScancodeKpClear = 216,
        ScancodeKpClearentry = 217,
        ScancodeKpBinary = 218,
        ScancodeKpOctal = 219,
        ScancodeKpDecimal = 220,
        ScancodeKpHexadecimal = 221,
        ScancodeLctrl = 224,
        ScancodeLshift = 225,
        /// <summary>alt, option</summary>
        ScancodeLalt = 226,
        /// <summary>windows, command (apple), meta</summary>
        ScancodeLgui = 227,
        ScancodeRctrl = 228,
        ScancodeRshift = 229,
        /// <summary>alt gr, option</summary>
        ScancodeRalt = 230,
        /// <summary>windows, command (apple), meta</summary>
        ScancodeRgui = 231,
        /// <summary>
        /// <para>I'm not sure if this is really not covered</para>
        /// <para>by any of the above, but since there's a</para>
        /// <para>special SDL_KMOD_MODE for it I'm adding it here</para>
        /// </summary>
        ScancodeMode = 257,
        ScancodeAudionext = 258,
        ScancodeAudioprev = 259,
        ScancodeAudiostop = 260,
        ScancodeAudioplay = 261,
        ScancodeAudiomute = 262,
        ScancodeMediaselect = 263,
        /// <summary>AL Internet Browser</summary>
        ScancodeWww = 264,
        ScancodeMail = 265,
        /// <summary>AL Calculator</summary>
        ScancodeCalculator = 266,
        ScancodeComputer = 267,
        /// <summary>AC Search</summary>
        ScancodeAcSearch = 268,
        /// <summary>AC Home</summary>
        ScancodeAcHome = 269,
        /// <summary>AC Back</summary>
        ScancodeAcBack = 270,
        /// <summary>AC Forward</summary>
        ScancodeAcForward = 271,
        /// <summary>AC Stop</summary>
        ScancodeAcStop = 272,
        /// <summary>AC Refresh</summary>
        ScancodeAcRefresh = 273,
        /// <summary>AC Bookmarks</summary>
        ScancodeAcBookmarks = 274,
        ScancodeBrightnessdown = 275,
        ScancodeBrightnessup = 276,
        /// <summary>
        /// <para>display mirroring/dual display</para>
        /// <para>switch, video mode switch</para>
        /// </summary>
        ScancodeDisplayswitch = 277,
        ScancodeKbdillumtoggle = 278,
        ScancodeKbdillumdown = 279,
        ScancodeKbdillumup = 280,
        ScancodeEject = 281,
        /// <summary>SC System Sleep</summary>
        ScancodeSleep = 282,
        ScancodeApp1 = 283,
        ScancodeApp2 = 284,
        ScancodeAudiorewind = 285,
        ScancodeAudiofastforward = 286,
        /// <summary>
        /// <para>Usually situated below the display on phones and</para>
        /// <para>used as a multi-function feature key for selecting</para>
        /// <para>a software defined function shown on the bottom left</para>
        /// <para>of the display.</para>
        /// </summary>
        ScancodeSoftleft = 287,
        /// <summary>
        /// <para>Usually situated below the display on phones and</para>
        /// <para>used as a multi-function feature key for selecting</para>
        /// <para>a software defined function shown on the bottom right</para>
        /// <para>of the display.</para>
        /// </summary>
        ScancodeSoftright = 288,
        /// <summary>Used for accepting phone calls.</summary>
        ScancodeCall = 289,
        /// <summary>Used for rejecting phone calls.</summary>
        ScancodeEndcall = 290,
        /// <summary>
        /// <para>not a key, just marks the number of scancodes</para>
        /// <para>for array bounds</para>
        /// </summary>
        NumScancodes = 512
    }

    /// <summary>The SDL keyboard scancode representation.</summary>
    /// <remarks>
    /// <para>An SDL scancode is the physical representation of a key on the keyboard,</para>
    /// <para>independent of language and keyboard mapping.</para>
    /// <para>Values of this type are used to represent keyboard keys, among other places</para>
    /// <para>in the</para>
    /// </remarks>
    namespace Delegates
    {
        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        public unsafe delegate int Func_int___IntPtr___IntPtr(__IntPtr __0, __IntPtr __1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        public unsafe delegate int Func_int___IntPtr___IntPtr___IntPtr(__IntPtr __0, __IntPtr __1, __IntPtr __2);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        public unsafe delegate void Action___IntPtr___IntPtr(__IntPtr userdata, __IntPtr value);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        public unsafe delegate long Func_long___IntPtr(__IntPtr context);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        public unsafe delegate long Func_long___IntPtr_long_int(__IntPtr context, long offset, int whence);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        public unsafe delegate ulong Func_ulong___IntPtr___IntPtr_ulong(__IntPtr context, __IntPtr ptr, ulong size);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        public unsafe delegate int Func_int___IntPtr(__IntPtr context);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        public unsafe delegate void Action___IntPtr(__IntPtr __0);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        public unsafe delegate uint Func_uint___IntPtr(__IntPtr __0);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        public unsafe delegate void Action___IntPtr_int(__IntPtr userdata, int player_index);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        public unsafe delegate int Func_int___IntPtr_ushort_ushort(__IntPtr userdata, ushort low_frequency_rumble, ushort high_frequency_rumble);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        public unsafe delegate int Func_int___IntPtr_byte_byte_byte(__IntPtr userdata, byte red, byte green, byte blue);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        public unsafe delegate int Func_int___IntPtr___IntPtr_int(__IntPtr userdata, __IntPtr data, int size);
    }
}
