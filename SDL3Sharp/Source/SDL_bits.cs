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
    public unsafe partial class SDL
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_MostSignificantBitIndex32", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int MostSignificantBitIndex32(uint x);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_HasExactlyOneBitSet32", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern bool HasExactlyOneBitSet32(uint x);
        }

        public static int MostSignificantBitIndex32(uint x)
        {
            var ___ret = __Internal.MostSignificantBitIndex32(x);
            return ___ret;
        }

        public static bool HasExactlyOneBitSet32(uint x)
        {
            var ___ret = __Internal.HasExactlyOneBitSet32(x);
            return ___ret;
        }
    }
}
