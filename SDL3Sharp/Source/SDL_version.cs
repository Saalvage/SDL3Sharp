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
    /// <summary>Information about the version of SDL in use.</summary>
    /// <remarks>
    /// <para>Represents the library's version as three levels: major revision</para>
    /// <para>(increments with massive changes, additions, and enhancements),</para>
    /// <para>minor revision (increments with backwards-compatible changes to the</para>
    /// <para>major revision), and patchlevel (increments with fixes to the minor</para>
    /// <para>revision).</para>
    /// <para>SDL_VERSION</para>
    /// <para>SDL_GetVersion</para>
    /// </remarks>
    /// <summary>Information about the version of SDL in use.</summary>
    /// <remarks>
    /// <para>Represents the library's version as three levels: major revision</para>
    /// <para>(increments with massive changes, additions, and enhancements),</para>
    /// <para>minor revision (increments with backwards-compatible changes to the</para>
    /// <para>major revision), and patchlevel (increments with fixes to the minor</para>
    /// <para>revision).</para>
    /// <para>SDL_VERSION</para>
    /// <para>SDL_GetVersion</para>
    /// </remarks>
    public unsafe partial class Version : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 3, Pack = 8)]
        public partial struct __Internal
        {
            internal byte major;
            internal byte minor;
            internal byte patch;

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "??0SDL_Version@@QEAA@AEBU0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr cctor(__IntPtr __instance, __IntPtr _0);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SDL3Sharp.Version> NativeToManagedMap =
            new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SDL3Sharp.Version>();

        internal static void __RecordNativeToManagedMapping(IntPtr native, global::SDL3Sharp.Version managed)
        {
            NativeToManagedMap[native] = managed;
        }

        internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::SDL3Sharp.Version managed)
        {
    
            return NativeToManagedMap.TryGetValue(native, out managed);
        }

        protected bool __ownsNativeInstance;

        internal static Version __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            return new Version(native.ToPointer(), skipVTables);
        }

        internal static Version __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (__TryGetNativeToManagedMapping(native, out var managed))
                return (Version)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                __RecordNativeToManagedMapping(native, result);
            return result;
        }

        internal static Version __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new Version(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private Version(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        protected Version(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public Version()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::SDL3Sharp.Version.__Internal));
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        public Version(global::SDL3Sharp.Version _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::SDL3Sharp.Version.__Internal));
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
            *((global::SDL3Sharp.Version.__Internal*) __Instance) = *((global::SDL3Sharp.Version.__Internal*) _0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor: __ownsNativeInstance);
        }

        partial void DisposePartial(bool disposing);

        internal protected virtual void Dispose(bool disposing, bool callNativeDtor)
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            DisposePartial(disposing);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        /// <summary>major version</summary>
        public byte Major
        {
            get
            {
                return ((__Internal*)__Instance)->major;
            }

            set
            {
                ((__Internal*)__Instance)->major = value;
            }
        }

        /// <summary>minor version</summary>
        public byte Minor
        {
            get
            {
                return ((__Internal*)__Instance)->minor;
            }

            set
            {
                ((__Internal*)__Instance)->minor = value;
            }
        }

        /// <summary>update version</summary>
        public byte Patch
        {
            get
            {
                return ((__Internal*)__Instance)->patch;
            }

            set
            {
                ((__Internal*)__Instance)->patch = value;
            }
        }
    }

    public unsafe partial class SDL
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetVersion", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int GetVersion(__IntPtr ver);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetRevision", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr GetRevision();
        }

        /// <summary>Get the version of SDL that is linked against your program.</summary>
        /// <param name="ver">the SDL_Version structure that contains the version information</param>
        /// <remarks>
        /// <para>If you are linking to SDL dynamically, then it is possible that the current</para>
        /// <para>version will be different than the version you compiled against. This</para>
        /// <para>function returns the current version, while SDL_VERSION() is a macro that</para>
        /// <para>tells you what version you compiled with.</para>
        /// <para>This function may be called safely at any time, even before SDL_Init().</para>
        /// <para>0 on success or a negative error code on failure; call</para>
        /// <para>SDL_GetError() for more information.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_GetRevision</para>
        /// </remarks>
        public static int GetVersion(out global::SDL3Sharp.Version ver)
        {
            ver = new global::SDL3Sharp.Version();
            var __arg0 = ver is null ? __IntPtr.Zero : ver.__Instance;
            var ___ret = __Internal.GetVersion(__arg0);
            return ___ret;
        }

        /// <summary>Get the code revision of SDL that is linked against your program.</summary>
        /// <remarks>
        /// <para>This value is the revision of the code you are linked with and may be</para>
        /// <para>different from the code you are compiling with, which is found in the</para>
        /// <para>constant SDL_REVISION.</para>
        /// <para>The revision is arbitrary string (a hash value) uniquely identifying the</para>
        /// <para>exact revision of the SDL library in use, and is only useful in comparing</para>
        /// <para>against other revisions. It is NOT an incrementing number.</para>
        /// <para>If SDL wasn't built from a git repository with the appropriate tools, this</para>
        /// <para>will return an empty string.</para>
        /// <para>Prior to SDL 2.0.16, before development moved to GitHub, this returned a</para>
        /// <para>hash for a Mercurial repository.</para>
        /// <para>You shouldn't use this function for anything but logging it for debugging</para>
        /// <para>purposes. The string is not intended to be reliable in any way.</para>
        /// <para>an arbitrary string, uniquely identifying the exact revision of</para>
        /// <para>the SDL library in use.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_GetVersion</para>
        /// </remarks>
        public static string GetRevision()
        {
            var ___ret = __Internal.GetRevision();
            return CppSharp.Runtime.MarshalUtil.GetString(global::System.Text.Encoding.UTF8, ___ret);
        }
    }
}
