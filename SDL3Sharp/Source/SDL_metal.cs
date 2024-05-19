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
    /// <summary>A handle to a CAMetalLayer-backed NSView (macOS) or UIView (iOS/tvOS).</summary>
    /// <remarks>This can be cast directly to an NSView or UIView.</remarks>
    public unsafe partial class SDL
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_Metal_CreateView", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr MetalCreateView(__IntPtr window);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_Metal_DestroyView", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void MetalDestroyView(__IntPtr view);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_Metal_GetLayer", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr MetalGetLayer(__IntPtr view);
        }

        /// <summary>
        /// <para>Create a CAMetalLayer-backed NSView/UIView and attach it to the specified</para>
        /// <para>window.</para>
        /// </summary>
        /// <param name="window">the window</param>
        /// <remarks>
        /// <para>On macOS, this does *not* associate a MTLDevice with the CAMetalLayer on</para>
        /// <para>its own. It is up to user code to do that.</para>
        /// <para>The returned handle can be casted directly to a NSView or UIView. To access</para>
        /// <para>the backing CAMetalLayer, call SDL_Metal_GetLayer().</para>
        /// <para>handle NSView or UIView</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_Metal_DestroyView</para>
        /// <para>SDL_Metal_GetLayer</para>
        /// </remarks>
        public static __IntPtr MetalCreateView(global::SDL3Sharp.Window window)
        {
            var __arg0 = window is null ? __IntPtr.Zero : window.__Instance;
            var ___ret = __Internal.MetalCreateView(__arg0);
            return ___ret;
        }

        /// <summary>Destroy an existing SDL_MetalView object.</summary>
        /// <param name="view">the SDL_MetalView object</param>
        /// <remarks>
        /// <para>This should be called before SDL_DestroyWindow, if SDL_Metal_CreateView was</para>
        /// <para>called after SDL_CreateWindow.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_Metal_CreateView</para>
        /// </remarks>
        public static void MetalDestroyView(__IntPtr view)
        {
            __Internal.MetalDestroyView(view);
        }

        /// <summary>Get a pointer to the backing CAMetalLayer for the given view.</summary>
        /// <param name="view">the SDL_MetalView object</param>
        /// <remarks>
        /// <para>a pointer</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_Metal_CreateView</para>
        /// </remarks>
        public static __IntPtr MetalGetLayer(__IntPtr view)
        {
            var ___ret = __Internal.MetalGetLayer(view);
            return ___ret;
        }
    }
}