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
    /// <summary>Pen axis indices</summary>
    /// <remarks>
    /// <para>Below are the valid indices to the &quot;axis&quot; array from ::SDL_PenMotionEvent and ::SDL_PenButtonEvent.</para>
    /// <para>The axis indices form a contiguous range of ints from 0 to ::SDL_PEN_AXIS_LAST, inclusive.</para>
    /// <para>All &quot;axis[]&quot; entries are either normalised to  0..1 or report a (positive or negative)</para>
    /// <para>angle in degrees, with 0.0 representing the centre.</para>
    /// <para>Not all pens/backends support all axes: unsupported entries are always &quot;0.0f&quot;.</para>
    /// <para>To convert angles for tilt and rotation into vector representation, use</para>
    /// <para>SDL_sinf on the XTILT, YTILT, or ROTATION component, e.g., &quot;SDL_sinf(xtilt * SDL_PI_F / 180.0)&quot;.</para>
    /// </remarks>
    public enum PenAxis
    {
        /// <summary>Pen pressure.  Unidirectional: 0..1.0</summary>
        AxisPressure = 0,
        /// <summary>
        /// <para>Pen horizontal tilt angle.  Bidirectional: -90.0..90.0 (left-to-right).</para>
        /// <para>The physical max/min tilt may be smaller than -90.0 / 90.0, cf. SDL_PenCapabilityInfo</para>
        /// </summary>
        AxisXtilt = 1,
        /// <summary>
        /// <para>Pen vertical tilt angle.  Bidirectional: -90.0..90.0 (top-to-down).</para>
        /// <para>The physical max/min tilt may be smaller than -90.0 / 90.0, cf. SDL_PenCapabilityInfo</para>
        /// </summary>
        AxisYtilt = 2,
        /// <summary>Pen distance to drawing surface.  Unidirectional: 0.0..1.0</summary>
        AxisDistance = 3,
        /// <summary>Pen barrel rotation.  Bidirectional: -180..179.9 (clockwise, 0 is facing up, -180.0 is facing down).</summary>
        AxisRotation = 4,
        /// <summary>Pen finger wheel or slider (e.g., Airbrush Pen).  Unidirectional: 0..1.0</summary>
        AxisSlider = 5,
        /// <summary>Last valid axis index</summary>
        NumAxes = 6,
        /// <summary>Last axis index plus 1</summary>
        AxisLast = 5
    }

    /// <summary>Pen types</summary>
    /// <remarks>Some pens identify as a particular type of drawing device (e.g., an airbrush or a pencil).</remarks>
    public enum PenSubtype
    {
        Unknown = 0,
        /// <summary>Eraser</summary>
        Eraser = 1,
        /// <summary>Generic pen; this is the default.</summary>
        Pen = 2,
        /// <summary>Pencil</summary>
        Pencil = 3,
        /// <summary>Brush-like device</summary>
        Brush = 4,
        /// <summary>Airbrush device that &quot;sprays&quot; ink</summary>
        Airbrush = 5,
        /// <summary>Last valid pen type</summary>
        Last = 5
    }

    /// <summary>Pen axis indices</summary>
    /// <remarks>
    /// <para>Below are the valid indices to the &quot;axis&quot; array from ::SDL_PenMotionEvent and ::SDL_PenButtonEvent.</para>
    /// <para>The axis indices form a contiguous range of ints from 0 to ::SDL_PEN_AXIS_LAST, inclusive.</para>
    /// <para>All &quot;axis[]&quot; entries are either normalised to  0..1 or report a (positive or negative)</para>
    /// <para>angle in degrees, with 0.0 representing the centre.</para>
    /// <para>Not all pens/backends support all axes: unsupported entries are always &quot;0.0f&quot;.</para>
    /// <para>To convert angles for tilt and rotation into vector representation, use</para>
    /// <para>SDL_sinf on the XTILT, YTILT, or ROTATION component, e.g., &quot;SDL_sinf(xtilt * SDL_PI_F / 180.0)&quot;.</para>
    /// </remarks>
    /// <summary>Pen types</summary>
    /// <remarks>Some pens identify as a particular type of drawing device (e.g., an airbrush or a pencil).</remarks>
    /// <summary>Pen capabilities, as reported by ::SDL_GetPenCapabilities()</summary>
    /// <summary>Pen capabilities, as reported by ::SDL_GetPenCapabilities()</summary>
    public unsafe partial class PenCapabilityInfo : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 12)]
        public partial struct __Internal
        {
            internal float max_tilt;
            internal uint wacom_id;
            internal sbyte num_buttons;

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "??0SDL_PenCapabilityInfo@@QEAA@AEBU0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr cctor(__IntPtr __instance, __IntPtr _0);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SDL3Sharp.PenCapabilityInfo> NativeToManagedMap =
            new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SDL3Sharp.PenCapabilityInfo>();

        internal static void __RecordNativeToManagedMapping(IntPtr native, global::SDL3Sharp.PenCapabilityInfo managed)
        {
            NativeToManagedMap[native] = managed;
        }

        internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::SDL3Sharp.PenCapabilityInfo managed)
        {
    
            return NativeToManagedMap.TryGetValue(native, out managed);
        }

        protected bool __ownsNativeInstance;

        internal static PenCapabilityInfo __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            return new PenCapabilityInfo(native.ToPointer(), skipVTables);
        }

        internal static PenCapabilityInfo __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (__TryGetNativeToManagedMapping(native, out var managed))
                return (PenCapabilityInfo)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                __RecordNativeToManagedMapping(native, result);
            return result;
        }

        internal static PenCapabilityInfo __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new PenCapabilityInfo(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private PenCapabilityInfo(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        protected PenCapabilityInfo(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public PenCapabilityInfo()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::SDL3Sharp.PenCapabilityInfo.__Internal));
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        public PenCapabilityInfo(global::SDL3Sharp.PenCapabilityInfo _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::SDL3Sharp.PenCapabilityInfo.__Internal));
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
            *((global::SDL3Sharp.PenCapabilityInfo.__Internal*) __Instance) = *((global::SDL3Sharp.PenCapabilityInfo.__Internal*) _0.__Instance);
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

        /// <summary>Physical maximum tilt angle, for XTILT and YTILT, or SDL_PEN_INFO_UNKNOWN .  Pens cannot typically tilt all the way to 90 degrees, so this value is usually less than 90.0.</summary>
        public float MaxTilt
        {
            get
            {
                return ((__Internal*)__Instance)->max_tilt;
            }

            set
            {
                ((__Internal*)__Instance)->max_tilt = value;
            }
        }

        /// <summary>For Wacom devices: wacom tool type ID, otherwise 0 (useful e.g. with libwacom)</summary>
        public uint WacomId
        {
            get
            {
                return ((__Internal*)__Instance)->wacom_id;
            }

            set
            {
                ((__Internal*)__Instance)->wacom_id = value;
            }
        }

        /// <summary>Number of pen buttons (not counting the pen tip), or SDL_PEN_INFO_UNKNOWN</summary>
        public sbyte NumButtons
        {
            get
            {
                return ((__Internal*)__Instance)->num_buttons;
            }

            set
            {
                ((__Internal*)__Instance)->num_buttons = value;
            }
        }
    }

    public unsafe partial class SDL
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetPens", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern uint* GetPens(int* count);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetPenStatus", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern uint GetPenStatus(uint instance_id, float* x, float* y, float* axes, ulong num_axes);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetPenFromGUID", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern uint GetPenFromGUID(__IntPtr guid);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetPenGUID", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void GetPenGUID(__IntPtr @return, uint instance_id);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_PenConnected", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern bool PenConnected(uint instance_id);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetPenName", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr GetPenName(uint instance_id);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetPenCapabilities", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern uint GetPenCapabilities(uint instance_id, __IntPtr capabilities);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetPenType", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern global::SDL3Sharp.PenSubtype GetPenType(uint instance_id);
        }

        /// <summary>Retrieves all pens that are connected to the system.</summary>
        /// <param name="count">
        /// <para>The number of pens in the array (number of array elements</para>
        /// <para>minus 1, i.e., not counting the terminator 0).</para>
        /// </param>
        /// <remarks>
        /// <para>Yields an array of ::SDL_PenID values. These identify and track pens</para>
        /// <para>throughout a session. To track pens across sessions (program restart), use</para>
        /// <para>::SDL_GUID .</para>
        /// <para>A 0 terminated array of ::SDL_PenID values, or NULL on error. The</para>
        /// <para>array must be freed with ::SDL_free(). On a NULL return,</para>
        /// <para>::SDL_GetError() is set.</para>
        /// <para>This function is available since SDL 3.0.0</para>
        /// </remarks>
        public static uint* GetPens(ref int count)
        {
            fixed (int* __count0 = &count)
            {
                var __arg0 = __count0;
                var ___ret = __Internal.GetPens(__arg0);
                return ___ret;
            }
        }

        /// <summary>Retrieves the pen's current status.</summary>
        /// <param name="instance_id">The pen to query.</param>
        /// <param name="x">Out-mode parameter for pen x coordinate. May be NULL.</param>
        /// <param name="y">Out-mode parameter for pen y coordinate. May be NULL.</param>
        /// <param name="axes">
        /// <para>Out-mode parameter for axis information. May be null. The axes</para>
        /// <para>are in the same order as ::SDL_PenAxis.</para>
        /// </param>
        /// <param name="num_axes">Maximum number of axes to write to &quot;axes&quot;.</param>
        /// <remarks>
        /// <para>If the pen is detached (cf. ::SDL_PenConnected), this operation may return</para>
        /// <para>default values.</para>
        /// <para>a bit mask with the current pen button states (::SDL_BUTTON_LMASK</para>
        /// <para>etc.), possibly ::SDL_PEN_DOWN_MASK, and exactly one of</para>
        /// <para>::SDL_PEN_INK_MASK or ::SDL_PEN_ERASER_MASK , or 0 on error (see</para>
        /// <para>::SDL_GetError()).</para>
        /// <para>This function is available since SDL 3.0.0</para>
        /// </remarks>
        public static uint GetPenStatus(uint instance_id, ref float x, ref float y, ref float axes, ulong num_axes)
        {
            fixed (float* __x1 = &x)
            {
                var __arg1 = __x1;
                fixed (float* __y2 = &y)
                {
                    var __arg2 = __y2;
                    fixed (float* __axes3 = &axes)
                    {
                        var __arg3 = __axes3;
                        var ___ret = __Internal.GetPenStatus(instance_id, __arg1, __arg2, __arg3, num_axes);
                        return ___ret;
                    }
                }
            }
        }

        /// <summary>Retrieves an ::SDL_PenID for the given ::SDL_GUID.</summary>
        /// <param name="guid">A pen GUID.</param>
        /// <remarks>
        /// <para>A valid ::SDL_PenID, or ::SDL_PEN_INVALID if there is no matching</para>
        /// <para>SDL_PenID.</para>
        /// <para>This function is available since SDL 3.0.0</para>
        /// <para>SDL_GUID</para>
        /// </remarks>
        public static uint GetPenFromGUID(global::SDL3Sharp.GUID guid)
        {
            if (ReferenceEquals(guid, null))
                throw new global::System.ArgumentNullException("guid", "Cannot be null because it is passed by value.");
            var __arg0 = guid.__Instance;
            var ___ret = __Internal.GetPenFromGUID(__arg0);
            return ___ret;
        }

        /// <summary>Retrieves the ::SDL_GUID for a given ::SDL_PenID.</summary>
        /// <param name="instance_id">The pen to query.</param>
        /// <remarks>
        /// <para>The corresponding pen GUID; persistent across multiple sessions.</para>
        /// <para>If &quot;instance_id&quot; is ::SDL_PEN_INVALID, returns an all-zeroes GUID.</para>
        /// <para>This function is available since SDL 3.0.0</para>
        /// <para>SDL_PenForID</para>
        /// </remarks>
        public static global::SDL3Sharp.GUID GetPenGUID(uint instance_id)
        {
            var ___ret = new global::SDL3Sharp.GUID.__Internal();
            __Internal.GetPenGUID(new IntPtr(&___ret), instance_id);
            return global::SDL3Sharp.GUID.__CreateInstance(___ret);
        }

        /// <summary>Checks whether a pen is still attached.</summary>
        /// <param name="instance_id">A pen ID.</param>
        /// <remarks>
        /// <para>If a pen is detached, it will not show up for ::SDL_GetPens(). Other</para>
        /// <para>operations will still be available but may return default values.</para>
        /// <para>SDL_TRUE if &quot;instance_id&quot; is valid and the corresponding pen is</para>
        /// <para>attached, or SDL_FALSE otherwise.</para>
        /// <para>This function is available since SDL 3.0.0</para>
        /// </remarks>
        public static bool PenConnected(uint instance_id)
        {
            var ___ret = __Internal.PenConnected(instance_id);
            return ___ret;
        }

        /// <summary>Retrieves a human-readable description for a ::SDL_PenID.</summary>
        /// <param name="instance_id">The pen to query.</param>
        /// <remarks>
        /// <para>A string that contains the name of the pen, intended for human</para>
        /// <para>consumption. The string might or might not be localised, depending</para>
        /// <para>on platform settings. It is not guaranteed to be unique; use</para>
        /// <para>::SDL_GetPenGUID() for (best-effort) unique identifiers. The</para>
        /// <para>pointer is managed by the SDL pen subsystem and must not be</para>
        /// <para>deallocated. The pointer remains valid until SDL is shut down.</para>
        /// <para>Returns NULL on error (cf. ::SDL_GetError())</para>
        /// <para>This function is available since SDL 3.0.0</para>
        /// </remarks>
        public static string GetPenName(uint instance_id)
        {
            var ___ret = __Internal.GetPenName(instance_id);
            return CppSharp.Runtime.MarshalUtil.GetString(global::System.Text.Encoding.UTF8, ___ret);
        }

        /// <summary>Retrieves capability flags for a given ::SDL_PenID.</summary>
        /// <param name="instance_id">The pen to query.</param>
        /// <param name="capabilities">
        /// <para>Detail information about pen capabilities, such as the</para>
        /// <para>number of buttons</para>
        /// </param>
        /// <remarks>
        /// <para>a set of capability flags, cf. SDL_PEN_CAPABILITIES</para>
        /// <para>This function is available since SDL 3.0.0</para>
        /// </remarks>
        public static uint GetPenCapabilities(uint instance_id, global::SDL3Sharp.PenCapabilityInfo capabilities)
        {
            var __arg1 = capabilities is null ? __IntPtr.Zero : capabilities.__Instance;
            var ___ret = __Internal.GetPenCapabilities(instance_id, __arg1);
            return ___ret;
        }

        /// <summary>Retrieves the pen type for a given ::SDL_PenID.</summary>
        /// <param name="instance_id">The pen to query.</param>
        /// <remarks>
        /// <para>The corresponding pen type (cf. ::SDL_PenSubtype) or 0 on error.</para>
        /// <para>Note that the pen type does not dictate whether the pen tip is</para>
        /// <para>::SDL_PEN_TIP_INK or ::SDL_PEN_TIP_ERASER; to determine whether a</para>
        /// <para>pen is being used for drawing or in eraser mode, check either the</para>
        /// <para>pen tip on ::SDL_EVENT_PEN_DOWN, or the flag ::SDL_PEN_ERASER_MASK</para>
        /// <para>in the pen state.</para>
        /// <para>This function is available since SDL 3.0.0</para>
        /// </remarks>
        public static global::SDL3Sharp.PenSubtype GetPenType(uint instance_id)
        {
            var ___ret = __Internal.GetPenType(instance_id);
            return ___ret;
        }
    }
}
