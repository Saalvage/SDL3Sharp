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
    /// <summary>The position of camera in relation to system device.</summary>
    /// <remarks>SDL_GetCameraDevicePosition</remarks>
    public enum CameraPosition
    {
        Unknown = 0,
        FrontFacing = 1,
        BackFacing = 2
    }

    /// <summary>
    /// <para>This is a unique ID for a camera device for the time it is connected to the system,</para>
    /// <para>and is never reused for the lifetime of the application. If the device is</para>
    /// <para>disconnected and reconnected, it will get a new ID.</para>
    /// </summary>
    /// <remarks>
    /// <para>The ID value starts at 1 and increments from there. The value 0 is an invalid ID.</para>
    /// <para>SDL_GetCameraDevices</para>
    /// </remarks>
    /// <summary>SDL_CameraSpec structure</summary>
    /// <remarks>
    /// <para>SDL_GetCameraDeviceSupportedFormats</para>
    /// <para>SDL_GetCameraFormat</para>
    /// </remarks>
    /// <summary>The position of camera in relation to system device.</summary>
    /// <remarks>SDL_GetCameraDevicePosition</remarks>
    /// <summary>The structure used to identify an opened SDL camera</summary>
    public unsafe partial class Camera
    {
        public partial struct __Internal
        {
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SDL3Sharp.Camera> NativeToManagedMap =
            new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SDL3Sharp.Camera>();

        internal static void __RecordNativeToManagedMapping(IntPtr native, global::SDL3Sharp.Camera managed)
        {
            NativeToManagedMap[native] = managed;
        }

        internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::SDL3Sharp.Camera managed)
        {
    
            return NativeToManagedMap.TryGetValue(native, out managed);
        }

        protected bool __ownsNativeInstance;

        internal static Camera __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            return new Camera(native.ToPointer(), skipVTables);
        }

        internal static Camera __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (__TryGetNativeToManagedMapping(native, out var managed))
                return (Camera)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                __RecordNativeToManagedMapping(native, result);
            return result;
        }

        internal static Camera __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new Camera(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private Camera(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        protected Camera(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }
    }

    /// <summary>SDL_CameraSpec structure</summary>
    /// <remarks>
    /// <para>SDL_GetCameraDeviceSupportedFormats</para>
    /// <para>SDL_GetCameraFormat</para>
    /// </remarks>
    public unsafe partial class CameraSpec : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 20, Pack = 8)]
        public partial struct __Internal
        {
            internal global::SDL3Sharp.PixelFormatEnum format;
            internal int width;
            internal int height;
            internal int interval_numerator;
            internal int interval_denominator;

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "??0SDL_CameraSpec@@QEAA@AEBU0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr cctor(__IntPtr __instance, __IntPtr _0);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SDL3Sharp.CameraSpec> NativeToManagedMap =
            new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SDL3Sharp.CameraSpec>();

        internal static void __RecordNativeToManagedMapping(IntPtr native, global::SDL3Sharp.CameraSpec managed)
        {
            NativeToManagedMap[native] = managed;
        }

        internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::SDL3Sharp.CameraSpec managed)
        {
    
            return NativeToManagedMap.TryGetValue(native, out managed);
        }

        protected bool __ownsNativeInstance;

        internal static CameraSpec __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            return new CameraSpec(native.ToPointer(), skipVTables);
        }

        internal static CameraSpec __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (__TryGetNativeToManagedMapping(native, out var managed))
                return (CameraSpec)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                __RecordNativeToManagedMapping(native, result);
            return result;
        }

        internal static CameraSpec __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new CameraSpec(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private CameraSpec(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        protected CameraSpec(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public CameraSpec()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::SDL3Sharp.CameraSpec.__Internal));
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        public CameraSpec(global::SDL3Sharp.CameraSpec _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::SDL3Sharp.CameraSpec.__Internal));
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
            *((global::SDL3Sharp.CameraSpec.__Internal*) __Instance) = *((global::SDL3Sharp.CameraSpec.__Internal*) _0.__Instance);
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

        /// <summary>Frame format</summary>
        public global::SDL3Sharp.PixelFormatEnum Format
        {
            get
            {
                return ((__Internal*)__Instance)->format;
            }

            set
            {
                ((__Internal*)__Instance)->format = value;
            }
        }

        /// <summary>Frame width</summary>
        public int Width
        {
            get
            {
                return ((__Internal*)__Instance)->width;
            }

            set
            {
                ((__Internal*)__Instance)->width = value;
            }
        }

        /// <summary>Frame height</summary>
        public int Height
        {
            get
            {
                return ((__Internal*)__Instance)->height;
            }

            set
            {
                ((__Internal*)__Instance)->height = value;
            }
        }

        /// <summary>Frame rate numerator ((dom / num) == fps, (num / dom) == duration)</summary>
        public int IntervalNumerator
        {
            get
            {
                return ((__Internal*)__Instance)->interval_numerator;
            }

            set
            {
                ((__Internal*)__Instance)->interval_numerator = value;
            }
        }

        /// <summary>Frame rate demoninator ((dom / num) == fps, (num / dom) == duration)</summary>
        public int IntervalDenominator
        {
            get
            {
                return ((__Internal*)__Instance)->interval_denominator;
            }

            set
            {
                ((__Internal*)__Instance)->interval_denominator = value;
            }
        }
    }

    public unsafe partial class SDL
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetNumCameraDrivers", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int GetNumCameraDrivers();

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetCameraDriver", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr GetCameraDriver(int index);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetCurrentCameraDriver", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr GetCurrentCameraDriver();

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetCameraDevices", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern uint* GetCameraDevices(int* count);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetCameraDeviceSupportedFormats", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr GetCameraDeviceSupportedFormats(uint devid, int* count);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetCameraDeviceName", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern sbyte* GetCameraDeviceName(uint instance_id);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetCameraDevicePosition", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern global::SDL3Sharp.CameraPosition GetCameraDevicePosition(uint instance_id);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_OpenCameraDevice", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr OpenCameraDevice(uint instance_id, __IntPtr spec);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetCameraPermissionState", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int GetCameraPermissionState(__IntPtr camera);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetCameraInstanceID", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern uint GetCameraInstanceID(__IntPtr camera);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetCameraProperties", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern uint GetCameraProperties(__IntPtr camera);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_GetCameraFormat", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int GetCameraFormat(__IntPtr camera, __IntPtr spec);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_AcquireCameraFrame", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr AcquireCameraFrame(__IntPtr camera, ulong* timestampNS);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_ReleaseCameraFrame", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int ReleaseCameraFrame(__IntPtr camera, __IntPtr frame);

            [SuppressUnmanagedCodeSecurity, DllImport("SDL3", EntryPoint = "SDL_CloseCamera", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void CloseCamera(__IntPtr camera);
        }

        /// <summary>Use this function to get the number of built-in camera drivers.</summary>
        /// <remarks>
        /// <para>This function returns a hardcoded number. This never returns a negative</para>
        /// <para>value; if there are no drivers compiled into this build of SDL, this</para>
        /// <para>function returns zero. The presence of a driver in this list does not mean</para>
        /// <para>it will function, it just means SDL is capable of interacting with that</para>
        /// <para>interface. For example, a build of SDL might have v4l2 support, but if</para>
        /// <para>there's no kernel support available, SDL's v4l2 driver would fail if used.</para>
        /// <para>By default, SDL tries all drivers, in its preferred order, until one is</para>
        /// <para>found to be usable.</para>
        /// <para>the number of built-in camera drivers.</para>
        /// <para>It is safe to call this function from any thread.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_GetCameraDriver</para>
        /// </remarks>
        public static int GetNumCameraDrivers()
        {
            var ___ret = __Internal.GetNumCameraDrivers();
            return ___ret;
        }

        /// <summary>Use this function to get the name of a built in camera driver.</summary>
        /// <param name="index">
        /// <para>the index of the camera driver; the value ranges from 0 to</para>
        /// <para>SDL_GetNumCameraDrivers() - 1</para>
        /// </param>
        /// <remarks>
        /// <para>The list of camera drivers is given in the order that they are normally</para>
        /// <para>initialized by default; the drivers that seem more reasonable to choose</para>
        /// <para>first (as far as the SDL developers believe) are earlier in the list.</para>
        /// <para>The names of drivers are all simple, low-ASCII identifiers, like &quot;v4l2&quot;,</para>
        /// <para>&quot;coremedia&quot; or &quot;android&quot;. These never have Unicode characters, and are not</para>
        /// <para>meant to be proper names.</para>
        /// <para>the name of the camera driver at the requested index, or NULL if</para>
        /// <para>an invalid index was specified.</para>
        /// <para>It is safe to call this function from any thread.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_GetNumCameraDrivers</para>
        /// </remarks>
        public static string GetCameraDriver(int index)
        {
            var ___ret = __Internal.GetCameraDriver(index);
            return CppSharp.Runtime.MarshalUtil.GetString(global::System.Text.Encoding.UTF8, ___ret);
        }

        /// <summary>Get the name of the current camera driver.</summary>
        /// <remarks>
        /// <para>The returned string points to internal static memory and thus never becomes</para>
        /// <para>invalid, even if you quit the camera subsystem and initialize a new driver</para>
        /// <para>(although such a case would return a different static string from another</para>
        /// <para>call to this function, of course). As such, you should not modify or free</para>
        /// <para>the returned string.</para>
        /// <para>the name of the current camera driver or NULL if no driver has</para>
        /// <para>been initialized.</para>
        /// <para>It is safe to call this function from any thread.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// </remarks>
        public static string GetCurrentCameraDriver()
        {
            var ___ret = __Internal.GetCurrentCameraDriver();
            return CppSharp.Runtime.MarshalUtil.GetString(global::System.Text.Encoding.UTF8, ___ret);
        }

        /// <summary>Get a list of currently connected camera devices.</summary>
        /// <param name="count">
        /// <para>a pointer filled in with the number of camera devices. Can be</para>
        /// <para>NULL.</para>
        /// </param>
        /// <remarks>
        /// <para>a 0 terminated array of camera instance IDs which should be freed</para>
        /// <para>with SDL_free(), or NULL on error; call SDL_GetError() for more</para>
        /// <para>details.</para>
        /// <para>It is safe to call this function from any thread.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_OpenCamera</para>
        /// </remarks>
        public static uint* GetCameraDevices(ref int count)
        {
            fixed (int* __count0 = &count)
            {
                var __arg0 = __count0;
                var ___ret = __Internal.GetCameraDevices(__arg0);
                return ___ret;
            }
        }

        /// <summary>Get the list of native formats/sizes a camera supports.</summary>
        /// <param name="devid">the camera device instance ID to query.</param>
        /// <param name="count">
        /// <para>a pointer filled in with the number of elements in the list.</para>
        /// <para>Can be NULL.</para>
        /// </param>
        /// <remarks>
        /// <para>This returns a list of all formats and frame sizes that a specific camera</para>
        /// <para>can offer. This is useful if your app can accept a variety of image formats</para>
        /// <para>and sizes and so want to find the optimal spec that doesn't require</para>
        /// <para>conversion.</para>
        /// <para>This function isn't strictly required; if you call SDL_OpenCameraDevice</para>
        /// <para>with a NULL spec, SDL will choose a native format for you, and if you</para>
        /// <para>instead specify a desired format, it will transparently convert to the</para>
        /// <para>requested format on your behalf.</para>
        /// <para>If `count` is not NULL, it will be filled with the number of elements in</para>
        /// <para>the returned array. Additionally, the last element of the array has all</para>
        /// <para>fields set to zero (this element is not included in `count`).</para>
        /// <para>The returned list is owned by the caller, and should be released with</para>
        /// <para>SDL_free() when no longer needed.</para>
        /// <para>Note that it's legal for a camera to supply a list with only the zeroed</para>
        /// <para>final element and `*count` set to zero; this is what will happen on</para>
        /// <para>Emscripten builds, since that platform won't tell _anything_ about</para>
        /// <para>available cameras until you've opened one, and won't even tell if there</para>
        /// <para>_is_ a camera until the user has given you permission to check through a</para>
        /// <para>scary warning popup.</para>
        /// <para>a 0 terminated array of SDL_CameraSpecs, which should be freed</para>
        /// <para>with SDL_free(), or NULL on error; call SDL_GetError() for more</para>
        /// <para>details.</para>
        /// <para>It is safe to call this function from any thread.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_GetCameraDevices</para>
        /// <para>SDL_OpenCameraDevice</para>
        /// </remarks>
        public static global::SDL3Sharp.CameraSpec GetCameraDeviceSupportedFormats(uint devid, ref int count)
        {
            fixed (int* __count1 = &count)
            {
                var __arg1 = __count1;
                var ___ret = __Internal.GetCameraDeviceSupportedFormats(devid, __arg1);
                var __result0 = global::SDL3Sharp.CameraSpec.__GetOrCreateInstance(___ret, false);
                return __result0;
            }
        }

        /// <summary>Get human-readable device name for a camera.</summary>
        /// <param name="instance_id">the camera device instance ID</param>
        /// <remarks>
        /// <para>The returned string is owned by the caller; please release it with</para>
        /// <para>SDL_free() when done with it.</para>
        /// <para>Human-readable device name, or NULL on error; call SDL_GetError()</para>
        /// <para>for more information.</para>
        /// <para>It is safe to call this function from any thread.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_GetCameraDevices</para>
        /// </remarks>
        public static sbyte* GetCameraDeviceName(uint instance_id)
        {
            var ___ret = __Internal.GetCameraDeviceName(instance_id);
            return ___ret;
        }

        /// <summary>Get the position of the camera in relation to the system.</summary>
        /// <param name="instance_id">the camera device instance ID</param>
        /// <remarks>
        /// <para>Most platforms will report UNKNOWN, but mobile devices, like phones, can</para>
        /// <para>often make a distiction between cameras on the front of the device (that</para>
        /// <para>points towards the user, for taking &quot;selfies&quot;) and cameras on the back (for</para>
        /// <para>filming in the direction the user is facing).</para>
        /// <para>The position of the camera on the system hardware.</para>
        /// <para>It is safe to call this function from any thread.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_GetCameraDevices</para>
        /// </remarks>
        public static global::SDL3Sharp.CameraPosition GetCameraDevicePosition(uint instance_id)
        {
            var ___ret = __Internal.GetCameraDevicePosition(instance_id);
            return ___ret;
        }

        /// <summary>Open a video capture device (a &quot;camera&quot;).</summary>
        /// <param name="instance_id">the camera device instance ID</param>
        /// <param name="spec">
        /// <para>The desired format for data the device will provide. Can be</para>
        /// <para>NULL.</para>
        /// </param>
        /// <remarks>
        /// <para>You can open the device with any reasonable spec, and if the hardware can't</para>
        /// <para>directly support it, it will convert data seamlessly to the requested</para>
        /// <para>format. This might incur overhead, including scaling of image data.</para>
        /// <para>If you would rather accept whatever format the device offers, you can pass</para>
        /// <para>a NULL spec here and it will choose one for you (and you can use</para>
        /// <para>SDL_Surface's conversion/scaling functions directly if necessary).</para>
        /// <para>You can call SDL_GetCameraFormat() to get the actual data format if passing</para>
        /// <para>a NULL spec here. You can see the exact specs a device can support without</para>
        /// <para>conversion with SDL_GetCameraSupportedSpecs().</para>
        /// <para>SDL will not attempt to emulate framerate; it will try to set the hardware</para>
        /// <para>to the rate closest to the requested speed, but it won't attempt to limit</para>
        /// <para>or duplicate frames artificially; call SDL_GetCameraFormat() to see the</para>
        /// <para>actual framerate of the opened the device, and check your timestamps if</para>
        /// <para>this is crucial to your app!</para>
        /// <para>Note that the camera is not usable until the user approves its use! On some</para>
        /// <para>platforms, the operating system will prompt the user to permit access to</para>
        /// <para>the camera, and they can choose Yes or No at that point. Until they do, the</para>
        /// <para>camera will not be usable. The app should either wait for an</para>
        /// <para>SDL_EVENT_CAMERA_DEVICE_APPROVED (or SDL_EVENT_CAMERA_DEVICE_DENIED) event,</para>
        /// <para>or poll SDL_IsCameraApproved() occasionally until it returns non-zero. On</para>
        /// <para>platforms that don't require explicit user approval (and perhaps in places</para>
        /// <para>where the user previously permitted access), the approval event might come</para>
        /// <para>immediately, but it might come seconds, minutes, or hours later!</para>
        /// <para>device, or NULL on failure; call SDL_GetError() for more</para>
        /// <para>information.</para>
        /// <para>It is safe to call this function from any thread.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_GetCameraDevices</para>
        /// <para>SDL_GetCameraFormat</para>
        /// </remarks>
        public static global::SDL3Sharp.Camera OpenCameraDevice(uint instance_id, global::SDL3Sharp.CameraSpec spec)
        {
            var __arg1 = spec is null ? __IntPtr.Zero : spec.__Instance;
            var ___ret = __Internal.OpenCameraDevice(instance_id, __arg1);
            var __result0 = global::SDL3Sharp.Camera.__GetOrCreateInstance(___ret, false);
            return __result0;
        }

        /// <summary>Query if camera access has been approved by the user.</summary>
        /// <param name="camera">the opened camera device to query</param>
        /// <remarks>
        /// <para>Cameras will not function between when the device is opened by the app and</para>
        /// <para>when the user permits access to the hardware. On some platforms, this</para>
        /// <para>presents as a popup dialog where the user has to explicitly approve access;</para>
        /// <para>on others the approval might be implicit and not alert the user at all.</para>
        /// <para>This function can be used to check the status of that approval. It will</para>
        /// <para>return 0 if still waiting for user response, 1 if the camera is approved</para>
        /// <para>for use, and -1 if the user denied access.</para>
        /// <para>Instead of polling with this function, you can wait for a</para>
        /// <para>SDL_EVENT_CAMERA_DEVICE_APPROVED (or SDL_EVENT_CAMERA_DEVICE_DENIED) event</para>
        /// <para>in the standard SDL event loop, which is guaranteed to be sent once when</para>
        /// <para>permission to use the camera is decided.</para>
        /// <para>If a camera is declined, there's nothing to be done but call</para>
        /// <para>SDL_CloseCamera() to dispose of it.</para>
        /// <para>-1 if user denied access to the camera, 1 if user approved access,</para>
        /// <para>0 if no decision has been made yet.</para>
        /// <para>It is safe to call this function from any thread.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_OpenCameraDevice</para>
        /// <para>SDL_CloseCamera</para>
        /// </remarks>
        public static int GetCameraPermissionState(global::SDL3Sharp.Camera camera)
        {
            var __arg0 = camera is null ? __IntPtr.Zero : camera.__Instance;
            var ___ret = __Internal.GetCameraPermissionState(__arg0);
            return ___ret;
        }

        /// <summary>Get the instance ID of an opened camera.</summary>
        /// <param name="camera">an SDL_Camera to query</param>
        /// <remarks>
        /// <para>the instance ID of the specified camera on success or 0 on</para>
        /// <para>failure; call SDL_GetError() for more information.</para>
        /// <para>It is safe to call this function from any thread.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_OpenCameraDevice</para>
        /// </remarks>
        public static uint GetCameraInstanceID(global::SDL3Sharp.Camera camera)
        {
            var __arg0 = camera is null ? __IntPtr.Zero : camera.__Instance;
            var ___ret = __Internal.GetCameraInstanceID(__arg0);
            return ___ret;
        }

        /// <summary>Get the properties associated with an opened camera.</summary>
        /// <param name="camera">the SDL_Camera obtained from SDL_OpenCameraDevice()</param>
        /// <remarks>
        /// <para>a valid property ID on success or 0 on failure; call</para>
        /// <para>SDL_GetError() for more information.</para>
        /// <para>It is safe to call this function from any thread.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_GetProperty</para>
        /// <para>SDL_SetProperty</para>
        /// </remarks>
        public static uint GetCameraProperties(global::SDL3Sharp.Camera camera)
        {
            var __arg0 = camera is null ? __IntPtr.Zero : camera.__Instance;
            var ___ret = __Internal.GetCameraProperties(__arg0);
            return ___ret;
        }

        /// <summary>Get the spec that a camera is using when generating images.</summary>
        /// <param name="camera">opened camera device</param>
        /// <param name="spec">The SDL_CameraSpec to be initialized by this function.</param>
        /// <remarks>
        /// <para>Note that this might not be the native format of the hardware, as SDL might</para>
        /// <para>be converting to this format behind the scenes.</para>
        /// <para>If the system is waiting for the user to approve access to the camera, as</para>
        /// <para>some platforms require, this will return -1, but this isn't necessarily a</para>
        /// <para>fatal error; you should either wait for an SDL_EVENT_CAMERA_DEVICE_APPROVED</para>
        /// <para>(or SDL_EVENT_CAMERA_DEVICE_DENIED) event, or poll SDL_IsCameraApproved()</para>
        /// <para>occasionally until it returns non-zero.</para>
        /// <para>0 on success or a negative error code on failure; call</para>
        /// <para>SDL_GetError() for more information.</para>
        /// <para>It is safe to call this function from any thread.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_OpenCameraDevice</para>
        /// </remarks>
        public static int GetCameraFormat(global::SDL3Sharp.Camera camera, global::SDL3Sharp.CameraSpec spec)
        {
            var __arg0 = camera is null ? __IntPtr.Zero : camera.__Instance;
            var __arg1 = spec is null ? __IntPtr.Zero : spec.__Instance;
            var ___ret = __Internal.GetCameraFormat(__arg0, __arg1);
            return ___ret;
        }

        /// <summary>Acquire a frame.</summary>
        /// <param name="camera">opened camera device</param>
        /// <param name="timestampNS">
        /// <para>a pointer filled in with the frame's timestamp, or 0 on</para>
        /// <para>error. Can be NULL.</para>
        /// </param>
        /// <remarks>
        /// <para>The frame is a memory pointer to the image data, whose size and format are</para>
        /// <para>given by the spec requested when opening the device.</para>
        /// <para>This is a non blocking API. If there is a frame available, a non-NULL</para>
        /// <para>surface is returned, and timestampNS will be filled with a non-zero value.</para>
        /// <para>Note that an error case can also return NULL, but a NULL by itself is</para>
        /// <para>normal and just signifies that a new frame is not yet available. Note that</para>
        /// <para>even if a camera device fails outright (a USB camera is unplugged while in</para>
        /// <para>use, etc), SDL will send an event separately to notify the app, but</para>
        /// <para>continue to provide blank frames at ongoing intervals until</para>
        /// <para>SDL_CloseCamera() is called, so real failure here is almost always an out</para>
        /// <para>of memory condition.</para>
        /// <para>After use, the frame should be released with SDL_ReleaseCameraFrame(). If</para>
        /// <para>you don't do this, the system may stop providing more video!</para>
        /// <para>Do not call SDL_FreeSurface() on the returned surface! It must be given</para>
        /// <para>back to the camera subsystem with SDL_ReleaseCameraFrame!</para>
        /// <para>If the system is waiting for the user to approve access to the camera, as</para>
        /// <para>some platforms require, this will return NULL (no frames available); you</para>
        /// <para>should either wait for an SDL_EVENT_CAMERA_DEVICE_APPROVED (or</para>
        /// <para>SDL_EVENT_CAMERA_DEVICE_DENIED) event, or poll SDL_IsCameraApproved()</para>
        /// <para>occasionally until it returns non-zero.</para>
        /// <para>A new frame of video on success, NULL if none is currently</para>
        /// <para>available.</para>
        /// <para>It is safe to call this function from any thread.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_ReleaseCameraFrame</para>
        /// </remarks>
        public static global::SDL3Sharp.Surface AcquireCameraFrame(global::SDL3Sharp.Camera camera, ref ulong timestampNS)
        {
            var __arg0 = camera is null ? __IntPtr.Zero : camera.__Instance;
            fixed (ulong* __timestampNS1 = &timestampNS)
            {
                var __arg1 = __timestampNS1;
                var ___ret = __Internal.AcquireCameraFrame(__arg0, __arg1);
                var __result0 = global::SDL3Sharp.Surface.__GetOrCreateInstance(___ret, false);
                return __result0;
            }
        }

        /// <summary>Release a frame of video acquired from a camera.</summary>
        /// <param name="camera">opened camera device</param>
        /// <param name="frame">The video frame surface to release.</param>
        /// <remarks>
        /// <para>Let the back-end re-use the internal buffer for camera.</para>
        /// <para>This function _must_ be called only on surface objects returned by</para>
        /// <para>SDL_AcquireCameraFrame(). This function should be called as quickly as</para>
        /// <para>possible after acquisition, as SDL keeps a small FIFO queue of surfaces for</para>
        /// <para>video frames; if surfaces aren't released in a timely manner, SDL may drop</para>
        /// <para>upcoming video frames from the camera.</para>
        /// <para>If the app needs to keep the surface for a significant time, they should</para>
        /// <para>make a copy of it and release the original.</para>
        /// <para>The app should not use the surface again after calling this function;</para>
        /// <para>assume the surface is freed and the pointer is invalid.</para>
        /// <para>0 on success or a negative error code on failure; call</para>
        /// <para>SDL_GetError() for more information.</para>
        /// <para>It is safe to call this function from any thread.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_AcquireCameraFrame</para>
        /// </remarks>
        public static int ReleaseCameraFrame(global::SDL3Sharp.Camera camera, global::SDL3Sharp.Surface frame)
        {
            var __arg0 = camera is null ? __IntPtr.Zero : camera.__Instance;
            var __arg1 = frame is null ? __IntPtr.Zero : frame.__Instance;
            var ___ret = __Internal.ReleaseCameraFrame(__arg0, __arg1);
            return ___ret;
        }

        /// <summary>
        /// <para>Use this function to shut down camera processing and close the camera</para>
        /// <para>device.</para>
        /// </summary>
        /// <param name="camera">opened camera device</param>
        /// <remarks>
        /// <para>It is safe to call this function from any thread, but no</para>
        /// <para>thread may reference `device` once this function is called.</para>
        /// <para>This function is available since SDL 3.0.0.</para>
        /// <para>SDL_OpenCameraWithSpec</para>
        /// <para>SDL_OpenCamera</para>
        /// </remarks>
        public static void CloseCamera(global::SDL3Sharp.Camera camera)
        {
            var __arg0 = camera is null ? __IntPtr.Zero : camera.__Instance;
            __Internal.CloseCamera(__arg0);
        }
    }
}