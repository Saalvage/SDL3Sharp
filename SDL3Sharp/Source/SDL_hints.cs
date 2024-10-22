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
    /// <summary>An enumeration of hint priorities</summary>
    public enum HintPriority
    {
        Default = 0,
        Normal = 1,
        Override = 2
    }

    /// <summary>An enumeration of hint priorities</summary>
    /// <summary>Type definition of the hint callback function.</summary>
    /// <param name="userdata">what was passed as `userdata` to SDL_AddHintCallback()</param>
    /// <param name="name">what was passed as `name` to SDL_AddHintCallback()</param>
    /// <param name="oldValue">the previous hint value</param>
    /// <param name="newValue">the new value hint is to be set to</param>
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
    public unsafe delegate void HintCallback(__IntPtr userdata, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string oldValue, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string newValue);

    public unsafe partial class SDL
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_SetHintWithPriority", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern bool SetHintWithPriority([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string value, global::SDL3Sharp.HintPriority priority);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_SetHint", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern bool SetHint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string value);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_ResetHint", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern bool ResetHint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string name);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_ResetHints", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ResetHints();

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetHint", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr GetHint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string name);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetHintBoolean", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern bool GetHintBoolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string name, bool default_value);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_AddHintCallback", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int AddHintCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string name, __IntPtr callback, __IntPtr userdata);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_DelHintCallback", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void DelHintCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string name, __IntPtr callback, __IntPtr userdata);
        }

        /// <summary>Set a hint with a specific priority.</summary>
        /// <param name="name">the hint to set</param>
        /// <param name="value">the value of the hint variable</param>
        /// <param name="priority">the SDL_HintPriority level for the hint</param>
        /// <remarks>
        /// <para>The priority controls the behavior when setting a hint that already has a</para>
        /// <para>value. Hints will replace existing hints of their priority and lower.</para>
        /// <para>Environment variables are considered to have override priority.</para>
        /// <para>SDL_TRUE if the hint was set, SDL_FALSE otherwise.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_GetHint</para>
        /// <para>SDL_SetHint</para>
        /// </remarks>
        public static bool SetHintWithPriority(string name, string value, global::SDL3Sharp.HintPriority priority)
        {
            var ___ret = __Internal.SetHintWithPriority(name, value, priority);
            return ___ret;
        }

        /// <summary>Set a hint with normal priority.</summary>
        /// <param name="name">the hint to set</param>
        /// <param name="value">the value of the hint variable</param>
        /// <remarks>
        /// <para>Hints will not be set if there is an existing override hint or environment</para>
        /// <para>variable that takes precedence. You can use SDL_SetHintWithPriority() to</para>
        /// <para>set the hint with override priority instead.</para>
        /// <para>SDL_TRUE if the hint was set, SDL_FALSE otherwise.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_GetHint</para>
        /// <para>SDL_SetHintWithPriority</para>
        /// </remarks>
        public static bool SetHint(string name, string value)
        {
            var ___ret = __Internal.SetHint(name, value);
            return ___ret;
        }

        /// <summary>Reset a hint to the default value.</summary>
        /// <param name="name">the hint to set</param>
        /// <remarks>
        /// <para>This will reset a hint to the value of the environment variable, or NULL if</para>
        /// <para>the environment isn't set. Callbacks will be called normally with this</para>
        /// <para>change.</para>
        /// <para>SDL_TRUE if the hint was set, SDL_FALSE otherwise.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_GetHint</para>
        /// <para>SDL_SetHint</para>
        /// </remarks>
        public static bool ResetHint(string name)
        {
            var ___ret = __Internal.ResetHint(name);
            return ___ret;
        }

        /// <summary>Reset all hints to the default values.</summary>
        /// <remarks>
        /// <para>This will reset all hints to the value of the associated environment</para>
        /// <para>variable, or NULL if the environment isn't set. Callbacks will be called</para>
        /// <para>normally with this change.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_GetHint</para>
        /// <para>SDL_SetHint</para>
        /// <para>SDL_ResetHint</para>
        /// </remarks>
        public static void ResetHints()
        {
            __Internal.ResetHints();
        }

        /// <summary>Get the value of a hint.</summary>
        /// <param name="name">the hint to query</param>
        /// <remarks>
        /// <para>the string value of a hint or NULL if the hint isn't set.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_SetHint</para>
        /// <para>SDL_SetHintWithPriority</para>
        /// </remarks>
        public static string GetHint(string name)
        {
            var ___ret = __Internal.GetHint(name);
            return CppSharp.Runtime.MarshalUtil.GetString(global::System.Text.Encoding.UTF8, ___ret);
        }

        /// <summary>Get the boolean value of a hint variable.</summary>
        /// <param name="name">the name of the hint to get the boolean value from</param>
        /// <param name="default_value">the value to return if the hint does not exist</param>
        /// <remarks>
        /// <para>the boolean value of a hint or the provided default value if the</para>
        /// <para>hint does not exist.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_GetHint</para>
        /// <para>SDL_SetHint</para>
        /// </remarks>
        public static bool GetHintBoolean(string name, bool default_value)
        {
            var ___ret = __Internal.GetHintBoolean(name, default_value);
            return ___ret;
        }

        /// <summary>Add a function to watch a particular hint.</summary>
        /// <param name="name">the hint to watch</param>
        /// <param name="callback">
        /// <para>An SDL_HintCallback function that will be called when the</para>
        /// <para>hint value changes</para>
        /// </param>
        /// <param name="userdata">a pointer to pass to the callback function</param>
        /// <remarks>
        /// <para>0 on success or a negative error code on failure; call</para>
        /// <para>SDL_GetError() for more information.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_DelHintCallback</para>
        /// </remarks>
        public static int AddHintCallback(string name, global::SDL3Sharp.HintCallback callback, __IntPtr userdata)
        {
            var __arg1 = callback == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback);
            var ___ret = __Internal.AddHintCallback(name, __arg1, userdata);
            return ___ret;
        }

        /// <summary>Remove a function watching a particular hint.</summary>
        /// <param name="name">the hint being watched</param>
        /// <param name="callback">
        /// <para>An SDL_HintCallback function that will be called when the</para>
        /// <para>hint value changes</para>
        /// </param>
        /// <param name="userdata">a pointer being passed to the callback function</param>
        /// <remarks>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_AddHintCallback</para>
        /// </remarks>
        public static void DelHintCallback(string name, global::SDL3Sharp.HintCallback callback, __IntPtr userdata)
        {
            var __arg1 = callback == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback);
            __Internal.DelHintCallback(name, __arg1, userdata);
        }
    }
}
